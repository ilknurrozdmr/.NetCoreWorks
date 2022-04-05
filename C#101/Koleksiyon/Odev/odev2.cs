using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odeviki
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
             * her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
             * (Array sınıfını kullanarak yazınız.)*/

            int[] numberList = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz: ");
                numberList[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(numberList);

            int averageMin = (numberList[0] + numberList[1] + numberList[2]) / 3;
            int averageMax = (numberList[17] + numberList[18] + numberList[19]) / 3;
            int averageSum = averageMax + averageMin;

            Console.WriteLine("En küçük üç sayının ortalaması: " + averageMin);
            Console.WriteLine("En büyük üç sayının ortalaması: " + averageMax);
            Console.WriteLine("Ortalamalar toplamı: " + averageSum);
        }
    }
}
