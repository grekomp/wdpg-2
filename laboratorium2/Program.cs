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
            Triangle<double, double> triangle = new Triangle<double, double>(a:3.0, alpha:0.5, beta:0.5);
            TrojkatProstokatny<double, double> pros = new TrojkatProstokatny<double, double>(a:3, b:4);

            Console.WriteLine(pros.a);
            Console.WriteLine(pros.b);
            Console.WriteLine(pros.c);
            Console.WriteLine(pros.alpha);
            Console.WriteLine(pros.beta);
            Console.WriteLine(pros.gamma);
            Console.WriteLine(pros.getField());
            Console.WriteLine(pros.getPerimeter());

            Console.ReadKey();
        }
    }
}
