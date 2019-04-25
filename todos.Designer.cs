namespace finalproject
{
    partial class todos
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
            this.lblgoal = new System.Windows.Forms.Label();
            this.lblrollname = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.combogoal = new System.Windows.Forms.ComboBox();
            this.txtrolename = new System.Windows.Forms.TextBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.lbltodo = new System.Windows.Forms.Label();
            this.txttodo = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnreports = new System.Windows.Forms.Button();
            this.btntodos = new System.Windows.Forms.Button();
            this.btngoals = new System.Windows.Forms.Button();
            this.btnrolls = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalentryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todoentryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblgoal
            // 
            this.lblgoal.AutoSize = true;
            this.lblgoal.Location = new System.Drawing.Point(276, 96);
            this.lblgoal.Name = "lblgoal";
            this.lblgoal.Size = new System.Drawing.Size(29, 13);
            this.lblgoal.TabIndex = 0;
            this.lblgoal.Text = "Goal";
            this.lblgoal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblrollname
            // 
            this.lblrollname.AutoSize = true;
            this.lblrollname.Location = new System.Drawing.Point(186, 133);
            this.lblrollname.Name = "lblrollname";
            this.lblrollname.Size = new System.Drawing.Size(56, 13);
            this.lblrollname.TabIndex = 1;
            this.lblrollname.Text = "Roll Name";
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(354, 171);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(78, 20);
            this.calendar.TabIndex = 2;
            // 
            // combogoal
            // 
            this.combogoal.FormattingEnabled = true;
            this.combogoal.Location = new System.Drawing.Point(311, 88);
            this.combogoal.Name = "combogoal";
            this.combogoal.Size = new System.Drawing.Size(121, 21);
            this.combogoal.TabIndex = 3;
            this.combogoal.SelectedIndexChanged += new System.EventHandler(this.combogoal_SelectedIndexChanged);
            // 
            // txtrolename
            // 
            this.txtrolename.Location = new System.Drawing.Point(248, 126);
            this.txtrolename.Name = "txtrolename";
            this.txtrolename.Size = new System.Drawing.Size(100, 20);
            this.txtrolename.TabIndex = 4;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(355, 132);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(31, 13);
            this.lbltype.TabIndex = 5;
            this.lbltype.Text = "Type";
            this.lbltype.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(392, 125);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(100, 20);
            this.txttype.TabIndex = 6;
            // 
            // lbltodo
            // 
            this.lbltodo.AutoSize = true;
            this.lbltodo.Location = new System.Drawing.Point(205, 177);
            this.lbltodo.Name = "lbltodo";
            this.lbltodo.Size = new System.Drawing.Size(37, 13);
            this.lbltodo.TabIndex = 7;
            this.lbltodo.Text = "To Do";
            // 
            // txttodo
            // 
            this.txttodo.Location = new System.Drawing.Point(248, 171);
            this.txttodo.Name = "txttodo";
            this.txttodo.Size = new System.Drawing.Size(100, 20);
            this.txttodo.TabIndex = 8;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(438, 171);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(23, 20);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.goalentryDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.todoentryDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.todoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(213, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 135);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnreports
            // 
            this.btnreports.Location = new System.Drawing.Point(12, 225);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(110, 28);
            this.btnreports.TabIndex = 18;
            this.btnreports.Text = "Reports";
            this.btnreports.UseVisualStyleBackColor = true;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btntodos
            // 
            this.btntodos.Location = new System.Drawing.Point(12, 191);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(110, 28);
            this.btntodos.TabIndex = 17;
            this.btntodos.Text = "To Do\'s";
            this.btntodos.UseVisualStyleBackColor = true;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // btngoals
            // 
            this.btngoals.Location = new System.Drawing.Point(12, 157);
            this.btngoals.Name = "btngoals";
            this.btngoals.Size = new System.Drawing.Size(110, 28);
            this.btngoals.TabIndex = 16;
            this.btngoals.Text = "Goals";
            this.btngoals.UseVisualStyleBackColor = true;
            this.btngoals.Click += new System.EventHandler(this.btngoals_Click);
            // 
            // btnrolls
            // 
            this.btnrolls.Location = new System.Drawing.Point(12, 120);
            this.btnrolls.Name = "btnrolls";
            this.btnrolls.Size = new System.Drawing.Size(110, 31);
            this.btnrolls.TabIndex = 15;
            this.btnrolls.Text = "Roll";
            this.btnrolls.UseVisualStyleBackColor = true;
            this.btnrolls.Click += new System.EventHandler(this.btnrolls_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(357, 359);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 24;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(239, 359);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // goalentryDataGridViewTextBoxColumn
            // 
            this.goalentryDataGridViewTextBoxColumn.DataPropertyName = "Goalentry";
            this.goalentryDataGridViewTextBoxColumn.HeaderText = "Goalentry";
            this.goalentryDataGridViewTextBoxColumn.Name = "goalentryDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // todoentryDataGridViewTextBoxColumn
            // 
            this.todoentryDataGridViewTextBoxColumn.DataPropertyName = "Todoentry";
            this.todoentryDataGridViewTextBoxColumn.HeaderText = "Todoentry";
            this.todoentryDataGridViewTextBoxColumn.Name = "todoentryDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // todoBindingSource
            // 
            this.todoBindingSource.DataSource = typeof(finalproject.ServiceReference1.Todo);
            // 
            // todos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnreports);
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.btngoals);
            this.Controls.Add(this.btnrolls);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txttodo);
            this.Controls.Add(this.lbltodo);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.txtrolename);
            this.Controls.Add(this.combogoal);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.lblrollname);
            this.Controls.Add(this.lblgoal);
            this.Name = "todos";
            this.Text = "todos";
            this.Load += new System.EventHandler(this.todos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgoal;
        private System.Windows.Forms.Label lblrollname;
        private System.Windows.Forms.DateTimePicker calendar;
        private System.Windows.Forms.ComboBox combogoal;
        private System.Windows.Forms.TextBox txtrolename;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Label lbltodo;
        private System.Windows.Forms.TextBox txttodo;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btntodos;
        private System.Windows.Forms.Button btngoals;
        private System.Windows.Forms.Button btnrolls;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalentryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn todoentryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource todoBindingSource;
    }
}