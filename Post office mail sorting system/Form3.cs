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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;userid=root;password=;database=post_office_mailing_system";
                string Query = "INSERT INTO `mailing_details`(`Name`, `Address`, `Barcode`, `Mobile`) VALUES ('" + this.txtname.Text + "','" + this.txtaddress.Text + "','" + this.txtbarcode.Text + "','" + this.txtmobile.Text + "');";
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;userid=root;password=;database=post_office_mailing_system";
                string Query = "UPDATE `mailing_details` SET `Name`='" + this.txtname.Text + "',`Address`='" + this.txtaddress.Text + "',`Barcode`='" + this.txtbarcode.Text + "',`Mobile`='" + this.txtmobile.Text + "' WHERE `Barcode`='" + this.txtbarcode.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Successfully Updated");
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
                if(txtbarcode.Text!="")
                {
                    string MyConnection2 = "server=localhost;userid=root;password=;database=post_office_mailing_system";
                    string Query = "SELECT * FROM `mailing_details` WHERE `Barcode`='" + this.txtbarcode.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query,MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    while(MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                    MySqlDataAdapter adp = new MySqlDataAdapter(MyCommand2);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    txtname.Text = dt.Rows[0][0].ToString();
                    txtaddress.Text = dt.Rows[0][1].ToString();
                    txtmobile.Text = dt.Rows[0][3].ToString();
                }
                else
                {
                    MessageBox.Show("Enter Barcode to search");
                }
            }
                catch(Exception)
            {
                    MessageBox.Show("Error");
                }



        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;userid=root;password=;database=post_office_mailing_system";
                string Query = "DELETE FROM `mailing_details` WHERE `Barcode`='" + this.txtbarcode.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Delete Successfully");
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtaddress.Clear();
            txtbarcode.Clear();
            txtmobile.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (txtbarcode.Text != "")
                {
                    string MyConnection2 = "server=localhost;userid=root;password=;database=post_office_mailing_system";
                    string Query = "SELECT * FROM `mailing_details` WHERE `Address`='" + this.txtaddress.Text + "';";
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
                    txtname.Text = dt.Rows[0][0].ToString();
                    txtaddress.Text = dt.Rows[0][1].ToString();
                    txtmobile.Text = dt.Rows[0][3].ToString();
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

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    

        }
}
    