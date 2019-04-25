namespace finalproject
{
    partial class editTodo
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
            this.btnadd = new System.Windows.Forms.Button();
            this.txttodo = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.txtrolename = new System.Windows.Forms.TextBox();
            this.combogoal = new System.Windows.Forms.ComboBox();
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.lblgoal = new System.Windows.Forms.Label();
            this.lbltodo = new System.Windows.Forms.Label();
            this.lblrollname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(465, 205);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(23, 20);
            this.btnadd.TabIndex = 17;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txttodo
            // 
            this.txttodo.Location = new System.Drawing.Point(275, 205);
            this.txttodo.Name = "txttodo";
            this.txttodo.Size = new System.Drawing.Size(100, 20);
            this.txttodo.TabIndex = 16;
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(419, 159);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(100, 20);
            this.txttype.TabIndex = 15;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(382, 166);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(31, 13);
            this.lbltype.TabIndex = 14;
            this.lbltype.Text = "Type";
            // 
            // txtrolename
            // 
            this.txtrolename.Location = new System.Drawing.Point(275, 160);
            this.txtrolename.Name = "txtrolename";
            this.txtrolename.Size = new System.Drawing.Size(100, 20);
            this.txtrolename.TabIndex = 13;
            // 
            // combogoal
            // 
            this.combogoal.FormattingEnabled = true;
            this.combogoal.Location = new System.Drawing.Point(338, 122);
            this.combogoal.Name = "combogoal";
            this.combogoal.Size = new System.Drawing.Size(121, 21);
            this.combogoal.TabIndex = 12;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(381, 205);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(78, 20);
            this.calendar.TabIndex = 11;
            // 
            // lblgoal
            // 
            this.lblgoal.AutoSize = true;
            this.lblgoal.Location = new System.Drawing.Point(303, 130);
            this.lblgoal.Name = "lblgoal";
            this.lblgoal.Size = new System.Drawing.Size(29, 13);
            this.lblgoal.TabIndex = 10;
            this.lblgoal.Text = "Goal";
            // 
            // lbltodo
            // 
            this.lbltodo.AutoSize = true;
            this.lbltodo.Location = new System.Drawing.Point(211, 208);
            this.lbltodo.Name = "lbltodo";
            this.lbltodo.Size = new System.Drawing.Size(37, 13);
            this.lbltodo.TabIndex = 19;
            this.lbltodo.Text = "To Do";
            // 
            // lblrollname
            // 
            this.lblrollname.AutoSize = true;
            this.lblrollname.Location = new System.Drawing.Point(211, 164);
            this.lblrollname.Name = "lblrollname";
            this.lblrollname.Size = new System.Drawing.Size(56, 13);
            this.lblrollname.TabIndex = 18;
            this.lblrollname.Text = "Roll Name";
            // 
            // editTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltodo);
            this.Controls.Add(this.lblrollname);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txttodo);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.txtrolename);
            this.Controls.Add(this.combogoal);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.lblgoal);
            this.Name = "editTodo";
            this.Text = "editTodo";
            this.Load += new System.EventHandler(this.editTodo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txttodo;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.TextBox txtrolename;
        private System.Windows.Forms.ComboBox combogoal;
        private System.Windows.Forms.DateTimePicker calendar;
        private System.Windows.Forms.Label lblgoal;
        private System.Windows.Forms.Label lbltodo;
        private System.Windows.Forms.Label lblrollname;
    }
}