using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class TPoint : TAbstractPoint
    {
        public double x;
        public double y;
        public TPoint()
        {
            x = 0;
            y = 0;
        }
        public TPoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override void moveXY(double _x, double _y)
        {
            x += _x;
            y += _y;
        }
        public void print()
        {
            Console.WriteLine("x = {0}", x);
            Console.WriteLine("y = {0}", y);
            Console.WriteLine();
        }
        public override bool reciprocal()
        {
            if (x == 0) return false;

            x = 1 / x;
            return true;
        }
        public override void reverse()
        {
            x = -x;
        }
    }
    //Copyright © by:              Karol Bronowski
    //Code of the laboratory:      inf1A/1/IE/S
    //Number of album:             10502
}
