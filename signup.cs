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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            login l1 = new login();
            l1.Show();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
            myserver.registerUser(txtusername.Text, txtpassword.Text, txtphonenumber.Text);
            MessageBox.Show("Successfully registered");
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }
    }
}
