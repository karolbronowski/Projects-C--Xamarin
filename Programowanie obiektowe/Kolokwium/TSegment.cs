using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class TSegment
    {
        public TPoint first;
        public TPoint last;
        public TSegment()
        {
            first = new TPoint(0, 0);
            last = new TPoint(0, 0);
        }
        public TSegment(TPoint _first, TPoint _last)
        {
            first = _first;
            last = _last;
        }
        public double length()
        {
            return Math.Sqrt(Math.Pow((last.x - first.x), 2) + Math.Pow((last.y - first.y), 2));
        }
        public void print()
        {
            Console.WriteLine("Pierwszy punkt odcinka: ");
            first.print();
            Console.WriteLine("Ostatni punkt odcinka: ");
            last.print();
        }
    }
    //Copyright © by:              Karol Bronowski
    //Code of the laboratory:      inf1A/1/IE/S
    //Number of album:             10502
}
