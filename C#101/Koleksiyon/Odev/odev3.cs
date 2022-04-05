using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevuc
{
    class Program
    {
		/*Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.*/
        static void Main(string[] args)
        {
            ArrayList dizi = new ArrayList();
            Console.Write("Lütfen bir cümle giriniz: ");
            string metin = Console.ReadLine();
            string sesli = "aeıioöuüAEIİOÖUÜ";
            int sayac = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (sesli.Contains(metin[i]))
                {
                    sayac++;
                    dizi.Add(metin[i]);
                }

            }

            Console.WriteLine("Cümle içerisinde toplam " + sayac + " tane sesli harf vardır.");
            Console.WriteLine("Bunlar; ");
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
