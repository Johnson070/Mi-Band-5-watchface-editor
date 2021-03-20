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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundForm));
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
            resources.ApplyResources(this.UseBackgroundColor, "UseBackgroundColor");
            this.UseBackgroundColor.Name = "UseBackgroundColor";
            this.UseBackgroundColor.UseVisualStyleBackColor = true;
            this.UseBackgroundColor.CheckStateChanged += new System.EventHandler(this.UseBackgroundColor_CheckStateChanged);
            // 
            // BackgroundColorGroup
            // 
            this.BackgroundColorGroup.Controls.Add(this.panel1);
            this.BackgroundColorGroup.Controls.Add(this.SelectBackgroundColor);
            resources.ApplyResources(this.BackgroundColorGroup, "BackgroundColorGroup");
            this.BackgroundColorGroup.Name = "BackgroundColorGroup";
            this.BackgroundColorGroup.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // SelectBackgroundColor
            // 
            resources.ApplyResources(this.SelectBackgroundColor, "SelectBackgroundColor");
            this.SelectBackgroundColor.Name = "SelectBackgroundColor";
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
            resources.ApplyResources(this.BackgroundImages, "BackgroundImages");
            this.BackgroundImages.Name = "BackgroundImages";
            this.BackgroundImages.TabStop = false;
            // 
            // ImagePic
            // 
            this.ImagePic.AllowDrop = true;
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.ImagePic, "ImagePic");
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.Click += new System.EventHandler(this.clickPic);
            this.ImagePic.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropPic);
            this.ImagePic.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnterPic);
            // 
            // backgroundYPos
            // 
            resources.ApplyResources(this.backgroundYPos, "backgroundYPos");
            this.backgroundYPos.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.backgroundYPos.Name = "backgroundYPos";
            this.backgroundYPos.ValueChanged += new System.EventHandler(this.posValueChanged);
            // 
            // backgroundXPos
            // 
            resources.ApplyResources(this.backgroundXPos, "backgroundXPos");
            this.backgroundXPos.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.backgroundXPos.Name = "backgroundXPos";
            this.backgroundXPos.ValueChanged += new System.EventHandler(this.posValueChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Preview3Pic
            // 
            this.Preview3Pic.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.Preview3Pic, "Preview3Pic");
            this.Preview3Pic.Name = "Preview3Pic";
            this.Preview3Pic.Click += new System.EventHandler(this.clickPic);
            this.Preview3Pic.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropPic);
            this.Preview3Pic.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnterPic);
            // 
            // Preview2Pic
            // 
            this.Preview2Pic.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.Preview2Pic, "Preview2Pic");
            this.Preview2Pic.Name = "Preview2Pic";
            this.Preview2Pic.Click += new System.EventHandler(this.clickPic);
            this.Preview2Pic.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropPic);
            this.Preview2Pic.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnterPic);
            // 
            // Preview1Pic
            // 
            this.Preview1Pic.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.Preview1Pic, "Preview1Pic");
            this.Preview1Pic.Name = "Preview1Pic";
            this.Preview1Pic.Click += new System.EventHandler(this.clickPic);
            this.Preview1Pic.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropPic);
            this.Preview1Pic.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnterPic);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
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
            // genPreviews
            // 
            resources.ApplyResources(this.genPreviews, "genPreviews");
            this.genPreviews.Name = "genPreviews";
            this.genPreviews.UseVisualStyleBackColor = true;
            this.genPreviews.Click += new System.EventHandler(this.genPreviews_Click);
            // 
            // BackgroundForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BackgroundForm";
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