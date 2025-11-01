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
    public partial class ogrenciGiris : Form
    {
        public ogrenciGiris()
        {
            InitializeComponent();
        }
        private DersYonetimi dy;

        public ogrenciGiris(DersYonetimi dersYonetimi)
        {
            InitializeComponent();
            dy = dersYonetimi; // Eğitmen tarafından oluşturulan veri paylaşımı
        }

        private void ogrenciGiris_Load(object sender, EventArgs e)
        {
            // Öğrencileri yükle
            cmb_OgrenciSec.Items.Clear();
            foreach (var ogrenci in dy.TumOgrenciler)
                cmb_OgrenciSec.Items.Add(ogrenci);
            if (cmb_OgrenciSec.Items.Count > 0)
                cmb_OgrenciSec.SelectedIndex = 0;

            // Dersleri yükle
            lst_TumDersler.Items.Clear();
            foreach (var ders in dy.TumDersler)
                lst_TumDersler.Items.Add(ders);
            lst_TumDersler.DisplayMember = "Ad";
        }

        private void btn_DerseKaydol_Click(object sender, EventArgs e)
        {
            if (lst_TumDersler.SelectedItem != null && cmb_OgrenciSec.SelectedItem != null)
            {
                Ders secilenDers = (Ders)lst_TumDersler.SelectedItem;
                Ogrenci secilenOgrenci = (Ogrenci)cmb_OgrenciSec.SelectedItem;

                string mesaj = dy.OgrenciDerseKayitEt(secilenOgrenci, secilenDers);
                MessageBox.Show(mesaj);

                // Kayitli dersleri güncelle
                lst_KayitliDersler.Items.Clear();
                foreach (var ders in secilenOgrenci.KayitliDersler)
                    lst_KayitliDersler.Items.Add(ders.BilgileriGoster());
            }
            else
            {
                MessageBox.Show("Lütfen önce öğrenci ve ders seçin.");
            }
        }

        private void cmb_OgrenciSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ogrenci secilenOgrenci = (Ogrenci)cmb_OgrenciSec.SelectedItem;
            lbl_OgrenciAdi.Text = secilenOgrenci.AdSoyad;

            lst_KayitliDersler.Items.Clear();
            foreach (var ders in secilenOgrenci.KayitliDersler)
                lst_KayitliDersler.Items.Add(ders.BilgileriGoster());
        }

        private void btn_GeriDon_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Giris"].Show();
            this.Close();
        }
    }
}
