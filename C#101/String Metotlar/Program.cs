using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharp";

            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper - ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat-Birleştirme yapar
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));

            //CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); // Eşitse 0, degisken>degisken2 ise 1, degisken2>degisken ise -1 döner.

            //Compare
            Console.WriteLine(String.Compare(degisken, degisken2, true)); //Ignore case büyük küçük harf duyarsız. 0 döner.
            Console.WriteLine(String.Compare(degisken, degisken2, false)); //Ignore case büyük küçük harf duyarlı. 1 döner.

            //Contains - Karşılaştırır
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf - Bulduğu ilk indeksi döner.
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("İlknur"));

            //Insert - 0.indeksten sonra ekleme yapar.
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));

            //LastIndexOf - Son indeksi getirir.
            Console.WriteLine(degisken.LastIndexOf("i"));

            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30)); //Sola boşluk ekler.
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '_') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10)); // 10. indeksten sonrasını siler.
            Console.WriteLine(degisken.Remove(5, 3));
            Console.WriteLine(degisken.Remove(0, 1));

            //Replace - Değiştirir
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]); //Boşluğa göre parçalayıp diziye attım.

            //Substring - İstenen karakterleri getiriyor.
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));
        }
    }
}
