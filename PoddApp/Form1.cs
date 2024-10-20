using BL;
using DL;
using Models;

namespace PoddApp
{
    public partial class Form1 : Form
    {
        List<AvsnittRepository> _allapoddar;
        PoddController poddController = new PoddController();
        public Form1()
        {
            InitializeComponent();
            _allapoddar = poddController.HamtaAllaPoddar();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tror inte den g�r n�gon faktisk kontroll om det �r null eller inte
            if (txtNyttFlodeURL.Text != "")
            {
                if (cbNyttFlodeKategori.Text != "")
                {

                    string podcastNamn = txtNyttFlodeNamn.Text;
                    string rssLank = txtNyttFlodeURL.Text;
                    string valdKategori = cbNyttFlodeKategori.Text;
                    poddController.HamtaAvsnittFranRss(rssLank, valdKategori);

                    if (txtNyttFlodeNamn.Text == "")
                    {
                        txtVisaFloden.Items.Add(rssLank);
                    }
                    else
                    {
                        txtVisaFloden.Items.Add(podcastNamn);
                    }
                }
                else
                {
                    MessageBox.Show("Du m�ste v�lja en kategori", "Ingen kategori vald");
                }
            }
            else
            {
                MessageBox.Show("Du m�ste fylla i en giltig podcastl�nk", "Ogiltig podcastl�nk");
            }
        }
        private void txtVisaFloden_SelectedIndexChanged(object sender, EventArgs e)
        {
            //N�r vi byter index i listan s� t�mmer vi listan med avsnitt
            txtVisaAvsnitt.Text = "";
            txtVisaAvsnitt.DataSource = null;

            //Kollar om indexet �r inom m�jliga v�rden
            if (txtVisaFloden.SelectedIndex >= 0 && txtVisaFloden.SelectedIndex < _allapoddar.Count)
            {
                //I alla poddar h�mtar vi ut indexet vi har klickat p� och sedan h�mtar vi alla avsnitt fr�n den podden
                //var h�rleder att det �r en lista av avsnitt p� grund av HamtaAllaAvsnitt metoden
                var poddVisare = _allapoddar.ElementAt(txtVisaFloden.SelectedIndex).HamtaAllaAvsnitt();
                txtVisaAvsnitt.DataSource = poddVisare;
                txtVisaAvsnitt.DisplayMember = "Rubrik";
            }
            else
            {
                // Om index skulle vara utanf�r m�jliga v�rden
                MessageBox.Show("N�got gick fel");
            }

        }

        private void txtVisaAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int avsnittIndex = txtVisaAvsnitt.SelectedIndex;
            txtAvsnittBeskrivning.Text = "";

            if (txtVisaFloden.SelectedIndex >= 0 && avsnittIndex >= 0)
            {
                // H�mta den valda podden baserat p� index i txtVisaFloden
                var valdPodd = _allapoddar.ElementAt(txtVisaFloden.SelectedIndex);

                // H�mta avsnittet baserat p� index i txtVisaAvsnitt
                var valtAvsnitt = valdPodd.HamtaAllaAvsnitt().ElementAt(avsnittIndex);

                // Visa beskrivningen av det valda avsnittet
                txtAvsnittBeskrivning.Text = valtAvsnitt.Beskrivning;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Avsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLaggTillKategori_Click(object sender, EventArgs e)
        {

        }

        private void txtNyttFlodeURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtMinaFloden_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAvsnittBeskrivning_Click(object sender, EventArgs e)
        {

        }
        private void lblPodcastNamn_Click(object sender, EventArgs e)
        {

        }

        private void btnRaderaKategori_Click(object sender, EventArgs e)
        {

        }

        private void txtAvsnittBeskrivning_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLaggTillNyKategoriTitel_Click(object sender, EventArgs e)
        {

        }

        private void btnRaderaFloden_Click(object sender, EventArgs e)
        {

        }

        private void txtVisaKategorier_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMinaKategorier_Click(object sender, EventArgs e)
        {

        }

        private void lblLaggTillNyKategori_Click(object sender, EventArgs e)
        {

        }
    }
}
