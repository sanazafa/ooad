namespace finalproject
{
    partial class editGoal
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
            this.lblrolltype = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtgoal = new System.Windows.Forms.TextBox();
            this.lblgoal = new System.Windows.Forms.Label();
            this.comboroll = new System.Windows.Forms.ComboBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblroll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblrolltype
            // 
            this.lblrolltype.AutoSize = true;
            this.lblrolltype.Location = new System.Drawing.Point(384, 164);
            this.lblrolltype.Name = "lblrolltype";
            this.lblrolltype.Size = new System.Drawing.Size(35, 13);
            this.lblrolltype.TabIndex = 27;
            this.lblrolltype.Text = "label1";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(462, 212);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(24, 23);
            this.btnadd.TabIndex = 26;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtgoal
            // 
            this.txtgoal.Location = new System.Drawing.Point(356, 212);
            this.txtgoal.Name = "txtgoal";
            this.txtgoal.Size = new System.Drawing.Size(100, 20);
            this.txtgoal.TabIndex = 25;
            // 
            // lblgoal
            // 
            this.lblgoal.AutoSize = true;
            this.lblgoal.Location = new System.Drawing.Point(315, 220);
            this.lblgoal.Name = "lblgoal";
            this.lblgoal.Size = new System.Drawing.Size(29, 13);
            this.lblgoal.TabIndex = 24;
            this.lblgoal.Text = "Goal";
            // 
            // comboroll
            // 
            this.comboroll.FormattingEnabled = true;
            this.comboroll.Location = new System.Drawing.Point(356, 105);
            this.comboroll.Name = "comboroll";
            this.comboroll.Size = new System.Drawing.Size(121, 21);
            this.comboroll.TabIndex = 23;
            this.comboroll.SelectedIndexChanged += new System.EventHandler(this.comboroll_SelectedIndexChanged);
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(315, 164);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(31, 13);
            this.lbltype.TabIndex = 22;
            this.lbltype.Text = "Type";
            // 
            // lblroll
            // 
            this.lblroll.AutoSize = true;
            this.lblroll.Location = new System.Drawing.Point(315, 113);
            this.lblroll.Name = "lblroll";
            this.lblroll.Size = new System.Drawing.Size(29, 13);
            this.lblroll.TabIndex = 21;
            this.lblroll.Text = "Role";
            // 
            // editGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblrolltype);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtgoal);
            this.Controls.Add(this.lblgoal);
            this.Controls.Add(this.comboroll);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblroll);
            this.Name = "editGoal";
            this.Text = "editGoal";
            this.Load += new System.EventHandler(this.editGoal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrolltype;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtgoal;
        private System.Windows.Forms.Label lblgoal;
        private System.Windows.Forms.ComboBox comboroll;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblroll;
    }
}