namespace MiBand5WatchFaces.Forms
{
    partial class BackgroundForm
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
            this.UseBackgroundColor = new System.Windows.Forms.CheckBox();
            this.BackgroundColorGroup = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectBackgroundColor = new System.Windows.Forms.Button();
            this.BackgroundImages = new System.Windows.Forms.GroupBox();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.backgroundYPos = new System.Windows.Forms.NumericUpDown();
            this.backgroundXPos = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.Preview3Pic = new System.Windows.Forms.Panel();
            this.Preview2Pic = new System.Windows.Forms.Panel();
            this.Preview1Pic = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.genPreviews = new System.Windows.Forms.Button();
            this.BackgroundColorGroup.SuspendLayout();
            this.BackgroundImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundYPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundXPos)).BeginInit();
            this.SuspendLayout();
            // 
            // UseBackgroundColor
            // 
            this.UseBackgroundColor.AutoSize = true;
            this.UseBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UseBackgroundColor.Location = new System.Drawing.Point(12, 12);
            this.UseBackgroundColor.Name = "UseBackgroundColor";
            this.UseBackgroundColor.Size = new System.Drawing.Size(174, 22);
            this.UseBackgroundColor.TabIndex = 0;
            this.UseBackgroundColor.Text = "Use background color";
            this.UseBackgroundColor.UseVisualStyleBackColor = true;
            this.UseBackgroundColor.CheckStateChanged += new System.EventHandler(this.UseBackgroundColor_CheckStateChanged);
            // 
            // BackgroundColorGroup
            // 
            this.BackgroundColorGroup.Controls.Add(this.panel1);
            this.BackgroundColorGroup.Controls.Add(this.SelectBackgroundColor);
            this.BackgroundColorGroup.Enabled = false;
            this.BackgroundColorGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackgroundColorGroup.Location = new System.Drawing.Point(12, 40);
            this.BackgroundColorGroup.Name = "BackgroundColorGroup";
            this.BackgroundColorGroup.Size = new System.Drawing.Size(202, 57);
            this.BackgroundColorGroup.TabIndex = 1;
            this.BackgroundColorGroup.TabStop = false;
            this.BackgroundColorGroup.Text = "Background color";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(139, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 32);
            this.panel1.TabIndex = 1;
            // 
            // SelectBackgroundColor
            // 
            this.SelectBackgroundColor.Location = new System.Drawing.Point(6, 19);
            this.SelectBackgroundColor.Name = "SelectBackgroundColor";
            this.SelectBackgroundColor.Size = new System.Drawing.Size(127, 32);
            this.SelectBackgroundColor.TabIndex = 0;
            this.SelectBackgroundColor.Text = "Select color";
            this.SelectBackgroundColor.UseVisualStyleBackColor = true;
            this.SelectBackgroundColor.Click += new System.EventHandler(this.SelectBackgroundColor_Click);
            // 
            // BackgroundImages
            // 
            this.BackgroundImages.Controls.Add(this.ImagePic);
            this.BackgroundImages.Controls.Add(this.backgroundYPos);
            this.BackgroundImages.Controls.Add(this.backgroundXPos);
            this.BackgroundImages.Controls.Add(this.label6);
            this.BackgroundImages.Controls.Add(this.label5);
            this.BackgroundImages.Controls.Add(this.panel2);
            this.BackgroundImages.Controls.Add(this.label1);
            this.BackgroundImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackgroundImages.Location = new System.Drawing.Point(12, 103);
            this.BackgroundImages.Name = "BackgroundImages";
            this.BackgroundImages.Size = new System.Drawing.Size(143, 415);
            this.BackgroundImages.TabIndex = 2;
            this.BackgroundImages.TabStop = false;
            this.BackgroundImages.Text = "Images";
            // 
            // ImagePic
            // 
            this.ImagePic.AllowDrop = true;
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Location = new System.Drawing.Point(9, 41);
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.Size = new System.Drawing.Size(126, 294);
            this.ImagePic.TabIndex = 35;
            this.ImagePic.Click += new System.EventHandler(this.clickPic);
            this.ImagePic.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropPic);
            this.ImagePic.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnterPic);
            // 
            // backgroundYPos
            // 
            this.backgroundYPos.Location = new System.Drawing.Point(34, 372);
            this.backgroundYPos.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.backgroundYPos.Name = "backgroundYPos";
            this.backgroundYPos.Size = new System.Drawing.Size(48, 24);
            this.backgroundYPos.TabIndex = 32;
            this.backgroundYPos.ValueChanged += new System.EventHandler(this.posValueChanged);
            // 
            // backgroundXPos
            // 
            this.backgroundXPos.Location = new System.Drawing.Point(34, 342);
            this.backgroundXPos.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.backgroundXPos.Name = "backgroundXPos";
            this.backgroundXPos.Size = new System.Drawing.Size(48, 24);
            this.backgroundXPos.TabIndex = 31;
            this.backgroundXPos.ValueChanged += new System.EventHandler(this.posValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "X:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(9, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image:";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(12, 524);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(435, 36);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Preview3Pic
            // 
            this.Preview3Pic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Preview3Pic.Location = new System.Drawing.Point(353, 144);
            this.Preview3Pic.Name = "Preview3Pic";
            this.Preview3Pic.Size = new System.Drawing.Size(90, 210);
            this.Preview3Pic.TabIndex = 42;
            this.Preview3Pic.Click += new System.EventHandler(this.clickPic);
            this.Preview3Pic.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropPic);
            this.Preview3Pic.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnterPic);
            // 
            // Preview2Pic
            // 
            this.Preview2Pic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Preview2Pic.Location = new System.Drawing.Point(257, 144);
            this.Preview2Pic.Name = "Preview2Pic";
            this.Preview2Pic.Size = new System.Drawing.Size(90, 210);
            this.Preview2Pic.TabIndex = 43;
            this.Preview2Pic.Click += new System.EventHandler(this.clickPic);
            this.Preview2Pic.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropPic);
            this.Preview2Pic.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnterPic);
            // 
            // Preview1Pic
            // 
            this.Preview1Pic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Preview1Pic.Location = new System.Drawing.Point(161, 144);
            this.Preview1Pic.Name = "Preview1Pic";
            this.Preview1Pic.Size = new System.Drawing.Size(90, 210);
            this.Preview1Pic.TabIndex = 41;
            this.Preview1Pic.Click += new System.EventHandler(this.clickPic);
            this.Preview1Pic.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropPic);
            this.Preview1Pic.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnterPic);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(350, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Preview3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(254, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Preview2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(158, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Preview1:";
            // 
            // genPreviews
            // 
            this.genPreviews.Location = new System.Drawing.Point(161, 360);
            this.genPreviews.Name = "genPreviews";
            this.genPreviews.Size = new System.Drawing.Size(282, 23);
            this.genPreviews.TabIndex = 44;
            this.genPreviews.Text = "Generate previews";
            this.genPreviews.UseVisualStyleBackColor = true;
            this.genPreviews.Click += new System.EventHandler(this.genPreviews_Click);
            // 
            // BackgroundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 569);
            this.Controls.Add(this.genPreviews);
            this.Controls.Add(this.Preview3Pic);
            this.Controls.Add(this.Preview2Pic);
            this.Controls.Add(this.Preview1Pic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.BackgroundImages);
            this.Controls.Add(this.BackgroundColorGroup);
            this.Controls.Add(this.UseBackgroundColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BackgroundForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Background";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BackgroundForm_FormClosing);
            this.BackgroundColorGroup.ResumeLayout(false);
            this.BackgroundImages.ResumeLayout(false);
            this.BackgroundImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundYPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundXPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UseBackgroundColor;
        private System.Windows.Forms.GroupBox BackgroundColorGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SelectBackgroundColor;
        private System.Windows.Forms.GroupBox BackgroundImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown backgroundYPos;
        private System.Windows.Forms.NumericUpDown backgroundXPos;
        private System.Windows.Forms.Panel ImagePic;
        private System.Windows.Forms.Panel Preview3Pic;
        private System.Windows.Forms.Panel Preview2Pic;
        private System.Windows.Forms.Panel Preview1Pic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button genPreviews;
    }
}