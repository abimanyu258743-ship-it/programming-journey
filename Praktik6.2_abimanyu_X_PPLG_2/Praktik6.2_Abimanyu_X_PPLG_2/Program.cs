using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._2_Abimanyu_X_PPLG_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variabel untuk menyimpan hasil penjumblahan 
            int total = 0;

            Console.WriteLine("Menghitung jumblah angka dari 1 samapai 5:");

            // Perulangan for dari 1 hingga 5
            for (int i = 1; i<= 5; i++)
            {
                // Tambahkan nilai i0 saat ini ke variabel total 
                total = total + i; // Bisa juga sebagai : total += i;

                Console.WriteLine("Menambahkan " + i + ", total sementara = " + total);
                {
                    Console.WriteLine("\nHasil akhir penjumlahan adalah: " + total);
                }
            }
        }
    }
}
