using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevbir
{
    class Program
    {
        /*Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
         
     Negatif ve numeric olmayan girişleri engelleyin.
     Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
     Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/

        static bool asalKontrol(int deger)
        {
            if (deger <= 1)
                return false;

            for (int i = 2; i < deger; i++)
                if (deger % i == 0)
                    return false;

            return true;
        }


        static void Main(string[] args)
        {
            ArrayList arrayListAsal = new ArrayList();
            ArrayList arrayListNotAsal = new ArrayList();
            int okunan = 0;
            int asalToplam = 0;
            int asalOlmayanToplam = 0;

            for (int i = 0; i < 20; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write((i + 1) + ".Sayıyı Giriniz:");
                        okunan = Convert.ToInt32(Console.ReadLine());
                        if (okunan < 0)
                        {
                            Console.WriteLine("Lütfen Negatif olmayan Sayi Giriniz!");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Karakter Girmeyiniz!");
                    }
                }


                if (asalKontrol(okunan))
                {
                    arrayListAsal.Add(okunan);
                    asalToplam += okunan;
                }
                else
                {
                    arrayListNotAsal.Add(okunan);
                    asalOlmayanToplam += okunan;
                }
            }

            arrayListAsal.Sort();
            arrayListAsal.Reverse();

            arrayListNotAsal.Sort();
            arrayListNotAsal.Reverse();

            Console.WriteLine("\nAsal List");
            for (int i = 0; i < arrayListAsal.Count; i++)
            {
                Console.Write(arrayListAsal[i] + " ");
            }
            Console.WriteLine("\n\nAsal Olmayan List");
            for (int i = 0; i < arrayListNotAsal.Count; i++)
            {
                Console.Write(arrayListNotAsal[i] + " ");
            }

            try
            {
                Console.WriteLine("\n\nAsal liste ort:" + asalToplam / arrayListAsal.Count);

            }
            catch (DivideByZeroException e)
            {
                Console.Write("\n\nAsal Liste Boş");
            }

            
            Console.ReadKey();
        }
    }
}
