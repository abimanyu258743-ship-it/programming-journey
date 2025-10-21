using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._8_Abimanyu_X_PPLG_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangiPilihan;

            do
            {
                // --- blok proses yang akan diulangi --- 
                Console.WriteLine("----------------------------------");
                Console.Write("Masukan nama anda: ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Halo, {nama} ! proses telah selesai.");
                //----------------------------------------
                // pertanyaan untuk mengulang 
                Console.Write("apakah anda ingin mengulang lagi? (ya/tidak): ");
                ulangiPilihan = Console.ReadLine().ToLower();

                Console.WriteLine();


            }
            while (ulangiPilihan == "ya");
            Console.WriteLine("Terima kasih. Program selesai.");
        }
    }
}
