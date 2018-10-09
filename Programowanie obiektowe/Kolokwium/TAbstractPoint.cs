using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    abstract class TAbstractPoint
    {
        protected double x;
        public abstract void moveXY(double _x, double _y);
        public abstract bool reciprocal();
        public virtual void reverse()
        {
            x = -x;
        }
    }
    //Copyright © by:              Karol Bronowski
    //Code of the laboratory:      inf1A/1/IE/S
    //Number of album:             10502
}
