using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{
    //kelas 1
    /// <summary>
    /// main class
    /// </summary>
    class PersegiPanjang
    {
        static void Main(string[] args)
        {
            //deklarasi variabel
            /// summary
            /// deklarasi variabel
            /// </summary>
            double luas, panjang, lebar;

            //input
            /// summary
            /// input
            /// </summary>
            Console.Write("Masukkan panjang: ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukkan lebar : ");
            lebar = Convert.ToDouble(Console.ReadLine());

            //proses
            /// summary
            /// operasi perkalian
            /// </summary>
            /// <param name = "panjang"> masukkan angka panjang untuk menghitung luas </param>
            /// <param name = "lebar"> masukkan angka lebar untuk menghitung luas </param>
            luas = panjang * lebar;

            //output
            /// <returns>hasil dari perkalian panjang dan lebar</returns>
            Console.Write("luas persegi panjang= {0}", luas);
            Console.ReadKey();
        }
    }
}