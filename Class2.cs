using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nadin_Latihan_2
{
    public class Class2
    {
        public static void Main(string[] args)
        {
            double gaji;
            double jamKerja;
            double gajiPerJam;
            double gajiLembur = 0; 

            Console.Write("Masukkan jumlah jam kerja: ");
            jamKerja = double.Parse(Console.ReadLine());
            
            Console.Write("Masukkan gaji per jam: ");
            gajiPerJam = double.Parse(Console.ReadLine());
            
            if (jamKerja <= 40)
            {
                gaji = jamKerja * gajiPerJam;
            }

            else 
            {
                gaji= 40* gajiPerJam;
                gajiLembur = (jamKerja - 40) * (1.5 * gajiPerJam);
            }

            double totalGaji = gaji + gajiLembur;

            Console.WriteLine($"Gaji biasa: Rp {gaji:N2}");
            if (gajiLembur > 0)
            {
                Console.WriteLine($"Gaji lembur: Rp {gajiLembur:N2}");
            }
            Console.WriteLine($"Total gaji anda: Rp {totalGaji:N2}");
        }
    }
}

