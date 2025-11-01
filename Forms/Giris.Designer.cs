namespace onlineKursPlatform
{
    partial class Giris
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
            btn_Ogrenci = new Button();
            btn_Egitmen = new Button();
            btn_Cikis = new Button();
            SuspendLayout();
            // 
            // btn_Ogrenci
            // 
            btn_Ogrenci.Location = new Point(91, 87);
            btn_Ogrenci.Name = "btn_Ogrenci";
            btn_Ogrenci.Size = new Size(211, 89);
            btn_Ogrenci.TabIndex = 0;
            btn_Ogrenci.Text = "ÖĞRENCİ GİRİŞ";
            btn_Ogrenci.UseVisualStyleBackColor = true;
            btn_Ogrenci.Click += btn_Ogrenci_Click;
            // 
            // btn_Egitmen
            // 
            btn_Egitmen.Location = new Point(376, 87);
            btn_Egitmen.Name = "btn_Egitmen";
            btn_Egitmen.Size = new Size(211, 89);
            btn_Egitmen.TabIndex = 1;
            btn_Egitmen.Text = "EĞİTMEN GİRİŞ";
            btn_Egitmen.UseVisualStyleBackColor = true;
            btn_Egitmen.Click += btn_Egitmen_Click;
            // 
            // btn_Cikis
            // 
            btn_Cikis.Location = new Point(631, 12);
            btn_Cikis.Name = "btn_Cikis";
            btn_Cikis.Size = new Size(24, 23);
            btn_Cikis.TabIndex = 2;
            btn_Cikis.Text = "X";
            btn_Cikis.UseVisualStyleBackColor = true;
            btn_Cikis.Click += btn_Cikis_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(672, 270);
            ControlBox = false;
            Controls.Add(btn_Cikis);
            Controls.Add(btn_Egitmen);
            Controls.Add(btn_Ogrenci);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Akran Online Kurs Platformu";
            Load += Giris_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Ogrenci;
        private Button btn_Egitmen;
        private Button btn_Cikis;
    }
}
