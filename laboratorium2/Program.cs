using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorium2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle<double, double> triangle = new Triangle<double, double>(b:4.0, c:5.0, gamma: 0.645771823);


            Console.WriteLine(triangle.calculateMissingSides());
            Console.WriteLine(triangle.a);
            Console.WriteLine(triangle.b);
            Console.WriteLine(triangle.c);
            Console.WriteLine(triangle.gamma);

            Console.ReadKey();
        }
    }
}
