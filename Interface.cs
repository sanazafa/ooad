using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            roll r1 = new roll();
            r1.Show();

        }

        private void btngoals_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            goals g1 = new goals();
            g1.Show();
        }

        private void btntodos_Click(object sender, EventArgs e)
        {
            this.Hide();
            todos t1 = new todos();
            t1.Show();
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            reportstasklist r1 = new reportstasklist();
            r1.Show();
        }
    }
}
