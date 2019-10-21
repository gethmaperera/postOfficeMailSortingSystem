namespace WindowsFormsApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblbarcode = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsbarcode = new System.Windows.Forms.Label();
            this.txtsaddress = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnclear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblsname = new System.Windows.Forms.Label();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.lblsaddress = new System.Windows.Forms.Label();
            this.txtsbarcode = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnnxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(12, 448);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(159, 45);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(40, 60);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(66, 16);
            this.lbladdress.TabIndex = 5;
            this.lbladdress.Text = "Address";
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarcode.Location = new System.Drawing.Point(39, 91);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(67, 16);
            this.lblbarcode.TabIndex = 6;
            this.lblbarcode.Text = "Barcode";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(141, 91);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(169, 20);
            this.txtbarcode.TabIndex = 9;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(577, 51);
            this.txtweight.Margin = new System.Windows.Forms.Padding(4);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(154, 20);
            this.txtweight.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Weight";
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(467, 448);
            this.btnprint.Margin = new System.Windows.Forms.Padding(4);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(146, 45);
            this.btnprint.TabIndex = 16;
            this.btnprint.Text = "PRINT";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(525, 143);
            this.btnview.Margin = new System.Windows.Forms.Padding(4);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(146, 41);
            this.btnview.TabIndex = 15;
            this.btnview.Text = "VIEW";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 21;
            // 
            // lblsbarcode
            // 
            this.lblsbarcode.AutoSize = true;
            this.lblsbarcode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsbarcode.Location = new System.Drawing.Point(938, 114);
            this.lblsbarcode.Name = "lblsbarcode";
            this.lblsbarcode.Size = new System.Drawing.Size(132, 16);
            this.lblsbarcode.TabIndex = 22;
            this.lblsbarcode.Text = "Sender\'s barcode";
            // 
            // txtsaddress
            // 
            this.txtsaddress.Location = new System.Drawing.Point(1124, 78);
            this.txtsaddress.Name = "txtsaddress";
            this.txtsaddress.Size = new System.Drawing.Size(154, 20);
            this.txtsaddress.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(204, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 45);
            this.button1.TabIndex = 25;
            this.button1.Text = "GENARATE BARCODE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbloutput.Location = new System.Drawing.Point(582, 98);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(31, 13);
            this.lbloutput.TabIndex = 26;
            this.lbloutput.Text = "Price";
            this.lbloutput.Click += new System.EventHandler(this.lbloutput_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(658, 448);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(128, 45);
            this.btnclear.TabIndex = 31;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(22, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 87);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(836, 448);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(119, 45);
            this.btnback.TabIndex = 32;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblsname
            // 
            this.lblsname.AutoSize = true;
            this.lblsname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsname.Location = new System.Drawing.Point(938, 51);
            this.lblsname.Name = "lblsname";
            this.lblsname.Size = new System.Drawing.Size(112, 16);
            this.lblsname.TabIndex = 34;
            this.lblsname.Text = "Sender\'s name";
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(1124, 44);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(154, 20);
            this.txtsname.TabIndex = 35;
            // 
            // lblsaddress
            // 
            this.lblsaddress.AutoSize = true;
            this.lblsaddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaddress.Location = new System.Drawing.Point(938, 78);
            this.lblsaddress.Name = "lblsaddress";
            this.lblsaddress.Size = new System.Drawing.Size(132, 16);
            this.lblsaddress.TabIndex = 37;
            this.lblsaddress.Text = "Sender\'s Address";
            // 
            // txtsbarcode
            // 
            this.txtsbarcode.Location = new System.Drawing.Point(1124, 114);
            this.txtsbarcode.Name = "txtsbarcode";
            this.txtsbarcode.Size = new System.Drawing.Size(154, 20);
            this.txtsbarcode.TabIndex = 39;
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(1076, 168);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(118, 40);
            this.btninsert.TabIndex = 41;
            this.btninsert.Text = "INSERT";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnnxt
            // 
            this.btnnxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnxt.Location = new System.Drawing.Point(1015, 448);
            this.btnnxt.Name = "btnnxt";
            this.btnnxt.Size = new System.Drawing.Size(109, 47);
            this.btnnxt.TabIndex = 42;
            this.btnnxt.Text = "NEXT";
            this.btnnxt.UseVisualStyleBackColor = false;
            this.btnnxt.Click += new System.EventHandler(this.btnnxt_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.product_hold_mail_img_lg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 562);
            this.Controls.Add(this.btnnxt);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtsbarcode);
            this.Controls.Add(this.lblsaddress);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.lblsname);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtsaddress);
            this.Controls.Add(this.lblsbarcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.lblbarcode);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.btnsearch);
            this.Name = "Form2";
            this.Text = "POST OFFICER";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblbarcode;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsbarcode;
        private System.Windows.Forms.TextBox txtsaddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblsname;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.Label lblsaddress;
        private System.Windows.Forms.TextBox txtsbarcode;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnnxt;
    }
}