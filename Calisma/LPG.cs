using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma
{
    public class LPG : Yakit
    {
        public LPG()
        {
            Miktar = 1000;
            Fiyat = 15;
        }
        public double Fiyat { get; set; }
        public double Miktar { get; set; }

        public override string ToString()
        {
            return "LPG";
        }

        public void YakitAl(Musteri musteri)
        {

            Miktar = Miktar - musteri.istenilenMiktar;
            Console.WriteLine("kalan LPG miktarı: " + Miktar);
            Console.WriteLine("Ödenecek Tutar: " + (musteri.istenilenMiktar * Fiyat));
        }
    }
}
