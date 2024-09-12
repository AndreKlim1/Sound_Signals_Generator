using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DCP_Lab1.Model;
using NAudio.Wave;

namespace DCP_Lab1
{
    public partial class Form1 : Form
    {
        private double step = 1;
        private int samplingFrequency = 0;

        List<IGraphic> graphics = new List<IGraphic>();
        List<Signal> signals = new List<Signal>();
        float[] singleSignal;
        //IGraphic currentGraphic = new SinGraphic(10, 1, 1, 1, 1, 0);

        public Form1()
        {
            InitializeComponent();
            setupView();

            drawGraphics();
        }

        private void setupView() 
        {
            Size = new Size(1235, 615);
            samplingFrequencyComboBox.SelectedIndex = 3;
            firstAmplitudeSlider.Value = 1;
            firstOscillationFrequencySlider.Value = 1;
            firstStartPhaseSlider.Value = 0;
            firstPeriodSlider.Value = 1;

            signals.Add(new Signal(firstSignal, 1, Int32.Parse(samplingFrequencyComboBox.SelectedItem.ToString()), 1, 0, 1, 0.12));
            signals.Add(new Signal(secondSignal, 1, Int32.Parse(samplingFrequencyComboBox.SelectedItem.ToString()), 1, 0, 1, 0.12));
            firstSignal.SelectedIndex = 0;
            secondSignal.SelectedIndex = 1;

            setupChartView();
        }

        private void setupChartView() 
        {
            chartView.Series.Clear();

            // X - axis
            //chartView.ChartAreas[0].AxisX.Minimum = 0;
            //chartView.ChartAreas[0].AxisX.Maximum = 8 * Math.PI;

            // Y - axis
            chartView.ChartAreas[0].AxisY.Minimum = -5;
            chartView.ChartAreas[0].AxisY.Maximum = 5;

        }

        private void samplingFrequencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            samplingFrequency = Int32.Parse(samplingFrequencyComboBox.SelectedItem.ToString());
            drawGraphics();
        }

        private void amplitudeSlider_Scroll(object sender, EventArgs e)
        {
            if (sender == firstAmplitudeSlider)
            {
                signals[0].Amplitude = (double)firstAmplitudeSlider.Value/4;
                A1.Text = "A " + signals[0].Amplitude.ToString();
            }
            else
            {
                signals[1].Amplitude = (double)secondAmplitudeSlider.Value/4;
                A2.Text = "A " + signals[1].Amplitude.ToString();
            }
            drawGraphics();
        }

        private void oscillationFrequencySlider_Scroll(object sender, EventArgs e)
        {
            
            if (sender == firstOscillationFrequencySlider)
            {
                signals[0].OscillationFrequence = firstOscillationFrequencySlider.Value;
                f1.Text = "f " + signals[0].OscillationFrequence.ToString();
            }
            else
            {
                signals[1].OscillationFrequence = secondOscillationFrequencySlider.Value;
                f2.Text = "f " + signals[1].OscillationFrequence.ToString();
            }
            drawGraphics();
        }

        private void startPhaseSlider_Scroll(object sender, EventArgs e)
        {
            if (sender == firstStartPhaseSlider)
            {
                signals[0].StartPhase= firstStartPhaseSlider.Value;
                f01.Text = "f0 " + signals[0].StartPhase.ToString();
            }
            else
            {
                signals[1].StartPhase = secondStartPhaseSlider.Value;
                f02.Text = "f0 " + signals[1].StartPhase.ToString();
            }
            drawGraphics();
        }

        private void periodSlider_Scroll(object sender, EventArgs e)
        {
            if (sender == firstPeriodSlider)
            {
                signals[0].Period = firstPeriodSlider.Value;
                T1.Text = "T " + signals[0].Period.ToString();
            }
            else
            {
                signals[1].Period = secondPeriodSlider.Value;
                T2.Text = "T " + signals[1].Period.ToString();
            }
            drawGraphics();
        }

