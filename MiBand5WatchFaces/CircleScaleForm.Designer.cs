
namespace MiBand5WatchFaces
{
    partial class CircleScaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircleScaleForm));
            this.PropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.widthNum = new System.Windows.Forms.NumericUpDown();
            this.centerYNum = new System.Windows.Forms.NumericUpDown();
            this.centerXNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.radiusYNum = new System.Windows.Forms.NumericUpDown();
            this.radiusXNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.previewImage = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endAngleNum = new System.Windows.Forms.NumericUpDown();
            this.startAngleNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.PropertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerYNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerXNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusYNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusXNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endAngleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAngleNum)).BeginInit();
            this.SuspendLayout();
            // 
            // PropertiesGroupBox
            // 
            resources.ApplyResources(this.PropertiesGroupBox, "PropertiesGroupBox");
            this.PropertiesGroupBox.Controls.Add(this.colorButton);
            this.PropertiesGroupBox.Controls.Add(this.label7);
            this.PropertiesGroupBox.Controls.Add(this.widthNum);
            this.PropertiesGroupBox.Controls.Add(this.centerYNum);
            this.PropertiesGroupBox.Controls.Add(this.centerXNum);
            this.PropertiesGroupBox.Controls.Add(this.label6);
            this.PropertiesGroupBox.Controls.Add(this.radiusYNum);
            this.PropertiesGroupBox.Controls.Add(this.radiusXNum);
            this.PropertiesGroupBox.Controls.Add(this.label5);
            this.PropertiesGroupBox.Controls.Add(this.saveBtn);
            this.PropertiesGroupBox.Controls.Add(this.label4);
            this.PropertiesGroupBox.Controls.Add(this.previewImage);
            this.PropertiesGroupBox.Controls.Add(this.label3);
            this.PropertiesGroupBox.Controls.Add(this.label2);
            this.PropertiesGroupBox.Controls.Add(this.endAngleNum);
            this.PropertiesGroupBox.Controls.Add(this.startAngleNum);
            this.PropertiesGroupBox.Controls.Add(this.label1);
            this.PropertiesGroupBox.Name = "PropertiesGroupBox";
            this.PropertiesGroupBox.TabStop = false;
            // 
            // colorButton
            // 
            resources.ApplyResources(this.colorButton, "colorButton");
            this.colorButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorButton.Name = "colorButton";
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // widthNum
            // 
            resources.ApplyResources(this.widthNum, "widthNum");
            this.widthNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.widthNum.Name = "widthNum";
            this.widthNum.ValueChanged += new System.EventHandler(this.changeNumericValue);
            // 
            // centerYNum
            // 
            resources.ApplyResources(this.centerYNum, "centerYNum");
            this.centerYNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.centerYNum.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.centerYNum.Name = "centerYNum";
            this.centerYNum.ValueChanged += new System.EventHandler(this.changeNumericValue);
            // 
            // centerXNum
            // 
            resources.ApplyResources(this.centerXNum, "centerXNum");
            this.centerXNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.centerXNum.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.centerXNum.Name = "centerXNum";
            this.centerXNum.ValueChanged += new System.EventHandler(this.changeNumericValue);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // radiusYNum
            // 
            resources.ApplyResources(this.radiusYNum, "radiusYNum");
            this.radiusYNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.radiusYNum.Name = "radiusYNum";
            this.radiusYNum.ValueChanged += new System.EventHandler(this.changeNumericValue);
            // 
            // radiusXNum
            // 
            resources.ApplyResources(this.radiusXNum, "radiusXNum");
            this.radiusXNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.radiusXNum.Name = "radiusXNum";
            this.radiusXNum.ValueChanged += new System.EventHandler(this.changeNumericValue);
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
            // endAngleNum
            // 
            resources.ApplyResources(this.endAngleNum, "endAngleNum");
            this.endAngleNum.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.endAngleNum.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.endAngleNum.Name = "endAngleNum";
            this.endAngleNum.ValueChanged += new System.EventHandler(this.changeNumericValue);
            // 
            // startAngleNum
            // 
            resources.ApplyResources(this.startAngleNum, "startAngleNum");
            this.startAngleNum.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.startAngleNum.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.startAngleNum.Name = "startAngleNum";
            this.startAngleNum.ValueChanged += new System.EventHandler(this.changeNumericValue);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // CircleScaleForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.PropertiesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CircleScaleForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NumberFormEdit_FormClosing);
            this.PropertiesGroupBox.ResumeLayout(false);
            this.PropertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerYNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerXNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusYNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusXNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endAngleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAngleNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PropertiesGroupBox;
        private System.Windows.Forms.NumericUpDown centerYNum;
        private System.Windows.Forms.NumericUpDown centerXNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown radiusYNum;
        private System.Windows.Forms.NumericUpDown radiusXNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel previewImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown endAngleNum;
        private System.Windows.Forms.NumericUpDown startAngleNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown widthNum;
        private System.Windows.Forms.Button deleteButton;
    }
}