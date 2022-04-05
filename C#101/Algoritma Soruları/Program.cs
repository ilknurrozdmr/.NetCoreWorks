using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
             * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
             * Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
             
            Console.Write("Bir pozitif sayı adeti giriniz: ");           
            int n = Convert.ToInt32(Console.ReadLine());
            if(n > 0)
            {
                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Bir sayı giriniz: ");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    array[i] = sayi;                   
                }
                for (int j = 0; j < n; j++)
                {
                    if(array[j] % 2 == 0)
                    {
                        Console.WriteLine(array[j]);
                    }
                }
            }
            
            2 - Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin(n, m).
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            
            Console.Write("Bir pozitif sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bir pozitif sayı giriniz: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Bir sayı giriniz: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (m == array[i] || m % array[i] == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
            3 - Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
                Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
                Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            
            Console.Write("Bir pozitif sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Bir kelime giriniz: ");
                array[i] = Convert.ToString(Console.ReadLine());
            }
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******************************");
            Array.Reverse(array);
            foreach(var i in array)
            {
                Console.WriteLine(i);
            }
            
            4 - Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
                Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                      + "abcçdefgğhiıjklmnoöprsştuüvyz";
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Kelime Sayısı: " + kelimeler.Length);

            int sayac = 0;
            for (int i=0; i<cumle.Length; i++)
            {
                if (liste.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Toplam {0} tane harf vardır.", sayac);
            Console.ReadKey();*/
        }
    }
}
