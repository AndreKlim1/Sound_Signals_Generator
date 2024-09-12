﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DCP_Lab1.Model
{
    public class SawtoothGraphic: IGraphic
    {
        private double maxValue;
        private double step;
        private double amplitude;
        private double oscillationFrequency;
        private int samplingFrequency;
        private double startPhase;

        public SawtoothGraphic(double maxValue, 
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

        public string Name => "Sawtooth signal";

        public Color ColorValue => Color.Green;

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
            var pi = Math.PI;

            var firstMultiplier = - 2 * amplitude / pi;
            var cot = 1 / Math.Tan(pi * oscillationFrequency * x / samplingFrequency + startPhase);
            var arctan = Math.Atan(cot);

            return firstMultiplier * arctan;
        }
    }
}
