using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_Lab1.Model
{
    public class TriangleGraphic: IGraphic
    {
        private double maxValue;
        private double step;
        private double amplitude;
        private double oscillationFrequency;
        private int samplingFrequency;
        private double startPhase;

        public TriangleGraphic(double maxValue,
            double step, 
            double amplitude,
            double oscillationFrequency,
            int samplingFrequency,
            double startPhase)
        {
            this.maxValue = maxValue;   
            this.step = step;
            this.amplitude = amplitude;
            this.oscillationFrequency = oscillationFrequency;
            this.samplingFrequency = samplingFrequency;
            this.startPhase = startPhase;

        }

        public string Name => "Triangle signal";

        public Color ColorValue => Color.Red;

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
            var firstMultiplier = 2 * amplitude / pi;
            double expr;
            if (mod)
            {
                expr = Math.Abs(((x + 3 * pi / 2) % (2 * pi)) - pi) - pi / 2;
            }
            else
            {
                expr = Math.Abs(((2 * pi * oscillationFrequency * x / samplingFrequency + startPhase + 3 * pi / 2) % (2 * pi)) - pi) - pi / 2;
            }

            return firstMultiplier * expr;
        }


    }
}
