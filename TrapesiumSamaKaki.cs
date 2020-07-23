using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_FP
{
    public class TrapesiumSamaKaki : BangunDatar
    {
        public double SisiAtas { get; set; }
        public double SisiBawah { get; set; }
        public double SisiMiring { get; set; }
        public double Tinggi { get; set; }
        public override double Luas()
        {
            return 0.5 * (SisiAtas + SisiBawah) * Tinggi;
        }
        public override double Keliling()
        {
            return SisiAtas + SisiBawah + (2 * SisiMiring);
        }
    }
}
