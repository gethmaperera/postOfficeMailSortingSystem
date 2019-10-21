using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Windows.Forms;
using MySql.Data.Common;
using System.IO;



namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        

        

        private void Form7_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            label4.Text = today.ToString("d");
            label10.Text = Form2.f7address;
            label12.Text = Form2.f7barcode;
            label14.Text = Form2.f7weight;
            label6.Text=Form2.f7sender ;
            label16.Text = Form2.f7price;
            string barcode = label12.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

       
    }
}
