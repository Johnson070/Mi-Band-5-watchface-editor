namespace MiBand5WatchFaces.Forms
{
    partial class DateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MonthDayYearTab = new System.Windows.Forms.TabPage();
            this.TwoDigitsDayCheckbox = new System.Windows.Forms.CheckBox();
            this.TwoDigitsMonthCheckbox = new System.Windows.Forms.CheckBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.separateTab = new System.Windows.Forms.TabPage();
            this.SeparateMonthDayCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddDaySeparateButton = new System.Windows.Forms.Button();
            this.AddMonthSeparateButton = new System.Windows.Forms.Button();
            this.AddMonthImagesSeparateButton = new System.Windows.Forms.Button();
            this.onelineTab = new System.Windows.Forms.TabPage();
            this.OnelineMonthDayCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddOnelineDelimeterImageButton = new System.Windows.Forms.Button();
            this.AddMonthAndDayOnelineButton = new System.Windows.Forms.Button();
            this.onelinewithyearTab = new System.Windows.Forms.TabPage();
            this.OnelineWithYearCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addOnelineWithYearDelimeterImageButton = new System.Windows.Forms.Button();
            this.addOnelineWithYearMonthDayYearButton = new System.Windows.Forms.Button();
            this.AmPmTab = new System.Windows.Forms.TabPage();
            this.AmPmCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.posYNumAMPM = new System.Windows.Forms.NumericUpDown();
            this.posXNumAMPM = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.AddPMImageButton = new System.Windows.Forms.Button();
            this.AddAMImageButton = new System.Windows.Forms.Button();
            this.WeekDaysTab = new System.Windows.Forms.TabPage();
            this.weekdaysCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.addWeekDays = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.MonthDayYearTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.separateTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.onelineTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.onelinewithyearTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.AmPmTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYNumAMPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXNumAMPM)).BeginInit();
            this.WeekDaysTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MonthDayYearTab);
            this.tabControl1.Controls.Add(this.AmPmTab);
            this.tabControl1.Controls.Add(this.WeekDaysTab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 300);
            this.tabControl1.TabIndex = 0;
            // 
            // MonthDayYearTab
            // 
            this.MonthDayYearTab.Controls.Add(this.TwoDigitsDayCheckbox);
            this.MonthDayYearTab.Controls.Add(this.TwoDigitsMonthCheckbox);
            this.MonthDayYearTab.Controls.Add(this.tabControl2);
            this.MonthDayYearTab.Location = new System.Drawing.Point(4, 27);
            this.MonthDayYearTab.Name = "MonthDayYearTab";
            this.MonthDayYearTab.Padding = new System.Windows.Forms.Padding(3);
            this.MonthDayYearTab.Size = new System.Drawing.Size(379, 269);
            this.MonthDayYearTab.TabIndex = 0;
            this.MonthDayYearTab.Text = "Month Day Year";
            this.MonthDayYearTab.UseVisualStyleBackColor = true;
            // 
            // TwoDigitsDayCheckbox
            // 
            this.TwoDigitsDayCheckbox.AutoSize = true;
            this.TwoDigitsDayCheckbox.Checked = true;
            this.TwoDigitsDayCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TwoDigitsDayCheckbox.Enabled = false;
            this.TwoDigitsDayCheckbox.Location = new System.Drawing.Point(233, 241);
            this.TwoDigitsDayCheckbox.Name = "TwoDigitsDayCheckbox";
            this.TwoDigitsDayCheckbox.Size = new System.Drawing.Size(121, 22);
            this.TwoDigitsDayCheckbox.TabIndex = 2;
            this.TwoDigitsDayCheckbox.Text = "Two digits day";
            this.TwoDigitsDayCheckbox.UseVisualStyleBackColor = true;
            this.TwoDigitsDayCheckbox.CheckedChanged += new System.EventHandler(this.TwoDigitsChanged);
            // 
            // TwoDigitsMonthCheckbox
            // 
            this.TwoDigitsMonthCheckbox.AutoSize = true;
            this.TwoDigitsMonthCheckbox.Checked = true;
            this.TwoDigitsMonthCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TwoDigitsMonthCheckbox.Enabled = false;
            this.TwoDigitsMonthCheckbox.Location = new System.Drawing.Point(10, 241);
            this.TwoDigitsMonthCheckbox.Name = "TwoDigitsMonthCheckbox";
            this.TwoDigitsMonthCheckbox.Size = new System.Drawing.Size(140, 22);
            this.TwoDigitsMonthCheckbox.TabIndex = 1;
            this.TwoDigitsMonthCheckbox.Text = "Two digits month";
            this.TwoDigitsMonthCheckbox.UseVisualStyleBackColor = true;
            this.TwoDigitsMonthCheckbox.CheckedChanged += new System.EventHandler(this.TwoDigitsChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.separateTab);
            this.tabControl2.Controls.Add(this.onelineTab);
            this.tabControl2.Controls.Add(this.onelinewithyearTab);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(370, 229);
            this.tabControl2.TabIndex = 0;
            // 
            // separateTab
            // 
            this.separateTab.Controls.Add(this.SeparateMonthDayCheckbox);
            this.separateTab.Controls.Add(this.groupBox1);
            this.separateTab.Location = new System.Drawing.Point(4, 27);
            this.separateTab.Name = "separateTab";
            this.separateTab.Padding = new System.Windows.Forms.Padding(3);
            this.separateTab.Size = new System.Drawing.Size(362, 198);
            this.separateTab.TabIndex = 0;
            this.separateTab.Text = "Separate";
            this.separateTab.UseVisualStyleBackColor = true;
            // 
            // SeparateMonthDayCheckbox
            // 
            this.SeparateMonthDayCheckbox.AutoSize = true;
            this.SeparateMonthDayCheckbox.Location = new System.Drawing.Point(15, 6);
            this.SeparateMonthDayCheckbox.Name = "SeparateMonthDayCheckbox";
            this.SeparateMonthDayCheckbox.Size = new System.Drawing.Size(15, 14);
            this.SeparateMonthDayCheckbox.TabIndex = 1;
            this.SeparateMonthDayCheckbox.UseVisualStyleBackColor = true;
            this.SeparateMonthDayCheckbox.CheckedChanged += new System.EventHandler(this.checkStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AddDaySeparateButton);
            this.groupBox1.Controls.Add(this.AddMonthSeparateButton);
            this.groupBox1.Controls.Add(this.AddMonthImagesSeparateButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "     ";
            // 
            // AddDaySeparateButton
            // 
            this.AddDaySeparateButton.Location = new System.Drawing.Point(6, 129);
            this.AddDaySeparateButton.Name = "AddDaySeparateButton";
            this.AddDaySeparateButton.Size = new System.Drawing.Size(341, 47);
            this.AddDaySeparateButton.TabIndex = 12;
            this.AddDaySeparateButton.Text = "Add day";
            this.AddDaySeparateButton.UseVisualStyleBackColor = true;
            this.AddDaySeparateButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // AddMonthSeparateButton
            // 
            this.AddMonthSeparateButton.Location = new System.Drawing.Point(6, 23);
            this.AddMonthSeparateButton.Name = "AddMonthSeparateButton";
            this.AddMonthSeparateButton.Size = new System.Drawing.Size(341, 47);
            this.AddMonthSeparateButton.TabIndex = 10;
            this.AddMonthSeparateButton.Text = "Add month";
            this.AddMonthSeparateButton.UseVisualStyleBackColor = true;
            this.AddMonthSeparateButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // AddMonthImagesSeparateButton
            // 
            this.AddMonthImagesSeparateButton.Location = new System.Drawing.Point(6, 76);
            this.AddMonthImagesSeparateButton.Name = "AddMonthImagesSeparateButton";
            this.AddMonthImagesSeparateButton.Size = new System.Drawing.Size(341, 47);
            this.AddMonthImagesSeparateButton.TabIndex = 11;
            this.AddMonthImagesSeparateButton.Text = "Add month images";
            this.AddMonthImagesSeparateButton.UseVisualStyleBackColor = true;
            this.AddMonthImagesSeparateButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // onelineTab
            // 
            this.onelineTab.Controls.Add(this.OnelineMonthDayCheckbox);
            this.onelineTab.Controls.Add(this.groupBox2);
            this.onelineTab.Location = new System.Drawing.Point(4, 27);
            this.onelineTab.Name = "onelineTab";
            this.onelineTab.Padding = new System.Windows.Forms.Padding(3);
            this.onelineTab.Size = new System.Drawing.Size(362, 198);
            this.onelineTab.TabIndex = 1;
            this.onelineTab.Text = "One line";
            this.onelineTab.UseVisualStyleBackColor = true;
            // 
            // OnelineMonthDayCheckbox
            // 
            this.OnelineMonthDayCheckbox.AutoSize = true;
            this.OnelineMonthDayCheckbox.Location = new System.Drawing.Point(15, 6);
            this.OnelineMonthDayCheckbox.Name = "OnelineMonthDayCheckbox";
            this.OnelineMonthDayCheckbox.Size = new System.Drawing.Size(15, 14);
            this.OnelineMonthDayCheckbox.TabIndex = 4;
            this.OnelineMonthDayCheckbox.UseVisualStyleBackColor = true;
            this.OnelineMonthDayCheckbox.CheckedChanged += new System.EventHandler(this.checkStateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.AddOnelineDelimeterImageButton);
            this.groupBox2.Controls.Add(this.AddMonthAndDayOnelineButton);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 206);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "     ";
            // 
            // AddOnelineDelimeterImageButton
            // 
            this.AddOnelineDelimeterImageButton.Enabled = false;
            this.AddOnelineDelimeterImageButton.Location = new System.Drawing.Point(6, 76);
            this.AddOnelineDelimeterImageButton.Name = "AddOnelineDelimeterImageButton";
            this.AddOnelineDelimeterImageButton.Size = new System.Drawing.Size(341, 47);
            this.AddOnelineDelimeterImageButton.TabIndex = 4;
            this.AddOnelineDelimeterImageButton.Text = "Add delimeter image";
            this.AddOnelineDelimeterImageButton.UseVisualStyleBackColor = true;
            this.AddOnelineDelimeterImageButton.Click += new System.EventHandler(this.AddImagesClick);
            // 
            // AddMonthAndDayOnelineButton
            // 
            this.AddMonthAndDayOnelineButton.Location = new System.Drawing.Point(6, 23);
            this.AddMonthAndDayOnelineButton.Name = "AddMonthAndDayOnelineButton";
            this.AddMonthAndDayOnelineButton.Size = new System.Drawing.Size(341, 47);
            this.AddMonthAndDayOnelineButton.TabIndex = 3;
            this.AddMonthAndDayOnelineButton.Text = "Add month and day";
            this.AddMonthAndDayOnelineButton.UseVisualStyleBackColor = true;
            this.AddMonthAndDayOnelineButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // onelinewithyearTab
            // 
            this.onelinewithyearTab.Controls.Add(this.OnelineWithYearCheckbox);
            this.onelinewithyearTab.Controls.Add(this.groupBox3);
            this.onelinewithyearTab.Location = new System.Drawing.Point(4, 27);
            this.onelinewithyearTab.Name = "onelinewithyearTab";
            this.onelinewithyearTab.Size = new System.Drawing.Size(362, 198);
            this.onelinewithyearTab.TabIndex = 2;
            this.onelinewithyearTab.Text = "One line with year";
            this.onelinewithyearTab.UseVisualStyleBackColor = true;
            // 
            // OnelineWithYearCheckbox
            // 
            this.OnelineWithYearCheckbox.AutoSize = true;
            this.OnelineWithYearCheckbox.Location = new System.Drawing.Point(15, 6);
            this.OnelineWithYearCheckbox.Name = "OnelineWithYearCheckbox";
            this.OnelineWithYearCheckbox.Size = new System.Drawing.Size(15, 14);
            this.OnelineWithYearCheckbox.TabIndex = 6;
            this.OnelineWithYearCheckbox.UseVisualStyleBackColor = true;
            this.OnelineWithYearCheckbox.CheckedChanged += new System.EventHandler(this.checkStateChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.addOnelineWithYearDelimeterImageButton);
            this.groupBox3.Controls.Add(this.addOnelineWithYearMonthDayYearButton);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 206);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "     ";
            // 
            // addOnelineWithYearDelimeterImageButton
            // 
            this.addOnelineWithYearDelimeterImageButton.Location = new System.Drawing.Point(6, 76);
            this.addOnelineWithYearDelimeterImageButton.Name = "addOnelineWithYearDelimeterImageButton";
            this.addOnelineWithYearDelimeterImageButton.Size = new System.Drawing.Size(341, 47);
            this.addOnelineWithYearDelimeterImageButton.TabIndex = 4;
            this.addOnelineWithYearDelimeterImageButton.Text = "Add delimeter image";
            this.addOnelineWithYearDelimeterImageButton.UseVisualStyleBackColor = true;
            this.addOnelineWithYearDelimeterImageButton.Click += new System.EventHandler(this.AddImagesClick);
            // 
            // addOnelineWithYearMonthDayYearButton
            // 
            this.addOnelineWithYearMonthDayYearButton.Location = new System.Drawing.Point(6, 23);
            this.addOnelineWithYearMonthDayYearButton.Name = "addOnelineWithYearMonthDayYearButton";
            this.addOnelineWithYearMonthDayYearButton.Size = new System.Drawing.Size(341, 47);
            this.addOnelineWithYearMonthDayYearButton.TabIndex = 3;
            this.addOnelineWithYearMonthDayYearButton.Text = "Add month and day and year";
            this.addOnelineWithYearMonthDayYearButton.UseVisualStyleBackColor = true;
            this.addOnelineWithYearMonthDayYearButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // AmPmTab
            // 
            this.AmPmTab.Controls.Add(this.AmPmCheckbox);
            this.AmPmTab.Controls.Add(this.groupBox4);
            this.AmPmTab.Location = new System.Drawing.Point(4, 27);
            this.AmPmTab.Name = "AmPmTab";
            this.AmPmTab.Padding = new System.Windows.Forms.Padding(3);
            this.AmPmTab.Size = new System.Drawing.Size(379, 269);
            this.AmPmTab.TabIndex = 1;
            this.AmPmTab.Text = "Am Pm";
            this.AmPmTab.UseVisualStyleBackColor = true;
            // 
            // AmPmCheckbox
            // 
            this.AmPmCheckbox.AutoSize = true;
            this.AmPmCheckbox.Location = new System.Drawing.Point(16, 6);
            this.AmPmCheckbox.Name = "AmPmCheckbox";
            this.AmPmCheckbox.Size = new System.Drawing.Size(15, 14);
            this.AmPmCheckbox.TabIndex = 6;
            this.AmPmCheckbox.UseVisualStyleBackColor = true;
            this.AmPmCheckbox.CheckedChanged += new System.EventHandler(this.checkStateChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.posYNumAMPM);
            this.groupBox4.Controls.Add(this.posXNumAMPM);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.AddPMImageButton);
            this.groupBox4.Controls.Add(this.AddAMImageButton);
            this.groupBox4.Location = new System.Drawing.Point(4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(369, 260);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "     ";
            // 
            // posYNumAMPM
            // 
            this.posYNumAMPM.Enabled = false;
            this.posYNumAMPM.Location = new System.Drawing.Point(143, 129);
            this.posYNumAMPM.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.posYNumAMPM.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.posYNumAMPM.Name = "posYNumAMPM";
            this.posYNumAMPM.Size = new System.Drawing.Size(49, 24);
            this.posYNumAMPM.TabIndex = 17;
            this.posYNumAMPM.ValueChanged += new System.EventHandler(this.AMPMPosChanged);
            // 
            // posXNumAMPM
            // 
            this.posXNumAMPM.Enabled = false;
            this.posXNumAMPM.Location = new System.Drawing.Point(86, 129);
            this.posXNumAMPM.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.posXNumAMPM.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.posXNumAMPM.Name = "posXNumAMPM";
            this.posXNumAMPM.Size = new System.Drawing.Size(49, 24);
            this.posXNumAMPM.TabIndex = 16;
            this.posXNumAMPM.ValueChanged += new System.EventHandler(this.AMPMPosChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Position:";
            // 
            // AddPMImageButton
            // 
            this.AddPMImageButton.Location = new System.Drawing.Point(6, 76);
            this.AddPMImageButton.Name = "AddPMImageButton";
            this.AddPMImageButton.Size = new System.Drawing.Size(357, 47);
            this.AddPMImageButton.TabIndex = 5;
            this.AddPMImageButton.Text = "Add PM image";
            this.AddPMImageButton.UseVisualStyleBackColor = true;
            this.AddPMImageButton.Click += new System.EventHandler(this.AddImagesClick);
            // 
            // AddAMImageButton
            // 
            this.AddAMImageButton.Location = new System.Drawing.Point(6, 23);
            this.AddAMImageButton.Name = "AddAMImageButton";
            this.AddAMImageButton.Size = new System.Drawing.Size(357, 47);
            this.AddAMImageButton.TabIndex = 4;
            this.AddAMImageButton.Text = "Add AM image";
            this.AddAMImageButton.UseVisualStyleBackColor = true;
            this.AddAMImageButton.Click += new System.EventHandler(this.AddImagesClick);
            // 
            // WeekDaysTab
            // 
            this.WeekDaysTab.Controls.Add(this.weekdaysCheckbox);
            this.WeekDaysTab.Controls.Add(this.groupBox5);
            this.WeekDaysTab.Location = new System.Drawing.Point(4, 27);
            this.WeekDaysTab.Name = "WeekDaysTab";
            this.WeekDaysTab.Size = new System.Drawing.Size(379, 269);
            this.WeekDaysTab.TabIndex = 2;
            this.WeekDaysTab.Text = "Week Days EN";
            this.WeekDaysTab.UseVisualStyleBackColor = true;
            // 
            // weekdaysCheckbox
            // 
            this.weekdaysCheckbox.AutoSize = true;
            this.weekdaysCheckbox.Location = new System.Drawing.Point(16, 6);
            this.weekdaysCheckbox.Name = "weekdaysCheckbox";
            this.weekdaysCheckbox.Size = new System.Drawing.Size(15, 14);
            this.weekdaysCheckbox.TabIndex = 8;
            this.weekdaysCheckbox.UseVisualStyleBackColor = true;
            this.weekdaysCheckbox.CheckedChanged += new System.EventHandler(this.checkStateChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.addWeekDays);
            this.groupBox5.Location = new System.Drawing.Point(4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(369, 260);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "     ";
            // 
            // addWeekDays
            // 
            this.addWeekDays.Location = new System.Drawing.Point(6, 23);
            this.addWeekDays.Name = "addWeekDays";
            this.addWeekDays.Size = new System.Drawing.Size(357, 33);
            this.addWeekDays.TabIndex = 4;
            this.addWeekDays.Text = "Add week days images";
            this.addWeekDays.UseVisualStyleBackColor = true;
            this.addWeekDays.Click += new System.EventHandler(this.addWeekdayClick);
            // 
            // ImagePic
            // 
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Location = new System.Drawing.Point(405, 18);
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.Size = new System.Drawing.Size(126, 294);
            this.ImagePic.TabIndex = 9;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(12, 318);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(519, 44);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 370);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DateForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.MonthDayYearTab.ResumeLayout(false);
            this.MonthDayYearTab.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.separateTab.ResumeLayout(false);
            this.separateTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.onelineTab.ResumeLayout(false);
            this.onelineTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.onelinewithyearTab.ResumeLayout(false);
            this.onelinewithyearTab.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.AmPmTab.ResumeLayout(false);
            this.AmPmTab.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYNumAMPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXNumAMPM)).EndInit();
            this.WeekDaysTab.ResumeLayout(false);
            this.WeekDaysTab.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MonthDayYearTab;
        private System.Windows.Forms.TabPage AmPmTab;
        private System.Windows.Forms.TabPage WeekDaysTab;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage separateTab;
        private System.Windows.Forms.TabPage onelineTab;
        private System.Windows.Forms.TabPage onelinewithyearTab;
        private System.Windows.Forms.Panel ImagePic;
        private System.Windows.Forms.CheckBox SeparateMonthDayCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddDaySeparateButton;
        private System.Windows.Forms.Button AddMonthSeparateButton;
        private System.Windows.Forms.Button AddMonthImagesSeparateButton;
        private System.Windows.Forms.CheckBox OnelineMonthDayCheckbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddOnelineDelimeterImageButton;
        private System.Windows.Forms.Button AddMonthAndDayOnelineButton;
        private System.Windows.Forms.CheckBox OnelineWithYearCheckbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addOnelineWithYearDelimeterImageButton;
        private System.Windows.Forms.Button addOnelineWithYearMonthDayYearButton;
        private System.Windows.Forms.CheckBox AmPmCheckbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button AddPMImageButton;
        private System.Windows.Forms.Button AddAMImageButton;
        private System.Windows.Forms.NumericUpDown posYNumAMPM;
        private System.Windows.Forms.NumericUpDown posXNumAMPM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox weekdaysCheckbox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button addWeekDays;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox TwoDigitsDayCheckbox;
        private System.Windows.Forms.CheckBox TwoDigitsMonthCheckbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}