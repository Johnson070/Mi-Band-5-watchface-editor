
namespace MiBand5WatchFaces.Forms
{
    partial class ScaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaleForm));
            this.PropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.posYNum = new System.Windows.Forms.NumericUpDown();
            this.posXNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.previewImage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ImagesComboBox = new System.Windows.Forms.ComboBox();
            this.selectImages = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
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
            this.PropertiesGroupBox.Controls.Add(this.label1);
            this.PropertiesGroupBox.Controls.Add(this.ImagesComboBox);
            resources.ApplyResources(this.PropertiesGroupBox, "PropertiesGroupBox");
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
            this.previewImage.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.previewImage, "previewImage");
            this.previewImage.Name = "previewImage";
            this.previewImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.previewImage_MouseDown);
            this.previewImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.previewImage_MouseMove);
            this.previewImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.previewImage_MouseUp);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ImagesComboBox
            // 
            this.ImagesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImagesComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.ImagesComboBox, "ImagesComboBox");
            this.ImagesComboBox.Name = "ImagesComboBox";
            this.ImagesComboBox.TextChanged += new System.EventHandler(this.ImagesComboBox_TextChanged);
            // 
            // selectImages
            // 
            resources.ApplyResources(this.selectImages, "selectImages");
            this.selectImages.Name = "selectImages";
            this.selectImages.UseVisualStyleBackColor = true;
            this.selectImages.Click += new System.EventHandler(this.selectImages_Click);
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ScaleForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.PropertiesGroupBox);
            this.Controls.Add(this.selectImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScaleForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NumberFormEdit_FormClosing);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ImagesComboBox;
        private System.Windows.Forms.Button selectImages;
        private System.Windows.Forms.Button deleteButton;
    }
}