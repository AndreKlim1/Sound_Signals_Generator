using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DCP_Lab1.Model
{
    public class RectangleImpulseGraphic: IGraphic
    {
        private double maxValue;
        private double step;
        private double amplitude;
        private double period;
        private int samplingFrequency;
        private double workCycle;

        public RectangleImpulseGraphic(double maxValue, 
            double step, 
            double amplitude,
            double period,
            int samplingFrequency,
            double workCycle)
        {
            this.maxValue = maxValue;
            this.step = step;
            this.amplitude = amplitude;
            this.period = period;
            this.samplingFrequency = samplingFrequency;
            this.workCycle = workCycle;

        }

        public string Name => "Rect signal";

        public Color ColorValue => Color.Black;

        public List<CoordinatePoint> getPoints()
        {
            List<CoordinatePoint> points = new List<CoordinatePoint>();

            var pi = Math.PI;

            for (double x = 0; x < maxValue; x += step)
            {
                var point = new CoordinatePoint(x, getValue(x));

                points.Add(point);
            }

            return points;
        }

        public double getValue(double x)
        {
            var expresion = ((x / samplingFrequency) % period) / period;

            if (expresion < workCycle)
            {
                return amplitude;
            }
            else
            {
                return -amplitude;
            }
        }
    }
}
