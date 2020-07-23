using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_FP
{
    public class SegitigaSamaSisi : BangunDatar
    {
        public double Alas { get; set; }
        public double Tinggi { get; set; }

        public override double Luas()
        {
            return 0.5 * Alas * Tinggi;
        }
        public override double Keliling()
        {
            return 3 * Alas;
        }
    }
}
