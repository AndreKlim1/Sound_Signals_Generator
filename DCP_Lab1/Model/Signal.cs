using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCP_Lab1.Model
{
    public class Signal
    {
        public ComboBox SignalType;
        public double Amplitude;
        //public int SamplingFrequency;
        public double OscillationFrequence;
        public double StartPhase;
        public double Period;
        public double WorkCycle;

        public Signal(ComboBox signalType, double amplitude, int samplingFrequency, double oscillationFrequence, double startPhase, double period, double workCycle)
        {
            SignalType = signalType;
            Amplitude = amplitude;
            //SamplingFrequency = samplingFrequency;
            OscillationFrequence = oscillationFrequence;
            StartPhase = startPhase;
            Period = period;
            WorkCycle = workCycle;
        }
    }
}
