using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma
{
    public class Elektrik : Yakit
    {
        public Elektrik()
        {
            Fiyat = 10; 
        }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
        public override string ToString()
        {
            return "Elektik";
        }

        public void YakitAl(Musteri musteri)
        {
            Console.WriteLine("Ödenecek Tutar: " + (musteri.istenilenMiktar * Fiyat));
        }
    }
}
