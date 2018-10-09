using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            TPoint a = new TPoint(1, 2);
            TPoint b = new TPoint(3, 2);
            a.reciprocal();
            a.reverse();
            a.print();

            TSegment po = new TSegment(a, b);
            po.print();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            TRasterSegment ab = new TRasterSegment(a, b);
            ab.generatePoints();
            ab.print();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\nDługość odcinka między punktami wynosi -> " + ab.length());
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("ComplexNumber: ");
            ComplexNumber cd = new ComplexNumber(-1, 2);
            cd.print();
            Console.WriteLine("\n--------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("FullComplexNumer: ");
            FullComplexNumber ef = new FullComplexNumber(-2, 3);
            ef.print();
             
            Console.ReadKey();
        }
    }
    //Copyright © by:              Karol Bronowski
    //Code of the laboratory:      inf1A/1/IE/S
    //Number of album:             10502
}
