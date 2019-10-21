using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.IO;
using System.Threading;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

        }

        int i = 1;
       // int counter = 0;
        int loopsignal;
        string A, B, C;
        long BarA, BarB, BarC;
        long BarAE, BarBE, BarCE;

        public void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = "COM21";
                    serialPort1.Open();
                }


                do
                {
                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.PortName = "COM21";
                        serialPort1.Open();
                    }

                    string MyConnection2 = "server=localhost;userid=root;password=;database=post_office_mailing_system";
                    string Query = "SELECT * FROM `range` WHERE `index`=" + i + ";";
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

                    try
                    {
                        if (dt.Rows[0][1].ToString() == "")
                        {
                            loopsignal = 0;
                        }
                        else
                        {
                            loopsignal = 1;
                        }
                    }
                    catch
                    {
                        loopsignal = 0;
                    }

                    if (loopsignal == 1)
                    {
                        txtbarcode.Text = dt.Rows[0][1].ToString();
                        i++;
                        //counter++;

                        //textBox3.Text = Convert.ToString(counter);


                        long barcode = long.Parse(txtbarcode.Text);

                        if ((barcode >= BarA) && (barcode <= BarAE))
                        {
                            string range = "A";
                            textBox2.Text = range;
                            serialPort1.Write("A'");
                            timer2.Enabled = true;
                            timer2.Start();
                            serialPort1.Write("A'");
                            timer2.Start();
                            serialPort1.Write("A'");
                            timer2.Start();
                            serialPort1.Write("A'");
                            timer2.Enabled = false;

                        }
                        else if ((barcode >= BarB) && (barcode <= BarBE))
                        {
                            string range = "B";
                            textBox2.Text = range;
                            serialPort1.Write("B'");
                            timer2.Enabled = true;
                            timer2.Start();
                            serialPort1.Write("B'");
                            timer2.Start();
                            serialPort1.Write("B'");
                            timer2.Start();
                            serialPort1.Write("B'");
                            timer2.Enabled = false;
                        }
                        else if ((barcode >= BarC) && (barcode <= BarCE))
                        {
                            string range = "C";
                            textBox2.Text = range;
                            serialPort1.Write("C'");
                            timer2.Enabled = true;
                            timer2.Start();
                            serialPort1.Write("C'");
                            timer2.Start();
                            serialPort1.Write("C'");
                            timer2.Start();
                            serialPort1.Write("C'");
                            timer2.Enabled = false;
                        }
                        else
                        {
                            string range = "D";
                            textBox2.Text = range;
                            serialPort1.Write("D'");
                            timer2.Enabled = true;
                            timer2.Start();
                            serialPort1.Write("D'");
                            timer2.Start();
                            serialPort1.Write("D'");
                            timer2.Start();
                            serialPort1.Write("D'");
                            timer2.Enabled = false;
                        }

                    } serialPort1.Close();

                } while (loopsignal == 1);
            }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxA.SelectedIndex = 0;
            comboBoxB.SelectedIndex = 1;
            comboBoxC.SelectedIndex = 2;

            textBoxD.Text = "Other";
         }

        private void changerange_Click(object sender, EventArgs e)
        {
            A = comboBoxA.Text;

            if (A == "Colombo 1")
            {
                BarA = 103500010000000;
                BarAE = 103500019999999;
            }
            else if (A == "Colombo 2")
            {
                BarA = 103500020000000;
                BarAE = 103500029999999;
            }
            else
            {
                BarA = 103500030000000;
                BarAE = 103500039999999;
            }

            B =comboBoxB.Text;
            if (B == "Colombo 1")
            {
                BarB = 103500010000000;
                BarBE = 103500019999999;
            }
            else if (B == "Colombo 2")
            {
                BarB = 103500020000000;
                BarBE = 103500029999999;
            }
            else
            {
                BarB = 103500030000000;
                BarBE = 103500039999999;
            }

            C = comboBoxC.Text;
            if (C == "Colombo 1")
            {
                BarC = 103500010000000;
                BarCE = 103500019999999;
            }
            else if (C == "Colombo 2")
            {
                BarC = 103500020000000;
                BarCE = 103500029999999;
            }
            else
            {
                BarC = 103500030000000;
                BarCE = 103500039999999;
            }

            MessageBox.Show("Ranges Changed!");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void comboBoxC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
     } 
  }















