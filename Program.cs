namespace ResponsiPemrograman4324
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan satu = new Karyawan();
            Karyawan dua = new Karyawan();

            Console.WriteLine("No   Nik/Nama            Gaji Bulanan");
            Console.WriteLine("---------------------------------------");

            satu.NIK = "1. 21114324";
            satu.Nama = " Dzaky     ";
            satu.GajiBulanan = Convert.ToInt32("    1000000");

            dua.NIK = "2. 21114253";
            dua.Nama = " Mahmud     ";
            dua.GajiBulanan = Convert.ToInt32("   2500000");

            satu.Gaji();
            dua.Gaji();

            Console.WriteLine();
            Console.WriteLine("Asyiiiiik naik gaji 10%!!");
            Console.WriteLine();
            Console.WriteLine("No   Nik/Nama            Gaji Bulanan");
            Console.WriteLine("---------------------------------------");

            satu.NaikGaji();
            dua.NaikGaji();

        }
    }
}