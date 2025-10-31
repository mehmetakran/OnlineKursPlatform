using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineKursPlatform.Models
{
    public class Ogrenci
    {
        public int Id;
        public string AdSoyad;
        public List<Ders> KayitliDersler;

        public Ogrenci(int id, string adSoyad)
        {
            Id = id;
            AdSoyad = adSoyad;
            KayitliDersler = new List<Ders>();
        }

        // Bu metot, ComboBox'larda öğrencinin ismini göstermek için kullanılır.
        public override string ToString()
        {
            return AdSoyad;  // Öğrencinin adını döndürüyoruz.
        }
    }
}
