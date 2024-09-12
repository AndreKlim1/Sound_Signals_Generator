using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_Lab1.Model
{
    public class SumGraphics : IGraphic
    {
        private double maxValue { get; set; }
        private double step;
        private List<IGraphic> graphics;

        public SumGraphics(double maxValue, double step, List<IGraphic> graphics) 
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

        public Color ColorValue => Color.Brown;

        public List<CoordinatePoint> getPoints()
        {
            List<CoordinatePoint> resultPoints = new List<CoordinatePoint>();

            //for (double x = 0; x < 8 * Math.PI; x += Math.PI / 20.0)
            for (double x = 0; x < maxValue; x += step)
            {
                var point = new CoordinatePoint(x, getValue(x));

                resultPoints.Add(point);
            }

            return resultPoints;
        }

        public double getValue(double x) 
        {
            double sum = 0;
            foreach (var graphic in graphics) 
            {
                sum += graphic.getValue(x);
            }

            return sum;
        }

    }
}
