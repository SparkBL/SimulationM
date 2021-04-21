namespace SimulationM
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lambda = new System.Windows.Forms.NumericUpDown();
            this.mu1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.mu2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.sigma = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.distribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.eventsInvokedValue = new System.Windows.Forms.Label();
            this.timePassedValue = new System.Windows.Forms.Label();
            this.timePassed = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlPanel = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eventLimitValue = new System.Windows.Forms.NumericUpDown();
            this.inputProcess = new System.Windows.Forms.GroupBox();
            this.setParametersButton = new System.Windows.Forms.Button();
            this.mmppButton = new System.Windows.Forms.RadioButton();
            this.simpleInputButton = new System.Windows.Forms.RadioButton();
            this.Stats = new System.Windows.Forms.GroupBox();
            this.intervalsPassed = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ksDistance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribution)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLimitValue)).BeginInit();
            this.inputProcess.SuspendLayout();
            this.Stats.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(40, 27);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(79, 28);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lambda";
            // 
            // lambda
            // 
            this.lambda.DecimalPlaces = 3;
            this.lambda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lambda.Location = new System.Drawing.Point(53, 47);
            this.lambda.Margin = new System.Windows.Forms.Padding(2);
            this.lambda.Name = "lambda";
            this.lambda.Size = new System.Drawing.Size(90, 20);
            this.lambda.TabIndex = 3;
            this.lambda.Value = new decimal(new int[] {
            433,
            0,
            0,
            196608});
            // 
            // mu1
            // 
            this.mu1.DecimalPlaces = 3;
            this.mu1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.mu1.Location = new System.Drawing.Point(67, 82);
            this.mu1.Margin = new System.Windows.Forms.Padding(2);
            this.mu1.Name = "mu1";
            this.mu1.Size = new System.Drawing.Size(90, 20);
            this.mu1.TabIndex = 5;
            this.mu1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mu1";
            // 
            // mu2
            // 
            this.mu2.DecimalPlaces = 3;
            this.mu2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.mu2.Location = new System.Drawing.Point(67, 105);
            this.mu2.Margin = new System.Windows.Forms.Padding(2);
            this.mu2.Name = "mu2";
            this.mu2.Size = new System.Drawing.Size(90, 20);
            this.mu2.TabIndex = 7;
            this.mu2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mu2";
            // 
            // sigma
            // 
            this.sigma.DecimalPlaces = 3;
            this.sigma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sigma.Location = new System.Drawing.Point(67, 128);
            this.sigma.Margin = new System.Windows.Forms.Padding(2);
            this.sigma.Name = "sigma";
            this.sigma.Size = new System.Drawing.Size(90, 20);
            this.sigma.TabIndex = 9;
            this.sigma.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sigma";
            // 
            // distribution
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.distribution.ChartAreas.Add(chartArea1);
            this.distribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.distribution.Location = new System.Drawing.Point(167, 2);
            this.distribution.Margin = new System.Windows.Forms.Padding(2);
            this.distribution.Name = "distribution";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Claims in Orbit";
            this.distribution.Series.Add(series1);
            this.distribution.Size = new System.Drawing.Size(621, 436);
            this.distribution.TabIndex = 14;
            this.distribution.Text = "orbitCount";
            title1.Name = "Distribution";
            title1.Text = "Distribution of claims in the orbit";
            this.distribution.Titles.Add(title1);
            // 
            // eventsInvokedValue
            // 
            this.eventsInvokedValue.AutoSize = true;
            this.eventsInvokedValue.Location = new System.Drawing.Point(85, 37);
            this.eventsInvokedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventsInvokedValue.Name = "eventsInvokedValue";
            this.eventsInvokedValue.Size = new System.Drawing.Size(13, 13);
            this.eventsInvokedValue.TabIndex = 16;
            this.eventsInvokedValue.Text = "0";
            // 
            // timePassedValue
            // 
            this.timePassedValue.AutoSize = true;
            this.timePassedValue.Location = new System.Drawing.Point(85, 23);
            this.timePassedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timePassedValue.Name = "timePassedValue";
            this.timePassedValue.Size = new System.Drawing.Size(13, 13);
            this.timePassedValue.TabIndex = 18;
            this.timePassedValue.Text = "0";
            // 
            // timePassed
            // 
            this.timePassed.AutoSize = true;
            this.timePassed.Location = new System.Drawing.Point(4, 23);
            this.timePassed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timePassed.Name = "timePassed";
            this.timePassed.Size = new System.Drawing.Size(67, 13);
            this.timePassed.TabIndex = 17;
            this.timePassed.Text = "Time passed";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toCSVToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // toCSVToolStripMenuItem
            // 
            this.toCSVToolStripMenuItem.Name = "toCSVToolStripMenuItem";
            this.toCSVToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.toCSVToolStripMenuItem.Text = "To CSV";
            this.toCSVToolStripMenuItem.Click += new System.EventHandler(this.toCSVToolStripMenuItem_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.label6);
            this.controlPanel.Controls.Add(this.eventLimitValue);
            this.controlPanel.Controls.Add(this.inputProcess);
            this.controlPanel.Controls.Add(this.start);
            this.controlPanel.Controls.Add(this.Stats);
            this.controlPanel.Controls.Add(this.mu2);
            this.controlPanel.Controls.Add(this.mu1);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.label3);
            this.controlPanel.Controls.Add(this.label4);
            this.controlPanel.Controls.Add(this.sigma);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(2, 2);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Padding = new System.Windows.Forms.Padding(2);
            this.controlPanel.Size = new System.Drawing.Size(161, 436);
            this.controlPanel.TabIndex = 22;
            this.controlPanel.TabStop = false;
            this.controlPanel.Text = "Controls";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Event Limit";
            // 
            // eventLimitValue
            // 
            this.eventLimitValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.eventLimitValue.Location = new System.Drawing.Point(67, 159);
            this.eventLimitValue.Margin = new System.Windows.Forms.Padding(2);
            this.eventLimitValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.eventLimitValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.eventLimitValue.Name = "eventLimitValue";
            this.eventLimitValue.Size = new System.Drawing.Size(90, 20);
            this.eventLimitValue.TabIndex = 26;
            this.eventLimitValue.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // inputProcess
            // 
            this.inputProcess.Controls.Add(this.setParametersButton);
            this.inputProcess.Controls.Add(this.mmppButton);
            this.inputProcess.Controls.Add(this.simpleInputButton);
            this.inputProcess.Controls.Add(this.lambda);
            this.inputProcess.Controls.Add(this.label1);
            this.inputProcess.Location = new System.Drawing.Point(2, 190);
            this.inputProcess.Margin = new System.Windows.Forms.Padding(2);
            this.inputProcess.Name = "inputProcess";
            this.inputProcess.Padding = new System.Windows.Forms.Padding(2);
            this.inputProcess.Size = new System.Drawing.Size(150, 142);
            this.inputProcess.TabIndex = 24;
            this.inputProcess.TabStop = false;
            this.inputProcess.Text = "Input Process";
            // 
            // setParametersButton
            // 
            this.setParametersButton.Enabled = false;
            this.setParametersButton.Location = new System.Drawing.Point(9, 100);
            this.setParametersButton.Margin = new System.Windows.Forms.Padding(2);
            this.setParametersButton.Name = "setParametersButton";
            this.setParametersButton.Size = new System.Drawing.Size(134, 20);
            this.setParametersButton.TabIndex = 4;
            this.setParametersButton.Text = "Set Parameters";
            this.setParametersButton.UseVisualStyleBackColor = true;
            this.setParametersButton.Click += new System.EventHandler(this.setParametersButton_Click);
            // 
            // mmppButton
            // 
            this.mmppButton.AutoSize = true;
            this.mmppButton.Location = new System.Drawing.Point(9, 78);
            this.mmppButton.Margin = new System.Windows.Forms.Padding(2);
            this.mmppButton.Name = "mmppButton";
            this.mmppButton.Size = new System.Drawing.Size(57, 17);
            this.mmppButton.TabIndex = 1;
            this.mmppButton.TabStop = true;
            this.mmppButton.Text = "MMPP";
            this.mmppButton.UseVisualStyleBackColor = true;
            this.mmppButton.CheckedChanged += new System.EventHandler(this.mmppButton_CheckedChanged);
            // 
            // simpleInputButton
            // 
            this.simpleInputButton.AutoSize = true;
            this.simpleInputButton.Checked = true;
            this.simpleInputButton.Location = new System.Drawing.Point(9, 25);
            this.simpleInputButton.Margin = new System.Windows.Forms.Padding(2);
            this.simpleInputButton.Name = "simpleInputButton";
            this.simpleInputButton.Size = new System.Drawing.Size(83, 17);
            this.simpleInputButton.TabIndex = 0;
            this.simpleInputButton.TabStop = true;
            this.simpleInputButton.Text = "Simple Input";
            this.simpleInputButton.UseVisualStyleBackColor = true;
            this.simpleInputButton.CheckedChanged += new System.EventHandler(this.simpleInputButton_CheckedChanged);
            // 
            // Stats
            // 
            this.Stats.Controls.Add(this.ksDistance);
            this.Stats.Controls.Add(this.label7);
            this.Stats.Controls.Add(this.eventsInvokedValue);
            this.Stats.Controls.Add(this.timePassedValue);
            this.Stats.Controls.Add(this.intervalsPassed);
            this.Stats.Controls.Add(this.timePassed);
            this.Stats.Location = new System.Drawing.Point(4, 337);
            this.Stats.Margin = new System.Windows.Forms.Padding(2);
            this.Stats.Name = "Stats";
            this.Stats.Padding = new System.Windows.Forms.Padding(2);
            this.Stats.Size = new System.Drawing.Size(150, 90);
            this.Stats.TabIndex = 23;
            this.Stats.TabStop = false;
            this.Stats.Text = "Statistics";
            // 
            // intervalsPassed
            // 
            this.intervalsPassed.AutoSize = true;
            this.intervalsPassed.Location = new System.Drawing.Point(4, 37);
            this.intervalsPassed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intervalsPassed.Name = "intervalsPassed";
            this.intervalsPassed.Size = new System.Drawing.Size(81, 13);
            this.intervalsPassed.TabIndex = 15;
            this.intervalsPassed.Text = "Events invoked";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.distribution, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.controlPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 440);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // ksDistance
            // 
            this.ksDistance.AutoSize = true;
            this.ksDistance.Location = new System.Drawing.Point(85, 53);
            this.ksDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ksDistance.Name = "ksDistance";
            this.ksDistance.Size = new System.Drawing.Size(13, 13);
            this.ksDistance.TabIndex = 20;
            this.ksDistance.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Kolm distance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 464);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(806, 378);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribution)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLimitValue)).EndInit();
            this.inputProcess.ResumeLayout(false);
            this.inputProcess.PerformLayout();
            this.Stats.ResumeLayout(false);
            this.Stats.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown lambda;
        private System.Windows.Forms.NumericUpDown mu1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown mu2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sigma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart distribution;
        private System.Windows.Forms.Label eventsInvokedValue;
        private System.Windows.Forms.Label timePassedValue;
        private System.Windows.Forms.Label timePassed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toCSVToolStripMenuItem;
        private System.Windows.Forms.GroupBox controlPanel;
        private System.Windows.Forms.GroupBox Stats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox inputProcess;
        private System.Windows.Forms.RadioButton mmppButton;
        private System.Windows.Forms.RadioButton simpleInputButton;
        private System.Windows.Forms.Button setParametersButton;
        private System.Windows.Forms.Label intervalsPassed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown eventLimitValue;
        private System.Windows.Forms.Label ksDistance;
        private System.Windows.Forms.Label label7;
    }
}

