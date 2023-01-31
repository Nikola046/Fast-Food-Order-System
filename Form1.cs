using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodOrderSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_username.Text!="administrator" || tb_password.Text != "admin064")
            {
                MessageBox.Show("Incorrect Username or Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_username.Clear();
                tb_password.Clear();
            }
            else
            {
                Menu menu= new Menu();
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
        }
    }
}
