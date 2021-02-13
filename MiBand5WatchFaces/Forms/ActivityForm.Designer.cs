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
            this.addNoDataPulseButton = new System.Windows.Forms.Button();
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
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(365, 324);
            this.tabControl1.TabIndex = 0;
            // 
            // stepsTab
            // 
            this.stepsTab.Controls.Add(this.stepsCheckBox);
            this.stepsTab.Controls.Add(this.groupBox1);
            this.stepsTab.Location = new System.Drawing.Point(4, 27);
            this.stepsTab.Name = "stepsTab";
            this.stepsTab.Padding = new System.Windows.Forms.Padding(3);
            this.stepsTab.Size = new System.Drawing.Size(357, 293);
            this.stepsTab.TabIndex = 0;
            this.stepsTab.Text = "Steps";
            this.stepsTab.UseVisualStyleBackColor = true;
            // 
            // stepsCheckBox
            // 
            this.stepsCheckBox.AutoSize = true;
            this.stepsCheckBox.Location = new System.Drawing.Point(16, 9);
            this.stepsCheckBox.Name = "stepsCheckBox";
            this.stepsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.stepsCheckBox.TabIndex = 1;
            this.stepsCheckBox.UseVisualStyleBackColor = true;
            this.stepsCheckBox.CheckedChanged += new System.EventHandler(this.updateGroupBox);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addSuffixStepsButton);
            this.groupBox1.Controls.Add(this.addPreffixStepsButton);
            this.groupBox1.Controls.Add(this.addStepsButton);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "     Steps";
            // 
            // addSuffixStepsButton
            // 
            this.addSuffixStepsButton.Enabled = false;
            this.addSuffixStepsButton.Location = new System.Drawing.Point(6, 107);
            this.addSuffixStepsButton.Name = "addSuffixStepsButton";
            this.addSuffixStepsButton.Size = new System.Drawing.Size(331, 36);
            this.addSuffixStepsButton.TabIndex = 2;
            this.addSuffixStepsButton.Text = "Add suffix";
            this.addSuffixStepsButton.UseVisualStyleBackColor = true;
            this.addSuffixStepsButton.Click += new System.EventHandler(this.addSuffixButtonClick);
            // 
            // addPreffixStepsButton
            // 
            this.addPreffixStepsButton.Enabled = false;
            this.addPreffixStepsButton.Location = new System.Drawing.Point(6, 65);
            this.addPreffixStepsButton.Name = "addPreffixStepsButton";
            this.addPreffixStepsButton.Size = new System.Drawing.Size(331, 36);
            this.addPreffixStepsButton.TabIndex = 1;
            this.addPreffixStepsButton.Text = "Add preffix";
            this.addPreffixStepsButton.UseVisualStyleBackColor = true;
            this.addPreffixStepsButton.Click += new System.EventHandler(this.addPreffixButtonClick);
            // 
            // addStepsButton
            // 
            this.addStepsButton.Location = new System.Drawing.Point(6, 23);
            this.addStepsButton.Name = "addStepsButton";
            this.addStepsButton.Size = new System.Drawing.Size(331, 36);
            this.addStepsButton.TabIndex = 0;
            this.addStepsButton.Text = "Add steps";
            this.addStepsButton.UseVisualStyleBackColor = true;
            this.addStepsButton.Click += new System.EventHandler(this.addNumberButtonClick);
            // 
            // caloriesTab
            // 
            this.caloriesTab.Controls.Add(this.caloriesCheckBox);
            this.caloriesTab.Controls.Add(this.groupBox2);
            this.caloriesTab.Location = new System.Drawing.Point(4, 27);
            this.caloriesTab.Name = "caloriesTab";
            this.caloriesTab.Padding = new System.Windows.Forms.Padding(3);
            this.caloriesTab.Size = new System.Drawing.Size(357, 293);
            this.caloriesTab.TabIndex = 1;
            this.caloriesTab.Text = "Calories";
            this.caloriesTab.UseVisualStyleBackColor = true;
            // 
            // caloriesCheckBox
            // 
            this.caloriesCheckBox.AutoSize = true;
            this.caloriesCheckBox.Location = new System.Drawing.Point(16, 9);
            this.caloriesCheckBox.Name = "caloriesCheckBox";
            this.caloriesCheckBox.Size = new System.Drawing.Size(15, 14);
            this.caloriesCheckBox.TabIndex = 3;
            this.caloriesCheckBox.UseVisualStyleBackColor = true;
            this.caloriesCheckBox.CheckedChanged += new System.EventHandler(this.updateGroupBox);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addSuffixCaloriesButton);
            this.groupBox2.Controls.Add(this.addPreffixCaloriesButton);
            this.groupBox2.Controls.Add(this.addCaloriesButton);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 284);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "     Calories";
            // 
            // addSuffixCaloriesButton
            // 
            this.addSuffixCaloriesButton.Enabled = false;
            this.addSuffixCaloriesButton.Location = new System.Drawing.Point(6, 107);
            this.addSuffixCaloriesButton.Name = "addSuffixCaloriesButton";
            this.addSuffixCaloriesButton.Size = new System.Drawing.Size(331, 36);
            this.addSuffixCaloriesButton.TabIndex = 2;
            this.addSuffixCaloriesButton.Text = "Add suffix";
            this.addSuffixCaloriesButton.UseVisualStyleBackColor = true;
            this.addSuffixCaloriesButton.Click += new System.EventHandler(this.addSuffixButtonClick);
            // 
            // addPreffixCaloriesButton
            // 
            this.addPreffixCaloriesButton.Enabled = false;
            this.addPreffixCaloriesButton.Location = new System.Drawing.Point(6, 65);
            this.addPreffixCaloriesButton.Name = "addPreffixCaloriesButton";
            this.addPreffixCaloriesButton.Size = new System.Drawing.Size(331, 36);
            this.addPreffixCaloriesButton.TabIndex = 1;
            this.addPreffixCaloriesButton.Text = "Add preffix";
            this.addPreffixCaloriesButton.UseVisualStyleBackColor = true;
            this.addPreffixCaloriesButton.Click += new System.EventHandler(this.addPreffixButtonClick);
            // 
            // addCaloriesButton
            // 
            this.addCaloriesButton.Location = new System.Drawing.Point(6, 23);
            this.addCaloriesButton.Name = "addCaloriesButton";
            this.addCaloriesButton.Size = new System.Drawing.Size(331, 36);
            this.addCaloriesButton.TabIndex = 0;
            this.addCaloriesButton.Text = "Add calories";
            this.addCaloriesButton.UseVisualStyleBackColor = true;
            this.addCaloriesButton.Click += new System.EventHandler(this.addNumberButtonClick);
            // 
            // pulseTab
            // 
            this.pulseTab.Controls.Add(this.pulseCheckBox);
            this.pulseTab.Controls.Add(this.groupBox3);
            this.pulseTab.Location = new System.Drawing.Point(4, 27);
            this.pulseTab.Name = "pulseTab";
            this.pulseTab.Size = new System.Drawing.Size(357, 293);
            this.pulseTab.TabIndex = 2;
            this.pulseTab.Text = "Pulse";
            this.pulseTab.UseVisualStyleBackColor = true;
            // 
            // pulseCheckBox
            // 
            this.pulseCheckBox.AutoSize = true;
            this.pulseCheckBox.Location = new System.Drawing.Point(16, 9);
            this.pulseCheckBox.Name = "pulseCheckBox";
            this.pulseCheckBox.Size = new System.Drawing.Size(15, 14);
            this.pulseCheckBox.TabIndex = 3;
            this.pulseCheckBox.UseVisualStyleBackColor = true;
            this.pulseCheckBox.CheckedChanged += new System.EventHandler(this.updateGroupBox);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addNoDataPulseButton);
            this.groupBox3.Controls.Add(this.addSuffixPulseButton);
            this.groupBox3.Controls.Add(this.addPreffixPulseButton);
            this.groupBox3.Controls.Add(this.addPulseButton);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 284);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "     Pulse";
            // 
            // addSuffixPulseButton
            // 
            this.addSuffixPulseButton.Enabled = false;
            this.addSuffixPulseButton.Location = new System.Drawing.Point(6, 107);
            this.addSuffixPulseButton.Name = "addSuffixPulseButton";
            this.addSuffixPulseButton.Size = new System.Drawing.Size(331, 36);
            this.addSuffixPulseButton.TabIndex = 2;
            this.addSuffixPulseButton.Text = "Add suffix";
            this.addSuffixPulseButton.UseVisualStyleBackColor = true;
            this.addSuffixPulseButton.Click += new System.EventHandler(this.addSuffixButtonClick);
            // 
            // addPreffixPulseButton
            // 
            this.addPreffixPulseButton.Enabled = false;
            this.addPreffixPulseButton.Location = new System.Drawing.Point(6, 65);
            this.addPreffixPulseButton.Name = "addPreffixPulseButton";
            this.addPreffixPulseButton.Size = new System.Drawing.Size(331, 36);
            this.addPreffixPulseButton.TabIndex = 1;
            this.addPreffixPulseButton.Text = "Add preffix";
            this.addPreffixPulseButton.UseVisualStyleBackColor = true;
            this.addPreffixPulseButton.Click += new System.EventHandler(this.addPreffixButtonClick);
            // 
            // addPulseButton
            // 
            this.addPulseButton.Location = new System.Drawing.Point(6, 23);
            this.addPulseButton.Name = "addPulseButton";
            this.addPulseButton.Size = new System.Drawing.Size(331, 36);
            this.addPulseButton.TabIndex = 0;
            this.addPulseButton.Text = "Add pulse";
            this.addPulseButton.UseVisualStyleBackColor = true;
            this.addPulseButton.Click += new System.EventHandler(this.addNumberButtonClick);
            // 
            // distanceTab
            // 
            this.distanceTab.Controls.Add(this.distanceCheckBox);
            this.distanceTab.Controls.Add(this.groupBox5);
            this.distanceTab.Location = new System.Drawing.Point(4, 27);
            this.distanceTab.Name = "distanceTab";
            this.distanceTab.Size = new System.Drawing.Size(357, 293);
            this.distanceTab.TabIndex = 3;
            this.distanceTab.Text = "Distance";
            this.distanceTab.UseVisualStyleBackColor = true;
            // 
            // distanceCheckBox
            // 
            this.distanceCheckBox.AutoSize = true;
            this.distanceCheckBox.Location = new System.Drawing.Point(16, 9);
            this.distanceCheckBox.Name = "distanceCheckBox";
            this.distanceCheckBox.Size = new System.Drawing.Size(15, 14);
            this.distanceCheckBox.TabIndex = 3;
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
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(343, 280);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "     Distance";
            // 
            // addMiImageButton
            // 
            this.addMiImageButton.Enabled = false;
            this.addMiImageButton.Location = new System.Drawing.Point(6, 233);
            this.addMiImageButton.Name = "addMiImageButton";
            this.addMiImageButton.Size = new System.Drawing.Size(331, 36);
            this.addMiImageButton.TabIndex = 5;
            this.addMiImageButton.Text = "Add MI image";
            this.addMiImageButton.UseVisualStyleBackColor = true;
            this.addMiImageButton.Click += new System.EventHandler(this.addImageDistance);
            // 
            // addKmImageButton
            // 
            this.addKmImageButton.Enabled = false;
            this.addKmImageButton.Location = new System.Drawing.Point(6, 191);
            this.addKmImageButton.Name = "addKmImageButton";
            this.addKmImageButton.Size = new System.Drawing.Size(331, 36);
            this.addKmImageButton.TabIndex = 4;
            this.addKmImageButton.Text = "Add KM image";
            this.addKmImageButton.UseVisualStyleBackColor = true;
            this.addKmImageButton.Click += new System.EventHandler(this.addImageDistance);
            // 
            // addMiDistanceSuffixButton
            // 
            this.addMiDistanceSuffixButton.Enabled = false;
            this.addMiDistanceSuffixButton.Location = new System.Drawing.Point(6, 149);
            this.addMiDistanceSuffixButton.Name = "addMiDistanceSuffixButton";
            this.addMiDistanceSuffixButton.Size = new System.Drawing.Size(331, 36);
            this.addMiDistanceSuffixButton.TabIndex = 3;
            this.addMiDistanceSuffixButton.Text = "Add MI suffix";
            this.addMiDistanceSuffixButton.UseVisualStyleBackColor = true;
            this.addMiDistanceSuffixButton.Click += new System.EventHandler(this.addSuffixButtonClick);
            // 
            // addDecimalDistanceButton
            // 
            this.addDecimalDistanceButton.Enabled = false;
            this.addDecimalDistanceButton.Location = new System.Drawing.Point(6, 107);
            this.addDecimalDistanceButton.Name = "addDecimalDistanceButton";
            this.addDecimalDistanceButton.Size = new System.Drawing.Size(331, 36);
            this.addDecimalDistanceButton.TabIndex = 2;
            this.addDecimalDistanceButton.Text = "Add decimal point";
            this.addDecimalDistanceButton.UseVisualStyleBackColor = true;
            this.addDecimalDistanceButton.Click += new System.EventHandler(this.addSuffixButtonClick);
            // 
            // addKmDistanceSuffixButton
            // 
            this.addKmDistanceSuffixButton.Enabled = false;
            this.addKmDistanceSuffixButton.Location = new System.Drawing.Point(6, 65);
            this.addKmDistanceSuffixButton.Name = "addKmDistanceSuffixButton";
            this.addKmDistanceSuffixButton.Size = new System.Drawing.Size(331, 36);
            this.addKmDistanceSuffixButton.TabIndex = 1;
            this.addKmDistanceSuffixButton.Text = "Add KM suffix";
            this.addKmDistanceSuffixButton.UseVisualStyleBackColor = true;
            this.addKmDistanceSuffixButton.Click += new System.EventHandler(this.addSuffixButtonClick);
            // 
            // addDistanceButton
            // 
            this.addDistanceButton.Location = new System.Drawing.Point(6, 23);
            this.addDistanceButton.Name = "addDistanceButton";
            this.addDistanceButton.Size = new System.Drawing.Size(331, 36);
            this.addDistanceButton.TabIndex = 0;
            this.addDistanceButton.Text = "Add distance";
            this.addDistanceButton.UseVisualStyleBackColor = true;
            this.addDistanceButton.Click += new System.EventHandler(this.addNumberButtonClick);
            // 
            // paiTab
            // 
            this.paiTab.Controls.Add(this.paiCheckBox);
            this.paiTab.Controls.Add(this.groupBox4);
            this.paiTab.Location = new System.Drawing.Point(4, 27);
            this.paiTab.Name = "paiTab";
            this.paiTab.Size = new System.Drawing.Size(357, 293);
            this.paiTab.TabIndex = 4;
            this.paiTab.Text = "PAI";
            this.paiTab.UseVisualStyleBackColor = true;
            // 
            // paiCheckBox
            // 
            this.paiCheckBox.AutoSize = true;
            this.paiCheckBox.Location = new System.Drawing.Point(16, 9);
            this.paiCheckBox.Name = "paiCheckBox";
            this.paiCheckBox.Size = new System.Drawing.Size(15, 14);
            this.paiCheckBox.TabIndex = 3;
            this.paiCheckBox.UseVisualStyleBackColor = true;
            this.paiCheckBox.CheckedChanged += new System.EventHandler(this.updateGroupBox);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addPAIButton);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(343, 284);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "     PAI";
            // 
            // addPAIButton
            // 
            this.addPAIButton.Location = new System.Drawing.Point(6, 23);
            this.addPAIButton.Name = "addPAIButton";
            this.addPAIButton.Size = new System.Drawing.Size(331, 36);
            this.addPAIButton.TabIndex = 0;
            this.addPAIButton.Text = "Add PAI";
            this.addPAIButton.UseVisualStyleBackColor = true;
            this.addPAIButton.Click += new System.EventHandler(this.addNumberButtonClick);
            // 
            // ImagePic
            // 
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Location = new System.Drawing.Point(383, 35);
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.Size = new System.Drawing.Size(126, 294);
            this.ImagePic.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(12, 342);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(498, 37);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addNoDataPulseButton
            // 
            this.addNoDataPulseButton.Enabled = false;
            this.addNoDataPulseButton.Location = new System.Drawing.Point(6, 149);
            this.addNoDataPulseButton.Name = "addNoDataPulseButton";
            this.addNoDataPulseButton.Size = new System.Drawing.Size(331, 36);
            this.addNoDataPulseButton.TabIndex = 3;
            this.addNoDataPulseButton.Text = "Add no data";
            this.addNoDataPulseButton.UseVisualStyleBackColor = true;
            this.addNoDataPulseButton.Click += new System.EventHandler(this.addSuffixButtonClick);
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 391);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity";
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