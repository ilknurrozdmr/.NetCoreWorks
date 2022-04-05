using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Hayvanlar : Canlilar
    {

        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon yapar.");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }

    public class Surungenler : Hayvanlar
    {
        public Surungenler()
        {
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }

        public void SurunerekHareketEtme()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }

    public class Kuslar : Hayvanlar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }

        public class Sürüngenler:Hayvanlar
        {
            public void SurunerekHareketEtmek()
            {
                Console.WriteLine("Sürüngenler sürünerek hareket eder");
            }

        }
        

        public Kuslar()
        {
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.Adaptasyon();
            base.UyaranlaraTepki();
        }


        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }
}
