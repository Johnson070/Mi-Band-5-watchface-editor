namespace MiBand5WatchFaces.Forms
{
    partial class WeatherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.WeatherIconCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddWeatherCustomIconButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.TemperatureTodaySeparateNightCheckbox = new System.Windows.Forms.CheckBox();
            this.TemperatureTodaySeparateDayCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AddDegreeImageTemperatureTodaySeparateNightButton = new System.Windows.Forms.Button();
            this.AddMinusImageTemperatureTodaySeparateNightButton = new System.Windows.Forms.Button();
            this.AddNumberTemperatureTodaySeparateNightButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddDegreeImageTemperatureTodaySeparateDayButton = new System.Windows.Forms.Button();
            this.AddMinusImageTemperatureTodaySeparateDayButton = new System.Windows.Forms.Button();
            this.AddNumberTemperatureTodaySeparateDayButton = new System.Windows.Forms.Button();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.TemperatureTodayOnelineCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.AddForBothTemperatureTodayOnelineCheckBox = new System.Windows.Forms.CheckBox();
            this.AddDegreeImageTemperatureTodayOnelineButton = new System.Windows.Forms.Button();
            this.AddNumberTemperatureTodayOnelineButton = new System.Windows.Forms.Button();
            this.AddMinusImageTemperatureTodayOnelineButton = new System.Windows.Forms.Button();
            this.AddDelimeterImageTemperatureTodayOnelineButton = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.TemperatureCurrentCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddDegreeImageTemperatureCurrentButton = new System.Windows.Forms.Button();
            this.AddMinusImageTemperatureCurrentButton = new System.Windows.Forms.Button();
            this.AddNumberTemperatureCurrentButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.HumidityCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.AddSuffixImageHumidityButton = new System.Windows.Forms.Button();
            this.AddSuffixHumidityButton = new System.Windows.Forms.Button();
            this.AddNumberHumidityButton = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.WindCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.AddSuffixWindButton = new System.Windows.Forms.Button();
            this.AddNumberWindButton = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.UVIndexCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.AddSuffixUVButton = new System.Windows.Forms.Button();
            this.AddNumberUVButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.WeatherIconCheckbox);
            this.tabPage1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // WeatherIconCheckbox
            // 
            resources.ApplyResources(this.WeatherIconCheckbox, "WeatherIconCheckbox");
            this.WeatherIconCheckbox.Name = "WeatherIconCheckbox";
            this.WeatherIconCheckbox.UseVisualStyleBackColor = true;
            this.WeatherIconCheckbox.CheckedChanged += new System.EventHandler(this.GroupBoxChangeCheck);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.AddWeatherCustomIconButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // AddWeatherCustomIconButton
            // 
            resources.ApplyResources(this.AddWeatherCustomIconButton, "AddWeatherCustomIconButton");
            this.AddWeatherCustomIconButton.Name = "AddWeatherCustomIconButton";
            this.AddWeatherCustomIconButton.UseVisualStyleBackColor = true;
            this.AddWeatherCustomIconButton.Click += new System.EventHandler(this.AddWeatherCustomIconButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            resources.ApplyResources(this.tabControl2, "tabControl2");
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.tabControl3);
            resources.ApplyResources(this.tabPage7, "tabPage7");
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage9);
            this.tabControl3.Controls.Add(this.tabPage10);
            resources.ApplyResources(this.tabControl3, "tabControl3");
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.TemperatureTodaySeparateNightCheckbox);
            this.tabPage9.Controls.Add(this.TemperatureTodaySeparateDayCheckbox);
            this.tabPage9.Controls.Add(this.groupBox4);
            this.tabPage9.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPage9, "tabPage9");
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // TemperatureTodaySeparateNightCheckbox
            // 
            resources.ApplyResources(this.TemperatureTodaySeparateNightCheckbox, "TemperatureTodaySeparateNightCheckbox");
            this.TemperatureTodaySeparateNightCheckbox.Name = "TemperatureTodaySeparateNightCheckbox";
            this.TemperatureTodaySeparateNightCheckbox.UseVisualStyleBackColor = true;
            this.TemperatureTodaySeparateNightCheckbox.CheckedChanged += new System.EventHandler(this.GroupBoxChangeCheck);
            // 
            // TemperatureTodaySeparateDayCheckbox
            // 
            resources.ApplyResources(this.TemperatureTodaySeparateDayCheckbox, "TemperatureTodaySeparateDayCheckbox");
            this.TemperatureTodaySeparateDayCheckbox.Name = "TemperatureTodaySeparateDayCheckbox";
            this.TemperatureTodaySeparateDayCheckbox.UseVisualStyleBackColor = true;
            this.TemperatureTodaySeparateDayCheckbox.CheckedChanged += new System.EventHandler(this.GroupBoxChangeCheck);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.AddDegreeImageTemperatureTodaySeparateNightButton);
            this.groupBox4.Controls.Add(this.AddMinusImageTemperatureTodaySeparateNightButton);
            this.groupBox4.Controls.Add(this.AddNumberTemperatureTodaySeparateNightButton);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // AddDegreeImageTemperatureTodaySeparateNightButton
            // 
            resources.ApplyResources(this.AddDegreeImageTemperatureTodaySeparateNightButton, "AddDegreeImageTemperatureTodaySeparateNightButton");
            this.AddDegreeImageTemperatureTodaySeparateNightButton.Name = "AddDegreeImageTemperatureTodaySeparateNightButton";
            this.AddDegreeImageTemperatureTodaySeparateNightButton.UseVisualStyleBackColor = true;
            this.AddDegreeImageTemperatureTodaySeparateNightButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddMinusImageTemperatureTodaySeparateNightButton
            // 
            resources.ApplyResources(this.AddMinusImageTemperatureTodaySeparateNightButton, "AddMinusImageTemperatureTodaySeparateNightButton");
            this.AddMinusImageTemperatureTodaySeparateNightButton.Name = "AddMinusImageTemperatureTodaySeparateNightButton";
            this.AddMinusImageTemperatureTodaySeparateNightButton.UseVisualStyleBackColor = true;
            this.AddMinusImageTemperatureTodaySeparateNightButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddNumberTemperatureTodaySeparateNightButton
            // 
            resources.ApplyResources(this.AddNumberTemperatureTodaySeparateNightButton, "AddNumberTemperatureTodaySeparateNightButton");
            this.AddNumberTemperatureTodaySeparateNightButton.Name = "AddNumberTemperatureTodaySeparateNightButton";
            this.AddNumberTemperatureTodaySeparateNightButton.UseVisualStyleBackColor = true;
            this.AddNumberTemperatureTodaySeparateNightButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.AddDegreeImageTemperatureTodaySeparateDayButton);
            this.groupBox2.Controls.Add(this.AddMinusImageTemperatureTodaySeparateDayButton);
            this.groupBox2.Controls.Add(this.AddNumberTemperatureTodaySeparateDayButton);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // AddDegreeImageTemperatureTodaySeparateDayButton
            // 
            resources.ApplyResources(this.AddDegreeImageTemperatureTodaySeparateDayButton, "AddDegreeImageTemperatureTodaySeparateDayButton");
            this.AddDegreeImageTemperatureTodaySeparateDayButton.Name = "AddDegreeImageTemperatureTodaySeparateDayButton";
            this.AddDegreeImageTemperatureTodaySeparateDayButton.UseVisualStyleBackColor = true;
            this.AddDegreeImageTemperatureTodaySeparateDayButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddMinusImageTemperatureTodaySeparateDayButton
            // 
            resources.ApplyResources(this.AddMinusImageTemperatureTodaySeparateDayButton, "AddMinusImageTemperatureTodaySeparateDayButton");
            this.AddMinusImageTemperatureTodaySeparateDayButton.Name = "AddMinusImageTemperatureTodaySeparateDayButton";
            this.AddMinusImageTemperatureTodaySeparateDayButton.UseVisualStyleBackColor = true;
            this.AddMinusImageTemperatureTodaySeparateDayButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddNumberTemperatureTodaySeparateDayButton
            // 
            resources.ApplyResources(this.AddNumberTemperatureTodaySeparateDayButton, "AddNumberTemperatureTodaySeparateDayButton");
            this.AddNumberTemperatureTodaySeparateDayButton.Name = "AddNumberTemperatureTodaySeparateDayButton";
            this.AddNumberTemperatureTodaySeparateDayButton.UseVisualStyleBackColor = true;
            this.AddNumberTemperatureTodaySeparateDayButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.TemperatureTodayOnelineCheckbox);
            this.tabPage10.Controls.Add(this.groupBox5);
            resources.ApplyResources(this.tabPage10, "tabPage10");
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // TemperatureTodayOnelineCheckbox
            // 
            resources.ApplyResources(this.TemperatureTodayOnelineCheckbox, "TemperatureTodayOnelineCheckbox");
            this.TemperatureTodayOnelineCheckbox.Name = "TemperatureTodayOnelineCheckbox";
            this.TemperatureTodayOnelineCheckbox.UseVisualStyleBackColor = true;
            this.TemperatureTodayOnelineCheckbox.CheckedChanged += new System.EventHandler(this.GroupBoxChangeCheck);
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.AddForBothTemperatureTodayOnelineCheckBox);
            this.groupBox5.Controls.Add(this.AddDegreeImageTemperatureTodayOnelineButton);
            this.groupBox5.Controls.Add(this.AddNumberTemperatureTodayOnelineButton);
            this.groupBox5.Controls.Add(this.AddMinusImageTemperatureTodayOnelineButton);
            this.groupBox5.Controls.Add(this.AddDelimeterImageTemperatureTodayOnelineButton);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // AddForBothTemperatureTodayOnelineCheckBox
            // 
            resources.ApplyResources(this.AddForBothTemperatureTodayOnelineCheckBox, "AddForBothTemperatureTodayOnelineCheckBox");
            this.AddForBothTemperatureTodayOnelineCheckBox.Name = "AddForBothTemperatureTodayOnelineCheckBox";
            this.AddForBothTemperatureTodayOnelineCheckBox.UseVisualStyleBackColor = true;
            this.AddForBothTemperatureTodayOnelineCheckBox.CheckedChanged += new System.EventHandler(this.AddForBothTemperatureTodayOnelineCheckBox_CheckedChanged);
            // 
            // AddDegreeImageTemperatureTodayOnelineButton
            // 
            resources.ApplyResources(this.AddDegreeImageTemperatureTodayOnelineButton, "AddDegreeImageTemperatureTodayOnelineButton");
            this.AddDegreeImageTemperatureTodayOnelineButton.Name = "AddDegreeImageTemperatureTodayOnelineButton";
            this.AddDegreeImageTemperatureTodayOnelineButton.UseVisualStyleBackColor = true;
            this.AddDegreeImageTemperatureTodayOnelineButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddNumberTemperatureTodayOnelineButton
            // 
            resources.ApplyResources(this.AddNumberTemperatureTodayOnelineButton, "AddNumberTemperatureTodayOnelineButton");
            this.AddNumberTemperatureTodayOnelineButton.Name = "AddNumberTemperatureTodayOnelineButton";
            this.AddNumberTemperatureTodayOnelineButton.UseVisualStyleBackColor = true;
            this.AddNumberTemperatureTodayOnelineButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // AddMinusImageTemperatureTodayOnelineButton
            // 
            resources.ApplyResources(this.AddMinusImageTemperatureTodayOnelineButton, "AddMinusImageTemperatureTodayOnelineButton");
            this.AddMinusImageTemperatureTodayOnelineButton.Name = "AddMinusImageTemperatureTodayOnelineButton";
            this.AddMinusImageTemperatureTodayOnelineButton.UseVisualStyleBackColor = true;
            this.AddMinusImageTemperatureTodayOnelineButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddDelimeterImageTemperatureTodayOnelineButton
            // 
            resources.ApplyResources(this.AddDelimeterImageTemperatureTodayOnelineButton, "AddDelimeterImageTemperatureTodayOnelineButton");
            this.AddDelimeterImageTemperatureTodayOnelineButton.Name = "AddDelimeterImageTemperatureTodayOnelineButton";
            this.AddDelimeterImageTemperatureTodayOnelineButton.UseVisualStyleBackColor = true;
            this.AddDelimeterImageTemperatureTodayOnelineButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.TemperatureCurrentCheckbox);
            this.tabPage8.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.tabPage8, "tabPage8");
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // TemperatureCurrentCheckbox
            // 
            resources.ApplyResources(this.TemperatureCurrentCheckbox, "TemperatureCurrentCheckbox");
            this.TemperatureCurrentCheckbox.Name = "TemperatureCurrentCheckbox";
            this.TemperatureCurrentCheckbox.UseVisualStyleBackColor = true;
            this.TemperatureCurrentCheckbox.CheckedChanged += new System.EventHandler(this.GroupBoxChangeCheck);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.AddDegreeImageTemperatureCurrentButton);
            this.groupBox3.Controls.Add(this.AddMinusImageTemperatureCurrentButton);
            this.groupBox3.Controls.Add(this.AddNumberTemperatureCurrentButton);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // AddDegreeImageTemperatureCurrentButton
            // 
            resources.ApplyResources(this.AddDegreeImageTemperatureCurrentButton, "AddDegreeImageTemperatureCurrentButton");
            this.AddDegreeImageTemperatureCurrentButton.Name = "AddDegreeImageTemperatureCurrentButton";
            this.AddDegreeImageTemperatureCurrentButton.UseVisualStyleBackColor = true;
            this.AddDegreeImageTemperatureCurrentButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddMinusImageTemperatureCurrentButton
            // 
            resources.ApplyResources(this.AddMinusImageTemperatureCurrentButton, "AddMinusImageTemperatureCurrentButton");
            this.AddMinusImageTemperatureCurrentButton.Name = "AddMinusImageTemperatureCurrentButton";
            this.AddMinusImageTemperatureCurrentButton.UseVisualStyleBackColor = true;
            this.AddMinusImageTemperatureCurrentButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddNumberTemperatureCurrentButton
            // 
            resources.ApplyResources(this.AddNumberTemperatureCurrentButton, "AddNumberTemperatureCurrentButton");
            this.AddNumberTemperatureCurrentButton.Name = "AddNumberTemperatureCurrentButton";
            this.AddNumberTemperatureCurrentButton.UseVisualStyleBackColor = true;
            this.AddNumberTemperatureCurrentButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.HumidityCheckbox);
            this.tabPage4.Controls.Add(this.groupBox6);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // HumidityCheckbox
            // 
            resources.ApplyResources(this.HumidityCheckbox, "HumidityCheckbox");
            this.HumidityCheckbox.Name = "HumidityCheckbox";
            this.HumidityCheckbox.UseVisualStyleBackColor = true;
            this.HumidityCheckbox.CheckedChanged += new System.EventHandler(this.GroupBoxChangeCheck);
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Controls.Add(this.AddSuffixImageHumidityButton);
            this.groupBox6.Controls.Add(this.AddSuffixHumidityButton);
            this.groupBox6.Controls.Add(this.AddNumberHumidityButton);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // AddSuffixImageHumidityButton
            // 
            resources.ApplyResources(this.AddSuffixImageHumidityButton, "AddSuffixImageHumidityButton");
            this.AddSuffixImageHumidityButton.Name = "AddSuffixImageHumidityButton";
            this.AddSuffixImageHumidityButton.UseVisualStyleBackColor = true;
            this.AddSuffixImageHumidityButton.Click += new System.EventHandler(this.AddSuffixImageHumidityButton_Click);
            // 
            // AddSuffixHumidityButton
            // 
            resources.ApplyResources(this.AddSuffixHumidityButton, "AddSuffixHumidityButton");
            this.AddSuffixHumidityButton.Name = "AddSuffixHumidityButton";
            this.AddSuffixHumidityButton.UseVisualStyleBackColor = true;
            this.AddSuffixHumidityButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddNumberHumidityButton
            // 
            resources.ApplyResources(this.AddNumberHumidityButton, "AddNumberHumidityButton");
            this.AddNumberHumidityButton.Name = "AddNumberHumidityButton";
            this.AddNumberHumidityButton.UseVisualStyleBackColor = true;
            this.AddNumberHumidityButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.WindCheckbox);
            this.tabPage5.Controls.Add(this.groupBox7);
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // WindCheckbox
            // 
            resources.ApplyResources(this.WindCheckbox, "WindCheckbox");
            this.WindCheckbox.Name = "WindCheckbox";
            this.WindCheckbox.UseVisualStyleBackColor = true;
            this.WindCheckbox.CheckedChanged += new System.EventHandler(this.GroupBoxChangeCheck);
            // 
            // groupBox7
            // 
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Controls.Add(this.AddSuffixWindButton);
            this.groupBox7.Controls.Add(this.AddNumberWindButton);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // AddSuffixWindButton
            // 
            resources.ApplyResources(this.AddSuffixWindButton, "AddSuffixWindButton");
            this.AddSuffixWindButton.Name = "AddSuffixWindButton";
            this.AddSuffixWindButton.UseVisualStyleBackColor = true;
            this.AddSuffixWindButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddNumberWindButton
            // 
            resources.ApplyResources(this.AddNumberWindButton, "AddNumberWindButton");
            this.AddNumberWindButton.Name = "AddNumberWindButton";
            this.AddNumberWindButton.UseVisualStyleBackColor = true;
            this.AddNumberWindButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.UVIndexCheckbox);
            this.tabPage6.Controls.Add(this.groupBox8);
            resources.ApplyResources(this.tabPage6, "tabPage6");
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // UVIndexCheckbox
            // 
            resources.ApplyResources(this.UVIndexCheckbox, "UVIndexCheckbox");
            this.UVIndexCheckbox.Name = "UVIndexCheckbox";
            this.UVIndexCheckbox.UseVisualStyleBackColor = true;
            this.UVIndexCheckbox.CheckedChanged += new System.EventHandler(this.GroupBoxChangeCheck);
            // 
            // groupBox8
            // 
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Controls.Add(this.AddSuffixUVButton);
            this.groupBox8.Controls.Add(this.AddNumberUVButton);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // AddSuffixUVButton
            // 
            resources.ApplyResources(this.AddSuffixUVButton, "AddSuffixUVButton");
            this.AddSuffixUVButton.Name = "AddSuffixUVButton";
            this.AddSuffixUVButton.UseVisualStyleBackColor = true;
            this.AddSuffixUVButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddNumberUVButton
            // 
            resources.ApplyResources(this.AddNumberUVButton, "AddNumberUVButton");
            this.AddNumberUVButton.Name = "AddNumberUVButton";
            this.AddNumberUVButton.UseVisualStyleBackColor = true;
            this.AddNumberUVButton.Click += new System.EventHandler(this.AddNumberClick);
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ImagePic
            // 
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.ImagePic, "ImagePic");
            this.ImagePic.Name = "ImagePic";
            // 
            // WeatherForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WeatherForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WeatherForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.CheckBox WeatherIconCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddWeatherCustomIconButton;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.CheckBox TemperatureTodaySeparateNightCheckbox;
        private System.Windows.Forms.CheckBox TemperatureTodaySeparateDayCheckbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button AddDegreeImageTemperatureTodaySeparateNightButton;
        private System.Windows.Forms.Button AddMinusImageTemperatureTodaySeparateNightButton;
        private System.Windows.Forms.Button AddNumberTemperatureTodaySeparateNightButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddDegreeImageTemperatureTodaySeparateDayButton;
        private System.Windows.Forms.Button AddMinusImageTemperatureTodaySeparateDayButton;
        private System.Windows.Forms.Button AddNumberTemperatureTodaySeparateDayButton;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.CheckBox TemperatureTodayOnelineCheckbox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox AddForBothTemperatureTodayOnelineCheckBox;
        private System.Windows.Forms.Button AddDegreeImageTemperatureTodayOnelineButton;
        private System.Windows.Forms.Button AddNumberTemperatureTodayOnelineButton;
        private System.Windows.Forms.Button AddMinusImageTemperatureTodayOnelineButton;
        private System.Windows.Forms.Button AddDelimeterImageTemperatureTodayOnelineButton;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.CheckBox TemperatureCurrentCheckbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddDegreeImageTemperatureCurrentButton;
        private System.Windows.Forms.Button AddMinusImageTemperatureCurrentButton;
        private System.Windows.Forms.Button AddNumberTemperatureCurrentButton;
        private System.Windows.Forms.CheckBox HumidityCheckbox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button AddSuffixHumidityButton;
        private System.Windows.Forms.Button AddNumberHumidityButton;
        private System.Windows.Forms.Button AddSuffixImageHumidityButton;
        private System.Windows.Forms.CheckBox WindCheckbox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button AddNumberWindButton;
        private System.Windows.Forms.CheckBox UVIndexCheckbox;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button AddSuffixUVButton;
        private System.Windows.Forms.Button AddNumberUVButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel ImagePic;
        private System.Windows.Forms.Button AddSuffixWindButton;
    }
}