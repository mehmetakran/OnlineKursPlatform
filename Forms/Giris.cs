using onlineKursPlatform.Models;

namespace onlineKursPlatform
{
    public partial class Giris : Form
    {
        private DersYonetimi dy; // ders yönetimi nesnesi

        public Giris()
        {
            InitializeComponent();
            dy = new DersYonetimi(); // tek bir nesne oluþtur
        }
        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Uygulamayý kapatmak için kod
        }

        private void btn_Ogrenci_Click(object sender, EventArgs e)
        {
            Forms.ogrenciGiris ogrenci = new Forms.ogrenciGiris(dy); //Öðrenci formunu çaðýrýyoruz ve egitmen adýndaki deðiþkenimize türetiyoruz.
            ogrenci.Show();
            this.Hide();
        }

        private void btn_Egitmen_Click(object sender, EventArgs e)
        {
            Forms.egitmenGiris egitmen = new Forms.egitmenGiris(dy); //Eðitmen formunu çaðýrýyoruz ve egitmen adýndaki deðiþkenimize türetiyoruz.
            egitmen.Show();
            this.Hide();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
