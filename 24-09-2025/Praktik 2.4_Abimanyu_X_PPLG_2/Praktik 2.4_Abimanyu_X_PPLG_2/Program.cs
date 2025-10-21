using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_2._4_Abimanyu_X_PPLG_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // deklarasi variabel
            string nama_siswa = "Abimanyu Octa A.S ";
            string jk = "Laki-laki ";
            int umur = 15;
            int nilai = 100;
            char grade = 'A';
            double tb = 173;
            bool lulus = true;

            // menampilkan variabel
            Console.WriteLine("Nama Siswa   : " + nama_siswa);
            Console.WriteLine("Jenis Kelamin: " + jk);  
            Console.WriteLine("Usia         : " + umur + "Tahun");
            Console.WriteLine("Nilai        : " + nilai);
            Console.WriteLine("Grade Nilai  : " + grade);
            Console.WriteLine("Tinggi Badan : " + tb + "cm");
            Console.WriteLine("lulus        : " + lulus);
            Console.ReadKey();
        }
    }
}
