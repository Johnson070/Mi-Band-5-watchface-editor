namespace MiBand5WatchFaces
{
    partial class NumberFormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberFormEdit));
            this.selectImages = new System.Windows.Forms.Button();
            this.PropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.posYNum = new System.Windows.Forms.NumericUpDown();
            this.posXNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.sizeYNum = new System.Windows.Forms.NumericUpDown();
            this.sizeXNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.previewImage = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spaсingYNum = new System.Windows.Forms.NumericUpDown();
            this.spacingXNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AligmentComboBox = new System.Windows.Forms.ComboBox();
            this.PropertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeYNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeXNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaсingYNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacingXNum)).BeginInit();
            this.SuspendLayout();
            // 
            // selectImages
            // 
            this.selectImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectImages.Location = new System.Drawing.Point(12, 12);
            this.selectImages.Name = "selectImages";
            this.selectImages.Size = new System.Drawing.Size(204, 32);
            this.selectImages.TabIndex = 0;
            this.selectImages.Text = "Select images";
            this.selectImages.UseVisualStyleBackColor = true;
            this.selectImages.Click += new System.EventHandler(this.selectImages_Click);
            // 
            // PropertiesGroupBox
            // 
            this.PropertiesGroupBox.Controls.Add(this.posYNum);
            this.PropertiesGroupBox.Controls.Add(this.posXNum);
            this.PropertiesGroupBox.Controls.Add(this.label6);
            this.PropertiesGroupBox.Controls.Add(this.sizeYNum);
            this.PropertiesGroupBox.Controls.Add(this.sizeXNum);
            this.PropertiesGroupBox.Controls.Add(this.label5);
            this.PropertiesGroupBox.Controls.Add(this.saveBtn);
            this.PropertiesGroupBox.Controls.Add(this.label4);
            this.PropertiesGroupBox.Controls.Add(this.previewImage);
            this.PropertiesGroupBox.Controls.Add(this.label3);
            this.PropertiesGroupBox.Controls.Add(this.label2);
            this.PropertiesGroupBox.Controls.Add(this.spaсingYNum);
            this.PropertiesGroupBox.Controls.Add(this.spacingXNum);
            this.PropertiesGroupBox.Controls.Add(this.label1);
            this.PropertiesGroupBox.Controls.Add(this.AligmentComboBox);
            this.PropertiesGroupBox.Enabled = false;
            this.PropertiesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PropertiesGroupBox.Location = new System.Drawing.Point(12, 62);
            this.PropertiesGroupBox.Name = "PropertiesGroupBox";
            this.PropertiesGroupBox.Size = new System.Drawing.Size(204, 535);
            this.PropertiesGroupBox.TabIndex = 1;
            this.PropertiesGroupBox.TabStop = false;
            this.PropertiesGroupBox.Text = "Properties";
            // 
            // posYNum
            // 
            this.posYNum.Location = new System.Drawing.Point(145, 145);
            this.posYNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.posYNum.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.posYNum.Name = "posYNum";
            this.posYNum.Size = new System.Drawing.Size(49, 24);
            this.posYNum.TabIndex = 14;
            this.posYNum.ValueChanged += new System.EventHandler(this.posValueChanged);
            // 
            // posXNum
            // 
            this.posXNum.Location = new System.Drawing.Point(88, 145);
            this.posXNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.posXNum.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.posXNum.Name = "posXNum";
            this.posXNum.Size = new System.Drawing.Size(49, 24);
            this.posXNum.TabIndex = 13;
            this.posXNum.ValueChanged += new System.EventHandler(this.posValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Position:";
            // 
            // sizeYNum
            // 
            this.sizeYNum.Location = new System.Drawing.Point(145, 115);
            this.sizeYNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.sizeYNum.Name = "sizeYNum";
            this.sizeYNum.Size = new System.Drawing.Size(49, 24);
            this.sizeYNum.TabIndex = 11;
            this.sizeYNum.ValueChanged += new System.EventHandler(this.sizeValueChanged);
            // 
            // sizeXNum
            // 
            this.sizeXNum.Location = new System.Drawing.Point(88, 115);
            this.sizeXNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.sizeXNum.Name = "sizeXNum";
            this.sizeXNum.Size = new System.Drawing.Size(49, 24);
            this.sizeXNum.TabIndex = 10;
            this.sizeXNum.ValueChanged += new System.EventHandler(this.sizeValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Size:";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.Location = new System.Drawing.Point(3, 494);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(195, 33);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preview";
            // 
            // previewImage
            // 
            this.previewImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previewImage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.previewImage.Location = new System.Drawing.Point(39, 194);
            this.previewImage.Name = "previewImage";
            this.previewImage.Size = new System.Drawing.Size(126, 294);
            this.previewImage.TabIndex = 6;
            this.previewImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.previewImage_MouseDown);
            this.previewImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.previewImage_MouseMove);
            this.previewImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.previewImage_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Spacing Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Spacing X:";
            // 
            // spaсingYNum
            // 
            this.spaсingYNum.Location = new System.Drawing.Point(88, 85);
            this.spaсingYNum.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.spaсingYNum.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.spaсingYNum.Name = "spaсingYNum";
            this.spaсingYNum.Size = new System.Drawing.Size(49, 24);
            this.spaсingYNum.TabIndex = 3;
            this.spaсingYNum.ValueChanged += new System.EventHandler(this.spacingChange);
            // 
            // spacingXNum
            // 
            this.spacingXNum.Location = new System.Drawing.Point(88, 55);
            this.spacingXNum.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.spacingXNum.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.spacingXNum.Name = "spacingXNum";
            this.spacingXNum.Size = new System.Drawing.Size(49, 24);
            this.spacingXNum.TabIndex = 2;
            this.spacingXNum.ValueChanged += new System.EventHandler(this.spacingChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alignment:";
            // 
            // AligmentComboBox
            // 
            this.AligmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AligmentComboBox.FormattingEnabled = true;
            this.AligmentComboBox.Items.AddRange(new object[] {
            "LeftTop",
            "Top",
            "RightTop",
            "Left",
            "Center",
            "Right",
            "LeftBottom",
            "Bottom",
            "RightBottom"});
            this.AligmentComboBox.Location = new System.Drawing.Point(88, 23);
            this.AligmentComboBox.Name = "AligmentComboBox";
            this.AligmentComboBox.Size = new System.Drawing.Size(106, 26);
            this.AligmentComboBox.TabIndex = 0;
            this.AligmentComboBox.TextChanged += new System.EventHandler(this.alignChanged);
            // 
            // NumberFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 605);
            this.Controls.Add(this.PropertiesGroupBox);
            this.Controls.Add(this.selectImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NumberFormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Properties";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NumberFormEdit_FormClosing);
            this.Shown += new System.EventHandler(this.NumberFormEdit_Shown);
            this.PropertiesGroupBox.ResumeLayout(false);
            this.PropertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeYNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeXNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaсingYNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacingXNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectImages;
        private System.Windows.Forms.GroupBox PropertiesGroupBox;
        private System.Windows.Forms.ComboBox AligmentComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spaсingYNum;
        private System.Windows.Forms.NumericUpDown spacingXNum;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel previewImage;
        private System.Windows.Forms.NumericUpDown posYNum;
        private System.Windows.Forms.NumericUpDown posXNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sizeYNum;
        private System.Windows.Forms.NumericUpDown sizeXNum;
        private System.Windows.Forms.Label label5;
    }
}