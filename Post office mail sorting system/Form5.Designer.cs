namespace WindowsFormsApplication1
{
    partial class Form5
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
            this.btnmailing = new System.Windows.Forms.Button();
            this.btnchecking = new System.Windows.Forms.Button();
            this.btnsorting = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmailing
            // 
            this.btnmailing.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmailing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmailing.Location = new System.Drawing.Point(29, 228);
            this.btnmailing.Name = "btnmailing";
            this.btnmailing.Size = new System.Drawing.Size(132, 37);
            this.btnmailing.TabIndex = 0;
            this.btnmailing.Text = "MAILING";
            this.btnmailing.UseVisualStyleBackColor = false;
            this.btnmailing.Click += new System.EventHandler(this.btnmailing_Click);
            // 
            // btnchecking
            // 
            this.btnchecking.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnchecking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchecking.Location = new System.Drawing.Point(223, 228);
            this.btnchecking.Name = "btnchecking";
            this.btnchecking.Size = new System.Drawing.Size(151, 37);
            this.btnchecking.TabIndex = 1;
            this.btnchecking.Text = "CHECKING";
            this.btnchecking.UseVisualStyleBackColor = false;
            this.btnchecking.Click += new System.EventHandler(this.btnchecking_Click);
            // 
            // btnsorting
            // 
            this.btnsorting.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsorting.Location = new System.Drawing.Point(420, 228);
            this.btnsorting.Name = "btnsorting";
            this.btnsorting.Size = new System.Drawing.Size(158, 40);
            this.btnsorting.TabIndex = 2;
            this.btnsorting.Text = "SORTING";
            this.btnsorting.UseVisualStyleBackColor = false;
            this.btnsorting.Click += new System.EventHandler(this.btnsorting_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.sorting31;
            this.pictureBox3.Location = new System.Drawing.Point(433, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 143);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.checking;
            this.pictureBox2.Location = new System.Drawing.Point(223, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 143);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.mailing2;
            this.pictureBox1.Location = new System.Drawing.Point(29, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 143);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(599, 353);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsorting);
            this.Controls.Add(this.btnchecking);
            this.Controls.Add(this.btnmailing);
            this.Name = "Form5";
            this.Text = "START";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmailing;
        private System.Windows.Forms.Button btnchecking;
        private System.Windows.Forms.Button btnsorting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}