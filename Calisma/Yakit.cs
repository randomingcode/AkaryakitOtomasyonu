using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma
{
    public interface Yakit
    {
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
        public void YakitAl(Musteri musteri);
    }
}
