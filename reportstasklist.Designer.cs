namespace finalproject
{
    partial class reportstasklist
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
            this.btntasklist = new System.Windows.Forms.Button();
            this.btnbalance = new System.Windows.Forms.Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnreports = new System.Windows.Forms.Button();
            this.btntodos = new System.Windows.Forms.Button();
            this.btngoals = new System.Windows.Forms.Button();
            this.btnrolls = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntasklist
            // 
            this.btntasklist.Location = new System.Drawing.Point(278, 55);
            this.btntasklist.Name = "btntasklist";
            this.btntasklist.Size = new System.Drawing.Size(75, 23);
            this.btntasklist.TabIndex = 0;
            this.btntasklist.Text = "Task List";
            this.btntasklist.UseVisualStyleBackColor = true;
            // 
            // btnbalance
            // 
            this.btnbalance.Location = new System.Drawing.Point(359, 55);
            this.btnbalance.Name = "btnbalance";
            this.btnbalance.Size = new System.Drawing.Size(75, 23);
            this.btnbalance.TabIndex = 1;
            this.btnbalance.Text = "Balance";
            this.btnbalance.UseVisualStyleBackColor = true;
            this.btnbalance.Click += new System.EventHandler(this.btnbalance_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(242, 93);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(30, 13);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(204, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(292, 135);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnreports
            // 
            this.btnreports.Location = new System.Drawing.Point(12, 226);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(110, 28);
            this.btnreports.TabIndex = 18;
            this.btnreports.Text = "Reports";
            this.btnreports.UseVisualStyleBackColor = true;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btntodos
            // 
            this.btntodos.Location = new System.Drawing.Point(12, 192);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(110, 28);
            this.btntodos.TabIndex = 17;
            this.btntodos.Text = "To Do\'s";
            this.btntodos.UseVisualStyleBackColor = true;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // btngoals
            // 
            this.btngoals.Location = new System.Drawing.Point(12, 158);
            this.btngoals.Name = "btngoals";
            this.btngoals.Size = new System.Drawing.Size(110, 28);
            this.btngoals.TabIndex = 16;
            this.btngoals.Text = "Goals";
            this.btngoals.UseVisualStyleBackColor = true;
            this.btngoals.Click += new System.EventHandler(this.btngoals_Click);
            // 
            // btnrolls
            // 
            this.btnrolls.Location = new System.Drawing.Point(12, 121);
            this.btnrolls.Name = "btnrolls";
            this.btnrolls.Size = new System.Drawing.Size(110, 31);
            this.btnrolls.TabIndex = 15;
            this.btnrolls.Text = "Roll";
            this.btnrolls.UseVisualStyleBackColor = true;
            this.btnrolls.Click += new System.EventHandler(this.btnrolls_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(313, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(313, 129);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 20;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // reportstasklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnreports);
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.btngoals);
            this.Controls.Add(this.btnrolls);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.btnbalance);
            this.Controls.Add(this.btntasklist);
            this.Name = "reportstasklist";
            this.Text = "Reports Task List";
            this.Load += new System.EventHandler(this.reportstasklist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntasklist;
        private System.Windows.Forms.Button btnbalance;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btntodos;
        private System.Windows.Forms.Button btngoals;
        private System.Windows.Forms.Button btnrolls;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_submit;
    }
}