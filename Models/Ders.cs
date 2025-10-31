using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineKursPlatform.Models
{
    public class Ders
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Egitmen { get; set; }
        public int Kontenjan { get; set; }

        public Ders(int id, string ad, string egitmen, int kontenjan)
        {
            Id = id;
            Ad = ad;
            Egitmen = egitmen;
            Kontenjan = kontenjan;
        }

        // Dersin bilgilerini göster
        public string BilgileriGoster()
        {
            return "Ders Adı: " + Ad + ", Eğitmen: " + Egitmen + ", Kontenjan: " + Kontenjan;
        }

        // ToString metodunu override ederek dersin adını göstereceğiz.
        public override string ToString()
        {
            return Ad;  // ToString override'ı
        }
    }
}
