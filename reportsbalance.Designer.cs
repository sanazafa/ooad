namespace finalproject
{
    partial class reportsbalance
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnbalance = new System.Windows.Forms.Button();
            this.btntasklist = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.Label();
            this.btnreports = new System.Windows.Forms.Button();
            this.btntodos = new System.Windows.Forms.Button();
            this.btngoals = new System.Windows.Forms.Button();
            this.btnrolls = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbalance
            // 
            this.btnbalance.Location = new System.Drawing.Point(372, 69);
            this.btnbalance.Name = "btnbalance";
            this.btnbalance.Size = new System.Drawing.Size(75, 23);
            this.btnbalance.TabIndex = 8;
            this.btnbalance.Text = "Balance";
            this.btnbalance.UseVisualStyleBackColor = true;
            // 
            // btntasklist
            // 
            this.btntasklist.Location = new System.Drawing.Point(291, 69);
            this.btntasklist.Name = "btntasklist";
            this.btntasklist.Size = new System.Drawing.Size(75, 23);
            this.btntasklist.TabIndex = 7;
            this.btntasklist.Text = "Task List";
            this.btntasklist.UseVisualStyleBackColor = true;
            this.btntasklist.Click += new System.EventHandler(this.btntasklist_Click);
            // 
            // chart
            // 
            this.chart.AutoSize = true;
            this.chart.Location = new System.Drawing.Point(354, 95);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(32, 13);
            this.chart.TabIndex = 9;
            this.chart.Text = "Chart";
            // 
            // btnreports
            // 
            this.btnreports.Location = new System.Drawing.Point(12, 228);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(110, 28);
            this.btnreports.TabIndex = 13;
            this.btnreports.Text = "Reports";
            this.btnreports.UseVisualStyleBackColor = true;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btntodos
            // 
            this.btntodos.Location = new System.Drawing.Point(12, 194);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(110, 28);
            this.btntodos.TabIndex = 12;
            this.btntodos.Text = "To Do\'s";
            this.btntodos.UseVisualStyleBackColor = true;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // btngoals
            // 
            this.btngoals.Location = new System.Drawing.Point(12, 160);
            this.btngoals.Name = "btngoals";
            this.btngoals.Size = new System.Drawing.Size(110, 28);
            this.btngoals.TabIndex = 11;
            this.btngoals.Text = "Goals";
            this.btngoals.UseVisualStyleBackColor = true;
            this.btngoals.Click += new System.EventHandler(this.btngoals_Click);
            // 
            // btnrolls
            // 
            this.btnrolls.Location = new System.Drawing.Point(12, 123);
            this.btnrolls.Name = "btnrolls";
            this.btnrolls.Size = new System.Drawing.Size(110, 31);
            this.btnrolls.TabIndex = 10;
            this.btnrolls.Text = "Roll";
            this.btnrolls.UseVisualStyleBackColor = true;
            this.btnrolls.Click += new System.EventHandler(this.btnrolls_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(291, 123);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "task";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(243, 193);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // reportsbalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnreports);
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.btngoals);
            this.Controls.Add(this.btnrolls);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.btnbalance);
            this.Controls.Add(this.btntasklist);
            this.Name = "reportsbalance";
            this.Text = "Reports with Balance";
            this.Load += new System.EventHandler(this.reports_copy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnbalance;
        private System.Windows.Forms.Button btntasklist;
        private System.Windows.Forms.Label chart;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btntodos;
        private System.Windows.Forms.Button btngoals;
        private System.Windows.Forms.Button btnrolls;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}