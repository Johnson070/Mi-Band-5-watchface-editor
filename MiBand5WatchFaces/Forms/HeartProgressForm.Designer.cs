
namespace MiBand5WatchFaces.Forms
{
    partial class HeartProgressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeartProgressForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ScaleImageCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddScaleButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LineScaleCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddLineScaleButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LinearCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddLinearImages = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 294);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ScaleImageCheckbox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(458, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scale";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ScaleImageCheckbox
            // 
            this.ScaleImageCheckbox.AutoSize = true;
            this.ScaleImageCheckbox.Location = new System.Drawing.Point(15, 6);
            this.ScaleImageCheckbox.Name = "ScaleImageCheckbox";
            this.ScaleImageCheckbox.Size = new System.Drawing.Size(15, 14);
            this.ScaleImageCheckbox.TabIndex = 5;
            this.ScaleImageCheckbox.UseVisualStyleBackColor = true;
            this.ScaleImageCheckbox.CheckedChanged += new System.EventHandler(this.ChangeCheck);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AddScaleButton);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 251);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "     ";
            // 
            // AddScaleButton
            // 
            this.AddScaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddScaleButton.Location = new System.Drawing.Point(6, 23);
            this.AddScaleButton.Name = "AddScaleButton";
            this.AddScaleButton.Size = new System.Drawing.Size(436, 54);
            this.AddScaleButton.TabIndex = 0;
            this.AddScaleButton.Text = "Add images";
            this.AddScaleButton.UseVisualStyleBackColor = true;
            this.AddScaleButton.Click += new System.EventHandler(this.AddScaleButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LineScaleCheckbox);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(458, 263);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Line scale";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LineScaleCheckbox
            // 
            this.LineScaleCheckbox.AutoSize = true;
            this.LineScaleCheckbox.Location = new System.Drawing.Point(15, 6);
            this.LineScaleCheckbox.Name = "LineScaleCheckbox";
            this.LineScaleCheckbox.Size = new System.Drawing.Size(15, 14);
            this.LineScaleCheckbox.TabIndex = 7;
            this.LineScaleCheckbox.UseVisualStyleBackColor = true;
            this.LineScaleCheckbox.CheckedChanged += new System.EventHandler(this.ChangeCheck);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.AddLineScaleButton);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 251);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "     ";
            // 
            // AddLineScaleButton
            // 
            this.AddLineScaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLineScaleButton.Location = new System.Drawing.Point(6, 23);
            this.AddLineScaleButton.Name = "AddLineScaleButton";
            this.AddLineScaleButton.Size = new System.Drawing.Size(436, 54);
            this.AddLineScaleButton.TabIndex = 0;
            this.AddLineScaleButton.Text = "Add images";
            this.AddLineScaleButton.UseVisualStyleBackColor = true;
            this.AddLineScaleButton.Click += new System.EventHandler(this.AddLineScaleButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LinearCheckBox);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(458, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Linear";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LinearCheckBox
            // 
            this.LinearCheckBox.AutoSize = true;
            this.LinearCheckBox.Location = new System.Drawing.Point(15, 6);
            this.LinearCheckBox.Name = "LinearCheckBox";
            this.LinearCheckBox.Size = new System.Drawing.Size(15, 14);
            this.LinearCheckBox.TabIndex = 7;
            this.LinearCheckBox.UseVisualStyleBackColor = true;
            this.LinearCheckBox.CheckedChanged += new System.EventHandler(this.ChangeCheck);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.AddLinearImages);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 251);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "     ";
            // 
            // AddLinearImages
            // 
            this.AddLinearImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLinearImages.Location = new System.Drawing.Point(6, 23);
            this.AddLinearImages.Name = "AddLinearImages";
            this.AddLinearImages.Size = new System.Drawing.Size(436, 54);
            this.AddLinearImages.TabIndex = 0;
            this.AddLinearImages.Text = "Add images";
            this.AddLinearImages.UseVisualStyleBackColor = true;
            this.AddLinearImages.Click += new System.EventHandler(this.AddLineScaleImages_Click);
            // 
            // ImagePic
            // 
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Location = new System.Drawing.Point(484, 12);
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.Size = new System.Drawing.Size(126, 294);
            this.ImagePic.TabIndex = 13;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(12, 312);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(598, 37);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // HeartProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 360);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HeartProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heart Progress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NumberFormEdit_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel ImagePic;
        private System.Windows.Forms.CheckBox ScaleImageCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddScaleButton;
        private System.Windows.Forms.CheckBox LinearCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddLinearImages;
        private System.Windows.Forms.CheckBox LineScaleCheckbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddLineScaleButton;
        private System.Windows.Forms.Button saveButton;
    }
}