namespace Anonymator
{
    partial class tableSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tableSelect));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.lbl_Table = new System.Windows.Forms.Label();
            this.tableList = new System.Windows.Forms.ListBox();
            this.lbl_SubTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_selectTable = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Title1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_Title);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 62);
            this.panel2.TabIndex = 6;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Title.Location = new System.Drawing.Point(118, 14);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(260, 36);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Data Anonymator";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_disconnect);
            this.panel1.Controls.Add(this.lbl_Table);
            this.panel1.Controls.Add(this.tableList);
            this.panel1.Controls.Add(this.lbl_SubTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_selectTable);
            this.panel1.Location = new System.Drawing.Point(12, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 301);
            this.panel1.TabIndex = 5;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disconnect.ForeColor = System.Drawing.Color.Maroon;
            this.btn_disconnect.Location = new System.Drawing.Point(258, 270);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(103, 23);
            this.btn_disconnect.TabIndex = 2;
            this.btn_disconnect.Text = "<< Back";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // lbl_Table
            // 
            this.lbl_Table.AutoSize = true;
            this.lbl_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Table.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Table.Location = new System.Drawing.Point(256, 37);
            this.lbl_Table.Name = "lbl_Table";
            this.lbl_Table.Size = new System.Drawing.Size(70, 13);
            this.lbl_Table.TabIndex = 10;
            this.lbl_Table.Text = "List of Tables";
            // 
            // tableList
            // 
            this.tableList.FormattingEnabled = true;
            this.tableList.Location = new System.Drawing.Point(258, 53);
            this.tableList.Name = "tableList";
            this.tableList.Size = new System.Drawing.Size(209, 212);
            this.tableList.TabIndex = 1;
            // 
            // lbl_SubTitle
            // 
            this.lbl_SubTitle.AutoSize = true;
            this.lbl_SubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_SubTitle.Location = new System.Drawing.Point(256, 9);
            this.lbl_SubTitle.Name = "lbl_SubTitle";
            this.lbl_SubTitle.Size = new System.Drawing.Size(101, 13);
            this.lbl_SubTitle.TabIndex = 8;
            this.lbl_SubTitle.Text = "Database Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 300);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_selectTable
            // 
            this.btn_selectTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectTable.ForeColor = System.Drawing.Color.Maroon;
            this.btn_selectTable.Location = new System.Drawing.Point(367, 270);
            this.btn_selectTable.Name = "btn_selectTable";
            this.btn_selectTable.Size = new System.Drawing.Size(100, 23);
            this.btn_selectTable.TabIndex = 3;
            this.btn_selectTable.Text = "Select >>";
            this.btn_selectTable.UseVisualStyleBackColor = true;
            this.btn_selectTable.Click += new System.EventHandler(this.btn_selectTable_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_Title1);
            this.panel3.Location = new System.Drawing.Point(13, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 30);
            this.panel3.TabIndex = 7;
            // 
            // lbl_Title1
            // 
            this.lbl_Title1.AutoSize = true;
            this.lbl_Title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title1.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Title1.Location = new System.Drawing.Point(157, 5);
            this.lbl_Title1.Name = "lbl_Title1";
            this.lbl_Title1.Size = new System.Drawing.Size(179, 20);
            this.lbl_Title1.TabIndex = 0;
            this.lbl_Title1.Text = "Database Tables List";
            // 
            // tableSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 427);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "tableSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Tables List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tableSelect_FormClosed);
            this.Load += new System.EventHandler(this.tableSelect_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_SubTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_selectTable;
        private System.Windows.Forms.ListBox tableList;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Label lbl_Table;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Title1;
    }
}