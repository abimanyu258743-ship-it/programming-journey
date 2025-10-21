using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas1_ALIF_ALFIAN_X_PPLG_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nilaiAwal = 5;
            int nilaiPenambah = 1;
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{nilaiAwal} x {nilaiPenambah} = {nilaiAwal * nilaiPenambah}");
                nilaiPenambah++;
            }
        }
    }
}
