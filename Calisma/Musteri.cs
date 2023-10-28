using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma
{
    public delegate void Yakıt();
    public class Musteri
    {
        public string PlakaNo { get; set; }

        public Yakit YakıtTur { get; set; }

        public double istenilenMiktar { get; set; }

        public event Yakıt YakitAlindi;



        public void YakıtAl()
        {
            ProgressBar();
            YakitAlindi();

        }

        void ProgressBar()
        {
            Console.Write("Yakıt dolduruluyor.... ");
            using (var progress = new ProgressBar())
            {
                for (int i = 0; i <= 100; i++)
                {
                    progress.Report((double)i / 100);
                    Thread.Sleep(20);
                }
            }
            Console.WriteLine("Tamamlandı.");
        }


    }
}
