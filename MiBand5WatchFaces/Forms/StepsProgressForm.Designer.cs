
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.GoalImageCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddGoalImageButton = new System.Windows.Forms.Button();
            this.LinearCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddLinearImages = new System.Windows.Forms.Button();
            this.LineScaleCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddLineScaleButton = new System.Windows.Forms.Button();
            this.posYNum = new System.Windows.Forms.NumericUpDown();
            this.posXNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CircleScaleCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AddCircleScale = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXNum)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 294);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GoalImageCheckbox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(510, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Goal image";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LinearCheckBox);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(510, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Linear";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LineScaleCheckbox);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(510, 263);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Line scale";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.CircleScaleCheckbox);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(510, 263);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Circle scale";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ImagePic
            // 
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Location = new System.Drawing.Point(536, 12);
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.Size = new System.Drawing.Size(126, 294);
            this.ImagePic.TabIndex = 13;
            // 
            // GoalImageCheckbox
            // 
            this.GoalImageCheckbox.AutoSize = true;
            this.GoalImageCheckbox.Location = new System.Drawing.Point(15, 6);
            this.GoalImageCheckbox.Name = "GoalImageCheckbox";
            this.GoalImageCheckbox.Size = new System.Drawing.Size(15, 14);
            this.GoalImageCheckbox.TabIndex = 5;
            this.GoalImageCheckbox.UseVisualStyleBackColor = true;
            this.GoalImageCheckbox.CheckedChanged += new System.EventHandler(this.ChangeCheck);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AddGoalImageButton);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 251);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "     ";
            // 
            // AddGoalImageButton
            // 
            this.AddGoalImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddGoalImageButton.Location = new System.Drawing.Point(6, 23);
            this.AddGoalImageButton.Name = "AddGoalImageButton";
            this.AddGoalImageButton.Size = new System.Drawing.Size(488, 54);
            this.AddGoalImageButton.TabIndex = 0;
            this.AddGoalImageButton.Text = "Add image";
            this.AddGoalImageButton.UseVisualStyleBackColor = true;
            this.AddGoalImageButton.Click += new System.EventHandler(this.AddGoalImageButton_Click);
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
            this.groupBox2.Size = new System.Drawing.Size(504, 251);
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
            this.AddLinearImages.Size = new System.Drawing.Size(488, 54);
            this.AddLinearImages.TabIndex = 0;
            this.AddLinearImages.Text = "Add images";
            this.AddLinearImages.UseVisualStyleBackColor = true;
            this.AddLinearImages.Click += new System.EventHandler(this.AddLineScaleImages_Click);
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
            this.groupBox3.Controls.Add(this.posYNum);
            this.groupBox3.Controls.Add(this.posXNum);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.AddLineScaleButton);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 251);
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
            this.AddLineScaleButton.Size = new System.Drawing.Size(488, 54);
            this.AddLineScaleButton.TabIndex = 0;
            this.AddLineScaleButton.Text = "Add images";
            this.AddLineScaleButton.UseVisualStyleBackColor = true;
            this.AddLineScaleButton.Click += new System.EventHandler(this.AddLineScaleButton_Click);
            // 
            // posYNum
            // 
            this.posYNum.Enabled = false;
            this.posYNum.Location = new System.Drawing.Point(145, 83);
            this.posYNum.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.posYNum.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.posYNum.Name = "posYNum";
            this.posYNum.Size = new System.Drawing.Size(49, 24);
            this.posYNum.TabIndex = 20;
            this.posYNum.ValueChanged += new System.EventHandler(this.posChanged);
            // 
            // posXNum
            // 
            this.posXNum.Enabled = false;
            this.posXNum.Location = new System.Drawing.Point(88, 83);
            this.posXNum.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.posXNum.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.posXNum.Name = "posXNum";
            this.posXNum.Size = new System.Drawing.Size(49, 24);
            this.posXNum.TabIndex = 19;
            this.posXNum.ValueChanged += new System.EventHandler(this.posChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Position:";
            // 
            // CircleScaleCheckbox
            // 
            this.CircleScaleCheckbox.AutoSize = true;
            this.CircleScaleCheckbox.Location = new System.Drawing.Point(15, 6);
            this.CircleScaleCheckbox.Name = "CircleScaleCheckbox";
            this.CircleScaleCheckbox.Size = new System.Drawing.Size(15, 14);
            this.CircleScaleCheckbox.TabIndex = 9;
            this.CircleScaleCheckbox.UseVisualStyleBackColor = true;
            this.CircleScaleCheckbox.CheckedChanged += new System.EventHandler(this.ChangeCheck);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.AddCircleScale);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(504, 251);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "     ";
            // 
            // AddCircleScale
            // 
            this.AddCircleScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCircleScale.Location = new System.Drawing.Point(6, 23);
            this.AddCircleScale.Name = "AddCircleScale";
            this.AddCircleScale.Size = new System.Drawing.Size(488, 54);
            this.AddCircleScale.TabIndex = 0;
            this.AddCircleScale.Text = "Add circle scale";
            this.AddCircleScale.UseVisualStyleBackColor = true;
            this.AddCircleScale.Click += new System.EventHandler(this.AddCircleScale_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(12, 312);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(650, 37);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // StepsProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 360);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StepsProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steps Progress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NumberFormEdit_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXNum)).EndInit();
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
        private System.Windows.Forms.NumericUpDown posYNum;
        private System.Windows.Forms.NumericUpDown posXNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CircleScaleCheckbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button AddCircleScale;
        private System.Windows.Forms.Button saveButton;
    }
}