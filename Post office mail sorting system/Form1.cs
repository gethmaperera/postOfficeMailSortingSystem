using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String username = txtusername.Text;
            String password = txtpassword.Text;
            if (username == "post officer" && password == "enigma2")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }

            else if (username == "admin" && password == "enigma1")
            {
               Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnbck_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

    }
}