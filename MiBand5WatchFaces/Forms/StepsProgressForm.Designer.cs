
namespace MiBand5WatchFaces.Forms
{
    partial class StepsProgressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StepsProgressForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GoalImageCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddGoalImageButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LineScaleCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddLineScaleButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LinearCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddLinearImages = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CircleScaleCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AddCircleScale = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GoalImageCheckbox);
            this.tabPage1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GoalImageCheckbox
            // 
            resources.ApplyResources(this.GoalImageCheckbox, "GoalImageCheckbox");
            this.GoalImageCheckbox.Name = "GoalImageCheckbox";
            this.GoalImageCheckbox.UseVisualStyleBackColor = true;
            this.GoalImageCheckbox.CheckedChanged += new System.EventHandler(this.ChangeCheck);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.AddGoalImageButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // AddGoalImageButton
            // 
            resources.ApplyResources(this.AddGoalImageButton, "AddGoalImageButton");
            this.AddGoalImageButton.Name = "AddGoalImageButton";
            this.AddGoalImageButton.UseVisualStyleBackColor = true;
            this.AddGoalImageButton.Click += new System.EventHandler(this.AddGoalImageButton_Click);
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.CircleScaleCheckbox);
            this.tabPage4.Controls.Add(this.groupBox4);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // CircleScaleCheckbox
            // 
            resources.ApplyResources(this.CircleScaleCheckbox, "CircleScaleCheckbox");
            this.CircleScaleCheckbox.Name = "CircleScaleCheckbox";
            this.CircleScaleCheckbox.UseVisualStyleBackColor = true;
            this.CircleScaleCheckbox.CheckedChanged += new System.EventHandler(this.ChangeCheck);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.AddCircleScale);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // AddCircleScale
            // 
            resources.ApplyResources(this.AddCircleScale, "AddCircleScale");
            this.AddCircleScale.Name = "AddCircleScale";
            this.AddCircleScale.UseVisualStyleBackColor = true;
            this.AddCircleScale.Click += new System.EventHandler(this.AddCircleScale_Click);
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
            this.saveButton.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // StepsProgressForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StepsProgressForm";
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
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel ImagePic;
        private System.Windows.Forms.CheckBox GoalImageCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddGoalImageButton;
        private System.Windows.Forms.CheckBox LinearCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddLinearImages;
        private System.Windows.Forms.CheckBox LineScaleCheckbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddLineScaleButton;
        private System.Windows.Forms.CheckBox CircleScaleCheckbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button AddCircleScale;
        private System.Windows.Forms.Button saveButton;
    }
}