using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_Lab1.Model
{
    public class ModulationFrGraphic : IGraphic
    {
        private double maxValue { get; set; }
        private double step;
        private List<IGraphic> graphics;
        private double startPhase;
        private int samplingFrequency;
        private double oscillationFrequency;
        private double fi;

        public ModulationFrGraphic(double maxValue, double step, List<IGraphic> graphics, double startPhase, int samplingFrequency, double oscillationFrequency)
        {
            this.maxValue = maxValue;
            this.step = step;
            this.graphics = graphics;
            this.startPhase = startPhase;
            this.samplingFrequency = samplingFrequency;
            this.oscillationFrequency = oscillationFrequency;
        }
        public string Name
        {
            get
            {
                string name = "";
                foreach (var graphic in graphics)
                {
                    name += graphic.Name + " %\n ";
                }
                return name;
            }
        }

        public Color ColorValue => Color.Brown;

        public List<CoordinatePoint> getPoints()
        {
            List<CoordinatePoint> resultPoints = new List<CoordinatePoint>();
            fi = startPhase;

            for (double x = 0; x < maxValue; x += step)
            {
                var point = new CoordinatePoint(x, getValue(x));
                resultPoints.Add(point);
            }

            return resultPoints;
        }

        public double getValue(double x, bool mod = false)
        {
            var modY = graphics[0].getValue(fi, true);
            var lfoY = graphics[1].getValue(x);
            fi += 1 / (double)samplingFrequency * 2 * Math.PI * oscillationFrequency * (1 + lfoY);
            return modY;
        }
    }
}
