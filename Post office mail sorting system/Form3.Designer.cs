namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblbarcode = new System.Windows.Forms.Label();
            this.lblmobile = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(12, 302);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(150, 52);
            this.btninsert.TabIndex = 0;
            this.btninsert.Text = "INSERT";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(193, 302);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(155, 52);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(215, 29);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(55, 20);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Name";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(215, 65);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(75, 20);
            this.lbladdress.TabIndex = 4;
            this.lbladdress.Text = "Address";
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarcode.Location = new System.Drawing.Point(214, 119);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(76, 20);
            this.lblbarcode.TabIndex = 5;
            this.lblbarcode.Text = "Barcode";
            // 
            // lblmobile
            // 
            this.lblmobile.AutoSize = true;
            this.lblmobile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmobile.Location = new System.Drawing.Point(214, 162);
            this.lblmobile.Name = "lblmobile";
            this.lblmobile.Size = new System.Drawing.Size(61, 20);
            this.lblmobile.TabIndex = 6;
            this.lblmobile.Text = "Mobile";
            this.lblmobile.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(337, 29);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(286, 20);
            this.txtname.TabIndex = 7;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(337, 65);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(286, 20);
            this.txtaddress.TabIndex = 8;
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(337, 121);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(286, 20);
            this.txtbarcode.TabIndex = 9;
            // 
            // txtmobile
            // 
            this.txtmobile.Location = new System.Drawing.Point(337, 164);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(286, 20);
            this.txtmobile.TabIndex = 10;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(623, 302);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(145, 52);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(397, 302);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(158, 52);
            this.btnsearch.TabIndex = 12;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(397, 402);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(158, 56);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(623, 402);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(145, 56);
            this.btnback.TabIndex = 14;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.product_hold_mail_img_lg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 503);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblmobile);
            this.Controls.Add(this.lblbarcode);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Name = "Form3";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblbarcode;
        private System.Windows.Forms.Label lblmobile;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnback;
    }
}