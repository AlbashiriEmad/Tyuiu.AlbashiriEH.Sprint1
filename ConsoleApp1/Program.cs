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
            int a = 3;

            int b = --a + 2;

            int c = b;

            a = a + b + c;

            c = b++ + a;

            b = b - a;

            int x = a + b + c;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
