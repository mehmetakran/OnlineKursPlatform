namespace onlineKursPlatform
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Uygulamay� kapatmak i�in kod
        }

        private void btn_Ogrenci_Click(object sender, EventArgs e)
        {
            Forms.ogrenciGiris ogrenci = new Forms.ogrenciGiris(); //��renci formunu �a��r�yoruz ve egitmen ad�ndaki de�i�kenimize t�retiyoruz.
            ogrenci.Show();
            this.Hide();
        }

        private void btn_Egitmen_Click(object sender, EventArgs e)
        {
            Forms.egitmenGiris egitmen = new Forms.egitmenGiris(); //E�itmen formunu �a��r�yoruz ve egitmen ad�ndaki de�i�kenimize t�retiyoruz.
            egitmen.Show();
            this.Hide();
        }
    }
}
