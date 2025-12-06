using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nadin_Latihan_3
{
    public class Class3
    {
        
        public static void Main(string[] args)
        {

        string nama, npm, inputNama, inputNpm;
        Console.Write("Masukkan Nama: ");
        nama = Console.ReadLine();

        Console.Write("Masukkan NPM (4 karakter): ");
        npm = Console.ReadLine();

        if (npm.Length != 4)
        {
            Console.WriteLine("NPM harus 4 karakter! Program berhenti.");
            return; 
        }

        Console.Clear(); 

       
        Console.Write("Masukkan kembali Nama: ");
        inputNama = Console.ReadLine();

        Console.Write("Masukkan kembali NPM: ");
        inputNpm = Console.ReadLine();

        
        if (inputNama == nama && inputNpm == npm)
        {
            Console.WriteLine("Input data berhasil!");
        }
        else if (inputNama != nama && inputNpm != npm)
        {
            Console.WriteLine("Nama dan NPM salah!");
        }
        else if (inputNama != nama)
        {
            Console.WriteLine("Nama anda salah!");
        }
        else if (inputNpm != npm)
        {
            Console.WriteLine("NPM anda salah!");
        }

        Console.WriteLine("\n=== Data yang Disimpan ===");
        Console.WriteLine("Nama: " + nama);
        Console.WriteLine("NPM: " + npm);
        }
    }
}

    