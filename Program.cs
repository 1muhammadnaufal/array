using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // membuat array sekaligus inisialisasi nilai
            string[] arrNama = { "BALMON", "NANA", "BEATRIK", "HANABI" };
            int[] arrNim = { 4879, 4811, 4899, 4800 };
            int[] arrNilai = { 40, 88, 99, 75 };

            Console.WriteLine("===============================");
            Console.WriteLine("No\tNama\tNIM\tNilai");
            Console.WriteLine("===============================");

            //menampilkan semua elemen array
            for (int i = 0; i < arrNama.Length; i++)
            {
                Console.WriteLine((i + 1) + ".\t" + arrNama[i] + "\t" + arrNim[i] + "\t  " + arrNilai[i]);
            }
            Console.ReadKey();
        }
    }
}