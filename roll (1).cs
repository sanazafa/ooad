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
    public partial class roll : Form
    {
        
        public roll()
        {
            
            InitializeComponent();
            DataGridViewLinkColumn ink = new DataGridViewLinkColumn();
            dataGridView1.Columns.Add(ink);
            ink.HeaderText = "Delete data";
            ink.Text = "Delete";
            ink.UseColumnTextForLinkValue = true;
            datashow();
        }
        

        private void btnrolls_Click(object sender, EventArgs e)
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

        private void comborolltype_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*comborolltype.Items.Add("Self");
            comborolltype.Items.Add("Social");
            comborolltype.Items.Add("Work");
            */

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //goals Outside = new goals();
            //Outside.btnadd_Click(Outside.btnadd_Click.myroll.Type,);
            ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
            ServiceReference1.Roll myroll = new ServiceReference1.Roll();
            myroll.Name = txtrollname.Text;
            myroll.Type = comborolltype.Text;

            myserver.addRoll(myroll);
            datashow();
        }
        public void datashow()
        {
            ServiceReference1.Service1Client myclient = new ServiceReference1.Service1Client();
            BindingSource abc = new BindingSource();
            abc.DataSource = myclient.getRolllist();
            dataGridView1.DataSource = abc;
        }

        private void roll_Load(object sender, EventArgs e)
        {
            datashow();
        }

        private void txtrollname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
            goals goalform = new goals(myserver.getRoll(e.RowIndex));
            goalform.Show();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
                server.Deleteroll(this.dataGridView1.SelectedRows[0].Index);
                datashow();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
                ServiceReference1.Roll myroll = new ServiceReference1.Roll();
                int index = this.dataGridView1.SelectedRows[0].Index;
                myroll = server.getRoll(index);
                editRoll editroll = new editRoll(myroll, index);
                editroll.Show();
            }
        }
    }
}
