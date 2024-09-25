using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_Lab1.Model
{
    public class WhiteNoiseGraphic : IGraphic
    {
        private double maxValue;
        private double step;
        private double amplitude;
        private Random random = new Random();    
        public WhiteNoiseGraphic(double maxValue, double step, double amplitude) 
        {
            this.maxValue = maxValue;   
            this.step = step;   
            this.amplitude = amplitude;
        }

        public string Name => "White noise";

        public Color ColorValue => Color.Teal;

        public List<CoordinatePoint> getPoints()
        {
            List<CoordinatePoint> points = new List<CoordinatePoint>();

            for (double x = 0; x < maxValue; x += step)
            {
                var point = new CoordinatePoint(x, getValue(x));
                points.Add(point);
            }

            return points;
        }

        public double getValue(double x, bool mod = false)
        {
            return amplitude * (2 * random.NextDouble() - 1);
        }
    }
}
