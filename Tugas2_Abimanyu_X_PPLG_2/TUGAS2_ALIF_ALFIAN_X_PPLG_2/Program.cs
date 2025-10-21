using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS2_ALIF_ALFIAN_X_PPLG_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int penambah = 1;
            Console.WriteLine("Nilai awal = " + total);

            while (total < 15)
            {
                Console.WriteLine("Nilai ditambah dengan " + penambah);
                total = total + penambah;
                penambah++;
                Console.WriteLine("Nilai saat ini = " + total + "\n");
            }

            Console.WriteLine("Total = " + total);
        }
    }
}
