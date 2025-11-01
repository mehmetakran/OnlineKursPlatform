using onlineKursPlatform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlineKursPlatform.Forms
{
    public partial class egitmenGiris : Form
    {
        private DersYonetimi dy;

        // Parametresiz constructor (Designer için)
        public egitmenGiris()
        {
            InitializeComponent();
            dy = new DersYonetimi();
            OrtakAyarlar();
        }

        // Parametreli constructor
        public egitmenGiris(DersYonetimi dersYonetimi)
        {
            InitializeComponent();
            dy = dersYonetimi;
            OrtakAyarlar(); // Burada da çağırıyoruz
        }

        private void OrtakAyarlar()
        {
            // ComboBox öğelerini ekle
            cmb_DersTuru.Items.Clear();
            cmb_DersTuru.Items.Add("Canlı");
            cmb_DersTuru.Items.Add("Kayıtlı");
            cmb_DersTuru.SelectedIndex = 0;

            // Örnek öğrencileri ekle (sadece parametresiz constructor için eklemek isteyebilirsin)
            if (dy.TumOgrenciler.Count == 0)
            {
                dy.TumOgrenciler.Add(new Ogrenci(1, "Ali Veli"));
                dy.TumOgrenciler.Add(new Ogrenci(2, "Ayşe Yılmaz"));
            }

            OgrencileriYukle();
        }

        private void OgrencileriYukle()
        {
            cmb_Ogrenciler.Items.Clear();
            foreach (Ogrenci o in dy.TumOgrenciler)
                cmb_Ogrenciler.Items.Add(o);
            if (cmb_Ogrenciler.Items.Count > 0)
                cmb_Ogrenciler.SelectedIndex = 0;
        }

        private void btn_DersEkle_Click(object sender, EventArgs e)
        {
            // Alanların boş olup olmadığını kontrol et
            if (txt_DersAdi.Text == "" || txt_EgitmenAdi.Text == "" || txt_Kontenjan.Text == "")
            {
                MessageBox.Show("Lütfen alanları doldurunuz");
            }
            else
            {
                string ad = txt_DersAdi.Text;
                string egitmen = txt_EgitmenAdi.Text;

                // Kontenjanın geçerli bir sayı olup olmadığını kontrol et
                int kontenjan;
                bool isValidKontenjan = int.TryParse(txt_Kontenjan.Text, out kontenjan);

                if (!isValidKontenjan)
                {
                    MessageBox.Show("Kontenjan sadece sayı olmalıdır.");
                    return; // Fonksiyonu sonlandır, işlem yapma
                }

                // Ders adı ile zaten mevcut bir ders olup olmadığını kontrol et
                if (dy.DersAdKontrol(ad))
                {
                    MessageBox.Show("Bu ders zaten eklenmiş.");
                    return; // Ders eklenmesin
                }
                int yeniId = dy.TumDersler.Count + 1;
                // Ders türüne göre yeni ders oluştur
                Ders yeniDers;
                if (cmb_DersTuru.SelectedItem.ToString() == "Canlı")
                {

                    yeniDers = new CanliDers(yeniId, ad, egitmen, kontenjan, "10:00", 90);
                }
                else
                {

                    yeniDers = new KayitliDers(yeniId, ad, egitmen, kontenjan, "link.com", 120);
                }

                // Ders ekle
                dy.DersEkle(yeniDers);
                lst_Dersler.Items.Add(yeniDers);
                lst_Dersler.DisplayMember = "Ad";  // Listeye ders adı ekle
            }

        }

        private void btn_OgrenciKayit_Click(object sender, EventArgs e)
        {
            if (lst_Dersler.SelectedItem != null && cmb_Ogrenciler.SelectedItem != null)
            {
                Ders secilenDers = (Ders)lst_Dersler.SelectedItem;
                Ogrenci secilenOgrenci = (Ogrenci)cmb_Ogrenciler.SelectedItem;

                string mesaj = dy.OgrenciDerseKayitEt(secilenOgrenci, secilenDers);
                MessageBox.Show(mesaj);

                lst_Ogrenciler.Items.Clear();
                foreach (Ders d in secilenOgrenci.KayitliDersler)
                    lst_Ogrenciler.Items.Add(d.BilgileriGoster());
            }
            else
                MessageBox.Show("Önce ders ve öğrenci seçin!");
        }

        private void egitmenGiris_Load(object sender, EventArgs e)
        {
            grp_DersEkleme.Visible = false;
            grp_OgrenciKayitEt.Visible = false;
            grp_Dersler.Visible = false;
        }

        private void btn_GeriDön2_Click(object sender, EventArgs e)
        {

        }

        private void dersEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void öğrenciKayıtModülüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dersEklemeEkranınıGizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grp_DersEkleme.Visible = false;
        }

        private void kayıtModülünüGizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grp_OgrenciKayitEt.Visible = false;
        }

        private void dersleriKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grp_Dersler.Visible = false;
        }

        private void derslerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void anasayfayaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Giris"].Show();
            this.Close();
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grp_DersEkleme.Visible = true;
        }

        private void kayıtModülünüGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grp_OgrenciKayitEt.Visible = true;

            MessageBox.Show("BİLGİLENDİRME : Öğrenci Kayıtları ders seçimi ile beraber yapılmalıdır. \nDers Seçim Ekranını açmayı unutmayınız.");
        }

        private void dersleriGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grp_Dersler.Visible = true;
        }
    }
}
