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
    public partial class editGoal : Form
    {
        private ServiceReference1.Goal editgoal = new ServiceReference1.Goal();
        private ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
        int index;
        public editGoal()
        {
            InitializeComponent();
        }

        private void editGoal_Load(object sender, EventArgs e)
        {
            comboroll.Text = editgoal.Name;
            lblrolltype.Text = editgoal.Type;
            txtgoal.Text = editgoal.Goalentry;

        }
        public editGoal(ServiceReference1.Goal goal, int a)
        {
            InitializeComponent();
            editgoal = goal;
            index = a;
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            editgoal.Name = comboroll.Text;
            editgoal.Type = lblrolltype.Text;
            server.Deletegoal(index);
            server.savegoal(editgoal, index);
            this.Close();
            goals goalform = new goals();
            goalform.Show();
        }

        private void comboroll_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
