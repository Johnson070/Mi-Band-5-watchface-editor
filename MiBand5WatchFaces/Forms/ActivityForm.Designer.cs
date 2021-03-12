namespace MiBand5WatchFaces.Forms
{
    partial class ActivityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.stepsTab = new System.Windows.Forms.TabPage();
            this.stepsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addSuffixStepsButton = new System.Windows.Forms.Button();
            this.addPreffixStepsButton = new System.Windows.Forms.Button();
            this.addStepsButton = new System.Windows.Forms.Button();
            this.caloriesTab = new System.Windows.Forms.TabPage();
            this.caloriesCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addSuffixCaloriesButton = new System.Windows.Forms.Button();
            this.addPreffixCaloriesButton = new System.Windows.Forms.Button();
            this.addCaloriesButton = new System.Windows.Forms.Button();
            this.pulseTab = new System.Windows.Forms.TabPage();
            this.pulseCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addNoDataPulseButton = new System.Windows.Forms.Button();
            this.addSuffixPulseButton = new System.Windows.Forms.Button();
            this.addPreffixPulseButton = new System.Windows.Forms.Button();
            this.addPulseButton = new System.Windows.Forms.Button();
            this.distanceTab = new System.Windows.Forms.TabPage();
            this.distanceCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.addMiImageButton = new System.Windows.Forms.Button();
            this.addKmImageButton = new System.Windows.Forms.Button();
            this.addMiDistanceSuffixButton = new System.Windows.Forms.Button();
            this.addDecimalDistanceButton = new System.Windows.Forms.Button();
            this.addKmDistanceSuffixButton = new System.Windows.Forms.Button();
            this.addDistanceButton = new System.Windows.Forms.Button();
            this.paiTab = new System.Windows.Forms.TabPage();
            this.paiCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addPAIButton = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.stepsTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.caloriesTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pulseTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.distanceTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.paiTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.stepsTab);
            this.tabControl1.Controls.Add(this.caloriesTab);
            this.tabControl1.Controls.Add(this.pulseTab);
            this.tabControl1.Controls.Add(this.distanceTab);
            this.tabControl1.Controls.Add(this.paiTab);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // stepsTab
            // 
            this.stepsTab.Controls.Add(this.stepsCheckBox);
            this.stepsTab.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.stepsTab, "stepsTab");
            this.stepsTab.Name = "stepsTab";
            this.stepsTab.UseVisualStyleBackColor = true;
            // 
            // stepsCheckBox
            // 
            resources.ApplyResources(this.stepsCheckBox, "stepsCheckBox");
            this.stepsCheckBox.Name = "stepsCheckBox";
            this.stepsCheckBox.UseVisualStyleBackColor = true;
            this.stepsCheckBox.CheckedChanged += new System.EventHandler(this.updateGroupBox);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addSuffixStepsButton);
            this.groupBox1.Controls.Add(this.addPreffixStepsButton);
            this.groupBox1.Controls.Add(this.addStepsButton);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // addSuffixStepsButton
            // 
            resources.ApplyResources(this.addSuffixStepsButton, "addSuffixStepsButton");
            this.addSuffixStepsButton.Name = "addSuffixStepsButton";
            this.addSuffixStepsButton.UseVisualStyleBackColor = true;
            this.addSuffixStepsButton.Click += new System.EventHandler(this.addSuffixButtonClick);
            // 
            // addPreffixStepsButton
            // 
            resources.ApplyResources(this.addPreffixStepsButton, "addPreffixStepsButton");
            this.addPreffixStepsButton.Name = "addPreffixStepsButton";
            this.addPreffixStepsButton.UseVisualStyleBackColor = true;
            this.addPreffixStepsButton.Click += new System.EventHandler(this.addPreffixButtonClick);
            // 
            // addStepsButton
            // 
            resources.ApplyResources(this.addStepsButton, "addStepsButton");
            this.addStepsButton.Name = "addStepsButton";
            this.addStepsButton.UseVisualStyleBackColor = true;
            this.addStepsButton.Click += new System.EventHandler(this.addNumberButtonClick);
            // 
            // caloriesTab
            // 
            this.caloriesTab.Controls.Add(this.caloriesCheckBox);
            this.caloriesTab.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.caloriesTab, "caloriesTab");
            this.caloriesTab.Name = "caloriesTab";
            this.caloriesTab.UseVisualStyleBackColor = true;
            // 
            // caloriesCheckBox
            // 
            resources.ApplyResources(this.caloriesCheckBox, "caloriesCheckBox");
            this.caloriesCheckBox.Name = "caloriesCheckBox";
            this.caloriesCheckBox.UseVisualStyleBackColor = true;
            this.caloriesCheckBox.CheckedChanged += new System.EventHandler(this.updateGroupBox);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addSuffixCaloriesButton);
            this.groupBox2.Controls.Add(this.addPreffixCaloriesButton);
            this.groupBox2.Controls.Add(this.addCaloriesButton);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // addSuffixCaloriesButton
            // 
            resources.ApplyResources(this.addSuffixCaloriesButton, "addSuffixCaloriesButton");
            this.addSuffixCaloriesButton.Name = "addSuffixCaloriesButton";
            this.addSuffixCaloriesButton.UseVisualStyleBackColor = true;
            this.addSuffixCaloriesButton.Click += new System.EventHandler(this.addSuffixButtonClick);
            // 
            // addPreffixCaloriesButton
            // 
            resources.ApplyResources(this.addPreffixCaloriesButton, "addPreffixCaloriesButton");
            this.addPreffixCaloriesButton.Name = "addPreffixCaloriesButton";
            this.addPreffixCaloriesButton.UseVisualStyleBackColor = true;
            this.addPreffixCaloriesButton.Click += new System.EventHandler(this.addPreffixButtonClick);
            // 
            // addCaloriesButton
            // 
            resources.ApplyResources(this.addCaloriesButton, "addCaloriesButton");
            this.addCaloriesButton.Name = "addCaloriesButton";
            this.addCaloriesButton.UseVisualStyleBackColor = true;
            this.addCaloriesButton.Click += new System.EventHandler(this.addNumberButtonClick);
            // 
            // pulseTab
            // 
            this.pulseTab.Controls.Add(this.pulseCheckBox);
            this.pulseTab.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.pulseTab, "pulseTab");
            this.pulseTab.Name = "pulseTab";
            this.pulseTab.UseVisualStyleBackColor = true;
            // 
            // pulseCheckBox
            // 
            resources.ApplyResources(this.pulseCheckBox, "pulseCheckBox");
            this.pulseCheckBox.Name = "pulseCheckBox";
            this.pulseCheckBox.UseVisualStyleBackColor = true;
            this.pulseCheckBox.CheckedChanged += new System.EventHandler(this.updateGroupBox);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addNoDataPulseButton);
            this.groupBox3.Controls.Add(this.addSuffixPulseButton);
            this.groupBox3.Controls.Add(this.addPreffixPulseButton);
            this.groupBox3.Controls.Add(this.addPulseButton);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // addNoDataPulseButton
            // 
            resources.ApplyResources(this.addNoDataPulseButton, "addNoDataPulseButton");
            this.addNoDataPulseButton.Name = "addNoDataPulseButton";
            this.addNoDataPulseButton.UseVisualStyleBackColor = true;
            this.addNoDataPulseButton.Click += new System.EventHandler(this.addSuffixButtonClick);
            // 
            // addSuffixPulseButton
            // 
            resources.ApplyResources(this.addSuffixPulseButton, "addSuffixPulseButton");
            this.addSuffixPulseButton.Name = "addSuffixPulseButton";
            this.addSuffixPulseButton.UseVisualStyleBackColor = true;
            this.addSuffixPulseButton.Click += new System.EventHandler(this.addSuffixButtonClick);
            // 
            // addPreffixPulseButton
            // 
            resources.ApplyResources(this.addPreffixPulseButton, "addPreffixPulseButton");
            this.addPreffixPulseButton.Name = "addPreffixPulseButton";
            this.addPreffixPulseButton.UseVisualStyleBackColor = true;
            this.addPreffixPulseButton.Click += new System.EventHandler(this.addPreffixButtonClick);
            // 
            // addPulseButton
            // 
            resources.ApplyResources(this.addPulseButton, "addPulseButton");
            this.addPulseButton.Name = "addPulseButton";
            this.addPulseButton.UseVisualStyleBackColor = true;
            this.addPulseButton.Click += new System.EventHandler(this.addNumberButtonClick);
            // 
            // distanceTab
            // 
            this.distanceTab.Controls.Add(this.distanceCheckBox);
            this.distanceTab.Controls.Add(this.groupBox5);
            resources.ApplyResources(this.distanceTab, "distanceTab");
            this.distanceTab.Name = "distanceTab";
            this.distanceTab.UseVisualStyleBackColor = true;
            // 
            // distanceCheckBox
            // 
            resources.ApplyResources(this.distanceCheckBox, "distanceCheckBox");
            this.distanceCheckBox.Name = "distanceCheckBox";
            this.distanceCheckBox.UseVisualStyleBackColor = true;
            this.distanceCheckBox.CheckedChanged += new System.EventHandler(this.updateGroupBox);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.addMiImageButton);
            this.groupBox5.Controls.Add(this.addKmImageButton);
            this.groupBox5.Controls.Add(this.addMiDistanceSuffixButton);
            this.groupBox5.Controls.Add(this.addDecimalDistanceButton);
            this.groupBox5.Controls.Add(this.addKmDistanceSuffixButton);
            this.groupBox5.Controls.Add(this.addDistanceButton);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // addMiImageButton
            // 
            resources.ApplyResources(this.addMiImageButton, "addMiImageButton");
            this.addMiImageButton.Name = "addMiImageButton";
            this.addMiImageButton.UseVisualStyleBackColor = true;
            this.addMiImageButton.Click += new System.EventHandler(this.addImageDistance);
            // 
            // addKmImageButton
            // 
            resources.ApplyResources(this.addKmImageButton, "addKmImageButton");
            this.addKmImageButton.Name = "addKmImageButton";
            this.addKmImageButton.UseVisualStyleBackColor = true;
            this.addKmImageButton.Click += new System.EventHandler(this.addImageDistance);
            // 
            // addMiDistanceSuffixButton
            // 
            resources.ApplyResources(this.addMiDistanceSuffixButton, "addMiDistanceSuffixButton");
            this.addMiDistanceSuffixButton.Name = "addMiDistanceSuffixButton";
            this.addMiDistanceSuffixButton.UseVisualStyleBackColor = true;
            this.addMiDistanceSuffixButton.Click += new System.EventHandler(this.addSuffixButtonClick);
            // 
            // addDecimalDistanceButton
            // 
            resources.ApplyResources(this.addDecimalDistanceButton, "addDecimalDistanceButton");
            this.addDecimalDistanceButton.Name = "addDecimalDistanceButton";
            this.addDecimalDistanceButton.UseVisualStyleBackColor = true;
            this.addDecimalDistanceButton.Click += new System.EventHandler(this.addSuffixButtonClick);
            // 
            // addKmDistanceSuffixButton
            // 
            resources.ApplyResources(this.addKmDistanceSuffixButton, "addKmDistanceSuffixButton");
            this.addKmDistanceSuffixButton.Name = "addKmDistanceSuffixButton";
            this.addKmDistanceSuffixButton.UseVisualStyleBackColor = true;
            this.addKmDistanceSuffixButton.Click += new System.EventHandler(this.addSuffixButtonClick);
            // 
            // addDistanceButton
            // 
            resources.ApplyResources(this.addDistanceButton, "addDistanceButton");
            this.addDistanceButton.Name = "addDistanceButton";
            this.addDistanceButton.UseVisualStyleBackColor = true;
            this.addDistanceButton.Click += new System.EventHandler(this.addNumberButtonClick);
            // 
            // paiTab
            // 
            this.paiTab.Controls.Add(this.paiCheckBox);
            this.paiTab.Controls.Add(this.groupBox4);
            resources.ApplyResources(this.paiTab, "paiTab");
            this.paiTab.Name = "paiTab";
            this.paiTab.UseVisualStyleBackColor = true;
            // 
            // paiCheckBox
            // 
            resources.ApplyResources(this.paiCheckBox, "paiCheckBox");
            this.paiCheckBox.Name = "paiCheckBox";
            this.paiCheckBox.UseVisualStyleBackColor = true;
            this.paiCheckBox.CheckedChanged += new System.EventHandler(this.updateGroupBox);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addPAIButton);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // addPAIButton
            // 
            resources.ApplyResources(this.addPAIButton, "addPAIButton");
            this.addPAIButton.Name = "addPAIButton";
            this.addPAIButton.UseVisualStyleBackColor = true;
            this.addPAIButton.Click += new System.EventHandler(this.addNumberButtonClick);
            // 
            // ImagePic
            // 
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.ImagePic, "ImagePic");
            this.ImagePic.Name = "ImagePic";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ActivityForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ActivityForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActivityForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.stepsTab.ResumeLayout(false);
            this.stepsTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.caloriesTab.ResumeLayout(false);
            this.caloriesTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pulseTab.ResumeLayout(false);
            this.pulseTab.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.distanceTab.ResumeLayout(false);
            this.distanceTab.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.paiTab.ResumeLayout(false);
            this.paiTab.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage stepsTab;
        private System.Windows.Forms.TabPage caloriesTab;
        private System.Windows.Forms.TabPage pulseTab;
        private System.Windows.Forms.TabPage distanceTab;
        private System.Windows.Forms.TabPage paiTab;
        private System.Windows.Forms.CheckBox stepsCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addStepsButton;
        private System.Windows.Forms.Button addSuffixStepsButton;
        private System.Windows.Forms.Button addPreffixStepsButton;
        private System.Windows.Forms.CheckBox caloriesCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addSuffixCaloriesButton;
        private System.Windows.Forms.Button addPreffixCaloriesButton;
        private System.Windows.Forms.Button addCaloriesButton;
        private System.Windows.Forms.CheckBox pulseCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addSuffixPulseButton;
        private System.Windows.Forms.Button addPreffixPulseButton;
        private System.Windows.Forms.Button addPulseButton;
        private System.Windows.Forms.CheckBox distanceCheckBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button addMiDistanceSuffixButton;
        private System.Windows.Forms.Button addDecimalDistanceButton;
        private System.Windows.Forms.Button addKmDistanceSuffixButton;
        private System.Windows.Forms.Button addDistanceButton;
        private System.Windows.Forms.CheckBox paiCheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button addPAIButton;
        private System.Windows.Forms.Panel ImagePic;
        private System.Windows.Forms.Button addMiImageButton;
        private System.Windows.Forms.Button addKmImageButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addNoDataPulseButton;
    }
}