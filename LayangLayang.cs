using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_FP
{
    public class LayangLayang : BangunDatar
    {
        public double Sisi1 { get; set; }
        public double Sisi2 { get; set; }
        public double Sisi3 { get; set; }
        public double Sisi4 { get; set; }
        public double d1 { get; set; }
        public double d2 { get; set; }
        public override double Luas()
        {
            return 0.5 * d1 * d2;
        }
        public override double Keliling()
        {
            return Sisi1 + Sisi2 + Sisi3 + Sisi4;
        }
    }
}
