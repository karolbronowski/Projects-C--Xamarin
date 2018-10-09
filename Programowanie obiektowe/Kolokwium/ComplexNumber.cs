using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class ComplexNumber : TAbstractPoint
    {
        protected double i;
        public ComplexNumber(double x, double i)
        {
            this.x = x;
            this.i = i;
        }
        public override void moveXY(double _x, double _y)
        {
            throw new NotImplementedException();
        }
        public override bool reciprocal()
        {
            throw new NotImplementedException();
        }
        public static ComplexNumber operator +(ComplexNumber p1, ComplexNumber p2)
        {
            return new ComplexNumber(p1.x + p2.x, p1.i + p2.i);
        }
        public static ComplexNumber operator -(ComplexNumber p1, ComplexNumber p2)
        {
            return new ComplexNumber(p1.x - p2.x, p1.i - p2.i);
        }
        public static ComplexNumber operator *(ComplexNumber p1, ComplexNumber p2)
        {
            return new ComplexNumber((p1.x * p2.x) - (p1.i * p2.i), (p1.x * p2.i) + (p1.i * p2.x));
        }
        public static ComplexNumber operator /(ComplexNumber p1, ComplexNumber p2)
        {
            if ((p2.x * p2.x) + (p2.i * p2.i) > 0)
            {
                return new ComplexNumber((p1.x * p2.x + p1.i * p2.i) / ((p2.x * p2.x) + (p2.i * p2.i)), (p1.i * p2.x - p1.x * p2.i) / ((p2.x * p2.x) + (p2.i * p2.i)));
            }
            else throw new Exception("Błąd! Nie można podzielić tych liczb zespolonych (c^2+d^2 muszą być większe od 0)");
        }
        public void print()
        {
            Console.WriteLine("Część rzeczywista = {0}", x);
            Console.WriteLine("Część wyimagowana = {0}", i);
        }
        public double getRel()
        {
            return x;
        }

        public double getIm()
        {
            return i;
        }
    }
    //Copyright © by:              Karol Bronowski
    //Code of the laboratory:      inf1A/1/IE/S
    //Number of album:             10502
}
