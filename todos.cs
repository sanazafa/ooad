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
    public partial class todos : Form
    {
        
        public todos()
        {
            
            InitializeComponent();



        }

            ServiceReference1.Goal g1 = new ServiceReference1.Goal();
            public todos(ServiceReference1.Goal g)
            {
                g1 = g;
                InitializeComponent();
            }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void todos_Load(object sender, EventArgs e)
        {
            
            combogoal.Text = g1.Goalentry;
            txtrolename.Text = g1.Name;
            txttype.Text = g1.Type;
            datashow();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btngoals_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            goals g1 = new goals();
            g1.Show();
        }

        
        private void btntodos_Click(object sender, EventArgs e)
        {

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
            reportstasklist r1 = new reportstasklist();
            r1.Show();
        }

        private void combogoal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
            ServiceReference1.Todo mytodo = new ServiceReference1.Todo();
            //ServiceReference1.Roll myroll = new ServiceReference1.Roll();
            mytodo.Date = calendar.Text;
            mytodo.Goalentry = combogoal.Text;
            mytodo.Todoentry = txttodo.Text;
            mytodo.Type = txttype.Text;
            mytodo.Name = txtrolename.Text;
            myserver.addTodo(mytodo);
            datashow();
        }
        public void datashow()
        {
            ServiceReference1.Service1Client myclient = new ServiceReference1.Service1Client();
            BindingSource abc = new BindingSource();
            abc.DataSource = myclient.getTodolist();
            dataGridView1.DataSource = abc;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
                server.Deletetodo(this.dataGridView1.SelectedRows[0].Index);
                datashow();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
                ServiceReference1.Todo mytodo = new ServiceReference1.Todo();
                int index = this.dataGridView1.SelectedRows[0].Index;
                mytodo = server.getTodo(index);
                editTodo edittodo = new editTodo(mytodo, index);
                edittodo.Show();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Display()
        {
            
        }

    }
}
