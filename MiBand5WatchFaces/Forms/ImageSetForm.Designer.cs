namespace MiBand5WatchFaces.Forms
{
    partial class ImageSetForm
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
            this.PropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.posYNum = new System.Windows.Forms.NumericUpDown();
            this.posXNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.previewImage = new System.Windows.Forms.Panel();
            this.selectImages = new System.Windows.Forms.Button();
            this.PropertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXNum)).BeginInit();
            this.SuspendLayout();
            // 
            // PropertiesGroupBox
            // 
            this.PropertiesGroupBox.Controls.Add(this.posYNum);
            this.PropertiesGroupBox.Controls.Add(this.posXNum);
            this.PropertiesGroupBox.Controls.Add(this.label6);
            this.PropertiesGroupBox.Controls.Add(this.saveBtn);
            this.PropertiesGroupBox.Controls.Add(this.label4);
            this.PropertiesGroupBox.Controls.Add(this.previewImage);
            this.PropertiesGroupBox.Enabled = false;
            this.PropertiesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PropertiesGroupBox.Location = new System.Drawing.Point(12, 50);
            this.PropertiesGroupBox.Name = "PropertiesGroupBox";
            this.PropertiesGroupBox.Size = new System.Drawing.Size(204, 407);
            this.PropertiesGroupBox.TabIndex = 4;
            this.PropertiesGroupBox.TabStop = false;
            this.PropertiesGroupBox.Text = "Properties";
            // 
            // posYNum
            // 
            this.posYNum.Location = new System.Drawing.Point(145, 18);
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
            this.posYNum.TabIndex = 14;
            // 
            // posXNum
            // 
            this.posXNum.Location = new System.Drawing.Point(88, 18);
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
            this.posXNum.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Position:";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(5, 368);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(195, 33);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preview";
            // 
            // previewImage
            // 
            this.previewImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previewImage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.previewImage.Location = new System.Drawing.Point(39, 66);
            this.previewImage.Name = "previewImage";
            this.previewImage.Size = new System.Drawing.Size(126, 294);
            this.previewImage.TabIndex = 6;
            this.previewImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.previewImage_MouseDown);
            this.previewImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.previewImage_MouseMove);
            this.previewImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.previewImage_MouseUp);
            // 
            // selectImages
            // 
            this.selectImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectImages.Location = new System.Drawing.Point(12, 12);
            this.selectImages.Name = "selectImages";
            this.selectImages.Size = new System.Drawing.Size(204, 32);
            this.selectImages.TabIndex = 3;
            this.selectImages.Text = "Select images";
            this.selectImages.UseVisualStyleBackColor = true;
            this.selectImages.Click += new System.EventHandler(this.selectImages_Click);
            // 
            // ImageSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 466);
            this.Controls.Add(this.PropertiesGroupBox);
            this.Controls.Add(this.selectImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ImageSetForm";
            this.Text = "Properties";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageSetForm_FormClosing);
            this.PropertiesGroupBox.ResumeLayout(false);
            this.PropertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PropertiesGroupBox;
        private System.Windows.Forms.NumericUpDown posYNum;
        private System.Windows.Forms.NumericUpDown posXNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel previewImage;
        private System.Windows.Forms.Button selectImages;
    }
}