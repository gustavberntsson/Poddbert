using BL;
using DL;
using Models;
using System.Xml;

namespace PoddApp
{
    public partial class Form1 : Form
    {
        List<AvsnittRepository> _allapoddar;
        PoddController poddController = new PoddController();
        public Form1()
        {
            InitializeComponent();

            poddController.LaddaFranXml("poddar.xml");

            _allapoddar = poddController.HamtaAllaPoddar();

            FyllKategoriLista(GetKategorier());

            UppdateraPoddLista();

            LaddaKategorierFranXml("kategorier.xml");

        }

        public List<string> GetKategorier()
        {
            List<string> kategorier = new List<string>();
            foreach (var item in txtVisaKategorier.Items)
            {
                kategorier.Add(item.ToString());
            }
            return kategorier;
        }

        public void FyllKategoriLista(List<string> kategorier)
        {
            //Rensar om det skulle finnas n�got i listan som inte kommer fr�n VisaKategorier listan
            cbNyttFlodeKategori.Items.Clear();
            foreach (var kategori in kategorier)
            {
                cbNyttFlodeKategori.Items.Add(kategori);
            }
        }
        private void UppdateraPoddLista()
        {
            //Tar bort alla objekt efter man redigerat n�got f�r att sedan kunna fylla listan p� nytt
            txtVisaFloden.Items.Clear();

            // H�mta vald kategori
            string valdKategori = txtVisaKategorier.SelectedItem?.ToString();

            // Filtrera poddar baserat p� vald kategori
            // Om ingen kategori �r vald s� kommer den default till "_allapoddar" utan filter
            // Annars ( : tecknet ) s� kommer den filtrera listan efter poddar som matchar kategorin som �r vald
            var filtreradePoddar = string.IsNullOrEmpty(valdKategori) ?
                _allapoddar :
                _allapoddar.Where(p => p.GetKategori() == valdKategori).ToList();

            //F�r varje filtrerad podcast -> populate listan VisaFloden med poddar efter deras namn
            foreach (var podcast in filtreradePoddar)
            {
                txtVisaFloden.Items.Add(podcast.GetNamn());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNyttFlodeLaggTill_Click(object sender, EventArgs e)
        {

            if (txtNyttFlodeURL.Text != "")
            {
                if (cbNyttFlodeKategori.Text != "")
                {
                    //Skapar en str�ng f�r att lagra podcastnamnet som sedan baseras p� om man fyllt i ett eget namn eller ej
                    string podcastNamn = "";

                    string rssLank = txtNyttFlodeURL.Text;
                    string valdKategori = cbNyttFlodeKategori.Text;

                    if (txtNyttFlodeNamn.Text != "")
                    {
                        podcastNamn = txtNyttFlodeNamn.Text;
                    }
                    else
                    {
                        podcastNamn = rssLank;
                    }

                    //Kollar s� namnet inte redan finns i listan
                    bool ickeUniktNamn = _allapoddar.Any(p => p.GetNamn() == podcastNamn);

                    if(ickeUniktNamn)
                    {
                        MessageBox.Show("Namnet p� podcasten �r inte unikt", "Byt namn p� podcast");
                        return;
                    }
                    try
                    {
                        poddController.HamtaAvsnittFranRss(podcastNamn, rssLank, valdKategori);

                        if (txtNyttFlodeNamn.Text == "")
                        {
                            txtVisaFloden.Items.Add(rssLank);
                        }
                        else
                        {
                            txtVisaFloden.Items.Add(podcastNamn);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Om l�nken inte �r ett normalt rss fl�de i xml format
                        //MessageBoxButtons och MessageBoxIcon �r knappar och ikoner som liknar ett normalt felmeddelande
                        MessageBox.Show("V�nligen kontrollera att l�nken leder till ett rss fl�de", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            //Kollar om det finns ett valt objekt
            if (txtVisaFloden.SelectedItem != null)
            {
                //H�mtar ut namnet p� podcasten f�r att anv�nda som "nyckel"
                string valtPoddNamn = txtVisaFloden.SelectedItem.ToString();

                //Hittar podcasten i listan baserat p� namnet
                var valdPodd = _allapoddar.FirstOrDefault(p => p.GetNamn() == valtPoddNamn);
                
                //Om podden finns
                if(valdPodd != null)
                {
                    var poddVisare = valdPodd.HamtaAllaAvsnitt();
                
                    txtVisaAvsnitt.DataSource = poddVisare;
                    txtVisaAvsnitt.DisplayMember = "Rubrik";
                }
            }
            else
            {
                // Om den inte hittar podcasten
                MessageBox.Show("Kunde inte hitta n�gon podcast");
            }

        }

        private void txtVisaAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int avsnittIndex = txtVisaAvsnitt.SelectedIndex;
            txtAvsnittBeskrivning.Text = "";

            if (txtVisaFloden.SelectedIndex >= 0 && avsnittIndex >= 0)
            {
                //H�mtar ut namnet p� podcasten f�r att anv�nda som "nyckel"
                string valtPoddNamn = txtVisaFloden.SelectedItem.ToString();

                // H�mta den valda podden baserat p� den valda poddens namn
                var valdPodd = _allapoddar.FirstOrDefault(p => p.GetNamn() == valtPoddNamn);

                // H�mtar avsnitten f�r valda podden
                var valdPoddAvsnittLista = valdPodd.HamtaAllaAvsnitt();

                // H�mtar specifika avsnittet ur listan baserat p� index
                var valtAvsnitt = valdPoddAvsnittLista[avsnittIndex];

                // Visa beskrivningen av det valda avsnittet
                txtAvsnittBeskrivning.Text = valtAvsnitt.Beskrivning;

                if(txtAvsnittBeskrivning.Text == "")
                {
                    txtAvsnittBeskrivning.Text = "Det finns ingen beskrivning f�r detta avsnitt";
                }
            }
        }


        private void txtNyttFlodeURL_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtMinaFloden_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnRaderaKategori_Click(object sender, EventArgs e)
        {
            if (txtVisaKategorier.SelectedIndex >= 0)
            {
                
                string valdKategori = txtVisaKategorier.SelectedItem.ToString();

                var allaPoddarIValdKategori = _allapoddar.Where(p => p.GetKategori() == valdKategori).ToList();
                if (allaPoddarIValdKategori.Count > 0)
                {
                    MessageBox.Show("Det finns " + allaPoddarIValdKategori.Count + " podd(ar) med denna kategori. "
                        + "Antingen ta bort dessa poddar eller �ndra deras kategori innan du kan forts�tta.",
                        "Kategori �r i bruk",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(
                        $"�r du s�ker p� att du vill radera kategorin '{valdKategori}'?",
                        "", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        txtVisaKategorier.Items.Remove(valdKategori);

                        FyllKategoriLista(GetKategorier());

                        SparaKategorierTillXml("kategorier.xml");

                        MessageBox.Show($"Kategorin '{valdKategori}' har raderats.");
                    }
                }
            }
            else
            {
                MessageBox.Show("V�lj en kategori att radera.");
            }
        }

        private void txtAvsnittBeskrivning_TextChanged(object sender, EventArgs e)
        {

        }

        private void SparaTillXml()
        {
            // Anv�nd den existerande instansen av PoddController
            poddController.SparaTillXml("poddar.xml");
        }
        private void btnRaderaFloden_Click(object sender, EventArgs e)
        {
            // Kontrollerar att ett fl�de �r valt
            if (txtVisaFloden.SelectedIndex >= 0)
            {
                string valtPoddNamn = txtVisaFloden.SelectedItem.ToString();

                // Visar en bekr�ftelseruta
                DialogResult dialogResult = MessageBox.Show(
                    $"�r du s�ker p� att du vill radera fl�det tillh�rande podcasten '{valtPoddNamn}'?",
                    "Bekr�fta radering",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // Hittar fl�det i listan
                    var poddAttTaBort = _allapoddar.FirstOrDefault(p => p.GetNamn() == valtPoddNamn);

                    if (poddAttTaBort != null)
                    {
                        // Tar bort fr�n listan
                        _allapoddar.Remove(poddAttTaBort);

                        // Sparar �ndringarna till XML
                        poddController.SparaTillXml("poddar.xml");

                        // Uppdatera lista i  UI
                        UppdateraPoddLista();

                        // Rensar avsnittslistan och beskrivningen
                        txtVisaAvsnitt.DataSource = null;
                        txtAvsnittBeskrivning.Text = "";

                        MessageBox.Show($"Fl�det tillh�rande podcasten '{valtPoddNamn}' har raderats.");
                    }
                }
            }
            else
            {
                MessageBox.Show("V�lj ett fl�de att radera.");
            }
        }


        private void txtVisaKategorier_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnRedigeraFloden_Click(object sender, EventArgs e)
        {
            using (var redigeraEgenskaper = new RedigeraEgenskaper(_allapoddar, GetKategorier(), poddController))
            {
                redigeraEgenskaper.FyllPoddLista();

                if (redigeraEgenskaper.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Dina �ndringar har sparats");
                    UppdateraPoddLista();
                }
                else if (redigeraEgenskaper.DialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Inga �ndringar har sparats.");
                }
            }
        }

        private void txtVisaKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            UppdateraPoddLista();

            //Om det finns poddar med vald kategori s� kommer den v�lja den f�rsta per automatik
            if(txtVisaFloden.Items.Count > 0)
            {
                txtVisaFloden.SelectedIndex = 0;
            }
        }

        private void btnLaggTillKategori_Click(object sender, EventArgs e)
        {
            string nyKategori = txtLaggTillKategori.Text.Trim();

            if (!string.IsNullOrEmpty(nyKategori))
            {
                if (!txtVisaKategorier.Items.Contains(nyKategori))
                {
                    txtVisaKategorier.Items.Add(nyKategori);
                    FyllKategoriLista(GetKategorier());

                    SparaKategorierTillXml("kategorier.xml");
                }
                else
                {
                    MessageBox.Show("Kategorin finns redan.");
                }
            }
            else
            {
                MessageBox.Show("Du m�ste ange ett kategorinamn.");
            }

            // T�m f�ltet efter att kategorin har lagts till
            txtLaggTillKategori.Text = "";
        }

        private void SparaKategorierTillXml(string filnamn)
        {
            using (XmlWriter writer = XmlWriter.Create(filnamn))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Kategorier");

                foreach (var kategori in txtVisaKategorier.Items)
                {
                    writer.WriteElementString("Kategori", kategori.ToString());
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        private void LaddaKategorierFranXml(string filnamn)
        {
            if (!File.Exists(filnamn))
            {
                return;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(filnamn);

            XmlNodeList kategoriNodes = doc.SelectNodes("/Kategorier/Kategori");
            foreach (XmlNode kategoriNode in kategoriNodes)
            {
                string kategori = kategoriNode.InnerText;
                if (!txtVisaKategorier.Items.Contains(kategori))
                {
                    txtVisaKategorier.Items.Add(kategori);
                }
            }

            FyllKategoriLista(GetKategorier());
        }
    }
}
