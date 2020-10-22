namespace Anonymator
{
    partial class Anonymate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anonymate));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_ChangeDB = new System.Windows.Forms.Button();
            this.btn_NextTable = new System.Windows.Forms.Button();
            this.lbl_GV = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Anonymate_GV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anonymate_GV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Exit);
            this.groupBox1.Controls.Add(this.btn_Back);
            this.groupBox1.Controls.Add(this.btn_ChangeDB);
            this.groupBox1.Controls.Add(this.btn_NextTable);
            this.groupBox1.Controls.Add(this.lbl_GV);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Anonymate_GV);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Exit.Location = new System.Drawing.Point(452, 452);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(152, 22);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Back.Location = new System.Drawing.Point(7, 450);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(140, 23);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.TabStop = false;
            this.btn_Back.Text = "<< Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_ChangeDB
            // 
            this.btn_ChangeDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeDB.ForeColor = System.Drawing.Color.Maroon;
            this.btn_ChangeDB.Location = new System.Drawing.Point(298, 452);
            this.btn_ChangeDB.Name = "btn_ChangeDB";
            this.btn_ChangeDB.Size = new System.Drawing.Size(148, 21);
            this.btn_ChangeDB.TabIndex = 5;
            this.btn_ChangeDB.TabStop = false;
            this.btn_ChangeDB.Text = "Change Database";
            this.btn_ChangeDB.UseVisualStyleBackColor = true;
            this.btn_ChangeDB.Click += new System.EventHandler(this.btn_ChangeDB_Click);
            // 
            // btn_NextTable
            // 
            this.btn_NextTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NextTable.ForeColor = System.Drawing.Color.Maroon;
            this.btn_NextTable.Location = new System.Drawing.Point(153, 451);
            this.btn_NextTable.Name = "btn_NextTable";
            this.btn_NextTable.Size = new System.Drawing.Size(139, 22);
            this.btn_NextTable.TabIndex = 2;
            this.btn_NextTable.TabStop = false;
            this.btn_NextTable.Text = "Next Table";
            this.btn_NextTable.UseVisualStyleBackColor = true;
            this.btn_NextTable.Click += new System.EventHandler(this.btn_NextTable_Click);
            // 
            // lbl_GV
            // 
            this.lbl_GV.AutoSize = true;
            this.lbl_GV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GV.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_GV.Location = new System.Drawing.Point(241, 78);
            this.lbl_GV.Name = "lbl_GV";
            this.lbl_GV.Size = new System.Drawing.Size(150, 20);
            this.lbl_GV.TabIndex = 8;
            this.lbl_GV.Text = "Anonymized Data";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Save.Location = new System.Drawing.Point(616, 452);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(300, 21);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.TabStop = false;
            this.btn_Save.Text = "Export";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Anonymator.Properties.Resources.SaveData1;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(616, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 377);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Anonymate_GV
            // 
            this.Anonymate_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Anonymate_GV.Location = new System.Drawing.Point(7, 105);
            this.Anonymate_GV.Name = "Anonymate_GV";
            this.Anonymate_GV.ReadOnly = true;
            this.Anonymate_GV.Size = new System.Drawing.Size(597, 338);
            this.Anonymate_GV.TabIndex = 1;
            this.Anonymate_GV.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Title);
            this.groupBox2.Location = new System.Drawing.Point(1, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(921, 64);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Title.Location = new System.Drawing.Point(347, 14);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(260, 36);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Data Anonymator";
            // 
            // Anonymate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 514);
            this.Controls.Add(this.groupBox1);
            this.Name = "Anonymate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anonymate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Anonymate_FormClosed);
            this.Load += new System.EventHandler(this.Anonymate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anonymate_GV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DataGridView Anonymate_GV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_GV;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_ChangeDB;
        private System.Windows.Forms.Button btn_NextTable;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}