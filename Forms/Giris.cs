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
            Application.Exit(); //Uygulamayý kapatmak için kod
        }

        private void btn_Ogrenci_Click(object sender, EventArgs e)
        {
            Forms.ogrenciGiris ogrenci = new Forms.ogrenciGiris(); //Öðrenci formunu çaðýrýyoruz ve egitmen adýndaki deðiþkenimize türetiyoruz.
            ogrenci.Show();
            this.Hide();
        }

        private void btn_Egitmen_Click(object sender, EventArgs e)
        {
            Forms.egitmenGiris egitmen = new Forms.egitmenGiris(); //Eðitmen formunu çaðýrýyoruz ve egitmen adýndaki deðiþkenimize türetiyoruz.
            egitmen.Show();
            this.Hide();
        }
    }
}
