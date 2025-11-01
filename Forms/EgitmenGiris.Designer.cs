namespace onlineKursPlatform.Forms
{
    partial class egitmenGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_DersAdi = new TextBox();
            txt_EgitmenAdi = new TextBox();
            txt_Kontenjan = new TextBox();
            cmb_DersTuru = new ComboBox();
            btn_DersEkle = new Button();
            lst_Dersler = new ListBox();
            cmb_Ogrenciler = new ComboBox();
            lst_Ogrenciler = new ListBox();
            btn_OgrenciKayit = new Button();
            grp_DersEkleme = new GroupBox();
            lbl_DersTuru = new Label();
            lbl_Kontenjan = new Label();
            lbl_EgitmenAdi = new Label();
            lbl_DersAdi = new Label();
            grp_OgrenciKayitEt = new GroupBox();
            lbl_Liste = new Label();
            lbl_Ogrenciler = new Label();
            pnl_DersEkle = new Panel();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            işlemlerToolStripMenuItem = new ToolStripMenuItem();
            dersEklemeToolStripMenuItem = new ToolStripMenuItem();
            gösterToolStripMenuItem = new ToolStripMenuItem();
            dersEklemeEkranınıGizleToolStripMenuItem = new ToolStripMenuItem();
            öğrenciKayıtModülüToolStripMenuItem = new ToolStripMenuItem();
            kayıtModülünüGösterToolStripMenuItem = new ToolStripMenuItem();
            kayıtModülünüGizleToolStripMenuItem = new ToolStripMenuItem();
            derslerToolStripMenuItem = new ToolStripMenuItem();
            dersleriGToolStripMenuItem = new ToolStripMenuItem();
            dersleriKapatToolStripMenuItem = new ToolStripMenuItem();
            anasayfayaDönToolStripMenuItem = new ToolStripMenuItem();
            pnl_Dersler = new Panel();
            grp_Dersler = new GroupBox();
            grp_DersEkleme.SuspendLayout();
            grp_OgrenciKayitEt.SuspendLayout();
            pnl_DersEkle.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnl_Dersler.SuspendLayout();
            grp_Dersler.SuspendLayout();
            SuspendLayout();
            // 
            // txt_DersAdi
            // 
            txt_DersAdi.Location = new Point(130, 22);
            txt_DersAdi.Name = "txt_DersAdi";
            txt_DersAdi.Size = new Size(205, 23);
            txt_DersAdi.TabIndex = 0;
            // 
            // txt_EgitmenAdi
            // 
            txt_EgitmenAdi.Location = new Point(130, 51);
            txt_EgitmenAdi.Name = "txt_EgitmenAdi";
            txt_EgitmenAdi.Size = new Size(205, 23);
            txt_EgitmenAdi.TabIndex = 1;
            // 
            // txt_Kontenjan
            // 
            txt_Kontenjan.Location = new Point(130, 80);
            txt_Kontenjan.Name = "txt_Kontenjan";
            txt_Kontenjan.Size = new Size(205, 23);
            txt_Kontenjan.TabIndex = 2;
            // 
            // cmb_DersTuru
            // 
            cmb_DersTuru.FormattingEnabled = true;
            cmb_DersTuru.Location = new Point(130, 109);
            cmb_DersTuru.Name = "cmb_DersTuru";
            cmb_DersTuru.Size = new Size(205, 23);
            cmb_DersTuru.TabIndex = 3;
            // 
            // btn_DersEkle
            // 
            btn_DersEkle.ForeColor = SystemColors.MenuText;
            btn_DersEkle.Location = new Point(130, 151);
            btn_DersEkle.Name = "btn_DersEkle";
            btn_DersEkle.Size = new Size(205, 39);
            btn_DersEkle.TabIndex = 4;
            btn_DersEkle.Text = "Ders Ekle";
            btn_DersEkle.UseVisualStyleBackColor = true;
            btn_DersEkle.Click += btn_DersEkle_Click;
            // 
            // lst_Dersler
            // 
            lst_Dersler.FormattingEnabled = true;
            lst_Dersler.ItemHeight = 15;
            lst_Dersler.Location = new Point(7, 22);
            lst_Dersler.Name = "lst_Dersler";
            lst_Dersler.Size = new Size(894, 169);
            lst_Dersler.TabIndex = 5;
            // 
            // cmb_Ogrenciler
            // 
            cmb_Ogrenciler.FormattingEnabled = true;
            cmb_Ogrenciler.Location = new Point(96, 22);
            cmb_Ogrenciler.Name = "cmb_Ogrenciler";
            cmb_Ogrenciler.Size = new Size(364, 23);
            cmb_Ogrenciler.TabIndex = 6;
            // 
            // lst_Ogrenciler
            // 
            lst_Ogrenciler.FormattingEnabled = true;
            lst_Ogrenciler.ItemHeight = 15;
            lst_Ogrenciler.Location = new Point(96, 51);
            lst_Ogrenciler.Name = "lst_Ogrenciler";
            lst_Ogrenciler.Size = new Size(364, 139);
            lst_Ogrenciler.TabIndex = 7;
            // 
            // btn_OgrenciKayit
            // 
            btn_OgrenciKayit.ForeColor = SystemColors.ControlText;
            btn_OgrenciKayit.Location = new Point(96, 200);
            btn_OgrenciKayit.Name = "btn_OgrenciKayit";
            btn_OgrenciKayit.Size = new Size(364, 31);
            btn_OgrenciKayit.TabIndex = 8;
            btn_OgrenciKayit.Text = "Öğrenci Kayıt Et";
            btn_OgrenciKayit.UseVisualStyleBackColor = true;
            btn_OgrenciKayit.Click += btn_OgrenciKayit_Click;
            // 
            // grp_DersEkleme
            // 
            grp_DersEkleme.Controls.Add(lbl_DersTuru);
            grp_DersEkleme.Controls.Add(lbl_Kontenjan);
            grp_DersEkleme.Controls.Add(lbl_EgitmenAdi);
            grp_DersEkleme.Controls.Add(lbl_DersAdi);
            grp_DersEkleme.Controls.Add(txt_DersAdi);
            grp_DersEkleme.Controls.Add(txt_EgitmenAdi);
            grp_DersEkleme.Controls.Add(txt_Kontenjan);
            grp_DersEkleme.Controls.Add(cmb_DersTuru);
            grp_DersEkleme.Controls.Add(btn_DersEkle);
            grp_DersEkleme.ForeColor = SystemColors.ButtonFace;
            grp_DersEkleme.Location = new Point(12, 12);
            grp_DersEkleme.Name = "grp_DersEkleme";
            grp_DersEkleme.Size = new Size(370, 237);
            grp_DersEkleme.TabIndex = 10;
            grp_DersEkleme.TabStop = false;
            grp_DersEkleme.Text = "Ders Ekleme";
            // 
            // lbl_DersTuru
            // 
            lbl_DersTuru.AutoSize = true;
            lbl_DersTuru.Location = new Point(16, 117);
            lbl_DersTuru.Name = "lbl_DersTuru";
            lbl_DersTuru.Size = new Size(57, 15);
            lbl_DersTuru.TabIndex = 8;
            lbl_DersTuru.Text = "Ders Türü";
            // 
            // lbl_Kontenjan
            // 
            lbl_Kontenjan.AutoSize = true;
            lbl_Kontenjan.Location = new Point(16, 88);
            lbl_Kontenjan.Name = "lbl_Kontenjan";
            lbl_Kontenjan.Size = new Size(99, 15);
            lbl_Kontenjan.TabIndex = 7;
            lbl_Kontenjan.Text = "Ders Kontenjanı : ";
            // 
            // lbl_EgitmenAdi
            // 
            lbl_EgitmenAdi.AutoSize = true;
            lbl_EgitmenAdi.Location = new Point(16, 59);
            lbl_EgitmenAdi.Name = "lbl_EgitmenAdi";
            lbl_EgitmenAdi.Size = new Size(81, 15);
            lbl_EgitmenAdi.TabIndex = 6;
            lbl_EgitmenAdi.Text = "Eğitmen Adı : ";
            // 
            // lbl_DersAdi
            // 
            lbl_DersAdi.AutoSize = true;
            lbl_DersAdi.Location = new Point(16, 30);
            lbl_DersAdi.Name = "lbl_DersAdi";
            lbl_DersAdi.Size = new Size(57, 15);
            lbl_DersAdi.TabIndex = 5;
            lbl_DersAdi.Text = "Ders Adı :";
            // 
            // grp_OgrenciKayitEt
            // 
            grp_OgrenciKayitEt.Controls.Add(lbl_Liste);
            grp_OgrenciKayitEt.Controls.Add(lbl_Ogrenciler);
            grp_OgrenciKayitEt.Controls.Add(cmb_Ogrenciler);
            grp_OgrenciKayitEt.Controls.Add(lst_Ogrenciler);
            grp_OgrenciKayitEt.Controls.Add(btn_OgrenciKayit);
            grp_OgrenciKayitEt.ForeColor = SystemColors.ButtonFace;
            grp_OgrenciKayitEt.Location = new Point(12, 12);
            grp_OgrenciKayitEt.Name = "grp_OgrenciKayitEt";
            grp_OgrenciKayitEt.Size = new Size(482, 237);
            grp_OgrenciKayitEt.TabIndex = 11;
            grp_OgrenciKayitEt.TabStop = false;
            grp_OgrenciKayitEt.Text = "Öğrenci Kayıt Et";
            // 
            // lbl_Liste
            // 
            lbl_Liste.AutoSize = true;
            lbl_Liste.Location = new Point(6, 109);
            lbl_Liste.Name = "lbl_Liste";
            lbl_Liste.Size = new Size(90, 15);
            lbl_Liste.TabIndex = 10;
            lbl_Liste.Text = "Öğrenci Listesi :";
            // 
            // lbl_Ogrenciler
            // 
            lbl_Ogrenciler.AutoSize = true;
            lbl_Ogrenciler.Location = new Point(6, 30);
            lbl_Ogrenciler.Name = "lbl_Ogrenciler";
            lbl_Ogrenciler.Size = new Size(71, 15);
            lbl_Ogrenciler.TabIndex = 9;
            lbl_Ogrenciler.Text = "Öğrenciler : ";
            // 
            // pnl_DersEkle
            // 
            pnl_DersEkle.BackColor = Color.Gray;
            pnl_DersEkle.Controls.Add(grp_DersEkleme);
            pnl_DersEkle.Location = new Point(28, 44);
            pnl_DersEkle.Name = "pnl_DersEkle";
            pnl_DersEkle.Size = new Size(394, 269);
            pnl_DersEkle.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(grp_OgrenciKayitEt);
            panel1.Location = new Point(445, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 269);
            panel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { işlemlerToolStripMenuItem, anasayfayaDönToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            işlemlerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dersEklemeToolStripMenuItem, öğrenciKayıtModülüToolStripMenuItem, derslerToolStripMenuItem });
            işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            işlemlerToolStripMenuItem.Size = new Size(60, 20);
            işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // dersEklemeToolStripMenuItem
            // 
            dersEklemeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gösterToolStripMenuItem, dersEklemeEkranınıGizleToolStripMenuItem });
            dersEklemeToolStripMenuItem.Name = "dersEklemeToolStripMenuItem";
            dersEklemeToolStripMenuItem.Size = new Size(190, 22);
            dersEklemeToolStripMenuItem.Text = "Ders Ekleme";
            dersEklemeToolStripMenuItem.Click += dersEklemeToolStripMenuItem_Click;
            // 
            // gösterToolStripMenuItem
            // 
            gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            gösterToolStripMenuItem.Size = new Size(108, 22);
            gösterToolStripMenuItem.Text = "Göster";
            gösterToolStripMenuItem.Click += gösterToolStripMenuItem_Click;
            // 
            // dersEklemeEkranınıGizleToolStripMenuItem
            // 
            dersEklemeEkranınıGizleToolStripMenuItem.Name = "dersEklemeEkranınıGizleToolStripMenuItem";
            dersEklemeEkranınıGizleToolStripMenuItem.Size = new Size(108, 22);
            dersEklemeEkranınıGizleToolStripMenuItem.Text = "Gizle";
            dersEklemeEkranınıGizleToolStripMenuItem.Click += dersEklemeEkranınıGizleToolStripMenuItem_Click;
            // 
            // öğrenciKayıtModülüToolStripMenuItem
            // 
            öğrenciKayıtModülüToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kayıtModülünüGösterToolStripMenuItem, kayıtModülünüGizleToolStripMenuItem });
            öğrenciKayıtModülüToolStripMenuItem.Name = "öğrenciKayıtModülüToolStripMenuItem";
            öğrenciKayıtModülüToolStripMenuItem.Size = new Size(190, 22);
            öğrenciKayıtModülüToolStripMenuItem.Text = "Öğrenci Kayıt Modülü";
            öğrenciKayıtModülüToolStripMenuItem.Click += öğrenciKayıtModülüToolStripMenuItem_Click;
            // 
            // kayıtModülünüGösterToolStripMenuItem
            // 
            kayıtModülünüGösterToolStripMenuItem.Name = "kayıtModülünüGösterToolStripMenuItem";
            kayıtModülünüGösterToolStripMenuItem.Size = new Size(196, 22);
            kayıtModülünüGösterToolStripMenuItem.Text = "Kayıt Modülünü Göster";
            kayıtModülünüGösterToolStripMenuItem.Click += kayıtModülünüGösterToolStripMenuItem_Click;
            // 
            // kayıtModülünüGizleToolStripMenuItem
            // 
            kayıtModülünüGizleToolStripMenuItem.Name = "kayıtModülünüGizleToolStripMenuItem";
            kayıtModülünüGizleToolStripMenuItem.Size = new Size(196, 22);
            kayıtModülünüGizleToolStripMenuItem.Text = "Kayıt Modülünü Gizle";
            kayıtModülünüGizleToolStripMenuItem.Click += kayıtModülünüGizleToolStripMenuItem_Click;
            // 
            // derslerToolStripMenuItem
            // 
            derslerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dersleriGToolStripMenuItem, dersleriKapatToolStripMenuItem });
            derslerToolStripMenuItem.Name = "derslerToolStripMenuItem";
            derslerToolStripMenuItem.Size = new Size(190, 22);
            derslerToolStripMenuItem.Text = "Dersler";
            derslerToolStripMenuItem.Click += derslerToolStripMenuItem_Click;
            // 
            // dersleriGToolStripMenuItem
            // 
            dersleriGToolStripMenuItem.Name = "dersleriGToolStripMenuItem";
            dersleriGToolStripMenuItem.Size = new Size(150, 22);
            dersleriGToolStripMenuItem.Text = "Dersleri Göster";
            dersleriGToolStripMenuItem.Click += dersleriGToolStripMenuItem_Click;
            // 
            // dersleriKapatToolStripMenuItem
            // 
            dersleriKapatToolStripMenuItem.Name = "dersleriKapatToolStripMenuItem";
            dersleriKapatToolStripMenuItem.Size = new Size(150, 22);
            dersleriKapatToolStripMenuItem.Text = "Dersleri Kapat";
            dersleriKapatToolStripMenuItem.Click += dersleriKapatToolStripMenuItem_Click;
            // 
            // anasayfayaDönToolStripMenuItem
            // 
            anasayfayaDönToolStripMenuItem.Name = "anasayfayaDönToolStripMenuItem";
            anasayfayaDönToolStripMenuItem.Size = new Size(104, 20);
            anasayfayaDönToolStripMenuItem.Text = "Anasayfaya Dön";
            anasayfayaDönToolStripMenuItem.Click += anasayfayaDönToolStripMenuItem_Click;
            // 
            // pnl_Dersler
            // 
            pnl_Dersler.BackColor = Color.Gray;
            pnl_Dersler.Controls.Add(grp_Dersler);
            pnl_Dersler.Location = new Point(28, 328);
            pnl_Dersler.Name = "pnl_Dersler";
            pnl_Dersler.Size = new Size(931, 218);
            pnl_Dersler.TabIndex = 14;
            // 
            // grp_Dersler
            // 
            grp_Dersler.Controls.Add(lst_Dersler);
            grp_Dersler.ForeColor = SystemColors.Control;
            grp_Dersler.Location = new Point(10, 4);
            grp_Dersler.Name = "grp_Dersler";
            grp_Dersler.Size = new Size(907, 201);
            grp_Dersler.TabIndex = 6;
            grp_Dersler.TabStop = false;
            grp_Dersler.Text = "Dersler";
            // 
            // egitmenGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(984, 622);
            ControlBox = false;
            Controls.Add(pnl_Dersler);
            Controls.Add(panel1);
            Controls.Add(pnl_DersEkle);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "egitmenGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eğitmen Sayfası";
            Load += egitmenGiris_Load;
            grp_DersEkleme.ResumeLayout(false);
            grp_DersEkleme.PerformLayout();
            grp_OgrenciKayitEt.ResumeLayout(false);
            grp_OgrenciKayitEt.PerformLayout();
            pnl_DersEkle.ResumeLayout(false);
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnl_Dersler.ResumeLayout(false);
            grp_Dersler.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_DersAdi;
        private TextBox txt_EgitmenAdi;
        private TextBox txt_Kontenjan;
        private ComboBox cmb_DersTuru;
        private Button btn_DersEkle;
        private ListBox lst_Dersler;
        private ComboBox cmb_Ogrenciler;
        private ListBox lst_Ogrenciler;
        private Button btn_OgrenciKayit;
        private GroupBox grp_DersEkleme;
        private GroupBox grp_OgrenciKayitEt;
        private Panel pnl_DersEkle;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem işlemlerToolStripMenuItem;
        private ToolStripMenuItem dersEklemeToolStripMenuItem;
        private ToolStripMenuItem öğrenciKayıtModülüToolStripMenuItem;
        private ToolStripMenuItem derslerToolStripMenuItem;
        private ToolStripMenuItem dersleriKapatToolStripMenuItem;
        private ToolStripMenuItem anasayfayaDönToolStripMenuItem;
        private Panel pnl_Dersler;
        private ToolStripMenuItem dersEklemeEkranınıGizleToolStripMenuItem;
        private ToolStripMenuItem kayıtModülünüGizleToolStripMenuItem;
        private ToolStripMenuItem gösterToolStripMenuItem;
        private ToolStripMenuItem kayıtModülünüGösterToolStripMenuItem;
        private ToolStripMenuItem dersleriGToolStripMenuItem;
        private Label lbl_DersTuru;
        private Label lbl_Kontenjan;
        private Label lbl_EgitmenAdi;
        private Label lbl_DersAdi;
        private Label lbl_Ogrenciler;
        private Label lbl_Liste;
        private GroupBox grp_Dersler;
    }
}