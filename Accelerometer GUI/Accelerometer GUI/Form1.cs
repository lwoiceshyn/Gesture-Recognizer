using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        public int systemState = 0;
        public int gestureState = 0;
        public ConcurrentQueue<int> XAccelQueue = new ConcurrentQueue<int>();
        public ConcurrentQueue<int> YAccelQueue = new ConcurrentQueue<int>();
        public ConcurrentQueue<int> ZAccelQueue = new ConcurrentQueue<int>();


        Timer input;
        Timer stay;
        Timer magnitude;


        private void ConnectedComPortUpdate()
        {
            try
            {
                //Clears COM List
                cmbPortName.Items.Clear();

                //Accesses System Port Information and Adds it to the ComboBox
                cmbPortName.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames().ToArray());

                //Selects the last and "first" device
                cmbPortName.SelectedIndex = 0;
            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please ensure your USB is plugged in and the tinystick is attached properly.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectedComPortUpdate();

            input = new Timer();
            stay = new Timer();
            magnitude = new Timer();

            input.Interval = 2000;
            input.Tick += new EventHandler(input_Tick);


            stay.Interval = 1000;
            stay.Tick += new EventHandler(stay_Tick);

            magnitude.Interval = 1000;
            magnitude.Tick += new EventHandler(magnitude_Tick);


        }

        private void cmbPortName_DropDown(object sender, EventArgs e)
        {
            ConnectedComPortUpdate();
        }

        Boolean i = false;
        double rt = 0;
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            int dataByte;

            if (i == false)
            {
                rt = 0;
                i = true;
            }


            while (serialPort.IsOpen && serialPort.BytesToRead != 0)
            {
                try
                {
                    dataByte = serialPort.ReadByte();
                }
                catch
                {
                    dataByte = 0;
                }

                if (dataByte == 255)
                {
                    systemState++;
                }

                else if (systemState == 1)
                {
                    XAccelQueue.Enqueue(dataByte);
                    systemState++;


                }

                else if (systemState == 2)
                {
                    YAccelQueue.Enqueue(dataByte);
                    systemState++;

                }

                else if (systemState == 3)
                {
                    ZAccelQueue.Enqueue(dataByte);
                    systemState = 0;
                }
            }

        }

        private void butPortState_Click(object sender, EventArgs e)
        {

            if (!serialPort.IsOpen)
            {

                cmbPortName.Enabled = false;
                eventTimer.Enabled = true;
                try { serialPort.PortName = cmbPortName.Text; }
                catch (ArgumentException) { MessageBox.Show("Make sure your device is connected to the serial port!"); }
                butPortState.Text = "Disconnect";

                try { serialPort.Open(); }
                catch (IOException)
                {

                    MessageBox.Show("Please do not remove the USB or tinystick connection during application.");
                    butPortState.Text = "Connect";
                    cmbPortName.Enabled = true;
                    ConnectedComPortUpdate();


                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Please select one of the already-listed COM items. Do not type in the combo box!");
                    butPortState.Text = "Connect";
                    cmbPortName.Enabled = true;
                    ConnectedComPortUpdate();
                }


                foreach (var series in myDataChart.Series)
                {
                    series.Points.Clear();
                }
                rt = 0;


            }
            else
            {
                if (serialPort.IsOpen)
                {

                    cmbPortName.Enabled = true;
                    eventTimer.Enabled = false;
                    butPortState.Text = "Connect";
                    serialPort.Close();
                    gestureBox.Text = "";
                }
            }

        }

        double totalaccel;
        double Xsquared;
        double Ysquared;
        double Zsquared;
        double xing;
        double ying;
        double zing;
        double g = 37.0;
        double currenttime;

        
        private void eventTimer_Tick(object sender, EventArgs e)
        {

            while (XAccelQueue.Count != 0 && YAccelQueue.Count != 0 && ZAccelQueue.Count != 0)
            {


                int XAccel;
                XAccelQueue.TryDequeue(out XAccel);
                int YAccel;
                YAccelQueue.TryDequeue(out YAccel);
                int ZAccel;
                ZAccelQueue.TryDequeue(out ZAccel);

                double XDouble = Convert.ToDouble(XAccel);
                double YDouble = Convert.ToDouble(YAccel);
                double ZDouble = Convert.ToDouble(ZAccel);

                xing = (XDouble - 128.0) / g;
                ying = (YDouble - 128.0) / g;
                zing = (ZDouble - 128.0) / g;

                Xsquared = xing * xing;
                Ysquared = ying * ying;
                Zsquared = zing * zing;
                totalaccel = Math.Sqrt(Xsquared + Ysquared + Zsquared);
                textMagnitude.Text = totalaccel.ToString("0.00");
                   
                textXAccel.Text = XAccel.ToString("000");
                textYAccel.Text = YAccel.ToString("000");
                textZAccel.Text = ZAccel.ToString("000");

                myDataChart.Series["X Acceleration"].Points.AddY(XAccel);
                myDataChart.Series["Y Acceleration"].Points.AddY(YAccel);
                myDataChart.Series["Z Acceleration"].Points.AddY(ZAccel);
                if (myDataChart.Series["X Acceleration"].Points.Count >= 1000)
                {
                    myDataChart.ChartAreas[0].AxisX.Maximum = myDataChart.Series["X Acceleration"].Points.Count();
                    myDataChart.ChartAreas[0].AxisX.Minimum = myDataChart.Series["X Acceleration"].Points.Count() - 1000;
                }
                if (myDataChart.Series["X Acceleration"].Points.Count >= 100000)
                {
                    myDataChart.Series["X Acceleration"].Points.Clear();
                    myDataChart.Series["Y Acceleration"].Points.Clear();
                    myDataChart.Series["Z Acceleration"].Points.Clear();
                }
  


                helpBox.Text = gestureState.ToString("0");
                rt = rt + 1;

                if (totalaccel > 5)
                {
                    magnitude.Start();
                    magnitudeBox.Text = "Over 5g!";
                }



                if (rt > 50 && YAccel < 100 && gestureState == 0)
                {
                    gestureState = 1;
                    gestureBox.Text = "Simple Kick!";
                    stay.Start();
                    
                }

                if (XAccel < 100 && gestureState == 0)
                {
                    input.Start();
                    gestureState = 2;
                    currenttime = rt;
                }
                if (XAccel < 100 && gestureState == 2 && rt - currenttime >= 100)
                {
                    gestureState = 3;
                    currenttime = 0;
                        
                }
                if (ZAccel < 100 && gestureState == 3)
                {
                    gestureState = 4;
                    gestureBox.Text = "Robocop-Chop!";
                    stay.Start();
                }



            }
        }
        void input_Tick(object sender, EventArgs e)
        {
            input.Stop();
            gestureState = 0;

        }
        void stay_Tick(object sender, EventArgs e)
        {
            gestureBox.Text = "";
            stay.Stop();
            gestureState = 0;

        }
        void magnitude_Tick(object sender, EventArgs e)
        {
            magnitudeBox.Text = "";
            magnitude.Stop();

        }
    }
}

    


