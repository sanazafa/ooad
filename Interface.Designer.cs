namespace finalproject
{
    partial class Interface
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
            this.btnrolls = new System.Windows.Forms.Button();
            this.btngoals = new System.Windows.Forms.Button();
            this.btntodos = new System.Windows.Forms.Button();
            this.btnreports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnrolls
            // 
            this.btnrolls.Location = new System.Drawing.Point(273, 84);
            this.btnrolls.Name = "btnrolls";
            this.btnrolls.Size = new System.Drawing.Size(248, 38);
            this.btnrolls.TabIndex = 0;
            this.btnrolls.Text = "Roll";
            this.btnrolls.UseVisualStyleBackColor = true;
            this.btnrolls.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngoals
            // 
            this.btngoals.Location = new System.Drawing.Point(273, 128);
            this.btngoals.Name = "btngoals";
            this.btngoals.Size = new System.Drawing.Size(248, 40);
            this.btngoals.TabIndex = 1;
            this.btngoals.Text = "Goals";
            this.btngoals.UseVisualStyleBackColor = true;
            this.btngoals.Click += new System.EventHandler(this.btngoals_Click);
            // 
            // btntodos
            // 
            this.btntodos.Location = new System.Drawing.Point(273, 174);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(248, 34);
            this.btntodos.TabIndex = 2;
            this.btntodos.Text = "To Do\'s";
            this.btntodos.UseVisualStyleBackColor = true;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // btnreports
            // 
            this.btnreports.Location = new System.Drawing.Point(273, 214);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(248, 43);
            this.btnreports.TabIndex = 3;
            this.btnreports.Text = "Reports";
            this.btnreports.UseVisualStyleBackColor = true;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreports);
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.btngoals);
            this.Controls.Add(this.btnrolls);
            this.Name = "Interface";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnrolls;
        private System.Windows.Forms.Button btngoals;
        private System.Windows.Forms.Button btntodos;
        private System.Windows.Forms.Button btnreports;
    }
}