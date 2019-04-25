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
    public partial class reportsbalance : Form
    {
        public reportsbalance()
        {
            InitializeComponent();
        }

        private void reports_copy_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            var _todo = client.getTodolist();

            var work = 0;
            var social = 0;
            var self = 0;

            //foreach(var items in _todo)
            //{
            //    if(items.Type == "")
            //}

            this.chart1.Series["task"].Points.AddXY("Work", 2);
            this.chart1.Series["task"].Points.AddXY("Self", 4);
            this.chart1.Series["task"].Points.AddXY("Social", 2);

        }

        private void btntasklist_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            reportstasklist r1 = new reportstasklist();
            r1.Show();
        }

        private void btntodos_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            todos t1 = new todos();
            t1.Show();
        }

        private void btngoals_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            goals g1 = new goals();
            g1.Show();
        }

        private void btnrolls_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            roll r1 = new roll();
            r1.Show();
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();

        }
    }
}
