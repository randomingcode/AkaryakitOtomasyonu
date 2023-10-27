using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma
{
    internal class Dizel : Yakit
    {
        public Dizel()
        {
            Miktar = 300;
            Fiyat = 30;
        }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
    }
}
