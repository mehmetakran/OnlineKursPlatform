using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineKursPlatform.Models
{
    public class KayitliDers : Ders
    {
        public string KayitLinki;
        public int IzlenmeSuresi;

        public KayitliDers(int id, string ad, string egitmen, int kontenjan, string kayitLinki, int izlenmeSuresi)
            : base(id, ad, egitmen, kontenjan)
        {
            KayitLinki = kayitLinki;
            IzlenmeSuresi = izlenmeSuresi;
        }

        public override string ToString()
        {
            return Ad + " (Kayıtlı)";  // Ders adını ve "Kayıtlı" ibaresini döndür
        }
    }
}
