using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_FP
{
    class Program
    {
        static List<BangunDatar> bangundatar = new List<BangunDatar>();
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Perhitungan Bangun Datar";
            bool loop = true;
            while (loop)
            {
                DisplayMenu();

                Console.Write("\n Nomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahBangun();
                        break;

                    case 2:
                        HapusBangun();
                        break;

                    case 3:
                        TampilBangun();
                        break;
                    
                    case 4:
                        loop = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(" Maaf, menu yang anda pilih tidak tersedia");
                        break;
                }
                Console.Write("\n [Tekan enter untuk kembali ke menu]");
                Console.ReadKey();
            }
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("\n Pilih menu Aplikasi");
            Console.WriteLine("\n 1. Tambah Bangun Datar");
            Console.WriteLine(" 2. Hapus Bangun Datar");
            Console.WriteLine(" 3. Tampilkan Bangun Datar");
            Console.WriteLine(" 4. Keluar");
        }

        static void TambahBangun()
        {
            Console.Clear();
            Console.WriteLine("\n Tambah Bangun Datar");
            Console.WriteLine("\n Bentuk Bangun Datar");
            Console.WriteLine(" 1. Persegi");
            Console.WriteLine(" 2. Persegi Panjang");
            Console.WriteLine(" 3. Trapesium Sama Kaki");
            Console.WriteLine(" 4. Segitiga Sama Sisi");
            Console.WriteLine(" 5. Belah Ketupat");
            Console.WriteLine(" 6. Layang - layang");
            Console.WriteLine(" 7. Lingkaran");
            Console.Write("\n Nomor Menu [1..7]: ");
            int pil = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch(pil)
            {
                case 1:
                    Console.Write(" Persegi\n");
                    Persegi persegi = new Persegi();
                    Console.Write(" Masukan Sisi : ");
                    persegi.Sisi = double.Parse(Console.ReadLine());
                    bangundatar.Add(persegi);
                    break;
                case 2:
                    Console.Write(" Persegi Panjang\n");
                    PersegiPanjang persegipanjang = new PersegiPanjang();
                    Console.Write(" Masukan Panjang : ");
                    persegipanjang.Panjang = double.Parse(Console.ReadLine());
                    Console.Write(" Masukan Lebar : ");
                    persegipanjang.Lebar = double.Parse(Console.ReadLine());
                    bangundatar.Add(persegipanjang);
                    break;
                case 3:
                    Console.Write(" Trapesium\n");
                    TrapesiumSamaKaki trapesium = new TrapesiumSamaKaki();
                    Console.Write(" Masukan Sisi Atas : ");
                    trapesium.SisiAtas = double.Parse(Console.ReadLine());
                    Console.Write(" Masukan Sisi Bawah : ");
                    trapesium.SisiBawah = double.Parse(Console.ReadLine());
                    Console.Write(" Masukan Sisi Miring : ");
                    trapesium.SisiMiring = double.Parse(Console.ReadLine());
                    Console.Write(" Masukan Tinggi : ");
                    trapesium.Tinggi = double.Parse(Console.ReadLine());
                    bangundatar.Add(trapesium);
                    break;
                case 4:
                    Console.Write(" Segitiga\n");
                    SegitigaSamaSisi segitiga = new SegitigaSamaSisi();
                    Console.Write(" Masukan Alas : ");
                    segitiga.Alas = double.Parse(Console.ReadLine());
                    Console.Write(" Masukan Tinggi : ");
                    segitiga.Tinggi = double.Parse(Console.ReadLine());
                    bangundatar.Add(segitiga);
                    break;
                case 5:
                    Console.Write(" Belah Ketupat\n");
                    BelahKetupat belahKetupat = new BelahKetupat();
                    Console.Write(" Masukan Sisi : ");
                    belahKetupat.Sisi = double.Parse(Console.ReadLine());
                    Console.Write(" Masukan Panjang Diagonal 1 : ");
                    belahKetupat.d1 = double.Parse(Console.ReadLine());
                    Console.Write(" Masukan panjang Diagonal 2 : ");
                    belahKetupat.d2 = double.Parse(Console.ReadLine());
                    bangundatar.Add(belahKetupat);
                    break;
                case 6:
                    Console.Write(" Layang - layang\n");
                    LayangLayang layang = new LayangLayang();
                    Console.Write(" Masukan Sisi kiri atas : ");
                    layang.Sisi1 = double.Parse(Console.ReadLine());
                    Console.Write(" Masukan Sisi kanan atas : ");
                    layang.Sisi2 = double.Parse(Console.ReadLine());
                    Console.Write(" Masukan Sisi kiri bawah : ");
                    layang.Sisi3 = double.Parse(Console.ReadLine());
                    Console.Write(" Masukan Sisi kanan bawah : ");
                    layang.Sisi4 = double.Parse(Console.ReadLine());
                    Console.Write(" Masukan Diagonal 1 : ");
                    layang.d1 = double.Parse(Console.ReadLine());
                    Console.Write(" Masukan Diagonal 2 : ");
                    layang.d2 = double.Parse(Console.ReadLine());
                    bangundatar.Add(layang);
                    break;
                case 7:
                    Console.Write(" Lingkaran\n");
                    Lingkaran lingkaran = new Lingkaran();
                    Console.Write(" Masukan jari - jari : ");
                    lingkaran.Jarijari = double.Parse(Console.ReadLine());
                    bangundatar.Add(lingkaran);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(" Maaf, menu yang Anda pilih tidak tersedia");
                    break;
            }
            Console.Write("\n [Tekan ENTER untuk kembali ke menu]");
            Console.ReadKey();
        }

        static void TampilBangun()
        {
            int noUrut = 0;
            double total = 0;
            string jenis;
            Console.WriteLine("\n Data Bangun Datar\n");
            foreach (BangunDatar bangun in bangundatar)
            {
                if (bangun is Persegi)
                {
                    jenis = "Persgi";
                }
                else if (bangun is PersegiPanjang)
                {
                    jenis = "Persgi Panjang";
                }
                else if (bangun is TrapesiumSamaKaki)
                {
                    jenis = "Trapesium Sama Kaki";
                }
                else if (bangun is SegitigaSamaSisi)
                {
                    jenis = "Segitiga Sama Sisi";
                }
                else if (bangun is BelahKetupat)
                {
                    jenis = "Belah Ketupat";
                }
                else if (bangun is LayangLayang)
                {
                    jenis = "Layang - Layang";
                }
                else if (bangun is Lingkaran)
                {
                    jenis = "Lingkaran";
                }
                else
                {
                    jenis = "Tidak ada";
                }
                noUrut++;
                total += bangun.Luas();
                Console.WriteLine(" {0}. Nama Bangun Datar: {1}, Luas Bangun Datar: {2}, Keliling Bangun Datar: {3}", noUrut, jenis, bangun.Luas(), bangun.Keliling());
            }
            if (noUrut < 1)
            {
                Console.WriteLine(" Data Bangun datar Kosong");
            }
            else
            {
                Console.WriteLine("\n Jumlah Luas Bangun Datar : {0}", total);
            }
        }

        static void HapusBangun()
        {
            TampilBangun();
            int no;
            Console.WriteLine(" Hapus Data Bangun Ruang");
            Console.Write(" Nomor Bangun : ");
            no = Convert.ToInt32(Console.ReadLine());
            if (no > bangundatar.Count || no < 0)
            {
                Console.WriteLine("\n Nomor bangun datar tidak ditemukan");
            }
            else
            {
                bangundatar.RemoveAt(no - 1);
                Console.WriteLine("\n Data bangun datar berhasil di hapus");
            }
        }

    }
}
