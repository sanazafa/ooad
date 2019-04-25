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
    public partial class reportstasklist : Form
    {
        public reportstasklist()
        {
            InitializeComponent();
        }

        private void btnbalance_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            reportsbalance rb1 = new reportsbalance();
            rb1.Show();
        }

        private void btntodos_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            todos t1 = new todos();
            t1.Show();
        }

        private void btnrolls_Click(object sender, EventArgs e)
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

        private void btnreports_Click(object sender, EventArgs e)
        {

        }

        private void reportstasklist_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            var _todo = client.getTodolist();

            foreach (var todo in _todo)
            {
                comboBox1.Items.Add(todo.Date);   
            }

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            var date_value = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            BindingSource source = new BindingSource();
            source.DataSource = client.GetDateTodo(date_value);
            dataGridView1.DataSource = source;

        }
    }
}
