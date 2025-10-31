using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineKursPlatform.Models
{
    public class CanliDers : Ders
    {
        public string BaslangicSaati;
        public int Sure;

        public CanliDers(int id, string ad, string egitmen, int kontenjan, string baslangicSaati, int sure)
            : base(id, ad, egitmen, kontenjan)
        {
            BaslangicSaati = baslangicSaati;
            Sure = sure;
        }

        public override string ToString()
        {
            return Ad + " (Canlı)";  // Ders adını ve "Canlı" ibaresini döndür
        }
    }
}
