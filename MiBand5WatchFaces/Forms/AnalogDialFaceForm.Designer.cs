
namespace MiBand5WatchFaces.Forms
{
    partial class AnalogDialFaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalogDialFaceForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hoursCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddArrowHoursButton = new System.Windows.Forms.Button();
            this.propertiesHoursGroup = new System.Windows.Forms.GroupBox();
            this.AddColorButtonHours = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OnlyborderHours = new System.Windows.Forms.CheckBox();
            this.AddCenterImageHoursButton = new System.Windows.Forms.Button();
            this.posYHours = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.posXHours = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.minutesCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddArrowMinutesButton = new System.Windows.Forms.Button();
            this.PropertiesMinutesGroupBox = new System.Windows.Forms.GroupBox();
            this.AddColorMinutesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OnlyborderMinutes = new System.Windows.Forms.CheckBox();
            this.AddCenterImageMinutesButton = new System.Windows.Forms.Button();
            this.posYMinutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.posXMinutes = new System.Windows.Forms.NumericUpDown();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.propertiesHoursGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXHours)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PropertiesMinutesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ImagePic
            // 
            resources.ApplyResources(this.ImagePic, "ImagePic");
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Name = "ImagePic";
            // 
            // tabs
            // 
            resources.ApplyResources(this.tabs, "tabs");
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.hoursCheckbox);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hoursCheckbox
            // 
            resources.ApplyResources(this.hoursCheckbox, "hoursCheckbox");
            this.hoursCheckbox.Name = "hoursCheckbox";
            this.hoursCheckbox.UseVisualStyleBackColor = true;
            this.hoursCheckbox.CheckedChanged += new System.EventHandler(this.tabCheckState);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.AddArrowHoursButton);
            this.groupBox3.Controls.Add(this.propertiesHoursGroup);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // AddArrowHoursButton
            // 
            resources.ApplyResources(this.AddArrowHoursButton, "AddArrowHoursButton");
            this.AddArrowHoursButton.Name = "AddArrowHoursButton";
            this.AddArrowHoursButton.UseVisualStyleBackColor = true;
            this.AddArrowHoursButton.Click += new System.EventHandler(this.AddArrowHoursButton_Click);
            // 
            // propertiesHoursGroup
            // 
            resources.ApplyResources(this.propertiesHoursGroup, "propertiesHoursGroup");
            this.propertiesHoursGroup.Controls.Add(this.AddColorButtonHours);
            this.propertiesHoursGroup.Controls.Add(this.label1);
            this.propertiesHoursGroup.Controls.Add(this.OnlyborderHours);
            this.propertiesHoursGroup.Controls.Add(this.AddCenterImageHoursButton);
            this.propertiesHoursGroup.Controls.Add(this.posYHours);
            this.propertiesHoursGroup.Controls.Add(this.label6);
            this.propertiesHoursGroup.Controls.Add(this.posXHours);
            this.propertiesHoursGroup.Name = "propertiesHoursGroup";
            this.propertiesHoursGroup.TabStop = false;
            // 
            // AddColorButtonHours
            // 
            resources.ApplyResources(this.AddColorButtonHours, "AddColorButtonHours");
            this.AddColorButtonHours.BackColor = System.Drawing.Color.Black;
            this.AddColorButtonHours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddColorButtonHours.Name = "AddColorButtonHours";
            this.AddColorButtonHours.UseVisualStyleBackColor = false;
            this.AddColorButtonHours.Click += new System.EventHandler(this.AddColorButtonHours_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // OnlyborderHours
            // 
            resources.ApplyResources(this.OnlyborderHours, "OnlyborderHours");
            this.OnlyborderHours.Name = "OnlyborderHours";
            this.OnlyborderHours.UseVisualStyleBackColor = true;
            this.OnlyborderHours.CheckedChanged += new System.EventHandler(this.OnlyborderHours_CheckedChanged);
            // 
            // AddCenterImageHoursButton
            // 
            resources.ApplyResources(this.AddCenterImageHoursButton, "AddCenterImageHoursButton");
            this.AddCenterImageHoursButton.Name = "AddCenterImageHoursButton";
            this.AddCenterImageHoursButton.UseVisualStyleBackColor = true;
            this.AddCenterImageHoursButton.Click += new System.EventHandler(this.AddCenterImageHoursButton_Click);
            // 
            // posYHours
            // 
            resources.ApplyResources(this.posYHours, "posYHours");
            this.posYHours.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.posYHours.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.posYHours.Name = "posYHours";
            this.posYHours.ValueChanged += new System.EventHandler(this.changePos);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // posXHours
            // 
            resources.ApplyResources(this.posXHours, "posXHours");
            this.posXHours.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.posXHours.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.posXHours.Name = "posXHours";
            this.posXHours.ValueChanged += new System.EventHandler(this.changePos);
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.minutesCheckbox);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // minutesCheckbox
            // 
            resources.ApplyResources(this.minutesCheckbox, "minutesCheckbox");
            this.minutesCheckbox.Name = "minutesCheckbox";
            this.minutesCheckbox.UseVisualStyleBackColor = true;
            this.minutesCheckbox.CheckedChanged += new System.EventHandler(this.tabCheckState);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.AddArrowMinutesButton);
            this.groupBox1.Controls.Add(this.PropertiesMinutesGroupBox);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // AddArrowMinutesButton
            // 
            resources.ApplyResources(this.AddArrowMinutesButton, "AddArrowMinutesButton");
            this.AddArrowMinutesButton.Name = "AddArrowMinutesButton";
            this.AddArrowMinutesButton.UseVisualStyleBackColor = true;
            this.AddArrowMinutesButton.Click += new System.EventHandler(this.AddArrowMinutesButton_Click);
            // 
            // PropertiesMinutesGroupBox
            // 
            resources.ApplyResources(this.PropertiesMinutesGroupBox, "PropertiesMinutesGroupBox");
            this.PropertiesMinutesGroupBox.Controls.Add(this.AddColorMinutesButton);
            this.PropertiesMinutesGroupBox.Controls.Add(this.label2);
            this.PropertiesMinutesGroupBox.Controls.Add(this.OnlyborderMinutes);
            this.PropertiesMinutesGroupBox.Controls.Add(this.AddCenterImageMinutesButton);
            this.PropertiesMinutesGroupBox.Controls.Add(this.posYMinutes);
            this.PropertiesMinutesGroupBox.Controls.Add(this.label3);
            this.PropertiesMinutesGroupBox.Controls.Add(this.posXMinutes);
            this.PropertiesMinutesGroupBox.Name = "PropertiesMinutesGroupBox";
            this.PropertiesMinutesGroupBox.TabStop = false;
            // 
            // AddColorMinutesButton
            // 
            resources.ApplyResources(this.AddColorMinutesButton, "AddColorMinutesButton");
            this.AddColorMinutesButton.BackColor = System.Drawing.Color.Black;
            this.AddColorMinutesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddColorMinutesButton.Name = "AddColorMinutesButton";
            this.AddColorMinutesButton.UseVisualStyleBackColor = false;
            this.AddColorMinutesButton.Click += new System.EventHandler(this.AddColorMinutesButton_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // OnlyborderMinutes
            // 
            resources.ApplyResources(this.OnlyborderMinutes, "OnlyborderMinutes");
            this.OnlyborderMinutes.Name = "OnlyborderMinutes";
            this.OnlyborderMinutes.UseVisualStyleBackColor = true;
            this.OnlyborderMinutes.CheckedChanged += new System.EventHandler(this.OnlyborderMinutes_CheckedChanged);
            // 
            // AddCenterImageMinutesButton
            // 
            resources.ApplyResources(this.AddCenterImageMinutesButton, "AddCenterImageMinutesButton");
            this.AddCenterImageMinutesButton.Name = "AddCenterImageMinutesButton";
            this.AddCenterImageMinutesButton.UseVisualStyleBackColor = true;
            this.AddCenterImageMinutesButton.Click += new System.EventHandler(this.AddCenterImageMinutesButton_Click);
            // 
            // posYMinutes
            // 
            resources.ApplyResources(this.posYMinutes, "posYMinutes");
            this.posYMinutes.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.posYMinutes.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.posYMinutes.Name = "posYMinutes";
            this.posYMinutes.ValueChanged += new System.EventHandler(this.changePos);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // posXMinutes
            // 
            resources.ApplyResources(this.posXMinutes, "posXMinutes");
            this.posXMinutes.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.posXMinutes.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.posXMinutes.Name = "posXMinutes";
            this.posXMinutes.ValueChanged += new System.EventHandler(this.changePos);
            // 
            // AnalogDialFaceForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AnalogDialFaceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnalogDialFaceForm_FormClosing);
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.propertiesHoursGroup.ResumeLayout(false);
            this.propertiesHoursGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXHours)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.PropertiesMinutesGroupBox.ResumeLayout(false);
            this.PropertiesMinutesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXMinutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel ImagePic;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox hoursCheckbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddCenterImageHoursButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox minutesCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox propertiesHoursGroup;
        private System.Windows.Forms.CheckBox OnlyborderHours;
        private System.Windows.Forms.NumericUpDown posYHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown posXHours;
        private System.Windows.Forms.Button AddArrowHoursButton;
        private System.Windows.Forms.Button AddColorButtonHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddArrowMinutesButton;
        private System.Windows.Forms.GroupBox PropertiesMinutesGroupBox;
        private System.Windows.Forms.Button AddColorMinutesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox OnlyborderMinutes;
        private System.Windows.Forms.Button AddCenterImageMinutesButton;
        private System.Windows.Forms.NumericUpDown posYMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown posXMinutes;
    }
}