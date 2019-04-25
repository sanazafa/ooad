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
    public partial class editRoll : Form
    {
        private ServiceReference1.Roll editroll=new ServiceReference1.Roll();
        private ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
        int index;
        public editRoll()
        {
            InitializeComponent();
        }

        private void editRoll_Load(object sender, EventArgs e)
        {
            txtrollname.Text = editroll.Name;
            comborolltype.Text = editroll.Type;

        }
        public editRoll(ServiceReference1.Roll roll,int a)
        {
            InitializeComponent();
            editroll = roll;
            index = a;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            editroll.Name = txtrollname.Text;
            editroll.Type = comborolltype.Text;
            server.Deleteroll(index);
            server.saveroll(editroll, index);
            this.Close();
            roll rollform = new roll();
            rollform.Show();
        }

        private void txtrollname_TextChanged(object sender, EventArgs e)
        {

        }

        private void comborolltype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
