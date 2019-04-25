namespace finalproject
{
    partial class roll
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
            this.btnreports = new System.Windows.Forms.Button();
            this.btntodos = new System.Windows.Forms.Button();
            this.btngoals = new System.Windows.Forms.Button();
            this.btnrolls = new System.Windows.Forms.Button();
            this.lblrollname = new System.Windows.Forms.Label();
            this.lblrolltype = new System.Windows.Forms.Label();
            this.txtrollname = new System.Windows.Forms.TextBox();
            this.comborolltype = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.rollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addgoal = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnreports
            // 
            this.btnreports.Location = new System.Drawing.Point(32, 182);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(110, 28);
            this.btnreports.TabIndex = 7;
            this.btnreports.Text = "Reports";
            this.btnreports.UseVisualStyleBackColor = true;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btntodos
            // 
            this.btntodos.Location = new System.Drawing.Point(32, 148);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(110, 28);
            this.btntodos.TabIndex = 6;
            this.btntodos.Text = "To Do\'s";
            this.btntodos.UseVisualStyleBackColor = true;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // btngoals
            // 
            this.btngoals.Location = new System.Drawing.Point(32, 114);
            this.btngoals.Name = "btngoals";
            this.btngoals.Size = new System.Drawing.Size(110, 28);
            this.btngoals.TabIndex = 5;
            this.btngoals.Text = "Goals";
            this.btngoals.UseVisualStyleBackColor = true;
            this.btngoals.Click += new System.EventHandler(this.btngoals_Click);
            // 
            // btnrolls
            // 
            this.btnrolls.Location = new System.Drawing.Point(32, 77);
            this.btnrolls.Name = "btnrolls";
            this.btnrolls.Size = new System.Drawing.Size(110, 31);
            this.btnrolls.TabIndex = 4;
            this.btnrolls.Text = "Roll";
            this.btnrolls.UseVisualStyleBackColor = true;
            this.btnrolls.Click += new System.EventHandler(this.btnrolls_Click);
            // 
            // lblrollname
            // 
            this.lblrollname.AutoSize = true;
            this.lblrollname.Location = new System.Drawing.Point(321, 86);
            this.lblrollname.Name = "lblrollname";
            this.lblrollname.Size = new System.Drawing.Size(56, 13);
            this.lblrollname.TabIndex = 8;
            this.lblrollname.Text = "Roll Name";
            // 
            // lblrolltype
            // 
            this.lblrolltype.AutoSize = true;
            this.lblrolltype.Location = new System.Drawing.Point(321, 123);
            this.lblrolltype.Name = "lblrolltype";
            this.lblrolltype.Size = new System.Drawing.Size(56, 13);
            this.lblrolltype.TabIndex = 9;
            this.lblrolltype.Text = "Role Type";
            // 
            // txtrollname
            // 
            this.txtrollname.Location = new System.Drawing.Point(383, 79);
            this.txtrollname.Name = "txtrollname";
            this.txtrollname.Size = new System.Drawing.Size(121, 20);
            this.txtrollname.TabIndex = 10;
            this.txtrollname.TextChanged += new System.EventHandler(this.txtrollname_TextChanged);
            // 
            // comborolltype
            // 
            this.comborolltype.FormattingEnabled = true;
            this.comborolltype.Items.AddRange(new object[] {
            "SOCIAL",
            "WORK",
            "SELF"});
            this.comborolltype.Location = new System.Drawing.Point(383, 123);
            this.comborolltype.Name = "comborolltype";
            this.comborolltype.Size = new System.Drawing.Size(121, 21);
            this.comborolltype.TabIndex = 11;
            this.comborolltype.SelectedIndexChanged += new System.EventHandler(this.comborolltype_SelectedIndexChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(429, 153);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.addgoal});
            this.dataGridView1.Location = new System.Drawing.Point(190, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 135);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(206, 337);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(324, 337);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 15;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // rollBindingSource
            // 
            this.rollBindingSource.DataSource = typeof(finalproject.ServiceReference1.Roll);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Roll";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // addgoal
            // 
            this.addgoal.DataPropertyName = "Name";
            this.addgoal.HeaderText = "Add goal";
            this.addgoal.Name = "addgoal";
            this.addgoal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addgoal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // roll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.comborolltype);
            this.Controls.Add(this.txtrollname);
            this.Controls.Add(this.lblrolltype);
            this.Controls.Add(this.lblrollname);
            this.Controls.Add(this.btnreports);
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.btngoals);
            this.Controls.Add(this.btnrolls);
            this.Name = "roll";
            this.Text = "Roll";
            this.Load += new System.EventHandler(this.roll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btntodos;
        private System.Windows.Forms.Button btngoals;
        private System.Windows.Forms.Button btnrolls;
        private System.Windows.Forms.Label lblrollname;
        private System.Windows.Forms.Label lblrolltype;
        private System.Windows.Forms.TextBox txtrollname;
        private System.Windows.Forms.ComboBox comborolltype;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource compositeTypeBindingSource;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.BindingSource rollBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn addgoal;
    }
}