﻿namespace PoddApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeader = new Label();
            btnNyttFlodeLaggTill = new Button();
            txtNyttFlodeURL = new TextBox();
            txtVisaKategorier = new RichTextBox();
            cbNyttFlodeKategori = new ComboBox();
            lblSkapaNyttFlodeKategori = new Label();
            lblSkapaNyttFlode = new Label();
            lblAvsnittLista = new Label();
            btnRedigeraFloden = new Button();
            btnRaderaFloden = new Button();
            lblMinaKategorier = new Label();
            btnRaderaKategori = new Button();
            btnLaggTillKategori = new Button();
            txtLaggTillKategori = new TextBox();
            lblLaggTillNyKategori = new Label();
            lblLaggTillNyKategoriTitel = new Label();
            lblLaggTillFlodeURL = new Label();
            lblAvsnittBeskrivning = new Label();
            txtAvsnittBeskrivning = new RichTextBox();
            txtVisaFloden = new ListBox();
            txtVisaAvsnitt = new ListBox();
            lblLaggTillFlodeNamn = new Label();
            txtNyttFlodeNamn = new TextBox();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 17F);
            lblHeader.ForeColor = Color.FromArgb(204, 230, 135, 130);
            lblHeader.Location = new Point(470, 31);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(104, 31);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Podcasts";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.Click += label1_Click;
            // 
            // btnNyttFlodeLaggTill
            // 
            btnNyttFlodeLaggTill.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnNyttFlodeLaggTill.FlatStyle = FlatStyle.Flat;
            btnNyttFlodeLaggTill.Location = new Point(165, 219);
            btnNyttFlodeLaggTill.Margin = new Padding(4, 3, 4, 3);
            btnNyttFlodeLaggTill.Name = "btnNyttFlodeLaggTill";
            btnNyttFlodeLaggTill.Size = new Size(88, 21);
            btnNyttFlodeLaggTill.TabIndex = 1;
            btnNyttFlodeLaggTill.Text = "Lägg till";
            btnNyttFlodeLaggTill.UseVisualStyleBackColor = false;
            btnNyttFlodeLaggTill.Click += button1_Click;
            // 
            // txtNyttFlodeURL
            // 
            txtNyttFlodeURL.Location = new Point(110, 154);
            txtNyttFlodeURL.Margin = new Padding(4, 3, 4, 3);
            txtNyttFlodeURL.Name = "txtNyttFlodeURL";
            txtNyttFlodeURL.PlaceholderText = "https://www.exempel.com/rss";
            txtNyttFlodeURL.Size = new Size(204, 23);
            txtNyttFlodeURL.TabIndex = 3;
            txtNyttFlodeURL.TextChanged += txtNyttFlodeURL_TextChanged;
            // 
            // txtVisaKategorier
            // 
            txtVisaKategorier.Location = new Point(729, 122);
            txtVisaKategorier.Margin = new Padding(4, 3, 4, 3);
            txtVisaKategorier.Name = "txtVisaKategorier";
            txtVisaKategorier.Size = new Size(299, 167);
            txtVisaKategorier.TabIndex = 6;
            txtVisaKategorier.Text = "";
            txtVisaKategorier.TextChanged += txtVisaKategorier_TextChanged;
            // 
            // cbNyttFlodeKategori
            // 
            cbNyttFlodeKategori.FormattingEnabled = true;
            cbNyttFlodeKategori.Items.AddRange(new object[] { "Skräck", "Komedi" });
            cbNyttFlodeKategori.Location = new Point(110, 184);
            cbNyttFlodeKategori.Margin = new Padding(4, 3, 4, 3);
            cbNyttFlodeKategori.Name = "cbNyttFlodeKategori";
            cbNyttFlodeKategori.Size = new Size(204, 23);
            cbNyttFlodeKategori.TabIndex = 8;
            // 
            // lblSkapaNyttFlodeKategori
            // 
            lblSkapaNyttFlodeKategori.AutoSize = true;
            lblSkapaNyttFlodeKategori.Location = new Point(46, 186);
            lblSkapaNyttFlodeKategori.Margin = new Padding(4, 0, 4, 0);
            lblSkapaNyttFlodeKategori.Name = "lblSkapaNyttFlodeKategori";
            lblSkapaNyttFlodeKategori.Size = new Size(51, 15);
            lblSkapaNyttFlodeKategori.TabIndex = 11;
            lblSkapaNyttFlodeKategori.Text = "Kategori";
            // 
            // lblSkapaNyttFlode
            // 
            lblSkapaNyttFlode.AutoSize = true;
            lblSkapaNyttFlode.Font = new Font("Segoe UI", 11F);
            lblSkapaNyttFlode.Location = new Point(150, 93);
            lblSkapaNyttFlode.Margin = new Padding(4, 0, 4, 0);
            lblSkapaNyttFlode.Name = "lblSkapaNyttFlode";
            lblSkapaNyttFlode.Size = new Size(117, 20);
            lblSkapaNyttFlode.TabIndex = 12;
            lblSkapaNyttFlode.Text = "Skapa nytt flöde";
            lblSkapaNyttFlode.Click += label4_Click;
            // 
            // lblAvsnittLista
            // 
            lblAvsnittLista.AutoSize = true;
            lblAvsnittLista.Location = new Point(500, 91);
            lblAvsnittLista.Margin = new Padding(4, 0, 4, 0);
            lblAvsnittLista.Name = "lblAvsnittLista";
            lblAvsnittLista.Size = new Size(44, 15);
            lblAvsnittLista.TabIndex = 13;
            lblAvsnittLista.Text = "Avsnitt";
            lblAvsnittLista.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRedigeraFloden
            // 
            btnRedigeraFloden.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnRedigeraFloden.FlatStyle = FlatStyle.Flat;
            btnRedigeraFloden.Location = new Point(94, 474);
            btnRedigeraFloden.Margin = new Padding(4, 3, 4, 3);
            btnRedigeraFloden.Name = "btnRedigeraFloden";
            btnRedigeraFloden.Size = new Size(111, 24);
            btnRedigeraFloden.TabIndex = 17;
            btnRedigeraFloden.Text = "Redigera";
            btnRedigeraFloden.UseVisualStyleBackColor = false;
            // 
            // btnRaderaFloden
            // 
            btnRaderaFloden.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnRaderaFloden.FlatStyle = FlatStyle.Flat;
            btnRaderaFloden.Location = new Point(223, 474);
            btnRaderaFloden.Margin = new Padding(4, 3, 4, 3);
            btnRaderaFloden.Name = "btnRaderaFloden";
            btnRaderaFloden.Size = new Size(105, 24);
            btnRaderaFloden.TabIndex = 18;
            btnRaderaFloden.Text = "Radera";
            btnRaderaFloden.UseVisualStyleBackColor = false;
            btnRaderaFloden.Click += btnRaderaFloden_Click;
            // 
            // lblMinaKategorier
            // 
            lblMinaKategorier.AutoSize = true;
            lblMinaKategorier.Location = new Point(831, 93);
            lblMinaKategorier.Margin = new Padding(4, 0, 4, 0);
            lblMinaKategorier.Name = "lblMinaKategorier";
            lblMinaKategorier.Size = new Size(90, 15);
            lblMinaKategorier.TabIndex = 19;
            lblMinaKategorier.Text = "Mina kategorier";
            lblMinaKategorier.Click += lblMinaKategorier_Click;
            // 
            // btnRaderaKategori
            // 
            btnRaderaKategori.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnRaderaKategori.FlatStyle = FlatStyle.Flat;
            btnRaderaKategori.Location = new Point(951, 293);
            btnRaderaKategori.Margin = new Padding(1, 2, 1, 2);
            btnRaderaKategori.Name = "btnRaderaKategori";
            btnRaderaKategori.Size = new Size(76, 21);
            btnRaderaKategori.TabIndex = 20;
            btnRaderaKategori.Text = "Radera";
            btnRaderaKategori.UseVisualStyleBackColor = false;
            btnRaderaKategori.Click += btnRaderaKategori_Click;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.BackColor = Color.FromArgb(204, 255, 210, 205);
            btnLaggTillKategori.FlatStyle = FlatStyle.Flat;
            btnLaggTillKategori.Location = new Point(840, 406);
            btnLaggTillKategori.Margin = new Padding(4, 3, 4, 3);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(78, 22);
            btnLaggTillKategori.TabIndex = 21;
            btnLaggTillKategori.Text = "Lägg till";
            btnLaggTillKategori.UseVisualStyleBackColor = false;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click;
            // 
            // txtLaggTillKategori
            // 
            txtLaggTillKategori.Location = new Point(820, 374);
            txtLaggTillKategori.Margin = new Padding(4, 3, 4, 3);
            txtLaggTillKategori.Name = "txtLaggTillKategori";
            txtLaggTillKategori.Size = new Size(117, 23);
            txtLaggTillKategori.TabIndex = 22;
            // 
            // lblLaggTillNyKategori
            // 
            lblLaggTillNyKategori.AutoSize = true;
            lblLaggTillNyKategori.Font = new Font("Segoe UI", 11F);
            lblLaggTillNyKategori.Location = new Point(808, 338);
            lblLaggTillNyKategori.Margin = new Padding(4, 0, 4, 0);
            lblLaggTillNyKategori.Name = "lblLaggTillNyKategori";
            lblLaggTillNyKategori.Size = new Size(141, 20);
            lblLaggTillNyKategori.TabIndex = 23;
            lblLaggTillNyKategori.Text = "Lägg till ny kategori";
            lblLaggTillNyKategori.Click += lblLaggTillNyKategori_Click;
            // 
            // lblLaggTillNyKategoriTitel
            // 
            lblLaggTillNyKategoriTitel.AutoSize = true;
            lblLaggTillNyKategoriTitel.Location = new Point(771, 376);
            lblLaggTillNyKategoriTitel.Margin = new Padding(4, 0, 4, 0);
            lblLaggTillNyKategoriTitel.Name = "lblLaggTillNyKategoriTitel";
            lblLaggTillNyKategoriTitel.Size = new Size(29, 15);
            lblLaggTillNyKategoriTitel.TabIndex = 24;
            lblLaggTillNyKategoriTitel.Text = "Titel";
            lblLaggTillNyKategoriTitel.Click += lblLaggTillNyKategoriTitel_Click;
            // 
            // lblLaggTillFlodeURL
            // 
            lblLaggTillFlodeURL.AutoSize = true;
            lblLaggTillFlodeURL.Location = new Point(70, 156);
            lblLaggTillFlodeURL.Margin = new Padding(4, 0, 4, 0);
            lblLaggTillFlodeURL.Name = "lblLaggTillFlodeURL";
            lblLaggTillFlodeURL.Size = new Size(28, 15);
            lblLaggTillFlodeURL.TabIndex = 25;
            lblLaggTillFlodeURL.Text = "URL";
            lblLaggTillFlodeURL.Click += label1_Click_1;
            // 
            // lblAvsnittBeskrivning
            // 
            lblAvsnittBeskrivning.AutoSize = true;
            lblAvsnittBeskrivning.Location = new Point(493, 311);
            lblAvsnittBeskrivning.Margin = new Padding(4, 0, 4, 0);
            lblAvsnittBeskrivning.Name = "lblAvsnittBeskrivning";
            lblAvsnittBeskrivning.Size = new Size(68, 15);
            lblAvsnittBeskrivning.TabIndex = 26;
            lblAvsnittBeskrivning.Text = "Beskrivning";
            lblAvsnittBeskrivning.Click += lblAvsnittBeskrivning_Click;
            // 
            // txtAvsnittBeskrivning
            // 
            txtAvsnittBeskrivning.Location = new Point(387, 338);
            txtAvsnittBeskrivning.Margin = new Padding(4, 3, 4, 3);
            txtAvsnittBeskrivning.Name = "txtAvsnittBeskrivning";
            txtAvsnittBeskrivning.Size = new Size(290, 161);
            txtAvsnittBeskrivning.TabIndex = 27;
            txtAvsnittBeskrivning.Text = "";
            txtAvsnittBeskrivning.TextChanged += txtAvsnittBeskrivning_TextChanged;
            // 
            // txtVisaFloden
            // 
            txtVisaFloden.FormattingEnabled = true;
            txtVisaFloden.ItemHeight = 15;
            txtVisaFloden.Location = new Point(94, 257);
            txtVisaFloden.Margin = new Padding(4, 3, 4, 3);
            txtVisaFloden.Name = "txtVisaFloden";
            txtVisaFloden.Size = new Size(235, 199);
            txtVisaFloden.TabIndex = 28;
            txtVisaFloden.SelectedIndexChanged += txtVisaFloden_SelectedIndexChanged;
            // 
            // txtVisaAvsnitt
            // 
            txtVisaAvsnitt.FormattingEnabled = true;
            txtVisaAvsnitt.ItemHeight = 15;
            txtVisaAvsnitt.Location = new Point(387, 122);
            txtVisaAvsnitt.Margin = new Padding(4, 3, 4, 3);
            txtVisaAvsnitt.Name = "txtVisaAvsnitt";
            txtVisaAvsnitt.Size = new Size(290, 169);
            txtVisaAvsnitt.TabIndex = 29;
            txtVisaAvsnitt.SelectedIndexChanged += txtVisaAvsnitt_SelectedIndexChanged;
            // 
            // lblLaggTillFlodeNamn
            // 
            lblLaggTillFlodeNamn.AutoSize = true;
            lblLaggTillFlodeNamn.Location = new Point(58, 126);
            lblLaggTillFlodeNamn.Margin = new Padding(4, 0, 4, 0);
            lblLaggTillFlodeNamn.Name = "lblLaggTillFlodeNamn";
            lblLaggTillFlodeNamn.Size = new Size(40, 15);
            lblLaggTillFlodeNamn.TabIndex = 30;
            lblLaggTillFlodeNamn.Text = "Namn";
            lblLaggTillFlodeNamn.Click += lblPodcastNamn_Click;
            // 
            // txtNyttFlodeNamn
            // 
            txtNyttFlodeNamn.Location = new Point(110, 124);
            txtNyttFlodeNamn.Margin = new Padding(4, 3, 4, 3);
            txtNyttFlodeNamn.Name = "txtNyttFlodeNamn";
            txtNyttFlodeNamn.PlaceholderText = "Creepypodden i P3";
            txtNyttFlodeNamn.Size = new Size(204, 23);
            txtNyttFlodeNamn.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 529);
            Controls.Add(txtNyttFlodeNamn);
            Controls.Add(lblLaggTillFlodeNamn);
            Controls.Add(txtVisaAvsnitt);
            Controls.Add(txtVisaFloden);
            Controls.Add(txtAvsnittBeskrivning);
            Controls.Add(lblAvsnittBeskrivning);
            Controls.Add(lblLaggTillFlodeURL);
            Controls.Add(lblLaggTillNyKategoriTitel);
            Controls.Add(lblLaggTillNyKategori);
            Controls.Add(txtLaggTillKategori);
            Controls.Add(btnLaggTillKategori);
            Controls.Add(btnRaderaKategori);
            Controls.Add(lblMinaKategorier);
            Controls.Add(btnRaderaFloden);
            Controls.Add(btnRedigeraFloden);
            Controls.Add(lblAvsnittLista);
            Controls.Add(lblSkapaNyttFlode);
            Controls.Add(lblSkapaNyttFlodeKategori);
            Controls.Add(cbNyttFlodeKategori);
            Controls.Add(txtVisaKategorier);
            Controls.Add(txtNyttFlodeURL);
            Controls.Add(btnNyttFlodeLaggTill);
            Controls.Add(lblHeader);
            Cursor = Cursors.IBeam;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lblHeader;
        private Button btnNyttFlodeLaggTill;
        private TextBox txtNyttFlodeURL;
        private RichTextBox txtVisaKategorier;
        private ComboBox cbNyttFlodeKategori;
        private Label lblSkapaNyttFlodeKategori;
        private Label lblSkapaNyttFlode;
        private Label lblAvsnittLista;
        private Button btnRedigeraFloden;
        private Button btnRaderaFloden;
        private Label lblMinaKategorier;
        private Button btnRaderaKategori;
        private Button btnLaggTillKategori;
        private TextBox txtLaggTillKategori;
        private Label lblLaggTillNyKategori;
        private Label lblLaggTillNyKategoriTitel;
        private Label lblLaggTillFlodeURL;
        private Label lblAvsnittBeskrivning;
        private RichTextBox txtAvsnittBeskrivning;
        private ListBox txtVisaFloden;
        private ListBox txtVisaAvsnitt;
        private Label lblLaggTillFlodeNamn;
        private TextBox txtNyttFlodeNamn;
    }
}
