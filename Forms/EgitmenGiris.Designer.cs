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
            lbl_Mesaj = new Label();
            SuspendLayout();
            // 
            // txt_DersAdi
            // 
            txt_DersAdi.Location = new Point(84, 12);
            txt_DersAdi.Name = "txt_DersAdi";
            txt_DersAdi.Size = new Size(174, 23);
            txt_DersAdi.TabIndex = 0;
            // 
            // txt_EgitmenAdi
            // 
            txt_EgitmenAdi.Location = new Point(84, 41);
            txt_EgitmenAdi.Name = "txt_EgitmenAdi";
            txt_EgitmenAdi.Size = new Size(174, 23);
            txt_EgitmenAdi.TabIndex = 1;
            // 
            // txt_Kontenjan
            // 
            txt_Kontenjan.Location = new Point(84, 70);
            txt_Kontenjan.Name = "txt_Kontenjan";
            txt_Kontenjan.Size = new Size(174, 23);
            txt_Kontenjan.TabIndex = 2;
            // 
            // cmb_DersTuru
            // 
            cmb_DersTuru.FormattingEnabled = true;
            cmb_DersTuru.Location = new Point(84, 99);
            cmb_DersTuru.Name = "cmb_DersTuru";
            cmb_DersTuru.Size = new Size(174, 23);
            cmb_DersTuru.TabIndex = 3;
            // 
            // btn_DersEkle
            // 
            btn_DersEkle.Location = new Point(84, 142);
            btn_DersEkle.Name = "btn_DersEkle";
            btn_DersEkle.Size = new Size(174, 39);
            btn_DersEkle.TabIndex = 4;
            btn_DersEkle.Text = "Ders Ekle";
            btn_DersEkle.UseVisualStyleBackColor = true;
            btn_DersEkle.Click += btn_DersEkle_Click;
            // 
            // lst_Dersler
            // 
            lst_Dersler.FormattingEnabled = true;
            lst_Dersler.ItemHeight = 15;
            lst_Dersler.Location = new Point(308, 12);
            lst_Dersler.Name = "lst_Dersler";
            lst_Dersler.Size = new Size(215, 109);
            lst_Dersler.TabIndex = 5;
            // 
            // cmb_Ogrenciler
            // 
            cmb_Ogrenciler.FormattingEnabled = true;
            cmb_Ogrenciler.Location = new Point(528, 12);
            cmb_Ogrenciler.Name = "cmb_Ogrenciler";
            cmb_Ogrenciler.Size = new Size(121, 23);
            cmb_Ogrenciler.TabIndex = 6;
            // 
            // lst_Ogrenciler
            // 
            lst_Ogrenciler.FormattingEnabled = true;
            lst_Ogrenciler.ItemHeight = 15;
            lst_Ogrenciler.Location = new Point(529, 41);
            lst_Ogrenciler.Name = "lst_Ogrenciler";
            lst_Ogrenciler.Size = new Size(259, 94);
            lst_Ogrenciler.TabIndex = 7;
            // 
            // btn_OgrenciKayit
            // 
            btn_OgrenciKayit.Location = new Point(529, 150);
            btn_OgrenciKayit.Name = "btn_OgrenciKayit";
            btn_OgrenciKayit.Size = new Size(120, 31);
            btn_OgrenciKayit.TabIndex = 8;
            btn_OgrenciKayit.Text = "Öğrenci Kayıt Et";
            btn_OgrenciKayit.UseVisualStyleBackColor = true;
            btn_OgrenciKayit.Click += btn_OgrenciKayit_Click;
            // 
            // lbl_Mesaj
            // 
            lbl_Mesaj.AutoSize = true;
            lbl_Mesaj.Location = new Point(84, 200);
            lbl_Mesaj.Name = "lbl_Mesaj";
            lbl_Mesaj.Size = new Size(38, 15);
            lbl_Mesaj.TabIndex = 9;
            lbl_Mesaj.Text = "label1";
            // 
            // egitmenGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lbl_Mesaj);
            Controls.Add(btn_OgrenciKayit);
            Controls.Add(lst_Ogrenciler);
            Controls.Add(cmb_Ogrenciler);
            Controls.Add(lst_Dersler);
            Controls.Add(btn_DersEkle);
            Controls.Add(cmb_DersTuru);
            Controls.Add(txt_Kontenjan);
            Controls.Add(txt_EgitmenAdi);
            Controls.Add(txt_DersAdi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "egitmenGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eğitmen Sayfası";
            Load += egitmenGiris_Load;
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
        private Label lbl_Mesaj;
    }
}