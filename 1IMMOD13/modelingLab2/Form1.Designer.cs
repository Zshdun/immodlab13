namespace modelingLab2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.clearButton = new System.Windows.Forms.Button();
            this.initButton = new System.Windows.Forms.Button();
            this.dollarLabel = new System.Windows.Forms.Label();
            this.euroLabel = new System.Windows.Forms.Label();
            this.euroSP = new System.Windows.Forms.NumericUpDown();
            this.dollarSP = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.euroSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(398, 9);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(70, 20);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clear_Click);
            // 
            // initButton
            // 
            this.initButton.Location = new System.Drawing.Point(322, 9);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(70, 20);
            this.initButton.TabIndex = 0;
            this.initButton.Text = "Старт";
            this.initButton.UseVisualStyleBackColor = true;
            this.initButton.Click += new System.EventHandler(this.init_Click);
            // 
            // dollarLabel
            // 
            this.dollarLabel.AutoSize = true;
            this.dollarLabel.Location = new System.Drawing.Point(12, 11);
            this.dollarLabel.Name = "dollarLabel";
            this.dollarLabel.Size = new System.Drawing.Size(82, 13);
            this.dollarLabel.TabIndex = 1;
            this.dollarLabel.Text = "Курс Доллара:";
            // 
            // euroLabel
            // 
            this.euroLabel.AutoSize = true;
            this.euroLabel.Location = new System.Drawing.Point(178, 13);
            this.euroLabel.Name = "euroLabel";
            this.euroLabel.Size = new System.Drawing.Size(62, 13);
            this.euroLabel.TabIndex = 1;
            this.euroLabel.Text = "Курс Евро:";
            // 
            // euroSP
            // 
            this.euroSP.DecimalPlaces = 3;
            this.euroSP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.euroSP.Location = new System.Drawing.Point(246, 9);
            this.euroSP.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.euroSP.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.euroSP.Name = "euroSP";
            this.euroSP.Size = new System.Drawing.Size(70, 20);
            this.euroSP.TabIndex = 2;
            this.euroSP.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // dollarSP
            // 
            this.dollarSP.DecimalPlaces = 3;
            this.dollarSP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.dollarSP.Location = new System.Drawing.Point(100, 9);
            this.dollarSP.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.dollarSP.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.dollarSP.Name = "dollarSP";
            this.dollarSP.Size = new System.Drawing.Size(70, 20);
            this.dollarSP.TabIndex = 2;
            this.dollarSP.Value = new decimal(new int[] {
            88,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(13, 35);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(633, 447);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 549);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dollarSP);
            this.Controls.Add(this.euroSP);
            this.Controls.Add(this.euroLabel);
            this.Controls.Add(this.dollarLabel);
            this.Controls.Add(this.initButton);
            this.Controls.Add(this.clearButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.euroSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.Label dollarLabel;
        private System.Windows.Forms.Label euroLabel;
        private System.Windows.Forms.NumericUpDown euroSP;
        private System.Windows.Forms.NumericUpDown dollarSP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}

