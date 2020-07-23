using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_FP
{
    public class BelahKetupat : BangunDatar
    {
        public double Sisi { get; set; }
        public double d1 { get; set; }
        public double d2 { get; set; }
        public override double Luas()
        {
            return 0.5 * d1 * d2;
        }
        public override double Keliling()
        {
            return 4 * Sisi;
        }
    }
}
