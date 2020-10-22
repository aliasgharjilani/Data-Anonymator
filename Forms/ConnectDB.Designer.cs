using System;

namespace Anonymator
{
    partial class ConnectDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectDB));
            this.txt_dSource = new System.Windows.Forms.TextBox();
            this.txt_dbName = new System.Windows.Forms.TextBox();
            this.txt_dbPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_Error = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lbl_dbUser = new System.Windows.Forms.Label();
            this.txt_dbUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_connecrDB = new System.Windows.Forms.Button();
            this.lbl_dbPass = new System.Windows.Forms.Label();
            this.lbl_dbName = new System.Windows.Forms.Label();
            this.lbl_DSource = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_dSource
            // 
            this.txt_dSource.Location = new System.Drawing.Point(268, 44);
            this.txt_dSource.Name = "txt_dSource";
            this.txt_dSource.Size = new System.Drawing.Size(118, 20);
            this.txt_dSource.TabIndex = 1;
            this.txt_dSource.Text = "DESKTOP-G2MHC42\\SQLEXPRESS";
            this.txt_dSource.TextChanged += new System.EventHandler(this.txt_dSource_TextChanged);
            // 
            // txt_dbName
            // 
            this.txt_dbName.Location = new System.Drawing.Point(268, 70);
            this.txt_dbName.Name = "txt_dbName";
            this.txt_dbName.Size = new System.Drawing.Size(118, 20);
            this.txt_dbName.TabIndex = 2;
            this.txt_dbName.Text = "SKhadmeen";
            // 
            // txt_dbPass
            // 
            this.txt_dbPass.Location = new System.Drawing.Point(268, 122);
            this.txt_dbPass.Name = "txt_dbPass";
            this.txt_dbPass.PasswordChar = '*';
            this.txt_dbPass.Size = new System.Drawing.Size(118, 20);
            this.txt_dbPass.TabIndex = 4;
            this.txt_dbPass.Text = "password123";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_Error);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.lbl_dbUser);
            this.panel1.Controls.Add(this.txt_dbUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_connecrDB);
            this.panel1.Controls.Add(this.lbl_dbPass);
            this.panel1.Controls.Add(this.lbl_dbName);
            this.panel1.Controls.Add(this.lbl_DSource);
            this.panel1.Controls.Add(this.txt_dbPass);
            this.panel1.Controls.Add(this.txt_dbName);
            this.panel1.Controls.Add(this.txt_dSource);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 224);
            this.panel1.TabIndex = 3;
            // 
            // pic_Error
            // 
            this.pic_Error.ErrorImage = null;
            this.pic_Error.Image = ((System.Drawing.Image)(resources.GetObject("pic_Error.Image")));
            this.pic_Error.Location = new System.Drawing.Point(156, 165);
            this.pic_Error.Name = "pic_Error";
            this.pic_Error.Size = new System.Drawing.Size(25, 25);
            this.pic_Error.TabIndex = 13;
            this.pic_Error.TabStop = false;
            this.pic_Error.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(179, 175);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // lbl_dbUser
            // 
            this.lbl_dbUser.AutoSize = true;
            this.lbl_dbUser.Location = new System.Drawing.Point(161, 99);
            this.lbl_dbUser.Name = "lbl_dbUser";
            this.lbl_dbUser.Size = new System.Drawing.Size(92, 13);
            this.lbl_dbUser.TabIndex = 10;
            this.lbl_dbUser.Text = "Database User ID";
            // 
            // txt_dbUser
            // 
            this.txt_dbUser.Location = new System.Drawing.Point(268, 96);
            this.txt_dbUser.Name = "txt_dbUser";
            this.txt_dbUser.Size = new System.Drawing.Size(118, 20);
            this.txt_dbUser.TabIndex = 3;
            this.txt_dbUser.Text = "KhadmeenUser";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(186, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Database Connection";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 190);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_connecrDB
            // 
            this.btn_connecrDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connecrDB.ForeColor = System.Drawing.Color.Maroon;
            this.btn_connecrDB.Location = new System.Drawing.Point(268, 148);
            this.btn_connecrDB.Name = "btn_connecrDB";
            this.btn_connecrDB.Size = new System.Drawing.Size(118, 23);
            this.btn_connecrDB.TabIndex = 5;
            this.btn_connecrDB.Text = "Connect Database";
            this.btn_connecrDB.UseVisualStyleBackColor = true;
            this.btn_connecrDB.Click += new System.EventHandler(this.btn_connecrDB_Click);
            // 
            // lbl_dbPass
            // 
            this.lbl_dbPass.AutoSize = true;
            this.lbl_dbPass.Location = new System.Drawing.Point(161, 125);
            this.lbl_dbPass.Name = "lbl_dbPass";
            this.lbl_dbPass.Size = new System.Drawing.Size(102, 13);
            this.lbl_dbPass.TabIndex = 5;
            this.lbl_dbPass.Text = "Database Password";
            // 
            // lbl_dbName
            // 
            this.lbl_dbName.AutoSize = true;
            this.lbl_dbName.Location = new System.Drawing.Point(161, 73);
            this.lbl_dbName.Name = "lbl_dbName";
            this.lbl_dbName.Size = new System.Drawing.Size(84, 13);
            this.lbl_dbName.TabIndex = 4;
            this.lbl_dbName.Text = "Database Name";
            // 
            // lbl_DSource
            // 
            this.lbl_DSource.AutoSize = true;
            this.lbl_DSource.Location = new System.Drawing.Point(161, 47);
            this.lbl_DSource.Name = "lbl_DSource";
            this.lbl_DSource.Size = new System.Drawing.Size(67, 13);
            this.lbl_DSource.TabIndex = 3;
            this.lbl_DSource.Text = "Data Source";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_Title);
            this.panel2.Location = new System.Drawing.Point(12, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 62);
            this.panel2.TabIndex = 4;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Title.Location = new System.Drawing.Point(76, 14);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(260, 36);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Data Anonymator";
            // 
            // ConnectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 310);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ConnectDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Database";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnectDB_FormClosed);
            this.Load += new System.EventHandler(this.ConnectDB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

         #endregion

        private System.Windows.Forms.TextBox txt_dSource;
        private System.Windows.Forms.TextBox txt_dbName;
        private System.Windows.Forms.TextBox txt_dbPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_connecrDB;
        private System.Windows.Forms.Label lbl_dbPass;
        private System.Windows.Forms.Label lbl_dbName;
        private System.Windows.Forms.Label lbl_DSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_dbUser;
        private System.Windows.Forms.TextBox txt_dbUser;
        private System.Windows.Forms.PictureBox pic_Error;
        private System.Windows.Forms.Label lblError;
    }
}