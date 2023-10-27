using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma
{
    public delegate void Yakıt();
    internal class Musteri
    {
        public string PlakaNo { get; set; }

        public Yakit YakıtTur { get; set; }

        public double istenilenMiktar { get; set; }

        public event Yakıt YakitAlindi;



        public void YakıtAl()
        {

            Console.WriteLine( " Yakıt dolduruluyor.");
            YakitAlindi();

        }

        
    }
}
