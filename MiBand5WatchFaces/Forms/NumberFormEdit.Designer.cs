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
            this.deleteButton = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.selectImages, "selectImages");
            this.selectImages.Name = "selectImages";
            this.selectImages.UseVisualStyleBackColor = true;
            this.selectImages.Click += new System.EventHandler(this.selectImages_Click);
            // 
            // PropertiesGroupBox
            // 
            resources.ApplyResources(this.PropertiesGroupBox, "PropertiesGroupBox");
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
            this.PropertiesGroupBox.Name = "PropertiesGroupBox";
            this.PropertiesGroupBox.TabStop = false;
            // 
            // posYNum
            // 
            resources.ApplyResources(this.posYNum, "posYNum");
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
            this.posYNum.ValueChanged += new System.EventHandler(this.posValueChanged);
            // 
            // posXNum
            // 
            resources.ApplyResources(this.posXNum, "posXNum");
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
            this.posXNum.ValueChanged += new System.EventHandler(this.posValueChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // sizeYNum
            // 
            resources.ApplyResources(this.sizeYNum, "sizeYNum");
            this.sizeYNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.sizeYNum.Name = "sizeYNum";
            this.sizeYNum.ValueChanged += new System.EventHandler(this.sizeValueChanged);
            // 
            // sizeXNum
            // 
            resources.ApplyResources(this.sizeXNum, "sizeXNum");
            this.sizeXNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.sizeXNum.Name = "sizeXNum";
            this.sizeXNum.ValueChanged += new System.EventHandler(this.sizeValueChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // saveBtn
            // 
            resources.ApplyResources(this.saveBtn, "saveBtn");
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // previewImage
            // 
            resources.ApplyResources(this.previewImage, "previewImage");
            this.previewImage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.previewImage.Name = "previewImage";
            this.previewImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.previewImage_MouseDown);
            this.previewImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.previewImage_MouseMove);
            this.previewImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.previewImage_MouseUp);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // spaсingYNum
            // 
            resources.ApplyResources(this.spaсingYNum, "spaсingYNum");
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
            this.spaсingYNum.ValueChanged += new System.EventHandler(this.spacingChange);
            // 
            // spacingXNum
            // 
            resources.ApplyResources(this.spacingXNum, "spacingXNum");
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
            this.spacingXNum.ValueChanged += new System.EventHandler(this.spacingChange);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // AligmentComboBox
            // 
            resources.ApplyResources(this.AligmentComboBox, "AligmentComboBox");
            this.AligmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AligmentComboBox.FormattingEnabled = true;
            this.AligmentComboBox.Items.AddRange(new object[] {
            resources.GetString("AligmentComboBox.Items"),
            resources.GetString("AligmentComboBox.Items1"),
            resources.GetString("AligmentComboBox.Items2"),
            resources.GetString("AligmentComboBox.Items3"),
            resources.GetString("AligmentComboBox.Items4"),
            resources.GetString("AligmentComboBox.Items5"),
            resources.GetString("AligmentComboBox.Items6"),
            resources.GetString("AligmentComboBox.Items7"),
            resources.GetString("AligmentComboBox.Items8")});
            this.AligmentComboBox.Name = "AligmentComboBox";
            this.AligmentComboBox.TextChanged += new System.EventHandler(this.alignChanged);
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // NumberFormEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.PropertiesGroupBox);
            this.Controls.Add(this.selectImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NumberFormEdit";
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
        private System.Windows.Forms.Button deleteButton;
    }
}