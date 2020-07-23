using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_FP
{
    public class Lingkaran : BangunDatar
    {
        public double Jarijari { get; set; }
        public override double Luas()
        {
            return 3.14 * Jarijari * Jarijari;
        }
        public override double Keliling()
        {
            return 3.14 * (2 * Jarijari);
        }
    }
}
