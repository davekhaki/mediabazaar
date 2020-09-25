using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_2_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3();
            form3.Show();
            //this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 stockForm = new Form5();
            stockForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 employeeForm = new Form2();
            employeeForm.Show();
        }
    }
}
