using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_Lab1.Model
{
    public struct CoordinatePoint
    {
        public double X;
        public double Y;

        public CoordinatePoint(double x, double y) 
        {
            this.X = x;
            this.Y = y;
        }
    }
}
