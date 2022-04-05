using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // Günün tarihini getirir.
            Console.WriteLine(DateTime.Now.Date); 
            Console.WriteLine(DateTime.Now.Day); 
            Console.WriteLine(DateTime.Now.Month); 
            Console.WriteLine(DateTime.Now.Year); 
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek); // Haftanın gününü string getirir.
            Console.WriteLine(DateTime.Now.DayOfYear); // Senenin kaçıncı gününde olduğumu belirtir.

            Console.WriteLine(DateTime.Now.ToLongDateString()); // Saturday, April 24, 2021
            Console.WriteLine(DateTime.Now.ToShortDateString()); // 4/24/2021
            Console.WriteLine(DateTime.Now.ToLongTimeString()); // 5:19:29 PM
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // 5:19 PM

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); // int 24
            Console.WriteLine(DateTime.Now.ToString("ddd")); // (string) Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); // (string) Saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); // int 04
            Console.WriteLine(DateTime.Now.ToString("MMM")); // (string) Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // (string) April

            Console.WriteLine(DateTime.Now.ToString("yy")); //21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021

            Console.WriteLine("*** Math Kütüphanesi ***");

            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25)); //Mutlak değer (- geleni + yapar)
            Console.WriteLine(Math.Sin(60)); //Sinüs
            Console.WriteLine(Math.Cos(60)); //Cosinüs
            Console.WriteLine(Math.Tan(60)); //Tanjant

            Console.WriteLine(Math.Ceiling(22.3)); //Yukarı yuvarlar 23
            Console.WriteLine(Math.Round(22.3)); //Hangisine daha yakınsa ona yuvarlar 22
            Console.WriteLine(Math.Round(22.7)); //Hangisine daha yakınsa ona yuvarlar 23
            Console.WriteLine(Math.Floor(22.7)); //Aşağı yuvarlar 22

            Console.WriteLine(Math.Min(2, 6));
            Console.WriteLine(Math.Max(2, 6));

            Console.WriteLine(Math.Pow(3, 4)); //3^4 üs işlemi
            Console.WriteLine(Math.Sqrt(9)); //Karekök 
            Console.WriteLine(Math.Log(9)); //Logaritma
            Console.WriteLine(Math.Exp(3)); //e üzeri 3ü verir
            Console.WriteLine(Math.Log10(10)); //Logaritma 10 tabanı 
        }
    }
}
