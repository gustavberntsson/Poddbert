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
            if (txtNyttFlodeURL != null && cbNyttFlodeKategori != null)
            {
                //Om man vill l�gga till ett eget namn vid "f�dseln" s� kommenterar man bort dessa och skapar nytt textf�lt
                //string namn = txtNyttFlodeNamn.Text;
                string rssLank = txtNyttFlodeURL.Text;
                string valdKategori = cbNyttFlodeKategori.Text;
                poddController.HamtaAvsnittFranRss(rssLank, valdKategori);
                txtVisaFloden.Items.Add(rssLank);
                //txtVisaFloden.Items.Add(namn);
            }
            
        }
        private void txtVisaFloden_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVisaAvsnitt.Text = "";
            txtVisaAvsnitt.DataSource = null;
            
            //I alla poddar h�mtar vi ut indexet vi har klickat p� och sedan h�mtar vi alla avsnitt fr�n den podden
            //var h�rleder att det �r en lista av avsnitt p� grund av HamtaAllaAvsnitt metoden
            var poddVisare = _allapoddar.ElementAt(txtVisaFloden.SelectedIndex).HamtaAllaAvsnitt();

            txtVisaAvsnitt.DataSource = poddVisare;

            txtVisaAvsnitt.DisplayMember = "Rubrik";
 
            
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


        private void txtVisaAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
