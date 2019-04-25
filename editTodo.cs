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
    public partial class editTodo : Form
    {
        private ServiceReference1.Todo edittodo = new ServiceReference1.Todo();
        private ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
        int index;
        public editTodo()
        {
            InitializeComponent();
        }

        private void editTodo_Load(object sender, EventArgs e)
        {
            txttodo.Text = edittodo.Todoentry;
            calendar.Text = edittodo.Date;
            txtrolename.Text = edittodo.Name;
            txttype.Text = edittodo.Type;
            combogoal.Text = edittodo.Todoentry;
        }
        public editTodo(ServiceReference1.Todo todo, int a)
        {
            InitializeComponent();
            edittodo = todo;
            index = a;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            edittodo.Date = calendar.Text;
            edittodo.Name = txtrolename.Text;
            edittodo.Type = txttype.Text;
            server.Deletetodo(index);
            server.savetodo(edittodo, index);
            this.Close();
            todos todoform = new todos();
            todoform.Show();
        }
    }
}