        private void workCycleTextBox_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (sender == firstWorkCycleTextBox)
                {
                    signals[0].WorkCycle = Double.Parse(firstWorkCycleTextBox.Text);
                }
                else
                {
                    signals[1].WorkCycle = Double.Parse(secondWorkCycleTextBox.Text); 
                }
                drawGraphics();
            }
            catch { }
        }

        private void enableSumModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            drawGraphics();
        }

        private void drawGraphics() 
        {
            chartView.Series.Clear();

            graphics = getGraphicsListToDraw();
            
            if (sumCheckBox.Checked)
            {
                var sumGraphic = new SumGraphics(samplingFrequency, step, graphics);
                singleSignal = GraphicToSignal(sumGraphic.getPoints());
                drawGraphic(sumGraphic);
            }
            else if(modulationCheckBox.Checked)
            {
                var modGraphic = new ModulationGraphic(samplingFrequency, step, graphics);
                singleSignal = GraphicToSignal(modGraphic.getPoints());
                drawGraphic(modGraphic);
            }
            else
            {
                foreach (var graphic in graphics) { drawGraphic(graphic); }
            }
        }

        private List<IGraphic> getGraphicsListToDraw() 
        {
            List<IGraphic> graphics = new List<IGraphic>();

            foreach (var signal in signals)
            {
                if (signal.SignalType.SelectedIndex == 0)
                {
                    var sinGraphic = new SinGraphic(samplingFrequency, step,
                        signal.Amplitude,
                        signal.OscillationFrequence,
                        samplingFrequency,
                        signal.StartPhase);
                    graphics.Add(sinGraphic);
                }

                else if (signal.SignalType.SelectedIndex == 1)
                {
                    var rectGraphic = new RectangleImpulseGraphic(samplingFrequency, step,
                        signal.Amplitude,
                        signal.Period,
                        samplingFrequency,
                        signal.WorkCycle);
                    graphics.Add(rectGraphic);
                }

                else if (signal.SignalType.SelectedIndex == 2)
                {
                    var triangleGraphic = new TriangleGraphic(samplingFrequency, step,
                        signal.Amplitude,
                        signal.OscillationFrequence,
                        samplingFrequency,
                        signal.StartPhase);
                    graphics.Add(triangleGraphic);
                }

                else if (signal.SignalType.SelectedIndex == 3)
                {
                    var sawtoothGraphic = new SawtoothGraphic(samplingFrequency, step,
                       signal.Amplitude,
                       signal.OscillationFrequence,
                       samplingFrequency,
                       signal.StartPhase);
                    graphics.Add(sawtoothGraphic);
                }

                else if (signal.SignalType.SelectedIndex == 4)
                {
                    var whiteNoiseGraphic = new WhiteNoiseGraphic(samplingFrequency, step, signal.Amplitude);
                    graphics.Add(whiteNoiseGraphic);
                }
            }
            return graphics;
        }

        private void drawGraphic(IGraphic graphic) 
        {
            var points = graphic.getPoints();

            var series = getSeriesForGraphic(graphic);

            foreach (var point in points) 
            {
                series.Points.AddXY(point.X, point.Y);
            }
            chartView.Series.Add(series);
        }

        private Series getSeriesForGraphic(IGraphic graphic)
        {
            var series = new Series(graphic.Name);
            series.Color = graphic.ColorValue;
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            return series;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(!sumCheckBox.Checked && !modulationCheckBox.Checked)
            {
                for (int j = 0; j < graphics.Count; j++)
                {
                    var yList = GraphicToSignal(graphics[j].getPoints());
                    SaveAudio(yList, j);
                }
            }
            else
            {
                SaveAudio(singleSignal, 2);
            }
        }

        static float[] GraphicToSignal(List<CoordinatePoint> pointsList)
        {
            float[] yList = new float[pointsList.Count];
            for (int i = 0; i < pointsList.Count; i++)
            {
                yList[i] = (float)pointsList[i].Y;
            }
            yList = NormalizeSignal(yList);
            return yList;
        }

        static void SaveAudio(float[] signal, int numb=0)
        {
            int sampleRate = 44100;
            string fileName = $"signal{numb}.wav";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (var waveFileWriter = new WaveFileWriter(fileName, new WaveFormat(sampleRate, 1)))
            {
                waveFileWriter.WriteSamples(signal, 0, signal.Length);
            }
        }

        static float[] NormalizeSignal(float[] signal)
        {
            float maxAmplitude = 0;

            foreach (var sample in signal)
            {
                if (Math.Abs(sample) > maxAmplitude)
                    maxAmplitude = Math.Abs(sample);
            }

            if (maxAmplitude > 0)
            {
                for (int i = 0; i < signal.Length; i++)
                {
                    signal[i] /= maxAmplitude;
                }
            }

            return signal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.Clear();
        }

        private void Signal_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawGraphics();
        }

        private void sumCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sumCheckBox.Checked == true)
            {
                modulationCheckBox.Checked = false;
            }
            drawGraphics();
        }

        private void modulationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (modulationCheckBox.Checked == true)
            {
                sumCheckBox.Checked = false;
            }
            drawGraphics();
        }
    }
}
