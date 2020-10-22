namespace Anonymator
{
    partial class columnSelect
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbAlphaNumericOptions = new System.Windows.Forms.GroupBox();
            this.radbtn_IntegerAlphaNum = new System.Windows.Forms.RadioButton();
            this.radbtn_UpperAlphaNum = new System.Windows.Forms.RadioButton();
            this.radbtn_LowerAlphaNum = new System.Windows.Forms.RadioButton();
            this.radbtn_InitAlphaNum = new System.Windows.Forms.RadioButton();
            this.gbAlphaOptions = new System.Windows.Forms.GroupBox();
            this.radbtn_InitAlpha = new System.Windows.Forms.RadioButton();
            this.radbtn_LowerAlpha = new System.Windows.Forms.RadioButton();
            this.radbtn_UpperAlpha = new System.Windows.Forms.RadioButton();
            this.gbDateOptions = new System.Windows.Forms.GroupBox();
            this.cbDateOptionsOffsetUnit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nupDateOffset = new System.Windows.Forms.NumericUpDown();
            this.radbtn_BothDate = new System.Windows.Forms.RadioButton();
            this.radbtn_FutureDate = new System.Windows.Forms.RadioButton();
            this.radbtn_PastDate = new System.Windows.Forms.RadioButton();
            this.gbNumricOptions = new System.Windows.Forms.GroupBox();
            this.radbtn_MatchInteger = new System.Windows.Forms.RadioButton();
            this.nupPercentInteger = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nupMaxInteger = new System.Windows.Forms.NumericUpDown();
            this.nupMinInteger = new System.Windows.Forms.NumericUpDown();
            this.radbtn_PercentInteger = new System.Windows.Forms.RadioButton();
            this.radbtn_RangeInteger = new System.Windows.Forms.RadioButton();
            this.pb_Deselect = new System.Windows.Forms.PictureBox();
            this.pb_Select = new System.Windows.Forms.PictureBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Anonymize = new System.Windows.Forms.Button();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.lbl_Attribute = new System.Windows.Forms.Label();
            this.columnList = new System.Windows.Forms.ListBox();
            this.lbl_Anonymizer = new System.Windows.Forms.Label();
            this.cmb_Anonymizer = new System.Windows.Forms.ComboBox();
            this.lv_AnonymizerDetails = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_SubTitle = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.gbAlphaNumericOptions.SuspendLayout();
            this.gbAlphaOptions.SuspendLayout();
            this.gbDateOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDateOffset)).BeginInit();
            this.gbNumricOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPercentInteger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMaxInteger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinInteger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Deselect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Select)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Title);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 75);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(463, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Table Mapping";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Title.Location = new System.Drawing.Point(401, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(260, 36);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Data Anonymator";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.label4);
            this.gbMain.Controls.Add(this.gbAlphaNumericOptions);
            this.gbMain.Controls.Add(this.gbAlphaOptions);
            this.gbMain.Controls.Add(this.gbDateOptions);
            this.gbMain.Controls.Add(this.gbNumricOptions);
            this.gbMain.Controls.Add(this.pb_Deselect);
            this.gbMain.Controls.Add(this.pb_Select);
            this.gbMain.Controls.Add(this.btn_Back);
            this.gbMain.Controls.Add(this.btn_Anonymize);
            this.gbMain.Controls.Add(this.btn_Preview);
            this.gbMain.Controls.Add(this.lbl_Attribute);
            this.gbMain.Controls.Add(this.columnList);
            this.gbMain.Controls.Add(this.lbl_Anonymizer);
            this.gbMain.Controls.Add(this.cmb_Anonymizer);
            this.gbMain.Controls.Add(this.lv_AnonymizerDetails);
            this.gbMain.Controls.Add(this.groupBox4);
            this.gbMain.Location = new System.Drawing.Point(13, 80);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(1001, 531);
            this.gbMain.TabIndex = 27;
            this.gbMain.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(500, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Mapping Details";
            // 
            // gbAlphaNumericOptions
            // 
            this.gbAlphaNumericOptions.Controls.Add(this.radbtn_IntegerAlphaNum);
            this.gbAlphaNumericOptions.Controls.Add(this.radbtn_UpperAlphaNum);
            this.gbAlphaNumericOptions.Controls.Add(this.radbtn_LowerAlphaNum);
            this.gbAlphaNumericOptions.Controls.Add(this.radbtn_InitAlphaNum);
            this.gbAlphaNumericOptions.Location = new System.Drawing.Point(588, 424);
            this.gbAlphaNumericOptions.Name = "gbAlphaNumericOptions";
            this.gbAlphaNumericOptions.Size = new System.Drawing.Size(179, 99);
            this.gbAlphaNumericOptions.TabIndex = 56;
            this.gbAlphaNumericOptions.TabStop = false;
            this.gbAlphaNumericOptions.Text = "AlphaNumeric Options";
            // 
            // radbtn_IntegerAlphaNum
            // 
            this.radbtn_IntegerAlphaNum.AutoSize = true;
            this.radbtn_IntegerAlphaNum.Location = new System.Drawing.Point(7, 39);
            this.radbtn_IntegerAlphaNum.Name = "radbtn_IntegerAlphaNum";
            this.radbtn_IntegerAlphaNum.Size = new System.Drawing.Size(82, 17);
            this.radbtn_IntegerAlphaNum.TabIndex = 15;
            this.radbtn_IntegerAlphaNum.TabStop = true;
            this.radbtn_IntegerAlphaNum.Text = "Integer Only";
            this.radbtn_IntegerAlphaNum.UseVisualStyleBackColor = true;
            // 
            // radbtn_UpperAlphaNum
            // 
            this.radbtn_UpperAlphaNum.AutoSize = true;
            this.radbtn_UpperAlphaNum.Location = new System.Drawing.Point(7, 77);
            this.radbtn_UpperAlphaNum.Name = "radbtn_UpperAlphaNum";
            this.radbtn_UpperAlphaNum.Size = new System.Drawing.Size(81, 17);
            this.radbtn_UpperAlphaNum.TabIndex = 16;
            this.radbtn_UpperAlphaNum.Text = "Upper Case";
            this.radbtn_UpperAlphaNum.UseVisualStyleBackColor = true;
            // 
            // radbtn_LowerAlphaNum
            // 
            this.radbtn_LowerAlphaNum.AutoSize = true;
            this.radbtn_LowerAlphaNum.Location = new System.Drawing.Point(7, 58);
            this.radbtn_LowerAlphaNum.Name = "radbtn_LowerAlphaNum";
            this.radbtn_LowerAlphaNum.Size = new System.Drawing.Size(81, 17);
            this.radbtn_LowerAlphaNum.TabIndex = 1;
            this.radbtn_LowerAlphaNum.TabStop = true;
            this.radbtn_LowerAlphaNum.Text = "Lower Case";
            this.radbtn_LowerAlphaNum.UseVisualStyleBackColor = true;
            // 
            // radbtn_InitAlphaNum
            // 
            this.radbtn_InitAlphaNum.AutoSize = true;
            this.radbtn_InitAlphaNum.Checked = true;
            this.radbtn_InitAlphaNum.Location = new System.Drawing.Point(7, 20);
            this.radbtn_InitAlphaNum.Name = "radbtn_InitAlphaNum";
            this.radbtn_InitAlphaNum.Size = new System.Drawing.Size(66, 17);
            this.radbtn_InitAlphaNum.TabIndex = 0;
            this.radbtn_InitAlphaNum.Text = "Init Case";
            this.radbtn_InitAlphaNum.UseVisualStyleBackColor = true;
            // 
            // gbAlphaOptions
            // 
            this.gbAlphaOptions.Controls.Add(this.radbtn_InitAlpha);
            this.gbAlphaOptions.Controls.Add(this.radbtn_LowerAlpha);
            this.gbAlphaOptions.Controls.Add(this.radbtn_UpperAlpha);
            this.gbAlphaOptions.Location = new System.Drawing.Point(391, 426);
            this.gbAlphaOptions.Name = "gbAlphaOptions";
            this.gbAlphaOptions.Size = new System.Drawing.Size(179, 99);
            this.gbAlphaOptions.TabIndex = 55;
            this.gbAlphaOptions.TabStop = false;
            this.gbAlphaOptions.Text = "Alpha Options";
            // 
            // radbtn_InitAlpha
            // 
            this.radbtn_InitAlpha.AutoSize = true;
            this.radbtn_InitAlpha.Checked = true;
            this.radbtn_InitAlpha.Location = new System.Drawing.Point(7, 19);
            this.radbtn_InitAlpha.Name = "radbtn_InitAlpha";
            this.radbtn_InitAlpha.Size = new System.Drawing.Size(66, 17);
            this.radbtn_InitAlpha.TabIndex = 12;
            this.radbtn_InitAlpha.TabStop = true;
            this.radbtn_InitAlpha.Text = "Init Case";
            this.radbtn_InitAlpha.UseVisualStyleBackColor = true;
            // 
            // radbtn_LowerAlpha
            // 
            this.radbtn_LowerAlpha.AutoSize = true;
            this.radbtn_LowerAlpha.Location = new System.Drawing.Point(6, 42);
            this.radbtn_LowerAlpha.Name = "radbtn_LowerAlpha";
            this.radbtn_LowerAlpha.Size = new System.Drawing.Size(81, 17);
            this.radbtn_LowerAlpha.TabIndex = 13;
            this.radbtn_LowerAlpha.Text = "Lower Case";
            this.radbtn_LowerAlpha.UseVisualStyleBackColor = true;
            // 
            // radbtn_UpperAlpha
            // 
            this.radbtn_UpperAlpha.AutoSize = true;
            this.radbtn_UpperAlpha.Location = new System.Drawing.Point(7, 65);
            this.radbtn_UpperAlpha.Name = "radbtn_UpperAlpha";
            this.radbtn_UpperAlpha.Size = new System.Drawing.Size(81, 17);
            this.radbtn_UpperAlpha.TabIndex = 14;
            this.radbtn_UpperAlpha.Text = "Upper Case";
            this.radbtn_UpperAlpha.UseVisualStyleBackColor = true;
            // 
            // gbDateOptions
            // 
            this.gbDateOptions.Controls.Add(this.cbDateOptionsOffsetUnit);
            this.gbDateOptions.Controls.Add(this.label5);
            this.gbDateOptions.Controls.Add(this.nupDateOffset);
            this.gbDateOptions.Controls.Add(this.radbtn_BothDate);
            this.gbDateOptions.Controls.Add(this.radbtn_FutureDate);
            this.gbDateOptions.Controls.Add(this.radbtn_PastDate);
            this.gbDateOptions.Location = new System.Drawing.Point(191, 429);
            this.gbDateOptions.Name = "gbDateOptions";
            this.gbDateOptions.Size = new System.Drawing.Size(179, 99);
            this.gbDateOptions.TabIndex = 54;
            this.gbDateOptions.TabStop = false;
            this.gbDateOptions.Text = "Date Options";
            // 
            // cbDateOptionsOffsetUnit
            // 
            this.cbDateOptionsOffsetUnit.FormattingEnabled = true;
            this.cbDateOptionsOffsetUnit.Items.AddRange(new object[] {
            "Years",
            "Months"});
            this.cbDateOptionsOffsetUnit.Location = new System.Drawing.Point(117, 49);
            this.cbDateOptionsOffsetUnit.Name = "cbDateOptionsOffsetUnit";
            this.cbDateOptionsOffsetUnit.Size = new System.Drawing.Size(56, 21);
            this.cbDateOptionsOffsetUnit.TabIndex = 12;
            this.cbDateOptionsOffsetUnit.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Offset:";
            // 
            // nupDateOffset
            // 
            this.nupDateOffset.Location = new System.Drawing.Point(52, 50);
            this.nupDateOffset.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupDateOffset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupDateOffset.Name = "nupDateOffset";
            this.nupDateOffset.Size = new System.Drawing.Size(62, 20);
            this.nupDateOffset.TabIndex = 11;
            this.nupDateOffset.TabStop = false;
            this.nupDateOffset.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radbtn_BothDate
            // 
            this.radbtn_BothDate.AutoSize = true;
            this.radbtn_BothDate.Checked = true;
            this.radbtn_BothDate.Location = new System.Drawing.Point(126, 20);
            this.radbtn_BothDate.Name = "radbtn_BothDate";
            this.radbtn_BothDate.Size = new System.Drawing.Size(47, 17);
            this.radbtn_BothDate.TabIndex = 10;
            this.radbtn_BothDate.TabStop = true;
            this.radbtn_BothDate.Text = "Both";
            this.radbtn_BothDate.UseVisualStyleBackColor = true;
            // 
            // radbtn_FutureDate
            // 
            this.radbtn_FutureDate.AutoSize = true;
            this.radbtn_FutureDate.Location = new System.Drawing.Point(59, 21);
            this.radbtn_FutureDate.Name = "radbtn_FutureDate";
            this.radbtn_FutureDate.Size = new System.Drawing.Size(55, 17);
            this.radbtn_FutureDate.TabIndex = 8;
            this.radbtn_FutureDate.Text = "Future";
            this.radbtn_FutureDate.UseVisualStyleBackColor = true;
            // 
            // radbtn_PastDate
            // 
            this.radbtn_PastDate.AutoSize = true;
            this.radbtn_PastDate.Location = new System.Drawing.Point(7, 20);
            this.radbtn_PastDate.Name = "radbtn_PastDate";
            this.radbtn_PastDate.Size = new System.Drawing.Size(46, 17);
            this.radbtn_PastDate.TabIndex = 7;
            this.radbtn_PastDate.Text = "Past";
            this.radbtn_PastDate.UseVisualStyleBackColor = true;
            // 
            // gbNumricOptions
            // 
            this.gbNumricOptions.Controls.Add(this.radbtn_MatchInteger);
            this.gbNumricOptions.Controls.Add(this.nupPercentInteger);
            this.gbNumricOptions.Controls.Add(this.label3);
            this.gbNumricOptions.Controls.Add(this.label2);
            this.gbNumricOptions.Controls.Add(this.nupMaxInteger);
            this.gbNumricOptions.Controls.Add(this.nupMinInteger);
            this.gbNumricOptions.Controls.Add(this.radbtn_PercentInteger);
            this.gbNumricOptions.Controls.Add(this.radbtn_RangeInteger);
            this.gbNumricOptions.Location = new System.Drawing.Point(6, 424);
            this.gbNumricOptions.Name = "gbNumricOptions";
            this.gbNumricOptions.Size = new System.Drawing.Size(179, 101);
            this.gbNumricOptions.TabIndex = 53;
            this.gbNumricOptions.TabStop = false;
            this.gbNumricOptions.Text = "Numeric Options";
            // 
            // radbtn_MatchInteger
            // 
            this.radbtn_MatchInteger.AutoSize = true;
            this.radbtn_MatchInteger.Checked = true;
            this.radbtn_MatchInteger.Location = new System.Drawing.Point(10, 16);
            this.radbtn_MatchInteger.Name = "radbtn_MatchInteger";
            this.radbtn_MatchInteger.Size = new System.Drawing.Size(78, 17);
            this.radbtn_MatchInteger.TabIndex = 61;
            this.radbtn_MatchInteger.TabStop = true;
            this.radbtn_MatchInteger.Text = "Match Size";
            this.radbtn_MatchInteger.UseVisualStyleBackColor = true;
            // 
            // nupPercentInteger
            // 
            this.nupPercentInteger.Location = new System.Drawing.Point(99, 78);
            this.nupPercentInteger.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPercentInteger.Name = "nupPercentInteger";
            this.nupPercentInteger.Size = new System.Drawing.Size(74, 20);
            this.nupPercentInteger.TabIndex = 60;
            this.nupPercentInteger.TabStop = false;
            this.nupPercentInteger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Min";
            // 
            // nupMaxInteger
            // 
            this.nupMaxInteger.Location = new System.Drawing.Point(99, 56);
            this.nupMaxInteger.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupMaxInteger.Name = "nupMaxInteger";
            this.nupMaxInteger.Size = new System.Drawing.Size(74, 20);
            this.nupMaxInteger.TabIndex = 57;
            this.nupMaxInteger.TabStop = false;
            // 
            // nupMinInteger
            // 
            this.nupMinInteger.Location = new System.Drawing.Point(99, 35);
            this.nupMinInteger.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupMinInteger.Name = "nupMinInteger";
            this.nupMinInteger.Size = new System.Drawing.Size(74, 20);
            this.nupMinInteger.TabIndex = 56;
            this.nupMinInteger.TabStop = false;
            // 
            // radbtn_PercentInteger
            // 
            this.radbtn_PercentInteger.AutoSize = true;
            this.radbtn_PercentInteger.Location = new System.Drawing.Point(10, 80);
            this.radbtn_PercentInteger.Name = "radbtn_PercentInteger";
            this.radbtn_PercentInteger.Size = new System.Drawing.Size(80, 17);
            this.radbtn_PercentInteger.TabIndex = 55;
            this.radbtn_PercentInteger.Text = "Percentage";
            this.radbtn_PercentInteger.UseVisualStyleBackColor = true;
            // 
            // radbtn_RangeInteger
            // 
            this.radbtn_RangeInteger.AutoSize = true;
            this.radbtn_RangeInteger.Location = new System.Drawing.Point(10, 46);
            this.radbtn_RangeInteger.Name = "radbtn_RangeInteger";
            this.radbtn_RangeInteger.Size = new System.Drawing.Size(57, 17);
            this.radbtn_RangeInteger.TabIndex = 54;
            this.radbtn_RangeInteger.Text = "Range";
            this.radbtn_RangeInteger.UseVisualStyleBackColor = true;
            // 
            // pb_Deselect
            // 
            this.pb_Deselect.Image = global::Anonymator.Properties.Resources.Deselect11;
            this.pb_Deselect.Location = new System.Drawing.Point(439, 143);
            this.pb_Deselect.Name = "pb_Deselect";
            this.pb_Deselect.Size = new System.Drawing.Size(50, 50);
            this.pb_Deselect.TabIndex = 52;
            this.pb_Deselect.TabStop = false;
            this.pb_Deselect.Click += new System.EventHandler(this.pb_Deselect_Click);
            // 
            // pb_Select
            // 
            this.pb_Select.Image = global::Anonymator.Properties.Resources.Select11;
            this.pb_Select.InitialImage = global::Anonymator.Properties.Resources.Select;
            this.pb_Select.Location = new System.Drawing.Point(439, 91);
            this.pb_Select.Name = "pb_Select";
            this.pb_Select.Size = new System.Drawing.Size(50, 50);
            this.pb_Select.TabIndex = 51;
            this.pb_Select.TabStop = false;
            this.pb_Select.Click += new System.EventHandler(this.pb_Select_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Back.Location = new System.Drawing.Point(493, 332);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(247, 23);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "<< Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Anonymize
            // 
            this.btn_Anonymize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Anonymize.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Anonymize.Location = new System.Drawing.Point(493, 361);
            this.btn_Anonymize.Name = "btn_Anonymize";
            this.btn_Anonymize.Size = new System.Drawing.Size(494, 23);
            this.btn_Anonymize.TabIndex = 6;
            this.btn_Anonymize.Text = "Anonymize";
            this.btn_Anonymize.UseVisualStyleBackColor = true;
            this.btn_Anonymize.Click += new System.EventHandler(this.btn_Anonymize_Click);
            // 
            // btn_Preview
            // 
            this.btn_Preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Preview.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Preview.Location = new System.Drawing.Point(756, 332);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(231, 23);
            this.btn_Preview.TabIndex = 5;
            this.btn_Preview.Text = "Preview";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // lbl_Attribute
            // 
            this.lbl_Attribute.AutoSize = true;
            this.lbl_Attribute.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Attribute.Location = new System.Drawing.Point(258, 36);
            this.lbl_Attribute.Name = "lbl_Attribute";
            this.lbl_Attribute.Size = new System.Drawing.Size(79, 13);
            this.lbl_Attribute.TabIndex = 47;
            this.lbl_Attribute.Text = "Select Attribute";
            // 
            // columnList
            // 
            this.columnList.FormattingEnabled = true;
            this.columnList.Location = new System.Drawing.Point(256, 52);
            this.columnList.Name = "columnList";
            this.columnList.Size = new System.Drawing.Size(179, 186);
            this.columnList.TabIndex = 1;
            // 
            // lbl_Anonymizer
            // 
            this.lbl_Anonymizer.AutoSize = true;
            this.lbl_Anonymizer.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Anonymizer.Location = new System.Drawing.Point(259, 241);
            this.lbl_Anonymizer.Name = "lbl_Anonymizer";
            this.lbl_Anonymizer.Size = new System.Drawing.Size(94, 13);
            this.lbl_Anonymizer.TabIndex = 45;
            this.lbl_Anonymizer.Text = "Select Anonymizer";
            // 
            // cmb_Anonymizer
            // 
            this.cmb_Anonymizer.FormattingEnabled = true;
            this.cmb_Anonymizer.Location = new System.Drawing.Point(257, 257);
            this.cmb_Anonymizer.Name = "cmb_Anonymizer";
            this.cmb_Anonymizer.Size = new System.Drawing.Size(179, 21);
            this.cmb_Anonymizer.TabIndex = 2;
            this.cmb_Anonymizer.TabStop = false;
            this.cmb_Anonymizer.Text = "Choose Anonymator";
            this.cmb_Anonymizer.SelectedIndexChanged += new System.EventHandler(this.cmb_Anonymizer_SelectedIndexChanged);
            // 
            // lv_AnonymizerDetails
            // 
            this.lv_AnonymizerDetails.FullRowSelect = true;
            this.lv_AnonymizerDetails.HideSelection = false;
            this.lv_AnonymizerDetails.Location = new System.Drawing.Point(493, 52);
            this.lv_AnonymizerDetails.MultiSelect = false;
            this.lv_AnonymizerDetails.Name = "lv_AnonymizerDetails";
            this.lv_AnonymizerDetails.Size = new System.Drawing.Size(494, 274);
            this.lv_AnonymizerDetails.TabIndex = 3;
            this.lv_AnonymizerDetails.UseCompatibleStateImageBehavior = false;
            this.lv_AnonymizerDetails.View = System.Windows.Forms.View.Details;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.lbl_SubTitle);
            this.groupBox4.Location = new System.Drawing.Point(250, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(751, 33);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(2, 52);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(524, 303);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(12, 52);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(524, 304);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // lbl_SubTitle
            // 
            this.lbl_SubTitle.AutoSize = true;
            this.lbl_SubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_SubTitle.Location = new System.Drawing.Point(7, 12);
            this.lbl_SubTitle.Name = "lbl_SubTitle";
            this.lbl_SubTitle.Size = new System.Drawing.Size(75, 13);
            this.lbl_SubTitle.TabIndex = 19;
            this.lbl_SubTitle.Text = "Table Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 392);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Anonymator.Properties.Resources.Mapping_2;
            this.pictureBox1.Location = new System.Drawing.Point(1, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 378);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // columnSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 620);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.groupBox1);
            this.Name = "columnSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapping";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.columnSelect_FormClosed);
            this.Load += new System.EventHandler(this.columnSelect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbAlphaNumericOptions.ResumeLayout(false);
            this.gbAlphaNumericOptions.PerformLayout();
            this.gbAlphaOptions.ResumeLayout(false);
            this.gbAlphaOptions.PerformLayout();
            this.gbDateOptions.ResumeLayout(false);
            this.gbDateOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDateOffset)).EndInit();
            this.gbNumricOptions.ResumeLayout(false);
            this.gbNumricOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPercentInteger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMaxInteger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinInteger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Deselect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Select)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl_SubTitle;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_Anonymize;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Label lbl_Attribute;
        private System.Windows.Forms.ListBox columnList;
        private System.Windows.Forms.Label lbl_Anonymizer;
        private System.Windows.Forms.ComboBox cmb_Anonymizer;
        private System.Windows.Forms.ListView lv_AnonymizerDetails;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.PictureBox pb_Deselect;
        private System.Windows.Forms.PictureBox pb_Select;
        private System.Windows.Forms.GroupBox gbAlphaNumericOptions;
        private System.Windows.Forms.RadioButton radbtn_IntegerAlphaNum;
        private System.Windows.Forms.RadioButton radbtn_UpperAlphaNum;
        private System.Windows.Forms.RadioButton radbtn_LowerAlphaNum;
        private System.Windows.Forms.RadioButton radbtn_InitAlphaNum;
        private System.Windows.Forms.GroupBox gbAlphaOptions;
        private System.Windows.Forms.RadioButton radbtn_InitAlpha;
        private System.Windows.Forms.RadioButton radbtn_LowerAlpha;
        private System.Windows.Forms.RadioButton radbtn_UpperAlpha;
        private System.Windows.Forms.GroupBox gbDateOptions;
        private System.Windows.Forms.RadioButton radbtn_FutureDate;
        private System.Windows.Forms.RadioButton radbtn_PastDate;
        private System.Windows.Forms.GroupBox gbNumricOptions;
        private System.Windows.Forms.RadioButton radbtn_PercentInteger;
        private System.Windows.Forms.RadioButton radbtn_RangeInteger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupMaxInteger;
        private System.Windows.Forms.NumericUpDown nupMinInteger;
        private System.Windows.Forms.NumericUpDown nupPercentInteger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupDateOffset;
        private System.Windows.Forms.RadioButton radbtn_BothDate;
        private System.Windows.Forms.RadioButton radbtn_MatchInteger;
        private System.Windows.Forms.ComboBox cbDateOptionsOffsetUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}