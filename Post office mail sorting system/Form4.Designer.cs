namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.btninsert = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lbldes = new System.Windows.Forms.Label();
            this.lblsbarcode = new System.Windows.Forms.Label();
            this.lblrbarcode = new System.Windows.Forms.Label();
            this.txtsbarcode = new System.Windows.Forms.TextBox();
            this.txtrbarcode = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.RichTextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.btnclear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(62, 266);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(127, 36);
            this.btninsert.TabIndex = 0;
            this.btninsert.Text = "INSERT";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(255, 266);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(127, 36);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lbldes
            // 
            this.lbldes.AutoSize = true;
            this.lbldes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldes.Location = new System.Drawing.Point(59, 97);
            this.lbldes.Name = "lbldes";
            this.lbldes.Size = new System.Drawing.Size(87, 16);
            this.lbldes.TabIndex = 3;
            this.lbldes.Text = "Description";
            // 
            // lblsbarcode
            // 
            this.lblsbarcode.AutoSize = true;
            this.lblsbarcode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsbarcode.Location = new System.Drawing.Point(59, 29);
            this.lblsbarcode.Name = "lblsbarcode";
            this.lblsbarcode.Size = new System.Drawing.Size(183, 16);
            this.lblsbarcode.TabIndex = 4;
            this.lblsbarcode.Text = "Sender barcode/Address";
            // 
            // lblrbarcode
            // 
            this.lblrbarcode.AutoSize = true;
            this.lblrbarcode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblrbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrbarcode.Location = new System.Drawing.Point(59, 62);
            this.lblrbarcode.Name = "lblrbarcode";
            this.lblrbarcode.Size = new System.Drawing.Size(133, 16);
            this.lblrbarcode.TabIndex = 5;
            this.lblrbarcode.Text = "Receiver barcode";
            // 
            // txtsbarcode
            // 
            this.txtsbarcode.Location = new System.Drawing.Point(248, 28);
            this.txtsbarcode.Name = "txtsbarcode";
            this.txtsbarcode.Size = new System.Drawing.Size(289, 20);
            this.txtsbarcode.TabIndex = 8;
            // 
            // txtrbarcode
            // 
            this.txtrbarcode.Location = new System.Drawing.Point(248, 62);
            this.txtrbarcode.Name = "txtrbarcode";
            this.txtrbarcode.Size = new System.Drawing.Size(289, 20);
            this.txtrbarcode.TabIndex = 9;
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(248, 97);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(289, 96);
            this.txtdes.TabIndex = 10;
            this.txtdes.Text = "";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(59, 217);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(41, 16);
            this.lbldate.TabIndex = 11;
            this.lbldate.Text = "Date";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(248, 217);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(289, 20);
            this.txtdate.TabIndex = 12;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(433, 266);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(127, 36);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(623, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.product_hold_mail_img_lg;
            this.ClientSize = new System.Drawing.Size(1071, 572);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtrbarcode);
            this.Controls.Add(this.txtsbarcode);
            this.Controls.Add(this.lblrbarcode);
            this.Controls.Add(this.lblsbarcode);
            this.Controls.Add(this.lbldes);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btninsert);
            this.Name = "Form4";
            this.Text = "Returns";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lbldes;
        private System.Windows.Forms.Label lblsbarcode;
        private System.Windows.Forms.Label lblrbarcode;
        private System.Windows.Forms.TextBox txtsbarcode;
        private System.Windows.Forms.TextBox txtrbarcode;
        private System.Windows.Forms.RichTextBox txtdes;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button button1;
    }
}