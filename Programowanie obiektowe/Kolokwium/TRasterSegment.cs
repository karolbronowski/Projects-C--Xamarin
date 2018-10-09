using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class TRasterSegment : TSegment
    {
        public List<TPoint> additionalPoints = new List<TPoint>();
        public TRasterSegment()
        {
            first = new TPoint(0, 0);
            last = new TPoint(0, 0);
        }
        public TRasterSegment(TPoint _first, TPoint _last)
        {
            first = _first;
            last = _last;
        }
        public void generatePoints()
        {
            additionalPoints.Clear();
            double baseX = Math.Abs(first.x - last.x) / 11;
            double baseY = Math.Abs(first.y - last.y) / 11;
            TPoint temp;
            for (int i = 1; i <= 10; i++)
            {
                temp = new TPoint(baseX * i, baseY * i);
                additionalPoints.Add(temp);
            }
        }
        public /*new*/ void print()
        {
            for (int i = 0; i < additionalPoints.Count; i++)
            {
                Console.WriteLine("Punkt {0}:", (i + 1));
                Console.WriteLine("x = " + additionalPoints[i].x);
                Console.WriteLine("y = " + additionalPoints[i].y);
                Console.WriteLine();
            }
        }
    }
    //Copyright © by:              Karol Bronowski
    //Code of the laboratory:      inf1A/1/IE/S
    //Number of album:             10502
}
