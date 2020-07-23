using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_FP
{
    public class PersegiPanjang : BangunDatar
    {
        public double Panjang { get; set; }
        public double Lebar { get; set; }
        public override double Luas()
        {
            return Panjang * Lebar;
        }
        public override double Keliling()
        {
            return 2 * (Panjang + Lebar) ;
        }
    }
}
