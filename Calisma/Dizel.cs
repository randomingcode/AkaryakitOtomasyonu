using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma
{
    public class Dizel : Yakit
    {
        public Dizel()
        {
            Miktar = 300;
            Fiyat = 30;
        }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }

        public override string ToString()
        {
            return "Dizel";
        }

        public void YakitAl(Musteri musteri)
        {
            Miktar =Miktar - musteri.istenilenMiktar;
            Console.WriteLine(" kalan Dizel miktarı: " + Miktar);
            Console.WriteLine("Ödenecek Tutar: " + (musteri.istenilenMiktar * Fiyat));
        }
    }
}
