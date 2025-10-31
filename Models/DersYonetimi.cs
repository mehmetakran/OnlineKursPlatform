using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineKursPlatform.Models
{
    public class DersYonetimi
    {
        public List<Ders> TumDersler { get; set; }
        public List<Ogrenci> TumOgrenciler { get; set; }

        public DersYonetimi()
        {
            TumDersler = new List<Ders>();
            TumOgrenciler = new List<Ogrenci>();
        }

        // Öğrencinin derse kaydını yap
        public string OgrenciDerseKayitEt(Ogrenci ogrenci, Ders ders)
        {
            if (ogrenci.KayitliDersler.Contains(ders))
            {
                return "Bu derse zaten kayıtlı!";
            }

            ogrenci.KayitliDersler.Add(ders);  // Öğrenci kaydını ekle
            return "Öğrenci: " + ogrenci.AdSoyad + " başarıyla derse " + ders.Ad + " kayıt edilmiştir.";
        }

        // Ders adı kontrolü
        public bool DersAdKontrol(string dersAd)
        {
            foreach (var d in TumDersler)
            {
                if (d.Ad == dersAd)
                {
                    return true;  // Ders adı zaten mevcut
                }
            }
            return false;
        }

        // Ders ekle
        public void DersEkle(Ders ders)
        {
            if (!DersAdKontrol(ders.Ad))  // Eğer aynı ders yoksa
            {
                TumDersler.Add(ders);  // Yeni dersi listeye ekle
            }
            else
            {
                MessageBox.Show("Bu ders zaten mevcut!");  // Ders zaten eklenmişse uyarı ver
            }
        }
    }
}
