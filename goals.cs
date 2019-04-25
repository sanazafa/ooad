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
    public partial class goals : Form 
    {
        //roll r;
        public goals()
        {

            InitializeComponent();
            DataGridViewLinkColumn ink = new DataGridViewLinkColumn();
            dataGridView2.Columns.Add(ink);
            ink.HeaderText = "Delete data";
            ink.Text = "Delete";
            ink.UseColumnTextForLinkValue = true;
            datashow();
            //InitializeComponent();
            //r = r1;
            //txtgoal.TextChanged += new EventHandler(txtgoal_TextChanged);
        }
        ServiceReference1.Roll r1 = new ServiceReference1.Roll();
        public goals(ServiceReference1.Roll r)
        {
            
            r1 = r;
            
            InitializeComponent();
            //r = r1;
            //txtgoal.TextChanged += new EventHandler(txtgoal_TextChanged);
        }

        private void goals_Load(object sender, EventArgs e)
        {
            comboroll.Text = r1.Name;
            lblrolltype.Text = r1.Type;
            datashow();
            
        }

        private void btnrolls_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            roll r1 = new roll();
            r1.Show();
        }

        private void btngoals_Click(object sender, EventArgs e)
        {

        }

        private void btntodos_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            todos t1 = new todos();
            t1.Show();
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            reportstasklist r1 = new reportstasklist();
            r1.Show();
        }
        //roll r3 = new roll();
        private void btnadd_Click(object sender, EventArgs e)
        {
           // roll MyForm1 = new roll();
            //MyForm1.btnadd_Click(MyForm1.btnadd_Click.myroll.Name, btnadd_Click.myroll.Type);
            ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
            ServiceReference1.Goal mygoal = new ServiceReference1.Goal();
            //ServiceReference1.Roll myroll = new ServiceReference1.Roll();
            mygoal.Goalentry = txtgoal.Text;
            mygoal.Type = lblrolltype.Text;
            mygoal.Name = comboroll.Text;
            myserver.addGoal(mygoal);
            datashow();
        }
        public void datashow()
        {
            ServiceReference1.Service1Client myclient = new ServiceReference1.Service1Client();
            BindingSource abc = new BindingSource();
            abc.DataSource = myclient.getGoallist();
            dataGridView2.DataSource = abc;
        }

        private void comboroll_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
            todos todosform = new todos(myserver.getGoal(e.RowIndex));
            todosform.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count > 0)
            {
                ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
                server.Deletegoal(this.dataGridView2.SelectedRows[0].Index);
                datashow();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count > 0)
            {
                ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
                ServiceReference1.Goal mygoal= new ServiceReference1.Goal();
                int index = this.dataGridView2.SelectedRows[0].Index;
                mygoal = server.getGoal(index);
                editGoal editgoal = new editGoal(mygoal, index);
                editgoal.Show();
            }
        }
    }
}
