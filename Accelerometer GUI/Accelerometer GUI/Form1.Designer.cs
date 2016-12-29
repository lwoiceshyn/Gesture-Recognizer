namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.butPortState = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.eventTimer = new System.Windows.Forms.Timer(this.components);
            this.labelXAccel = new System.Windows.Forms.Label();
            this.labelYAccel = new System.Windows.Forms.Label();
            this.labelZAccel = new System.Windows.Forms.Label();
            this.textXAccel = new System.Windows.Forms.TextBox();
            this.textYAccel = new System.Windows.Forms.TextBox();
            this.textZAccel = new System.Windows.Forms.TextBox();
            this.myDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gestureBox = new System.Windows.Forms.TextBox();
            this.helpBox = new System.Windows.Forms.TextBox();
            this.helpLabel = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAccelMagnitude = new System.Windows.Forms.Label();
            this.textMagnitude = new System.Windows.Forms.TextBox();
            this.labelMagnitudeWarning = new System.Windows.Forms.Label();
            this.magnitudeBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myDataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPortName
            // 
            this.cmbPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(17, 16);
            this.cmbPortName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(160, 24);
            this.cmbPortName.TabIndex = 0;
            // 
            // butPortState
            // 
            this.butPortState.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPortState.ForeColor = System.Drawing.Color.Linen;
            this.butPortState.Location = new System.Drawing.Point(187, 16);
            this.butPortState.Margin = new System.Windows.Forms.Padding(4);
            this.butPortState.Name = "butPortState";
            this.butPortState.Size = new System.Drawing.Size(125, 28);
            this.butPortState.TabIndex = 1;
            this.butPortState.Text = "Connect";
            this.butPortState.UseVisualStyleBackColor = true;
            this.butPortState.Click += new System.EventHandler(this.butPortState_Click);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 128000;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // eventTimer
            // 
            this.eventTimer.Interval = 1;
            this.eventTimer.Tick += new System.EventHandler(this.eventTimer_Tick);
            // 
            // labelXAccel
            // 
            this.labelXAccel.AutoSize = true;
            this.labelXAccel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXAccel.Location = new System.Drawing.Point(16, 76);
            this.labelXAccel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelXAccel.Name = "labelXAccel";
            this.labelXAccel.Size = new System.Drawing.Size(168, 24);
            this.labelXAccel.TabIndex = 2;
            this.labelXAccel.Text = "X Acceleration:";
            // 
            // labelYAccel
            // 
            this.labelYAccel.AutoSize = true;
            this.labelYAccel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYAccel.Location = new System.Drawing.Point(491, 76);
            this.labelYAccel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYAccel.Name = "labelYAccel";
            this.labelYAccel.Size = new System.Drawing.Size(167, 24);
            this.labelYAccel.TabIndex = 3;
            this.labelYAccel.Text = "Y Acceleration:";
            // 
            // labelZAccel
            // 
            this.labelZAccel.AutoSize = true;
            this.labelZAccel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZAccel.Location = new System.Drawing.Point(998, 75);
            this.labelZAccel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZAccel.Name = "labelZAccel";
            this.labelZAccel.Size = new System.Drawing.Size(166, 24);
            this.labelZAccel.TabIndex = 4;
            this.labelZAccel.Text = "Z Acceleration:";
            // 
            // textXAccel
            // 
            this.textXAccel.Location = new System.Drawing.Point(205, 75);
            this.textXAccel.Margin = new System.Windows.Forms.Padding(4);
            this.textXAccel.Name = "textXAccel";
            this.textXAccel.ReadOnly = true;
            this.textXAccel.Size = new System.Drawing.Size(132, 22);
            this.textXAccel.TabIndex = 5;
            // 
            // textYAccel
            // 
            this.textYAccel.Location = new System.Drawing.Point(681, 75);
            this.textYAccel.Margin = new System.Windows.Forms.Padding(4);
            this.textYAccel.Name = "textYAccel";
            this.textYAccel.ReadOnly = true;
            this.textYAccel.Size = new System.Drawing.Size(132, 22);
            this.textYAccel.TabIndex = 6;
            // 
            // textZAccel
            // 
            this.textZAccel.Location = new System.Drawing.Point(1179, 75);
            this.textZAccel.Margin = new System.Windows.Forms.Padding(4);
            this.textZAccel.Name = "textZAccel";
            this.textZAccel.ReadOnly = true;
            this.textZAccel.Size = new System.Drawing.Size(132, 22);
            this.textZAccel.TabIndex = 7;
            // 
            // myDataChart
            // 
            this.myDataChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX.Title = "Time";
            chartArea2.AxisY.Title = "Acceleration";
            chartArea2.Name = "ChartArea1";
            this.myDataChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.myDataChart.Legends.Add(legend2);
            this.myDataChart.Location = new System.Drawing.Point(16, 202);
            this.myDataChart.Margin = new System.Windows.Forms.Padding(4);
            this.myDataChart.Name = "myDataChart";
            series4.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.White;
            series4.Name = "X Acceleration";
            series4.YValuesPerPoint = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Y Acceleration";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Z Acceleration";
            this.myDataChart.Series.Add(series4);
            this.myDataChart.Series.Add(series5);
            this.myDataChart.Series.Add(series6);
            this.myDataChart.Size = new System.Drawing.Size(839, 432);
            this.myDataChart.TabIndex = 8;
            this.myDataChart.Text = "chart1";
            // 
            // gestureBox
            // 
            this.gestureBox.Font = new System.Drawing.Font("Georgia", 30F);
            this.gestureBox.Location = new System.Drawing.Point(883, 270);
            this.gestureBox.Margin = new System.Windows.Forms.Padding(4);
            this.gestureBox.Name = "gestureBox";
            this.gestureBox.ReadOnly = true;
            this.gestureBox.Size = new System.Drawing.Size(464, 64);
            this.gestureBox.TabIndex = 15;
            // 
            // helpBox
            // 
            this.helpBox.Location = new System.Drawing.Point(978, 641);
            this.helpBox.Margin = new System.Windows.Forms.Padding(4);
            this.helpBox.Name = "helpBox";
            this.helpBox.ReadOnly = true;
            this.helpBox.Size = new System.Drawing.Size(29, 22);
            this.helpBox.TabIndex = 17;
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel.Location = new System.Drawing.Point(880, 643);
            this.helpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(90, 17);
            this.helpLabel.TabIndex = 18;
            this.helpLabel.Text = "gestureState:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(531, 1);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(447, 38);
            this.labelTitle.TabIndex = 20;
            this.labelTitle.Text = "Leo\'s Gesture Recognizer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(877, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Gesture:";
            // 
            // labelAccelMagnitude
            // 
            this.labelAccelMagnitude.AutoSize = true;
            this.labelAccelMagnitude.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccelMagnitude.Location = new System.Drawing.Point(16, 142);
            this.labelAccelMagnitude.Name = "labelAccelMagnitude";
            this.labelAccelMagnitude.Size = new System.Drawing.Size(431, 24);
            this.labelAccelMagnitude.TabIndex = 28;
            this.labelAccelMagnitude.Text = "Magnitude of Total Acceleration(# of g\'s)";
            // 
            // textMagnitude
            // 
            this.textMagnitude.Location = new System.Drawing.Point(467, 142);
            this.textMagnitude.Name = "textMagnitude";
            this.textMagnitude.ReadOnly = true;
            this.textMagnitude.Size = new System.Drawing.Size(126, 22);
            this.textMagnitude.TabIndex = 29;
            // 
            // labelMagnitudeWarning
            // 
            this.labelMagnitudeWarning.AutoSize = true;
            this.labelMagnitudeWarning.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.labelMagnitudeWarning.Location = new System.Drawing.Point(880, 367);
            this.labelMagnitudeWarning.Name = "labelMagnitudeWarning";
            this.labelMagnitudeWarning.Size = new System.Drawing.Size(138, 31);
            this.labelMagnitudeWarning.TabIndex = 30;
            this.labelMagnitudeWarning.Text = "Warning";
            // 
            // magnitudeBox
            // 
            this.magnitudeBox.Font = new System.Drawing.Font("Georgia", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magnitudeBox.Location = new System.Drawing.Point(886, 459);
            this.magnitudeBox.Name = "magnitudeBox";
            this.magnitudeBox.ReadOnly = true;
            this.magnitudeBox.Size = new System.Drawing.Size(461, 64);
            this.magnitudeBox.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1370, 673);
            this.Controls.Add(this.magnitudeBox);
            this.Controls.Add(this.labelMagnitudeWarning);
            this.Controls.Add(this.textMagnitude);
            this.Controls.Add(this.labelAccelMagnitude);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.helpBox);
            this.Controls.Add(this.gestureBox);
            this.Controls.Add(this.myDataChart);
            this.Controls.Add(this.textZAccel);
            this.Controls.Add(this.textYAccel);
            this.Controls.Add(this.textXAccel);
            this.Controls.Add(this.labelZAccel);
            this.Controls.Add(this.labelYAccel);
            this.Controls.Add(this.labelXAccel);
            this.Controls.Add(this.butPortState);
            this.Controls.Add(this.cmbPortName);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Mech 368 - Gesture Recognition Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.Button butPortState;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer eventTimer;
        private System.Windows.Forms.Label labelXAccel;
        private System.Windows.Forms.Label labelYAccel;
        private System.Windows.Forms.Label labelZAccel;
        private System.Windows.Forms.TextBox textXAccel;
        private System.Windows.Forms.TextBox textYAccel;
        private System.Windows.Forms.TextBox textZAccel;
        private System.Windows.Forms.DataVisualization.Charting.Chart myDataChart;
        private System.Windows.Forms.TextBox gestureBox;
        private System.Windows.Forms.TextBox helpBox;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAccelMagnitude;
        private System.Windows.Forms.TextBox textMagnitude;
        private System.Windows.Forms.Label labelMagnitudeWarning;
        private System.Windows.Forms.TextBox magnitudeBox;
    }
}

