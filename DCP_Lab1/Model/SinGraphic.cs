using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DCP_Lab1.Model
{
    public class SinGraphic : IGraphic
    {
        private double maxValue;
        private double step;
        private double amplitude;
        private double oscillationFrequency;
        private int samplingFrequency;
        private double startPhase;

        public SinGraphic(double maxValue, 
            double step, 
            double amplitude,
            double oscillationFrequency, 
            int samplingFrequency, 
            double startPhase)
        {
            this.maxValue= maxValue;
            this.step= step;
            this.amplitude = amplitude;
            this.oscillationFrequency = oscillationFrequency;
            this.samplingFrequency = samplingFrequency;
            this.startPhase = startPhase;
        }

        public string Name => "Sin signal";
        public Color ColorValue => Color.Blue;

        public List<CoordinatePoint> getPoints()
        {
            List<CoordinatePoint> points = new List<CoordinatePoint>();

            //for (double x = 0; x < 8 * Math.PI; x += Math.PI / 20.0) 
            for (double x = 0; x < maxValue; x += step)
            {
                var point = new CoordinatePoint(x, getValue(x));
               
                points.Add(point);
            }

            return points;
        }

        public double getValue(double x) 
        {
            var pi = Math.PI;
           
            return amplitude * Math.Sin(2 * pi * oscillationFrequency * x / samplingFrequency + startPhase);
        } 
    }
}
