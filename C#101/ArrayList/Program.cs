using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste = new ArrayList();
             liste.Add("Ayşe");
             liste.Add(2);
             liste.Add(true);
             liste.Add('A');

            //İçerisindeki verilere erişme
             Console.WriteLine(liste[1]);

             foreach (var list in liste)
             Console.WriteLine(list);

            //AddRange
            Console.WriteLine("*** AddRange ***");
            string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
            List<int> sayilar = new List<int>() { 1,8,3,7,9,92,5 };
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var newlist in liste)
                Console.WriteLine(newlist);

            //Sort
            Console.WriteLine("*** Sort ***");
            liste.Sort();
            foreach (var newlist in liste)
                Console.WriteLine(newlist);

            //BinarySearch
            Console.WriteLine("*** BinarySearch ***");
            Console.WriteLine(liste.BinarySearch(4));

            //Reverse
            Console.WriteLine("*** Reverse ***");
            liste.Reverse();
            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine("*** Clear ***");
            liste.Clear();

            foreach (var item in liste)
                Console.WriteLine(item);
        }
    }
}
