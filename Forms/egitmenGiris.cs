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

        DersYonetimi dy = new DersYonetimi();
        private void OgrencileriYukle()
        {
            cmb_Ogrenciler.Items.Clear();
            foreach (Ogrenci o in dy.TumOgrenciler)
                cmb_Ogrenciler.Items.Add(o);

            if (cmb_Ogrenciler.Items.Count > 0)
                cmb_Ogrenciler.SelectedIndex = 0;
        }

        public egitmenGiris()
        {
            InitializeComponent();
            dy = new DersYonetimi();

            cmb_DersTuru.Items.Add("Canlı");
            cmb_DersTuru.Items.Add("Kayıtlı");
            cmb_DersTuru.SelectedIndex = 0;

            // Örnek öğrenciler ekle
            dy.TumOgrenciler.Add(new Ogrenci(1, "Ali Veli"));
            dy.TumOgrenciler.Add(new Ogrenci(2, "Ayşe Yılmaz"));

            OgrencileriYukle();
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

                // Ders türüne göre yeni ders oluştur
                Ders yeniDers;
                if (cmb_DersTuru.SelectedItem.ToString() == "Canlı")
                    yeniDers = new CanliDers(1, ad, egitmen, kontenjan, "10:00", 90);
                else
                    yeniDers = new KayitliDers(1, ad, egitmen, kontenjan, "link.com", 120);

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

        }
    }
}
