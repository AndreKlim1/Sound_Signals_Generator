using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_Lab1.Model
{
    public interface IGraphic
    {
        string Name { get; }
        Color ColorValue { get; }
        List<CoordinatePoint> getPoints();
        double getValue(double x, bool mod = false);
    }
}
