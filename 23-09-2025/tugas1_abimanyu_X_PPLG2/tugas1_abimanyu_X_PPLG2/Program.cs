using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas1_abimanyu_X_PPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Biodata Saya ");
            Console.Write("Nama : ");
            string nama = Console.ReadLine();
            Console.Write("Nama Panggilan : ");
            string namapanggilan = Console.ReadLine();
            Console.Write("Jenis Kelamin : ");
            string jk = Console.ReadLine();
            Console.Write("Agama : ");
            string agama = Console.ReadLine();
            Console.Write("Usia : ");
            string usia = Console.ReadLine();
            Console.Write("Sekolah Di : ");
            string sekolah = Console.ReadLine();
            Console.Write("Jurusan : ");
            string jur = Console.ReadLine();
            Console.Write("Alamat :  ");
            string alamat = Console.ReadLine();
            Console.Write("Hobi : ");
            string hobi = Console.ReadLine();
            Console.Write("Cita-cita : ");
            string cc = Console.ReadLine();
            Console.WriteLine("***********************");
            Console.WriteLine( "    Biodata Saya    "  );
            Console.WriteLine("***********************");
            Console.WriteLine("Nama             : " + nama);
            Console.WriteLine("Nama Panggilan   : " + namapanggilan);
            Console.WriteLine("Jenis Kelamin    : " + jk);
            Console.WriteLine("Agama            : " + agama);
            Console.WriteLine("Usia             : " + usia);    
            Console.WriteLine("Sekolah Di       : " + sekolah);
            Console.WriteLine("Jurusan          : " + jur);
            Console.WriteLine("Alamat           : " + alamat);  
            Console.WriteLine("Hobi             : " + hobi);
            Console.WriteLine("Cita-cita        : " + cc);
        }
    }
}
