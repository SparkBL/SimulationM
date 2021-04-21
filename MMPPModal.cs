using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationM
{
    public partial class MMPPModal : Form
    {
        public MMPPModal(int stateCount, double[,] Q,  double[] Lambda)
        {
            InitializeComponent();

            this.stateCount.Value = stateCount;
            qGrid.AllowUserToAddRows = false;
            lambdaGrid.AllowUserToAddRows = false;
            stateCount_ValueChanged(this, null);
            lambdaGrid.Rows.Add();
            for (int i = 0; i < stateCount; i++)
            {
                this.lambdaGrid.Rows[0].Cells[i].Value = Lambda[i];
                for (int j = 0; j < stateCount; j++)
                {
                    this.qGrid.Rows[i].Cells[j].Value = Q[i, j];
                }
            }
        }

        private void Q_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (!double.TryParse(e.FormattedValue.ToString(), out _)){
                    MessageBox.Show("Enter valid numeric data");
                    qGrid.CurrentCell.Value = null;
                    e.Cancel = true;
                }
            }
        }
        private void Lambda_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (!double.TryParse(e.FormattedValue.ToString(), out _))
                {
                    MessageBox.Show("Enter valid numeric data");
                    lambdaGrid.CurrentCell.Value = null;
                    e.Cancel = true;
                }
            }
        }

        public double[,] Q { get; set; }
       public double[] Lambda { get; set; }

        private void Save_Click(object sender, EventArgs e)
        {
            Q = new double[(int)stateCount.Value,(int)stateCount.Value];
            Lambda = new double[ (int)stateCount.Value]; ;
            for(int i = 0; i < lambdaGrid.Columns.Count; i++)
            {
                Lambda[i] = Convert.ToDouble(lambdaGrid.Rows[0].Cells[i].Value);
                for (int j = 0; j < lambdaGrid.Columns.Count; j++)
                {
                    Q[i, j] = Convert.ToDouble(qGrid.Rows[i].Cells[j].Value);
                }
            }
            for (int i =0; i < (int)stateCount.Value; i++)
            {
                double sum = 0;
                for (int j = 0; j < (int)stateCount.Value; j++)
                    sum += Q[i, j];
                if (Q[i, i] > 0)
                {
                    MessageBox.Show("Diagonal elements must be less than zero!");
                    return;
                }

                if (Math.Abs(sum) > 0.0001)
                {
                    MessageBox.Show("Row sum does not equal zero!");
                    return;
                }
            }
               

                    this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void stateCount_ValueChanged(object sender, EventArgs e)
        {
            while (true)
            {
                if (lambdaGrid.ColumnCount > (int)stateCount.Value) lambdaGrid.Columns.RemoveAt(lambdaGrid.Columns.Count-1 );
                else
                if (lambdaGrid.ColumnCount < (int)stateCount.Value) lambdaGrid.Columns.Add("", "");
                else break;
            }

            while (true)
            {
                if (qGrid.ColumnCount > (int)stateCount.Value) qGrid.Columns.RemoveAt(qGrid.Columns.Count - 1);
                else
                if (qGrid.ColumnCount < (int)stateCount.Value) qGrid.Columns.Add("", "");
                else
                if (qGrid.RowCount > (int)stateCount.Value)
                {
                    qGrid.Rows[qGrid.Rows.Count - 1].Frozen = true;
                    qGrid.Rows.RemoveAt(qGrid.Rows.Count - 1);
                }
                else
                if (qGrid.RowCount < (int)stateCount.Value) qGrid.Rows.Add();
                else break;
                
            }
        }
    }
}
