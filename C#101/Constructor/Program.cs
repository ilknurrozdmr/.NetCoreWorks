using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Çalışan 1*****");
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "İlknur";
            calisan1.Soyad = "Özdemir";
            calisan1.No = 111111;
            calisan1.Departman = "Software developer";
            calisan1.CalisanBilgileri();

            Console.WriteLine("\n*****Çalışan 2*****");
            Calisan calisan2 = new Calisan("Zeynep", "Tunç", 12533652, "Pazarlama");
            calisan2.CalisanBilgileri();

            Console.WriteLine("\n*****Çalışan 3*****");
            Calisan calisan3 = new Calisan("Yusuf", "Can");
            calisan3.CalisanBilgileri();

            Console.ReadKey();
        }
        
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad,string soyad, int no,string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan() { }

        public void CalisanBilgileri()
        {
            Console.WriteLine($"Çalışanın Adı: {Ad}");
            Console.WriteLine($"Çalışanın Soyadı: {Soyad}");
            Console.WriteLine($"Çalışanın Numarası: {No}");
            Console.WriteLine($"Çalışanın Departmanı: {Departman}");
            
        } 
        
    } 
}
