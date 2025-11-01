namespace onlineKursPlatform.Forms
{
    partial class ogrenciGiris
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
            cmb_OgrenciSec = new ComboBox();
            lst_TumDersler = new ListBox();
            lst_KayitliDersler = new ListBox();
            btn_DerseKaydol = new Button();
            lbl_OgrenciAdi = new Label();
            btn_GeriDon = new Button();
            SuspendLayout();
            // 
            // cmb_OgrenciSec
            // 
            cmb_OgrenciSec.FormattingEnabled = true;
            cmb_OgrenciSec.Location = new Point(12, 12);
            cmb_OgrenciSec.Name = "cmb_OgrenciSec";
            cmb_OgrenciSec.Size = new Size(170, 23);
            cmb_OgrenciSec.TabIndex = 0;
            cmb_OgrenciSec.SelectedIndexChanged += cmb_OgrenciSec_SelectedIndexChanged;
            // 
            // lst_TumDersler
            // 
            lst_TumDersler.FormattingEnabled = true;
            lst_TumDersler.ItemHeight = 15;
            lst_TumDersler.Location = new Point(12, 41);
            lst_TumDersler.Name = "lst_TumDersler";
            lst_TumDersler.Size = new Size(170, 124);
            lst_TumDersler.TabIndex = 1;
            // 
            // lst_KayitliDersler
            // 
            lst_KayitliDersler.FormattingEnabled = true;
            lst_KayitliDersler.ItemHeight = 15;
            lst_KayitliDersler.Location = new Point(188, 41);
            lst_KayitliDersler.Name = "lst_KayitliDersler";
            lst_KayitliDersler.Size = new Size(168, 124);
            lst_KayitliDersler.TabIndex = 2;
            // 
            // btn_DerseKaydol
            // 
            btn_DerseKaydol.Location = new Point(12, 171);
            btn_DerseKaydol.Name = "btn_DerseKaydol";
            btn_DerseKaydol.Size = new Size(170, 43);
            btn_DerseKaydol.TabIndex = 3;
            btn_DerseKaydol.Text = "Derse Kayıt Ol";
            btn_DerseKaydol.UseVisualStyleBackColor = true;
            btn_DerseKaydol.Click += btn_DerseKaydol_Click;
            // 
            // lbl_OgrenciAdi
            // 
            lbl_OgrenciAdi.AutoSize = true;
            lbl_OgrenciAdi.Location = new Point(188, 15);
            lbl_OgrenciAdi.Name = "lbl_OgrenciAdi";
            lbl_OgrenciAdi.Size = new Size(38, 15);
            lbl_OgrenciAdi.TabIndex = 4;
            lbl_OgrenciAdi.Text = "label1";
            // 
            // btn_GeriDon
            // 
            btn_GeriDon.Location = new Point(660, 12);
            btn_GeriDon.Name = "btn_GeriDon";
            btn_GeriDon.Size = new Size(114, 44);
            btn_GeriDon.TabIndex = 5;
            btn_GeriDon.Text = "Anasayfa";
            btn_GeriDon.UseVisualStyleBackColor = true;
            btn_GeriDon.Click += btn_GeriDon_Click;
            // 
            // ogrenciGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(800, 346);
            Controls.Add(btn_GeriDon);
            Controls.Add(lbl_OgrenciAdi);
            Controls.Add(btn_DerseKaydol);
            Controls.Add(lst_KayitliDersler);
            Controls.Add(lst_TumDersler);
            Controls.Add(cmb_OgrenciSec);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ogrenciGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Sayfası";
            Load += ogrenciGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_OgrenciSec;
        private ListBox lst_TumDersler;
        private ListBox lst_KayitliDersler;
        private Button btn_DerseKaydol;
        private Label lbl_OgrenciAdi;
        private Button btn_GeriDon;
    }
}