namespace SimulationM
{
    partial class MMPPModal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.qGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lambdaGrid = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            this.stateCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambdaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateCount)).BeginInit();
            this.SuspendLayout();
            // 
            // qGrid
            // 
            this.qGrid.AllowUserToAddRows = false;
            this.qGrid.AllowUserToDeleteRows = false;
            this.qGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.qGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.qGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = "0,00";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.qGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.qGrid.Location = new System.Drawing.Point(12, 45);
            this.qGrid.Name = "qGrid";
            this.qGrid.RowHeadersVisible = false;
            this.qGrid.RowHeadersWidth = 45;
            this.qGrid.RowTemplate.Height = 24;
            this.qGrid.Size = new System.Drawing.Size(580, 163);
            this.qGrid.TabIndex = 0;
            this.qGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Q_CellValidating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Q Matrix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Location = new System.Drawing.Point(9, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lambda";
            // 
            // lambdaGrid
            // 
            this.lambdaGrid.AllowUserToAddRows = false;
            this.lambdaGrid.AllowUserToDeleteRows = false;
            this.lambdaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.lambdaGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.lambdaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lambdaGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = "0,00";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lambdaGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.lambdaGrid.Location = new System.Drawing.Point(12, 246);
            this.lambdaGrid.Name = "lambdaGrid";
            this.lambdaGrid.RowHeadersVisible = false;
            this.lambdaGrid.RowHeadersWidth = 45;
            this.lambdaGrid.RowTemplate.Height = 24;
            this.lambdaGrid.Size = new System.Drawing.Size(580, 163);
            this.lambdaGrid.TabIndex = 3;
            this.lambdaGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Lambda_CellValidating);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(517, 500);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // stateCount
            // 
            this.stateCount.Location = new System.Drawing.Point(107, 424);
            this.stateCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stateCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.stateCount.Name = "stateCount";
            this.stateCount.Size = new System.Drawing.Size(120, 22);
            this.stateCount.TabIndex = 5;
            this.stateCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.stateCount.ValueChanged += new System.EventHandler(this.stateCount_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Location = new System.Drawing.Point(12, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "State Count";
            // 
            // MMPPModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 535);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stateCount);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.lambdaGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qGrid);
            this.Name = "MMPPModal";
            this.Text = "MMPPModal";
            ((System.ComponentModel.ISupportInitialize)(this.qGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambdaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView qGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView lambdaGrid;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.NumericUpDown stateCount;
        private System.Windows.Forms.Label label3;
    }
}