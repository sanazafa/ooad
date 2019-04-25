namespace finalproject
{
    partial class editRoll
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
            this.btnsave = new System.Windows.Forms.Button();
            this.comborolltype = new System.Windows.Forms.ComboBox();
            this.txtrollname = new System.Windows.Forms.TextBox();
            this.lblrolltype = new System.Windows.Forms.Label();
            this.lblrollname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(412, 202);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // comborolltype
            // 
            this.comborolltype.FormattingEnabled = true;
            this.comborolltype.Items.AddRange(new object[] {
            "SOCIAL",
            "WORK",
            "SELF"});
            this.comborolltype.Location = new System.Drawing.Point(366, 172);
            this.comborolltype.Name = "comborolltype";
            this.comborolltype.Size = new System.Drawing.Size(121, 21);
            this.comborolltype.TabIndex = 16;
            this.comborolltype.SelectedIndexChanged += new System.EventHandler(this.comborolltype_SelectedIndexChanged);
            // 
            // txtrollname
            // 
            this.txtrollname.Location = new System.Drawing.Point(366, 128);
            this.txtrollname.Name = "txtrollname";
            this.txtrollname.Size = new System.Drawing.Size(121, 20);
            this.txtrollname.TabIndex = 15;
            this.txtrollname.TextChanged += new System.EventHandler(this.txtrollname_TextChanged);
            // 
            // lblrolltype
            // 
            this.lblrolltype.AutoSize = true;
            this.lblrolltype.Location = new System.Drawing.Point(304, 172);
            this.lblrolltype.Name = "lblrolltype";
            this.lblrolltype.Size = new System.Drawing.Size(56, 13);
            this.lblrolltype.TabIndex = 14;
            this.lblrolltype.Text = "Role Type";
            // 
            // lblrollname
            // 
            this.lblrollname.AutoSize = true;
            this.lblrollname.Location = new System.Drawing.Point(304, 135);
            this.lblrollname.Name = "lblrollname";
            this.lblrollname.Size = new System.Drawing.Size(56, 13);
            this.lblrollname.TabIndex = 13;
            this.lblrollname.Text = "Roll Name";
            // 
            // editRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.comborolltype);
            this.Controls.Add(this.txtrollname);
            this.Controls.Add(this.lblrolltype);
            this.Controls.Add(this.lblrollname);
            this.Name = "editRoll";
            this.Text = "editRoll";
            this.Load += new System.EventHandler(this.editRoll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox comborolltype;
        private System.Windows.Forms.TextBox txtrollname;
        private System.Windows.Forms.Label lblrolltype;
        private System.Windows.Forms.Label lblrollname;
    }
}