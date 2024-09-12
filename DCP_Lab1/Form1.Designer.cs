namespace DCP_Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.samplingFrequencyComboBox = new System.Windows.Forms.ComboBox();
            this.firstOscillationFrequencySlider = new System.Windows.Forms.TrackBar();
            this.f1 = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.Label();
            this.firstAmplitudeSlider = new System.Windows.Forms.TrackBar();
            this.f01 = new System.Windows.Forms.Label();
            this.firstStartPhaseSlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.Label();
            this.firstPeriodSlider = new System.Windows.Forms.TrackBar();
            this.firstWorkCycleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.f_label = new System.Windows.Forms.Label();
            this.firstSignal = new System.Windows.Forms.ComboBox();
            this.secondSignal = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.secondAmplitudeSlider = new System.Windows.Forms.TrackBar();
            this.secondOscillationFrequencySlider = new System.Windows.Forms.TrackBar();
            this.f2 = new System.Windows.Forms.Label();
            this.A2 = new System.Windows.Forms.Label();
            this.f02 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.secondStartPhaseSlider = new System.Windows.Forms.TrackBar();
            this.T2 = new System.Windows.Forms.Label();
            this.secondPeriodSlider = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.secondWorkCycleTextBox = new System.Windows.Forms.TextBox();
            this.sumCheckBox = new System.Windows.Forms.CheckBox();
            this.modulationCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstOscillationFrequencySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstAmplitudeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstStartPhaseSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPeriodSlider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondAmplitudeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondOscillationFrequencySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondStartPhaseSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPeriodSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // chartView
            // 
            chartArea6.Name = "ChartArea1";
            this.chartView.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartView.Legends.Add(legend6);
            this.chartView.Location = new System.Drawing.Point(616, 52);
            this.chartView.Margin = new System.Windows.Forms.Padding(2);
            this.chartView.Name = "chartView";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartView.Series.Add(series6);
            this.chartView.Size = new System.Drawing.Size(576, 440);
            this.chartView.TabIndex = 0;
            this.chartView.Text = "chart1";
            // 
            // samplingFrequencyComboBox
            // 
            this.samplingFrequencyComboBox.FormattingEnabled = true;
            this.samplingFrequencyComboBox.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048"});
            this.samplingFrequencyComboBox.Location = new System.Drawing.Point(44, 30);
            this.samplingFrequencyComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.samplingFrequencyComboBox.Name = "samplingFrequencyComboBox";
            this.samplingFrequencyComboBox.Size = new System.Drawing.Size(62, 21);
            this.samplingFrequencyComboBox.TabIndex = 1;
            this.samplingFrequencyComboBox.Text = "N";
            this.samplingFrequencyComboBox.SelectedIndexChanged += new System.EventHandler(this.samplingFrequencyComboBox_SelectedIndexChanged);
            // 
            // firstOscillationFrequencySlider
            // 
            this.firstOscillationFrequencySlider.Location = new System.Drawing.Point(2, 104);
            this.firstOscillationFrequencySlider.Margin = new System.Windows.Forms.Padding(2);
            this.firstOscillationFrequencySlider.Maximum = 100;
            this.firstOscillationFrequencySlider.Minimum = 1;
            this.firstOscillationFrequencySlider.Name = "firstOscillationFrequencySlider";
            this.firstOscillationFrequencySlider.Size = new System.Drawing.Size(248, 45);
            this.firstOscillationFrequencySlider.TabIndex = 2;
            this.firstOscillationFrequencySlider.Value = 1;
            this.firstOscillationFrequencySlider.Scroll += new System.EventHandler(this.oscillationFrequencySlider_Scroll);
            // 
            // f1
            // 
            this.f1.AutoSize = true;
            this.f1.Location = new System.Drawing.Point(10, 89);
            this.f1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(19, 13);
            this.f1.TabIndex = 3;
            this.f1.Text = "f 1";
            // 
            // A1
            // 
            this.A1.AutoSize = true;
            this.A1.Location = new System.Drawing.Point(10, 14);
            this.A1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(38, 13);
            this.A1.TabIndex = 4;
            this.A1.Text = "A 0,25";
            // 
            // firstAmplitudeSlider
            // 
            this.firstAmplitudeSlider.Location = new System.Drawing.Point(2, 35);
            this.firstAmplitudeSlider.Margin = new System.Windows.Forms.Padding(2);
            this.firstAmplitudeSlider.Maximum = 20;
            this.firstAmplitudeSlider.Minimum = 1;
            this.firstAmplitudeSlider.Name = "firstAmplitudeSlider";
            this.firstAmplitudeSlider.Size = new System.Drawing.Size(246, 45);
            this.firstAmplitudeSlider.TabIndex = 5;
            this.firstAmplitudeSlider.Value = 1;
            this.firstAmplitudeSlider.Scroll += new System.EventHandler(this.amplitudeSlider_Scroll);
            // 
            // f01
            // 
            this.f01.AutoSize = true;
            this.f01.Location = new System.Drawing.Point(10, 152);
            this.f01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f01.Name = "f01";
            this.f01.Size = new System.Drawing.Size(25, 13);
            this.f01.TabIndex = 6;
            this.f01.Text = "f0 0";
            // 
            // firstStartPhaseSlider
            // 
            this.firstStartPhaseSlider.Location = new System.Drawing.Point(4, 173);
            this.firstStartPhaseSlider.Margin = new System.Windows.Forms.Padding(2);
            this.firstStartPhaseSlider.Name = "firstStartPhaseSlider";
            this.firstStartPhaseSlider.Size = new System.Drawing.Size(244, 45);
            this.firstStartPhaseSlider.TabIndex = 7;
            this.firstStartPhaseSlider.Scroll += new System.EventHandler(this.startPhaseSlider_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "N: ";
            // 
            // T1
            // 
            this.T1.AutoSize = true;
            this.T1.Location = new System.Drawing.Point(10, 216);
            this.T1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(23, 13);
            this.T1.TabIndex = 13;
            this.T1.Text = "T 1";
            // 
            // firstPeriodSlider
            // 
            this.firstPeriodSlider.Location = new System.Drawing.Point(4, 231);
            this.firstPeriodSlider.Margin = new System.Windows.Forms.Padding(2);
            this.firstPeriodSlider.Minimum = 1;
            this.firstPeriodSlider.Name = "firstPeriodSlider";
            this.firstPeriodSlider.Size = new System.Drawing.Size(244, 45);
            this.firstPeriodSlider.TabIndex = 14;
            this.firstPeriodSlider.Value = 1;
            this.firstPeriodSlider.Scroll += new System.EventHandler(this.periodSlider_Scroll);
            // 
            // firstWorkCycleTextBox
            // 
            this.firstWorkCycleTextBox.Location = new System.Drawing.Point(36, 286);
            this.firstWorkCycleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstWorkCycleTextBox.Name = "firstWorkCycleTextBox";
            this.firstWorkCycleTextBox.Size = new System.Drawing.Size(52, 20);
            this.firstWorkCycleTextBox.TabIndex = 15;
            this.firstWorkCycleTextBox.Text = "0,12";
            this.firstWorkCycleTextBox.TextChanged += new System.EventHandler(this.workCycleTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "dc:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 511);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // f_label
            // 
            this.f_label.AutoSize = true;
            this.f_label.Location = new System.Drawing.Point(22, 89);
            this.f_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f_label.Name = "f_label";
            this.f_label.Size = new System.Drawing.Size(0, 13);
            this.f_label.TabIndex = 21;
            // 
            // firstSignal
            // 
            this.firstSignal.AllowDrop = true;
            this.firstSignal.FormattingEnabled = true;
            this.firstSignal.Items.AddRange(new object[] {
            "Sinusoid",
            "RectangleImpulse",
            "Triangle",
            "Sawtooth",
            "WhiteNoise"});
            this.firstSignal.Location = new System.Drawing.Point(49, 111);
            this.firstSignal.Name = "firstSignal";
            this.firstSignal.Size = new System.Drawing.Size(200, 21);
            this.firstSignal.TabIndex = 22;
            this.firstSignal.SelectedIndexChanged += new System.EventHandler(this.Signal_SelectedIndexChanged);
            // 
            // secondSignal
            // 
            this.secondSignal.AllowDrop = true;
            this.secondSignal.FormattingEnabled = true;
            this.secondSignal.Items.AddRange(new object[] {
            "Sinusoid",
            "RectangleImpulse",
            "Triangle",
            "Sawtooth",
            "WhiteNoise"});
            this.secondSignal.Location = new System.Drawing.Point(345, 111);
            this.secondSignal.Name = "secondSignal";
            this.secondSignal.Size = new System.Drawing.Size(200, 21);
            this.secondSignal.TabIndex = 25;
            this.secondSignal.SelectedIndexChanged += new System.EventHandler(this.Signal_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.firstAmplitudeSlider);
            this.panel1.Controls.Add(this.firstOscillationFrequencySlider);
            this.panel1.Controls.Add(this.f1);
            this.panel1.Controls.Add(this.A1);
            this.panel1.Controls.Add(this.f01);
            this.panel1.Controls.Add(this.f_label);
            this.panel1.Controls.Add(this.firstStartPhaseSlider);
            this.panel1.Controls.Add(this.T1);
            this.panel1.Controls.Add(this.firstPeriodSlider);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.firstWorkCycleTextBox);
            this.panel1.Location = new System.Drawing.Point(24, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 325);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.secondAmplitudeSlider);
            this.panel2.Controls.Add(this.secondOscillationFrequencySlider);
            this.panel2.Controls.Add(this.f2);
            this.panel2.Controls.Add(this.A2);
            this.panel2.Controls.Add(this.f02);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.secondStartPhaseSlider);
            this.panel2.Controls.Add(this.T2);
            this.panel2.Controls.Add(this.secondPeriodSlider);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.secondWorkCycleTextBox);
            this.panel2.Location = new System.Drawing.Point(320, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 325);
            this.panel2.TabIndex = 29;
            // 
            // secondAmplitudeSlider
            // 
            this.secondAmplitudeSlider.Location = new System.Drawing.Point(2, 35);
            this.secondAmplitudeSlider.Margin = new System.Windows.Forms.Padding(2);
            this.secondAmplitudeSlider.Maximum = 20;
            this.secondAmplitudeSlider.Minimum = 1;
            this.secondAmplitudeSlider.Name = "secondAmplitudeSlider";
            this.secondAmplitudeSlider.Size = new System.Drawing.Size(246, 45);
            this.secondAmplitudeSlider.TabIndex = 5;
            this.secondAmplitudeSlider.Value = 1;
            this.secondAmplitudeSlider.Scroll += new System.EventHandler(this.amplitudeSlider_Scroll);
            // 
            // secondOscillationFrequencySlider
            // 
            this.secondOscillationFrequencySlider.Location = new System.Drawing.Point(2, 104);
            this.secondOscillationFrequencySlider.Margin = new System.Windows.Forms.Padding(2);
            this.secondOscillationFrequencySlider.Maximum = 100;
            this.secondOscillationFrequencySlider.Minimum = 1;
            this.secondOscillationFrequencySlider.Name = "secondOscillationFrequencySlider";
            this.secondOscillationFrequencySlider.Size = new System.Drawing.Size(248, 45);
            this.secondOscillationFrequencySlider.TabIndex = 2;
            this.secondOscillationFrequencySlider.Value = 1;
            this.secondOscillationFrequencySlider.Scroll += new System.EventHandler(this.oscillationFrequencySlider_Scroll);
            // 
            // f2
            // 
            this.f2.AutoSize = true;
            this.f2.Location = new System.Drawing.Point(10, 89);
            this.f2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(19, 13);
            this.f2.TabIndex = 3;
            this.f2.Text = "f 1";
            // 
            // A2
            // 
            this.A2.AutoSize = true;
            this.A2.Location = new System.Drawing.Point(13, 14);
            this.A2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(38, 13);
            this.A2.TabIndex = 4;
            this.A2.Text = "A 0,25";
            // 
            // f02
            // 
            this.f02.AutoSize = true;
            this.f02.Location = new System.Drawing.Point(10, 152);
            this.f02.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f02.Name = "f02";
            this.f02.Size = new System.Drawing.Size(25, 13);
            this.f02.TabIndex = 6;
            this.f02.Text = "f0 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 21;
            // 
            // secondStartPhaseSlider
            // 
            this.secondStartPhaseSlider.Location = new System.Drawing.Point(4, 173);
            this.secondStartPhaseSlider.Margin = new System.Windows.Forms.Padding(2);
            this.secondStartPhaseSlider.Name = "secondStartPhaseSlider";
            this.secondStartPhaseSlider.Size = new System.Drawing.Size(244, 45);
            this.secondStartPhaseSlider.TabIndex = 7;
            this.secondStartPhaseSlider.Scroll += new System.EventHandler(this.startPhaseSlider_Scroll);
            // 
            // T2
            // 
            this.T2.AutoSize = true;
            this.T2.Location = new System.Drawing.Point(10, 216);
            this.T2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(23, 13);
            this.T2.TabIndex = 13;
            this.T2.Text = "T 1";
            // 
            // secondPeriodSlider
            // 
            this.secondPeriodSlider.Location = new System.Drawing.Point(4, 231);
            this.secondPeriodSlider.Margin = new System.Windows.Forms.Padding(2);
            this.secondPeriodSlider.Minimum = 1;
            this.secondPeriodSlider.Name = "secondPeriodSlider";
            this.secondPeriodSlider.Size = new System.Drawing.Size(244, 45);
            this.secondPeriodSlider.TabIndex = 14;
            this.secondPeriodSlider.Value = 1;
            this.secondPeriodSlider.Scroll += new System.EventHandler(this.periodSlider_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 289);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "dc:";
            // 
            // secondWorkCycleTextBox
            // 
            this.secondWorkCycleTextBox.Location = new System.Drawing.Point(36, 286);
            this.secondWorkCycleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.secondWorkCycleTextBox.Name = "secondWorkCycleTextBox";
            this.secondWorkCycleTextBox.Size = new System.Drawing.Size(52, 20);
            this.secondWorkCycleTextBox.TabIndex = 15;
            this.secondWorkCycleTextBox.Text = "0,12";
            this.secondWorkCycleTextBox.TextChanged += new System.EventHandler(this.workCycleTextBox_TextChanged);
            // 
            // sumCheckBox
            // 
            this.sumCheckBox.AutoSize = true;
            this.sumCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumCheckBox.Location = new System.Drawing.Point(201, 34);
            this.sumCheckBox.Name = "sumCheckBox";
            this.sumCheckBox.Size = new System.Drawing.Size(105, 24);
            this.sumCheckBox.TabIndex = 30;
            this.sumCheckBox.Text = "Sum mode";
            this.sumCheckBox.UseVisualStyleBackColor = true;
            this.sumCheckBox.CheckedChanged += new System.EventHandler(this.sumCheckBox_CheckedChanged);
            // 
            // modulationCheckBox
            // 
            this.modulationCheckBox.AutoSize = true;
            this.modulationCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modulationCheckBox.Location = new System.Drawing.Point(371, 34);
            this.modulationCheckBox.Name = "modulationCheckBox";
            this.modulationCheckBox.Size = new System.Drawing.Size(150, 24);
            this.modulationCheckBox.TabIndex = 31;
            this.modulationCheckBox.Text = "Modulation mode";
            this.modulationCheckBox.UseVisualStyleBackColor = true;
            this.modulationCheckBox.CheckedChanged += new System.EventHandler(this.modulationCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1217, 576);
            this.Controls.Add(this.modulationCheckBox);
            this.Controls.Add(this.sumCheckBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.secondSignal);
            this.Controls.Add(this.firstSignal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.samplingFrequencyComboBox);
            this.Controls.Add(this.chartView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstOscillationFrequencySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstAmplitudeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstStartPhaseSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPeriodSlider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondAmplitudeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondOscillationFrequencySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondStartPhaseSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPeriodSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartView;
        private System.Windows.Forms.ComboBox samplingFrequencyComboBox;
        private System.Windows.Forms.TrackBar firstOscillationFrequencySlider;
        private System.Windows.Forms.Label f1;
        private System.Windows.Forms.Label A1;
        private System.Windows.Forms.TrackBar firstAmplitudeSlider;
        private System.Windows.Forms.Label f01;
        private System.Windows.Forms.TrackBar firstStartPhaseSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label T1;
        private System.Windows.Forms.TrackBar firstPeriodSlider;
        private System.Windows.Forms.TextBox firstWorkCycleTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label f_label;
        private System.Windows.Forms.ComboBox firstSignal;
        private System.Windows.Forms.ComboBox secondSignal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar secondAmplitudeSlider;
        private System.Windows.Forms.TrackBar secondOscillationFrequencySlider;
        private System.Windows.Forms.Label f2;
        private System.Windows.Forms.Label A2;
        private System.Windows.Forms.Label f02;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar secondStartPhaseSlider;
        private System.Windows.Forms.Label T2;
        private System.Windows.Forms.TrackBar secondPeriodSlider;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox secondWorkCycleTextBox;
        private System.Windows.Forms.CheckBox sumCheckBox;
        private System.Windows.Forms.CheckBox modulationCheckBox;
    }
}

