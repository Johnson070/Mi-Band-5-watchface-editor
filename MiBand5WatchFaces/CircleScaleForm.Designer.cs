
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
            this.PropertiesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PropertiesGroupBox.Location = new System.Drawing.Point(14, 12);
            this.PropertiesGroupBox.Name = "PropertiesGroupBox";
            this.PropertiesGroupBox.Size = new System.Drawing.Size(204, 568);
            this.PropertiesGroupBox.TabIndex = 3;
            this.PropertiesGroupBox.TabStop = false;
            this.PropertiesGroupBox.Text = "Properties";
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorButton.Location = new System.Drawing.Point(88, 26);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(49, 23);
            this.colorButton.TabIndex = 17;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Width:";
            // 
            // widthNum
            // 
            this.widthNum.Location = new System.Drawing.Point(88, 115);
            this.widthNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.widthNum.Name = "widthNum";
            this.widthNum.Size = new System.Drawing.Size(49, 24);
            this.widthNum.TabIndex = 15;
            this.widthNum.ValueChanged += new System.EventHandler(this.changeNumericValue);
            // 
            // centerYNum
            // 
            this.centerYNum.Location = new System.Drawing.Point(145, 175);
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
            this.centerYNum.Size = new System.Drawing.Size(49, 24);
            this.centerYNum.TabIndex = 14;
            this.centerYNum.ValueChanged += new System.EventHandler(this.changeNumericValue);
            // 
            // centerXNum
            // 
            this.centerXNum.Location = new System.Drawing.Point(88, 175);
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
            this.centerXNum.Size = new System.Drawing.Size(49, 24);
            this.centerXNum.TabIndex = 13;
            this.centerXNum.ValueChanged += new System.EventHandler(this.changeNumericValue);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Center:";
            // 
            // radiusYNum
            // 
            this.radiusYNum.Location = new System.Drawing.Point(145, 145);
            this.radiusYNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.radiusYNum.Name = "radiusYNum";
            this.radiusYNum.Size = new System.Drawing.Size(49, 24);
            this.radiusYNum.TabIndex = 11;
            this.radiusYNum.ValueChanged += new System.EventHandler(this.changeNumericValue);
            // 
            // radiusXNum
            // 
            this.radiusXNum.Location = new System.Drawing.Point(88, 145);
            this.radiusXNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.radiusXNum.Name = "radiusXNum";
            this.radiusXNum.Size = new System.Drawing.Size(49, 24);
            this.radiusXNum.TabIndex = 10;
            this.radiusXNum.ValueChanged += new System.EventHandler(this.changeNumericValue);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Radius:";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.Location = new System.Drawing.Point(3, 527);
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
            this.label4.Location = new System.Drawing.Point(72, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preview";
            // 
            // previewImage
            // 
            this.previewImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previewImage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.previewImage.Location = new System.Drawing.Point(39, 227);
            this.previewImage.Name = "previewImage";
            this.previewImage.Size = new System.Drawing.Size(126, 294);
            this.previewImage.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "End angle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start angle:";
            // 
            // endAngleNum
            // 
            this.endAngleNum.Location = new System.Drawing.Point(88, 85);
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
            this.endAngleNum.Size = new System.Drawing.Size(49, 24);
            this.endAngleNum.TabIndex = 3;
            this.endAngleNum.ValueChanged += new System.EventHandler(this.changeNumericValue);
            // 
            // startAngleNum
            // 
            this.startAngleNum.Location = new System.Drawing.Point(88, 55);
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
            this.startAngleNum.Size = new System.Drawing.Size(49, 24);
            this.startAngleNum.TabIndex = 2;
            this.startAngleNum.ValueChanged += new System.EventHandler(this.changeNumericValue);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color:";
            // 
            // CircleScaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 588);
            this.Controls.Add(this.PropertiesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CircleScaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Circle scale";
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
    }
}