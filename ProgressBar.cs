using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationM
{
    public partial class ProgressBar : Form
    {
        private int step;
        public ProgressBar()
        {
            InitializeComponent();
            progressBar1.MarqueeAnimationSpeed = 100;
            label1.Visible = true;
            label1.Show();
        }
       

    }
}
