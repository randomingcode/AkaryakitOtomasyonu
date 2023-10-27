using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma
{
    internal class Benzin : Yakit
    {

        public Benzin()
        {
            Miktar = 300;
            Fiyat = 35;
        }
        public double Miktar {  get; set; }
        public double Fiyat { get; set; }

        public override string ToString()
        {
            return "benzin";
        }
    }
}
