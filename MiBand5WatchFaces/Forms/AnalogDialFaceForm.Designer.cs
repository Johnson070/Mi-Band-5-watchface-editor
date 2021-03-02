
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
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(12, 312);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(523, 37);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ImagePic
            // 
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Location = new System.Drawing.Point(409, 12);
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.Size = new System.Drawing.Size(126, 294);
            this.ImagePic.TabIndex = 18;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(391, 294);
            this.tabs.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hoursCheckbox);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(383, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hours";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hoursCheckbox
            // 
            this.hoursCheckbox.AutoSize = true;
            this.hoursCheckbox.Location = new System.Drawing.Point(15, 6);
            this.hoursCheckbox.Name = "hoursCheckbox";
            this.hoursCheckbox.Size = new System.Drawing.Size(15, 14);
            this.hoursCheckbox.TabIndex = 9;
            this.hoursCheckbox.UseVisualStyleBackColor = true;
            this.hoursCheckbox.CheckedChanged += new System.EventHandler(this.tabCheckState);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.AddArrowHoursButton);
            this.groupBox3.Controls.Add(this.propertiesHoursGroup);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 251);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "     ";
            // 
            // AddArrowHoursButton
            // 
            this.AddArrowHoursButton.Location = new System.Drawing.Point(6, 23);
            this.AddArrowHoursButton.Name = "AddArrowHoursButton";
            this.AddArrowHoursButton.Size = new System.Drawing.Size(359, 44);
            this.AddArrowHoursButton.TabIndex = 25;
            this.AddArrowHoursButton.Text = "Add arrow";
            this.AddArrowHoursButton.UseVisualStyleBackColor = true;
            this.AddArrowHoursButton.Click += new System.EventHandler(this.AddArrowHoursButton_Click);
            // 
            // propertiesHoursGroup
            // 
            this.propertiesHoursGroup.Controls.Add(this.AddColorButtonHours);
            this.propertiesHoursGroup.Controls.Add(this.label1);
            this.propertiesHoursGroup.Controls.Add(this.OnlyborderHours);
            this.propertiesHoursGroup.Controls.Add(this.AddCenterImageHoursButton);
            this.propertiesHoursGroup.Controls.Add(this.posYHours);
            this.propertiesHoursGroup.Controls.Add(this.label6);
            this.propertiesHoursGroup.Controls.Add(this.posXHours);
            this.propertiesHoursGroup.Enabled = false;
            this.propertiesHoursGroup.Location = new System.Drawing.Point(6, 77);
            this.propertiesHoursGroup.Name = "propertiesHoursGroup";
            this.propertiesHoursGroup.Size = new System.Drawing.Size(359, 168);
            this.propertiesHoursGroup.TabIndex = 24;
            this.propertiesHoursGroup.TabStop = false;
            this.propertiesHoursGroup.Text = "Properties";
            // 
            // AddColorButtonHours
            // 
            this.AddColorButtonHours.BackColor = System.Drawing.Color.Black;
            this.AddColorButtonHours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddColorButtonHours.Location = new System.Drawing.Point(89, 73);
            this.AddColorButtonHours.Name = "AddColorButtonHours";
            this.AddColorButtonHours.Size = new System.Drawing.Size(74, 31);
            this.AddColorButtonHours.TabIndex = 26;
            this.AddColorButtonHours.UseVisualStyleBackColor = false;
            this.AddColorButtonHours.Click += new System.EventHandler(this.AddColorButtonHours_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Color:";
            // 
            // OnlyborderHours
            // 
            this.OnlyborderHours.AutoSize = true;
            this.OnlyborderHours.Location = new System.Drawing.Point(6, 140);
            this.OnlyborderHours.Name = "OnlyborderHours";
            this.OnlyborderHours.Size = new System.Drawing.Size(104, 22);
            this.OnlyborderHours.TabIndex = 24;
            this.OnlyborderHours.Text = "Only border";
            this.OnlyborderHours.UseVisualStyleBackColor = true;
            this.OnlyborderHours.CheckedChanged += new System.EventHandler(this.OnlyborderHours_CheckedChanged);
            // 
            // AddCenterImageHoursButton
            // 
            this.AddCenterImageHoursButton.Location = new System.Drawing.Point(6, 23);
            this.AddCenterImageHoursButton.Name = "AddCenterImageHoursButton";
            this.AddCenterImageHoursButton.Size = new System.Drawing.Size(347, 44);
            this.AddCenterImageHoursButton.TabIndex = 0;
            this.AddCenterImageHoursButton.Text = "Add center image";
            this.AddCenterImageHoursButton.UseVisualStyleBackColor = true;
            this.AddCenterImageHoursButton.Click += new System.EventHandler(this.AddCenterImageHoursButton_Click);
            // 
            // posYHours
            // 
            this.posYHours.Location = new System.Drawing.Point(146, 110);
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
            this.posYHours.Size = new System.Drawing.Size(49, 24);
            this.posYHours.TabIndex = 23;
            this.posYHours.ValueChanged += new System.EventHandler(this.changePos);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Center:";
            // 
            // posXHours
            // 
            this.posXHours.Location = new System.Drawing.Point(89, 110);
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
            this.posXHours.Size = new System.Drawing.Size(49, 24);
            this.posXHours.TabIndex = 22;
            this.posXHours.ValueChanged += new System.EventHandler(this.changePos);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.minutesCheckbox);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(383, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Minutes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // minutesCheckbox
            // 
            this.minutesCheckbox.AutoSize = true;
            this.minutesCheckbox.Location = new System.Drawing.Point(15, 6);
            this.minutesCheckbox.Name = "minutesCheckbox";
            this.minutesCheckbox.Size = new System.Drawing.Size(15, 14);
            this.minutesCheckbox.TabIndex = 11;
            this.minutesCheckbox.UseVisualStyleBackColor = true;
            this.minutesCheckbox.CheckedChanged += new System.EventHandler(this.tabCheckState);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AddArrowMinutesButton);
            this.groupBox1.Controls.Add(this.PropertiesMinutesGroupBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 251);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "     ";
            // 
            // AddArrowMinutesButton
            // 
            this.AddArrowMinutesButton.Location = new System.Drawing.Point(6, 23);
            this.AddArrowMinutesButton.Name = "AddArrowMinutesButton";
            this.AddArrowMinutesButton.Size = new System.Drawing.Size(359, 44);
            this.AddArrowMinutesButton.TabIndex = 27;
            this.AddArrowMinutesButton.Text = "Add arrow";
            this.AddArrowMinutesButton.UseVisualStyleBackColor = true;
            this.AddArrowMinutesButton.Click += new System.EventHandler(this.AddArrowMinutesButton_Click);
            // 
            // PropertiesMinutesGroupBox
            // 
            this.PropertiesMinutesGroupBox.Controls.Add(this.AddColorMinutesButton);
            this.PropertiesMinutesGroupBox.Controls.Add(this.label2);
            this.PropertiesMinutesGroupBox.Controls.Add(this.OnlyborderMinutes);
            this.PropertiesMinutesGroupBox.Controls.Add(this.AddCenterImageMinutesButton);
            this.PropertiesMinutesGroupBox.Controls.Add(this.posYMinutes);
            this.PropertiesMinutesGroupBox.Controls.Add(this.label3);
            this.PropertiesMinutesGroupBox.Controls.Add(this.posXMinutes);
            this.PropertiesMinutesGroupBox.Enabled = false;
            this.PropertiesMinutesGroupBox.Location = new System.Drawing.Point(6, 77);
            this.PropertiesMinutesGroupBox.Name = "PropertiesMinutesGroupBox";
            this.PropertiesMinutesGroupBox.Size = new System.Drawing.Size(359, 168);
            this.PropertiesMinutesGroupBox.TabIndex = 26;
            this.PropertiesMinutesGroupBox.TabStop = false;
            this.PropertiesMinutesGroupBox.Text = "Properties";
            // 
            // AddColorMinutesButton
            // 
            this.AddColorMinutesButton.BackColor = System.Drawing.Color.Black;
            this.AddColorMinutesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddColorMinutesButton.Location = new System.Drawing.Point(89, 73);
            this.AddColorMinutesButton.Name = "AddColorMinutesButton";
            this.AddColorMinutesButton.Size = new System.Drawing.Size(74, 31);
            this.AddColorMinutesButton.TabIndex = 26;
            this.AddColorMinutesButton.UseVisualStyleBackColor = false;
            this.AddColorMinutesButton.Click += new System.EventHandler(this.AddColorMinutesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Color:";
            // 
            // OnlyborderMinutes
            // 
            this.OnlyborderMinutes.AutoSize = true;
            this.OnlyborderMinutes.Location = new System.Drawing.Point(6, 140);
            this.OnlyborderMinutes.Name = "OnlyborderMinutes";
            this.OnlyborderMinutes.Size = new System.Drawing.Size(104, 22);
            this.OnlyborderMinutes.TabIndex = 24;
            this.OnlyborderMinutes.Text = "Only border";
            this.OnlyborderMinutes.UseVisualStyleBackColor = true;
            this.OnlyborderMinutes.CheckedChanged += new System.EventHandler(this.OnlyborderMinutes_CheckedChanged);
            // 
            // AddCenterImageMinutesButton
            // 
            this.AddCenterImageMinutesButton.Location = new System.Drawing.Point(6, 23);
            this.AddCenterImageMinutesButton.Name = "AddCenterImageMinutesButton";
            this.AddCenterImageMinutesButton.Size = new System.Drawing.Size(347, 44);
            this.AddCenterImageMinutesButton.TabIndex = 0;
            this.AddCenterImageMinutesButton.Text = "Add center image";
            this.AddCenterImageMinutesButton.UseVisualStyleBackColor = true;
            this.AddCenterImageMinutesButton.Click += new System.EventHandler(this.AddCenterImageMinutesButton_Click);
            // 
            // posYMinutes
            // 
            this.posYMinutes.Location = new System.Drawing.Point(146, 110);
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
            this.posYMinutes.Size = new System.Drawing.Size(49, 24);
            this.posYMinutes.TabIndex = 23;
            this.posYMinutes.ValueChanged += new System.EventHandler(this.changePos);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Center:";
            // 
            // posXMinutes
            // 
            this.posXMinutes.Location = new System.Drawing.Point(89, 110);
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
            this.posXMinutes.Size = new System.Drawing.Size(49, 24);
            this.posXMinutes.TabIndex = 22;
            this.posXMinutes.ValueChanged += new System.EventHandler(this.changePos);
            // 
            // AnalogDialFaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 362);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AnalogDialFaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Analog dial face";
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