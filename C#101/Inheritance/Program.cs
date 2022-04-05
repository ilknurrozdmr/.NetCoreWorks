using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
            tohumluBitkiler.TohumlaCogalma();

            Console.WriteLine("----------------------------------");

            Kuslar marti = new Kuslar();
            marti.Ucmak();
            Console.ReadKey();
        }
    }
}
