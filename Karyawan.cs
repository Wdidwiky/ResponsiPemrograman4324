using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4324
{
    public class Karyawan
    {
        public string NIK { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }


        public void Gaji()
        {

            Console.Write(NIK);
            Console.Write(Nama);
            Console.Write(GajiBulanan);
            Console.WriteLine();
        }

        public void NaikGaji()
        {
            int naik = GajiBulanan + (GajiBulanan * 10 / 100);
            Console.Write(NIK);
            Console.Write(Nama);
            Console.Write(naik);
            Console.WriteLine();
        }
    }
}
