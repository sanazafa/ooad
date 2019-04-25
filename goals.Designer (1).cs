namespace finalproject
{
    partial class goals
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
            this.lblroll = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.comboroll = new System.Windows.Forms.ComboBox();
            this.lblgoal = new System.Windows.Forms.Label();
            this.txtgoal = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnreports = new System.Windows.Forms.Button();
            this.btntodos = new System.Windows.Forms.Button();
            this.btngoals = new System.Windows.Forms.Button();
            this.btnrolls = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblrolltype = new System.Windows.Forms.Label();
            this.addtodos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.goalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goalentryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblroll
            // 
            this.lblroll.AutoSize = true;
            this.lblroll.Location = new System.Drawing.Point(258, 54);
            this.lblroll.Name = "lblroll";
            this.lblroll.Size = new System.Drawing.Size(29, 13);
            this.lblroll.TabIndex = 0;
            this.lblroll.Text = "Role";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(258, 105);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(31, 13);
            this.lbltype.TabIndex = 1;
            this.lbltype.Text = "Type";
            // 
            // comboroll
            // 
            this.comboroll.FormattingEnabled = true;
            this.comboroll.Location = new System.Drawing.Point(299, 46);
            this.comboroll.Name = "comboroll";
            this.comboroll.Size = new System.Drawing.Size(121, 21);
            this.comboroll.TabIndex = 2;
            this.comboroll.SelectedIndexChanged += new System.EventHandler(this.comboroll_SelectedIndexChanged);
            // 
            // lblgoal
            // 
            this.lblgoal.AutoSize = true;
            this.lblgoal.Location = new System.Drawing.Point(258, 161);
            this.lblgoal.Name = "lblgoal";
            this.lblgoal.Size = new System.Drawing.Size(29, 13);
            this.lblgoal.TabIndex = 4;
            this.lblgoal.Text = "Goal";
            // 
            // txtgoal
            // 
            this.txtgoal.Location = new System.Drawing.Point(299, 153);
            this.txtgoal.Name = "txtgoal";
            this.txtgoal.Size = new System.Drawing.Size(100, 20);
            this.txtgoal.TabIndex = 5;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(405, 153);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(24, 23);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnreports
            // 
            this.btnreports.Location = new System.Drawing.Point(22, 210);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(110, 28);
            this.btnreports.TabIndex = 18;
            this.btnreports.Text = "Reports";
            this.btnreports.UseVisualStyleBackColor = true;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btntodos
            // 
            this.btntodos.Location = new System.Drawing.Point(22, 176);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(110, 28);
            this.btntodos.TabIndex = 17;
            this.btntodos.Text = "To Do\'s";
            this.btntodos.UseVisualStyleBackColor = true;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // btngoals
            // 
            this.btngoals.Location = new System.Drawing.Point(22, 142);
            this.btngoals.Name = "btngoals";
            this.btngoals.Size = new System.Drawing.Size(110, 28);
            this.btngoals.TabIndex = 16;
            this.btngoals.Text = "Goals";
            this.btngoals.UseVisualStyleBackColor = true;
            this.btngoals.Click += new System.EventHandler(this.btngoals_Click);
            // 
            // btnrolls
            // 
            this.btnrolls.Location = new System.Drawing.Point(22, 105);
            this.btnrolls.Name = "btnrolls";
            this.btnrolls.Size = new System.Drawing.Size(110, 31);
            this.btnrolls.TabIndex = 15;
            this.btnrolls.Text = "Roll";
            this.btnrolls.UseVisualStyleBackColor = true;
            this.btnrolls.Click += new System.EventHandler(this.btnrolls_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addtodos,
            this.goalentryDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.goalBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(164, 210);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(544, 135);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // lblrolltype
            // 
            this.lblrolltype.AutoSize = true;
            this.lblrolltype.Location = new System.Drawing.Point(327, 105);
            this.lblrolltype.Name = "lblrolltype";
            this.lblrolltype.Size = new System.Drawing.Size(35, 13);
            this.lblrolltype.TabIndex = 20;
            this.lblrolltype.Text = "label1";
            // 
            // addtodos
            // 
            this.addtodos.DataPropertyName = "Goalentry";
            this.addtodos.HeaderText = "Add to do";
            this.addtodos.Name = "addtodos";
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(299, 362);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 22;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(181, 362);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // goalBindingSource
            // 
            this.goalBindingSource.DataSource = typeof(finalproject.ServiceReference1.Goal);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn1.HeaderText = "Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // goals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.lblrolltype);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnreports);
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.btngoals);
            this.Controls.Add(this.btnrolls);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtgoal);
            this.Controls.Add(this.lblgoal);
            this.Controls.Add(this.comboroll);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblroll);
            this.Name = "goals";
            this.Text = "goals";
            this.Load += new System.EventHandler(this.goals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblroll;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.ComboBox comboroll;
        private System.Windows.Forms.Label lblgoal;
        private System.Windows.Forms.TextBox txtgoal;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btntodos;
        private System.Windows.Forms.Button btngoals;
        private System.Windows.Forms.Button btnrolls;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblrolltype;
        private System.Windows.Forms.DataGridViewButtonColumn addtodos;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalentryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource goalBindingSource;
    }
}