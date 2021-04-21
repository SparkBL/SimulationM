using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimulationM.Sys;
using System.IO;
using System.Reflection;
using System.Threading;

namespace SimulationM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        Sys.Sys sys;
       
        string csvDelimiter = ";";
        double[,] Q = { {-0.2,0.2 },{0.3,-0.3 } };
        double[] Lambda = { 0.4,0.6 };
        IStream stream;
        double[] previousLaunch = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private void start_Click(object sender, EventArgs e)
        {
            Model.Reset();
            if (simpleInputButton.Checked) stream = new SimpleStream((double)lambda.Value);
            else
            {
                MMPPStream p  = new MMPPStream(Q, Lambda, Lambda.Length);
                stream = p;
            }
            sys = new Sys.Sys(stream, (double)mu1.Value, (double)mu2.Value, (double)sigma.Value);
            Model.SetSystem(sys);
            Model.EventLimit = (int)eventLimitValue.Value;
            
            distribution.Series[0].Points.Clear();
            Simulate();
        }


        private void updateInfo()
        {
            timePassedValue.Text = Model.time.ToString();
            double[] stat = Model.GetCurrentIntervalStatistics();
            ksDistance.Text = Math.Round(Utility.KDistance(stat, previousLaunch), 4).ToString();
            previousLaunch = stat;

            if (stat.Length > 1)
            {
                distribution.Series[0].Points.Clear();
                for (int i = 0; i < stat.Length; i++)
                    distribution.Series[0].Points.AddXY(i, stat[i]);
                double max = stat.Max();
                distribution.ChartAreas[0].AxisY.Maximum = Math.Round(max + 0.05 * max + 0.001, 3);
            }
            eventsInvokedValue.Text = Model.eventsInvoked.ToString();

        }

        private void Simulate()
        {
            start.Enabled = false;
            ProgressBar progressDialog = new ProgressBar();
            Thread backgroundThread = new Thread(
               new ThreadStart(() =>
               {
                   while (!Model.IsFinished())
                   {
                       Model.NextMoment();
                   }
                   progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                   MessageBox.Show("Simulation completed!");
               }
           ));
            backgroundThread.Start();
            progressDialog.ShowDialog();
            updateInfo();
            start.Enabled = true;
        }


        private void toCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog();
            diag.Title = "Export distribution to CSV File";
            diag.Filter = "CSV Files (*.csv)|*.csv|Все файлы (*.*)|*.*";
            diag.DefaultExt = "csv";
            diag.ShowDialog();
            if (diag.FileName !="")
            {
                FileStream  fs= (FileStream)diag.OpenFile();
                if (fs.CanWrite)
                {
                    int offset = 0;
                    double[] data = Model.GetCurrentIntervalStatistics();
                    for(int i = 0;i<data.Length;i++)
                    {
                        string input = i + csvDelimiter + data[i] + "\n";
                        fs.Write(Encoding.UTF8.GetBytes(input), 0, Encoding.UTF8.GetByteCount(input));
                        offset += Encoding.UTF8.GetByteCount(input);


                    }
                    fs.Flush();
                    fs.Close();

                }
                
                
            }
        }



        private void setParametersButton_Click(object sender, EventArgs e)
        {
            using (MMPPModal modal = new MMPPModal(Lambda.Length, Q, Lambda))
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Q = modal.Q;
                    this.Lambda = modal.Lambda;
                }
            }
            
        }

        private void simpleInputButton_CheckedChanged(object sender, EventArgs e)
        {
            setParametersButton.Enabled = false;
            lambda.Enabled = true;
        }

        private void mmppButton_CheckedChanged(object sender, EventArgs e)
        {
            lambda.Enabled = false;
            setParametersButton.Enabled = true;
        }
    }


}
