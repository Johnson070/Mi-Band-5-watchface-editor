
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
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ScaleImageCheckbox);
            this.tabPage1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ScaleImageCheckbox
            // 
            resources.ApplyResources(this.ScaleImageCheckbox, "ScaleImageCheckbox");
            this.ScaleImageCheckbox.Name = "ScaleImageCheckbox";
            this.ScaleImageCheckbox.UseVisualStyleBackColor = true;
            this.ScaleImageCheckbox.CheckedChanged += new System.EventHandler(this.ChangeCheck);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.AddScaleButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // AddScaleButton
            // 
            resources.ApplyResources(this.AddScaleButton, "AddScaleButton");
            this.AddScaleButton.Name = "AddScaleButton";
            this.AddScaleButton.UseVisualStyleBackColor = true;
            this.AddScaleButton.Click += new System.EventHandler(this.AddScaleButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LineScaleCheckbox);
            this.tabPage3.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LineScaleCheckbox
            // 
            resources.ApplyResources(this.LineScaleCheckbox, "LineScaleCheckbox");
            this.LineScaleCheckbox.Name = "LineScaleCheckbox";
            this.LineScaleCheckbox.UseVisualStyleBackColor = true;
            this.LineScaleCheckbox.CheckedChanged += new System.EventHandler(this.ChangeCheck);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.AddLineScaleButton);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // AddLineScaleButton
            // 
            resources.ApplyResources(this.AddLineScaleButton, "AddLineScaleButton");
            this.AddLineScaleButton.Name = "AddLineScaleButton";
            this.AddLineScaleButton.UseVisualStyleBackColor = true;
            this.AddLineScaleButton.Click += new System.EventHandler(this.AddLineScaleButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LinearCheckBox);
            this.tabPage2.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LinearCheckBox
            // 
            resources.ApplyResources(this.LinearCheckBox, "LinearCheckBox");
            this.LinearCheckBox.Name = "LinearCheckBox";
            this.LinearCheckBox.UseVisualStyleBackColor = true;
            this.LinearCheckBox.CheckedChanged += new System.EventHandler(this.ChangeCheck);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.AddLinearImages);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // AddLinearImages
            // 
            resources.ApplyResources(this.AddLinearImages, "AddLinearImages");
            this.AddLinearImages.Name = "AddLinearImages";
            this.AddLinearImages.UseVisualStyleBackColor = true;
            this.AddLinearImages.Click += new System.EventHandler(this.AddLineScaleImages_Click);
            // 
            // ImagePic
            // 
            resources.ApplyResources(this.ImagePic, "ImagePic");
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Name = "ImagePic";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // HeartProgressForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HeartProgressForm";
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