using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.Common;
using System.IO;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        public static string f7address ;
        public static string f7barcode;
        public static string f7sender;
        public static string f7weight ;
        public static string f7price ;

        private void button1_Click(object sender, EventArgs e)
        {
            string barcode = txtbarcode.Text;
            Bitmap bitmap = new Bitmap(barcode.Length * 20, 150);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Font ofont = new System.Drawing.Font("IDAutomationHC39M Free Version", 10);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                graphics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                graphics.DrawString("*" + barcode + "*", ofont, black, point);
            }
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                pictureBox1.Image = bitmap;
                pictureBox1.Height = bitmap.Height;
                pictureBox1.Width = bitmap.Width;

            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtbarcode.Text != "")
                {
                    string MyConnection2 = "server=localhost;userid=root;password=;database=post_office_mailing_system";
                    string Query = "SELECT * FROM `mailing_details` WHERE `Barcode`='" + this.txtbarcode.Text + "';";
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

                    comboBox1.Text = dt.Rows[0][1].ToString();

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

        private void btnview_Click(object sender, EventArgs e)
        {
            int weight = Int32.Parse(txtweight.Text);
            if (weight <= 20)
            {
                lbloutput.Text = "Rs.15.00";
            }
            else if (weight <= 40)
            {
                lbloutput.Text = "Rs.25.00";
            }
            else if (weight <= 60)
            {
                lbloutput.Text = "Rs.35.00";
            }
            else if (weight <= 80)
            {
                lbloutput.Text = "Rs.45.00";
            }
            else if (weight <= 150)
            {
                lbloutput.Text = "Rs.60.00";
            }
            else if (weight <= 200)
            {
                lbloutput.Text = "Rs.65.00";
            }
            else if (weight <= 250)
            {
                lbloutput.Text = "Rs.70.00";
            }
            else if (weight <= 300)
            {
                lbloutput.Text = "Rs.100.00";
            }
            else if (weight <= 350)
            {
                lbloutput.Text = "Rs.130.00";
            }
            else if (weight <= 400)
            {
                lbloutput.Text = "Rs.160.00";
            }
            else if (weight <= 450)
            {
                lbloutput.Text = "Rs.190.00";
            }
            else if (weight <= 500)
            {
                lbloutput.Text = "Rs.220.00";
            }
            else if (weight <= 550)
            {
                lbloutput.Text = "Rs.250.00";
            }
            else if (weight <= 600)
            {
                lbloutput.Text = "Rs.280.00";
            }
            else if (weight <= 650)
            {
                lbloutput.Text = "Rs.310.00";
            }
            else if (weight <= 700)
            {
                lbloutput.Text = "Rs.340.00";
            }
            else if (weight <= 750)
            {
                lbloutput.Text = "Rs.370.00";
            }
            else if (weight <= 800)
            {
                lbloutput.Text = "Rs.400.00";
            }
            else if (weight <= 850)
            {
                lbloutput.Text = "Rs.430.00";
            }
            else if (weight <= 500)
            {
                lbloutput.Text = "Rs.220.00";
            }
            else if (weight <= 900)
            {
                lbloutput.Text = "Rs.460.00";
            }
            else if (weight <= 950)
            {
                lbloutput.Text = "Rs.490.00";
            }
            else if (weight <= 1000)
            {
                lbloutput.Text = "Rs.520.00";
            }
            else
            {
                lbloutput.Text = "Error";
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    string MyConnection2 = "server=localhost;userid=root;password=;database=post_office_mailing_system";
                    string Query = "SELECT * FROM `mailing_details` WHERE `Address`='" + this.comboBox1.Text + "';";
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

                    txtbarcode.Text = dt.Rows[0][2].ToString();

                }
                else
                {
                    // MessageBox.Show("Enter Address to search");
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Error");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;userid=root;password=;database=post_office_mailing_system");

                string selectQuery = "SELECT * FROM `mailing_details`";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("Address"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {



            comboBox1.Text = "";
            txtbarcode.Clear();

            txtsname.Clear();
            txtsaddress.Clear();
            txtsbarcode.Clear();
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
            txtweight.Clear();
            lbloutput.Text = "";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void btnprint_Click(object sender, EventArgs e)
        {
            
             f7address = comboBox1.Text;
             f7barcode = txtbarcode.Text;
             f7sender = txtsname.Text;
             f7weight = txtweight.Text;
             f7price = lbloutput.Text;

            Form7 f7 = new Form7();
            f7.Show();
        }

        

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;userid=root;password=;database=post_office_mailing_system";
                string Query = "INSERT INTO `sender`(`Name`, `Address`, `Sbarcode`, `Rbarcode`) VALUES ('" + this.txtsname.Text + "','" + this.txtsaddress.Text + "','" + this.txtsbarcode.Text + "','" + this.txtbarcode.Text + "');";
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


        private void btnnxt_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();

        }

        private void lbloutput_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}   


      

