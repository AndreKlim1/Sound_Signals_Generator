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
        private double oscillationFrequency;
        private int samplingFrequency;
        private double startPhase;
        private double workCycle;

        public RectangleImpulseGraphic(double maxValue, 
            double step, 
            double amplitude,
            double oscillationFrequency,
            int samplingFrequency,
            double startPhase,
            double workCycle)
        {
            this.maxValue = maxValue;
            this.step = step;
            this.amplitude = amplitude;
            this.oscillationFrequency = oscillationFrequency;
            this.samplingFrequency = samplingFrequency;
            this.startPhase = startPhase;
            this.workCycle = workCycle;

        }

        public string Name => "Rect signal";

        public Color ColorValue => Color.Black;

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
            var pi = Math.PI;
            double expr;
            if (mod)
            {
                expr = (x) % (2 * pi) / (2 * pi);
            }
            else
            {
                expr = (2 * pi * oscillationFrequency * (x / samplingFrequency) + startPhase) % (2 * pi) / (2 * pi);
            }
            

            if (expr < workCycle)
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
