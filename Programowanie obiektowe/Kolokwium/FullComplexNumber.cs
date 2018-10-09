using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class FullComplexNumber : ComplexNumber
    {
        public FullComplexNumber(double x, double i) : base(x, i)
        {
        }
        public double absoluteValue()
        {
            return Math.Sqrt((i * i) + (x * x));
        }
        public double sin()
        {
            return i / absoluteValue();
        }
        public double cos()
        {
            return x / absoluteValue();
        }
        public double e_ip()
        {
            return cos() * sin();
        }
        public static FullComplexNumber operator +(FullComplexNumber p1, FullComplexNumber p2)
        {
            return new FullComplexNumber(p1.x + p2.x, p1.i + p2.i);
        }
        public static FullComplexNumber operator -(FullComplexNumber p1, FullComplexNumber p2)
        {
            return new FullComplexNumber(p1.x - p2.x, p1.i - p2.i);
        }
        public static FullComplexNumber operator *(FullComplexNumber p1, FullComplexNumber p2)
        {
            return new FullComplexNumber((p1.x * p2.x) - (p1.i * p2.i), (p1.x * p2.i) + (p1.i * p2.x));
        }
        public static FullComplexNumber operator /(FullComplexNumber p1, FullComplexNumber p2)
        {
            if ((p2.x * p2.x) + (p2.i * p2.i) > 0)
            {
                return new FullComplexNumber((p1.x * p2.x + p1.i * p2.i) / ((p2.x * p2.x) + (p2.i * p2.i)), (p1.i * p2.x - p1.x * p2.i) / ((p2.x * p2.x) + (p2.i * p2.i)));
            }
            else throw new Exception("Błąd! Nie można podzielić tych liczb zespolonych (c^2+d^2 muszą być większe od 0)");
        }
    }
    //Copyright © by:              Karol Bronowski
    //Code of the laboratory:      inf1A/1/IE/S
    //Number of album:             10502
}
