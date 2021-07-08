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
            this.AddMonthCNImagesSeparateButton = new System.Windows.Forms.Button();
            this.AddDaySeparateButton = new System.Windows.Forms.Button();
            this.AddMonthSeparateButton = new System.Windows.Forms.Button();
            this.AddMonthENImagesSeparateButton = new System.Windows.Forms.Button();
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
            this.AddCNPMImageButton = new System.Windows.Forms.Button();
            this.AddCNAMImageButton = new System.Windows.Forms.Button();
            this.posYNumAMPM = new System.Windows.Forms.NumericUpDown();
            this.posXNumAMPM = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.AddPMImageButton = new System.Windows.Forms.Button();
            this.AddAMImageButton = new System.Windows.Forms.Button();
            this.WeekDaysTab = new System.Windows.Forms.TabPage();
            this.weekdaysCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.addWeekDays = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cnWeekDaysCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.AddCNWeekDaysButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CN2WeekDaysCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.AddCN2WeekDaysButton = new System.Windows.Forms.Button();
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
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.MonthDayYearTab);
            this.tabControl1.Controls.Add(this.AmPmTab);
            this.tabControl1.Controls.Add(this.WeekDaysTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // MonthDayYearTab
            // 
            this.MonthDayYearTab.Controls.Add(this.TwoDigitsDayCheckbox);
            this.MonthDayYearTab.Controls.Add(this.TwoDigitsMonthCheckbox);
            this.MonthDayYearTab.Controls.Add(this.tabControl2);
            resources.ApplyResources(this.MonthDayYearTab, "MonthDayYearTab");
            this.MonthDayYearTab.Name = "MonthDayYearTab";
            this.MonthDayYearTab.UseVisualStyleBackColor = true;
            // 
            // TwoDigitsDayCheckbox
            // 
            resources.ApplyResources(this.TwoDigitsDayCheckbox, "TwoDigitsDayCheckbox");
            this.TwoDigitsDayCheckbox.Checked = true;
            this.TwoDigitsDayCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TwoDigitsDayCheckbox.Name = "TwoDigitsDayCheckbox";
            this.TwoDigitsDayCheckbox.UseVisualStyleBackColor = true;
            this.TwoDigitsDayCheckbox.CheckedChanged += new System.EventHandler(this.TwoDigitsChanged);
            // 
            // TwoDigitsMonthCheckbox
            // 
            resources.ApplyResources(this.TwoDigitsMonthCheckbox, "TwoDigitsMonthCheckbox");
            this.TwoDigitsMonthCheckbox.Checked = true;
            this.TwoDigitsMonthCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TwoDigitsMonthCheckbox.Name = "TwoDigitsMonthCheckbox";
            this.TwoDigitsMonthCheckbox.UseVisualStyleBackColor = true;
            this.TwoDigitsMonthCheckbox.CheckedChanged += new System.EventHandler(this.TwoDigitsChanged);
            // 
            // tabControl2
            // 
            resources.ApplyResources(this.tabControl2, "tabControl2");
            this.tabControl2.Controls.Add(this.separateTab);
            this.tabControl2.Controls.Add(this.onelineTab);
            this.tabControl2.Controls.Add(this.onelinewithyearTab);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            // 
            // separateTab
            // 
            this.separateTab.Controls.Add(this.SeparateMonthDayCheckbox);
            this.separateTab.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.separateTab, "separateTab");
            this.separateTab.Name = "separateTab";
            this.separateTab.UseVisualStyleBackColor = true;
            // 
            // SeparateMonthDayCheckbox
            // 
            resources.ApplyResources(this.SeparateMonthDayCheckbox, "SeparateMonthDayCheckbox");
            this.SeparateMonthDayCheckbox.Name = "SeparateMonthDayCheckbox";
            this.SeparateMonthDayCheckbox.UseVisualStyleBackColor = true;
            this.SeparateMonthDayCheckbox.CheckedChanged += new System.EventHandler(this.checkStateChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.AddMonthCNImagesSeparateButton);
            this.groupBox1.Controls.Add(this.AddDaySeparateButton);
            this.groupBox1.Controls.Add(this.AddMonthSeparateButton);
            this.groupBox1.Controls.Add(this.AddMonthENImagesSeparateButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // AddMonthCNImagesSeparateButton
            // 
            resources.ApplyResources(this.AddMonthCNImagesSeparateButton, "AddMonthCNImagesSeparateButton");
            this.AddMonthCNImagesSeparateButton.Name = "AddMonthCNImagesSeparateButton";
            this.AddMonthCNImagesSeparateButton.UseVisualStyleBackColor = true;
            this.AddMonthCNImagesSeparateButton.Click += new System.EventHandler(this.AddImagesClick);
            // 
            // AddDaySeparateButton
            // 
            resources.ApplyResources(this.AddDaySeparateButton, "AddDaySeparateButton");
            this.AddDaySeparateButton.Name = "AddDaySeparateButton";
            this.AddDaySeparateButton.UseVisualStyleBackColor = true;
            this.AddDaySeparateButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // AddMonthSeparateButton
            // 
            resources.ApplyResources(this.AddMonthSeparateButton, "AddMonthSeparateButton");
            this.AddMonthSeparateButton.Name = "AddMonthSeparateButton";
            this.AddMonthSeparateButton.UseVisualStyleBackColor = true;
            this.AddMonthSeparateButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // AddMonthENImagesSeparateButton
            // 
            resources.ApplyResources(this.AddMonthENImagesSeparateButton, "AddMonthENImagesSeparateButton");
            this.AddMonthENImagesSeparateButton.Name = "AddMonthENImagesSeparateButton";
            this.AddMonthENImagesSeparateButton.UseVisualStyleBackColor = true;
            this.AddMonthENImagesSeparateButton.Click += new System.EventHandler(this.AddImagesClick);
            // 
            // onelineTab
            // 
            this.onelineTab.Controls.Add(this.OnelineMonthDayCheckbox);
            this.onelineTab.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.onelineTab, "onelineTab");
            this.onelineTab.Name = "onelineTab";
            this.onelineTab.UseVisualStyleBackColor = true;
            // 
            // OnelineMonthDayCheckbox
            // 
            resources.ApplyResources(this.OnelineMonthDayCheckbox, "OnelineMonthDayCheckbox");
            this.OnelineMonthDayCheckbox.Name = "OnelineMonthDayCheckbox";
            this.OnelineMonthDayCheckbox.UseVisualStyleBackColor = true;
            this.OnelineMonthDayCheckbox.CheckedChanged += new System.EventHandler(this.checkStateChanged);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.AddOnelineDelimeterImageButton);
            this.groupBox2.Controls.Add(this.AddMonthAndDayOnelineButton);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // AddOnelineDelimeterImageButton
            // 
            resources.ApplyResources(this.AddOnelineDelimeterImageButton, "AddOnelineDelimeterImageButton");
            this.AddOnelineDelimeterImageButton.Name = "AddOnelineDelimeterImageButton";
            this.AddOnelineDelimeterImageButton.UseVisualStyleBackColor = true;
            this.AddOnelineDelimeterImageButton.Click += new System.EventHandler(this.AddImagesClick);
            // 
            // AddMonthAndDayOnelineButton
            // 
            resources.ApplyResources(this.AddMonthAndDayOnelineButton, "AddMonthAndDayOnelineButton");
            this.AddMonthAndDayOnelineButton.Name = "AddMonthAndDayOnelineButton";
            this.AddMonthAndDayOnelineButton.UseVisualStyleBackColor = true;
            this.AddMonthAndDayOnelineButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // onelinewithyearTab
            // 
            this.onelinewithyearTab.Controls.Add(this.OnelineWithYearCheckbox);
            this.onelinewithyearTab.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.onelinewithyearTab, "onelinewithyearTab");
            this.onelinewithyearTab.Name = "onelinewithyearTab";
            this.onelinewithyearTab.UseVisualStyleBackColor = true;
            // 
            // OnelineWithYearCheckbox
            // 
            resources.ApplyResources(this.OnelineWithYearCheckbox, "OnelineWithYearCheckbox");
            this.OnelineWithYearCheckbox.Name = "OnelineWithYearCheckbox";
            this.OnelineWithYearCheckbox.UseVisualStyleBackColor = true;
            this.OnelineWithYearCheckbox.CheckedChanged += new System.EventHandler(this.checkStateChanged);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.addOnelineWithYearDelimeterImageButton);
            this.groupBox3.Controls.Add(this.addOnelineWithYearMonthDayYearButton);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // addOnelineWithYearDelimeterImageButton
            // 
            resources.ApplyResources(this.addOnelineWithYearDelimeterImageButton, "addOnelineWithYearDelimeterImageButton");
            this.addOnelineWithYearDelimeterImageButton.Name = "addOnelineWithYearDelimeterImageButton";
            this.addOnelineWithYearDelimeterImageButton.UseVisualStyleBackColor = true;
            this.addOnelineWithYearDelimeterImageButton.Click += new System.EventHandler(this.AddImagesClick);
            // 
            // addOnelineWithYearMonthDayYearButton
            // 
            resources.ApplyResources(this.addOnelineWithYearMonthDayYearButton, "addOnelineWithYearMonthDayYearButton");
            this.addOnelineWithYearMonthDayYearButton.Name = "addOnelineWithYearMonthDayYearButton";
            this.addOnelineWithYearMonthDayYearButton.UseVisualStyleBackColor = true;
            this.addOnelineWithYearMonthDayYearButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // AmPmTab
            // 
            this.AmPmTab.Controls.Add(this.AmPmCheckbox);
            this.AmPmTab.Controls.Add(this.groupBox4);
            resources.ApplyResources(this.AmPmTab, "AmPmTab");
            this.AmPmTab.Name = "AmPmTab";
            this.AmPmTab.UseVisualStyleBackColor = true;
            // 
            // AmPmCheckbox
            // 
            resources.ApplyResources(this.AmPmCheckbox, "AmPmCheckbox");
            this.AmPmCheckbox.Name = "AmPmCheckbox";
            this.AmPmCheckbox.UseVisualStyleBackColor = true;
            this.AmPmCheckbox.CheckedChanged += new System.EventHandler(this.checkStateChanged);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.AddCNPMImageButton);
            this.groupBox4.Controls.Add(this.AddCNAMImageButton);
            this.groupBox4.Controls.Add(this.posYNumAMPM);
            this.groupBox4.Controls.Add(this.posXNumAMPM);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.AddPMImageButton);
            this.groupBox4.Controls.Add(this.AddAMImageButton);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // AddCNPMImageButton
            // 
            resources.ApplyResources(this.AddCNPMImageButton, "AddCNPMImageButton");
            this.AddCNPMImageButton.Name = "AddCNPMImageButton";
            this.AddCNPMImageButton.UseVisualStyleBackColor = true;
            this.AddCNPMImageButton.Click += new System.EventHandler(this.AddImagesClick);
            // 
            // AddCNAMImageButton
            // 
            resources.ApplyResources(this.AddCNAMImageButton, "AddCNAMImageButton");
            this.AddCNAMImageButton.Name = "AddCNAMImageButton";
            this.AddCNAMImageButton.UseVisualStyleBackColor = true;
            this.AddCNAMImageButton.Click += new System.EventHandler(this.AddImagesClick);
            // 
            // posYNumAMPM
            // 
            resources.ApplyResources(this.posYNumAMPM, "posYNumAMPM");
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
            this.posYNumAMPM.ValueChanged += new System.EventHandler(this.AMPMPosChanged);
            // 
            // posXNumAMPM
            // 
            resources.ApplyResources(this.posXNumAMPM, "posXNumAMPM");
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
            this.posXNumAMPM.ValueChanged += new System.EventHandler(this.AMPMPosChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // AddPMImageButton
            // 
            resources.ApplyResources(this.AddPMImageButton, "AddPMImageButton");
            this.AddPMImageButton.Name = "AddPMImageButton";
            this.AddPMImageButton.UseVisualStyleBackColor = true;
            this.AddPMImageButton.Click += new System.EventHandler(this.AddImagesClick);
            // 
            // AddAMImageButton
            // 
            resources.ApplyResources(this.AddAMImageButton, "AddAMImageButton");
            this.AddAMImageButton.Name = "AddAMImageButton";
            this.AddAMImageButton.UseVisualStyleBackColor = true;
            this.AddAMImageButton.Click += new System.EventHandler(this.AddImagesClick);
            // 
            // WeekDaysTab
            // 
            this.WeekDaysTab.Controls.Add(this.weekdaysCheckbox);
            this.WeekDaysTab.Controls.Add(this.groupBox5);
            resources.ApplyResources(this.WeekDaysTab, "WeekDaysTab");
            this.WeekDaysTab.Name = "WeekDaysTab";
            this.WeekDaysTab.UseVisualStyleBackColor = true;
            // 
            // weekdaysCheckbox
            // 
            resources.ApplyResources(this.weekdaysCheckbox, "weekdaysCheckbox");
            this.weekdaysCheckbox.Name = "weekdaysCheckbox";
            this.weekdaysCheckbox.UseVisualStyleBackColor = true;
            this.weekdaysCheckbox.CheckedChanged += new System.EventHandler(this.checkStateChanged);
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.addWeekDays);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // addWeekDays
            // 
            resources.ApplyResources(this.addWeekDays, "addWeekDays");
            this.addWeekDays.Name = "addWeekDays";
            this.addWeekDays.UseVisualStyleBackColor = true;
            this.addWeekDays.Click += new System.EventHandler(this.addWeekdayClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cnWeekDaysCheckbox);
            this.tabPage1.Controls.Add(this.groupBox6);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cnWeekDaysCheckbox
            // 
            resources.ApplyResources(this.cnWeekDaysCheckbox, "cnWeekDaysCheckbox");
            this.cnWeekDaysCheckbox.Name = "cnWeekDaysCheckbox";
            this.cnWeekDaysCheckbox.UseVisualStyleBackColor = true;
            this.cnWeekDaysCheckbox.CheckedChanged += new System.EventHandler(this.checkStateChanged);
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Controls.Add(this.AddCNWeekDaysButton);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // AddCNWeekDaysButton
            // 
            resources.ApplyResources(this.AddCNWeekDaysButton, "AddCNWeekDaysButton");
            this.AddCNWeekDaysButton.Name = "AddCNWeekDaysButton";
            this.AddCNWeekDaysButton.UseVisualStyleBackColor = true;
            this.AddCNWeekDaysButton.Click += new System.EventHandler(this.addWeekdayClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CN2WeekDaysCheckbox);
            this.tabPage2.Controls.Add(this.groupBox7);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CN2WeekDaysCheckbox
            // 
            resources.ApplyResources(this.CN2WeekDaysCheckbox, "CN2WeekDaysCheckbox");
            this.CN2WeekDaysCheckbox.Name = "CN2WeekDaysCheckbox";
            this.CN2WeekDaysCheckbox.UseVisualStyleBackColor = true;
            this.CN2WeekDaysCheckbox.CheckedChanged += new System.EventHandler(this.checkStateChanged);
            // 
            // groupBox7
            // 
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Controls.Add(this.AddCN2WeekDaysButton);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // AddCN2WeekDaysButton
            // 
            resources.ApplyResources(this.AddCN2WeekDaysButton, "AddCN2WeekDaysButton");
            this.AddCN2WeekDaysButton.Name = "AddCN2WeekDaysButton";
            this.AddCN2WeekDaysButton.UseVisualStyleBackColor = true;
            this.AddCN2WeekDaysButton.Click += new System.EventHandler(this.addWeekdayClick);
            // 
            // ImagePic
            // 
            resources.ApplyResources(this.ImagePic, "ImagePic");
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Name = "ImagePic";
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DateForm";
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
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
        private System.Windows.Forms.Button AddMonthENImagesSeparateButton;
        private System.Windows.Forms.CheckBox OnelineMonthDayCheckbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddOnelineDelimeterImageButton;
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cnWeekDaysCheckbox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button AddCNWeekDaysButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox CN2WeekDaysCheckbox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button AddCN2WeekDaysButton;
        private System.Windows.Forms.Button AddCNPMImageButton;
        private System.Windows.Forms.Button AddCNAMImageButton;
        private System.Windows.Forms.Button AddMonthCNImagesSeparateButton;
        private System.Windows.Forms.Button AddMonthAndDayOnelineButton;
    }
}