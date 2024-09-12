using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_Lab1.Model
{
    public class ModulationGraphic: IGraphic
    {
        private double maxValue { get; set; }
        private double step;
        private List<IGraphic> graphics;

        public ModulationGraphic(double maxValue, double step, List<IGraphic> graphics)
        {
            this.maxValue = maxValue;
            this.step = step;
            this.graphics = graphics;
        }
        public string Name
        {
            get
            {
                string name = "";
                foreach (var graphic in graphics)
                {
                    name += graphic.Name + " +\n ";
                }
                return name;
            }
        }

        public Color ColorValue => Color.RoyalBlue;

        public List<CoordinatePoint> getPoints()
        {
            List<CoordinatePoint> resultPoints = new List<CoordinatePoint>();

            for (double x = 0; x < maxValue; x += step)
            {
                var point = new CoordinatePoint(x, getValue(x));

                resultPoints.Add(point);
            }

            return resultPoints;
        }

        public double getValue(double x)
        {
            double mod = 1;
            foreach (var graphic in graphics)
            {
                mod *= graphic.getValue(x);
            }

            return mod;
        }
    }
}
