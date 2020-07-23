using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_FP
{
    public class Persegi : BangunDatar
    {
        public double Sisi { get; set; }
        public override double Luas()
        {
            return Sisi * Sisi;
        }
        public override double Keliling()
        {
            return 4 * Sisi;
        }
    }
}
