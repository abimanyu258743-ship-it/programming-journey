using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._6_Abimanyu_X_PPLG_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka;

            // Blok 'do' akan dieksekusi minimal satu kali.
            do
            {
                Console.Write("Masukan angka genap: ");
                // Mencoba membaca input dari pengguna
                if (!int.TryParse(Console.ReadLine(), out angka))
                {
                    Console.WriteLine("Input Tidak valid. Silahkan masukan angka.");
                    angka = 1;
                    continue;

                    
                }
                if (angka % 2 != 0)
                {
                    Console.WriteLine($"Angka {angka}adalah ganjil. Coba lagi.");
                }
            }
            while (angka % 2 != 0);
            Console.WriteLine($"Selamat! Anda memasukan angka genap: {angka}");
        }
    }
}
