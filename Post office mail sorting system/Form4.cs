using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void txtdes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;userid=root;password=;database=post_office_mailing_system";
                string Query = "INSERT INTO `returns`(`Sender`, `Receiver`, `Description`, `Date`) VALUES ('" + this.txtsbarcode.Text + "','" + this.txtrbarcode.Text + "','" + this.txtdes.Text + "','" + this.txtdate.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Saved Data");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtrbarcode.Text != "")
                {
                    string MyConnection2 = "server=localhost;userid=root;password=;database=post_office_mailing_system";
                    string Query = "SELECT * FROM `returns` WHERE `Receiver`='" + this.txtrbarcode.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                    MySqlDataAdapter adp = new MySqlDataAdapter(MyCommand2);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    txtsbarcode.Text = dt.Rows[0][0].ToString();
                    txtdes.Text = dt.Rows[0][2].ToString();
                    txtdate.Text = dt.Rows[0][3].ToString();
                }
                else
                {
                    MessageBox.Show("Enter Barcode to search");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtsbarcode.Clear();
            txtrbarcode.Clear();
            txtdes.Clear();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

    }
}