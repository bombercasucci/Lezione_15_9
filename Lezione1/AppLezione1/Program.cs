using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLezione1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 55555;
            Console.WriteLine($"il valore di a è {a}");
            short s = (short)a;
            Console.WriteLine($"il valore di a è {s}");
            Console.ReadLine();
        }
    }
}
