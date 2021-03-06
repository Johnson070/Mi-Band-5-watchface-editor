
namespace MiBand5WatchFaces.Forms
{
    partial class BatteryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteryForm));
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBatteryCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddSuffixButton = new System.Windows.Forms.Button();
            this.AddPreffixButton = new System.Windows.Forms.Button();
            this.AddNumberBatteryTextButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.IconBatteryCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddImagesBatteryIconButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LinearCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddImagesLinearButton = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(391, 294);
            this.tabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBatteryCheckbox);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(383, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Text battery";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBatteryCheckbox
            // 
            this.textBatteryCheckbox.AutoSize = true;
            this.textBatteryCheckbox.Location = new System.Drawing.Point(15, 6);
            this.textBatteryCheckbox.Name = "textBatteryCheckbox";
            this.textBatteryCheckbox.Size = new System.Drawing.Size(15, 14);
            this.textBatteryCheckbox.TabIndex = 9;
            this.textBatteryCheckbox.UseVisualStyleBackColor = true;
            this.textBatteryCheckbox.CheckedChanged += new System.EventHandler(this.ChangeCheckValue);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.AddSuffixButton);
            this.groupBox3.Controls.Add(this.AddPreffixButton);
            this.groupBox3.Controls.Add(this.AddNumberBatteryTextButton);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 251);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "     ";
            // 
            // AddSuffixButton
            // 
            this.AddSuffixButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSuffixButton.Enabled = false;
            this.AddSuffixButton.Location = new System.Drawing.Point(6, 123);
            this.AddSuffixButton.Name = "AddSuffixButton";
            this.AddSuffixButton.Size = new System.Drawing.Size(355, 44);
            this.AddSuffixButton.TabIndex = 22;
            this.AddSuffixButton.Text = "Add suffix";
            this.AddSuffixButton.UseVisualStyleBackColor = true;
            this.AddSuffixButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddPreffixButton
            // 
            this.AddPreffixButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPreffixButton.Enabled = false;
            this.AddPreffixButton.Location = new System.Drawing.Point(6, 73);
            this.AddPreffixButton.Name = "AddPreffixButton";
            this.AddPreffixButton.Size = new System.Drawing.Size(355, 44);
            this.AddPreffixButton.TabIndex = 21;
            this.AddPreffixButton.Text = "Add prefix";
            this.AddPreffixButton.UseVisualStyleBackColor = true;
            this.AddPreffixButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddNumberBatteryTextButton
            // 
            this.AddNumberBatteryTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNumberBatteryTextButton.Location = new System.Drawing.Point(6, 23);
            this.AddNumberBatteryTextButton.Name = "AddNumberBatteryTextButton";
            this.AddNumberBatteryTextButton.Size = new System.Drawing.Size(355, 44);
            this.AddNumberBatteryTextButton.TabIndex = 0;
            this.AddNumberBatteryTextButton.Text = "Add number";
            this.AddNumberBatteryTextButton.UseVisualStyleBackColor = true;
            this.AddNumberBatteryTextButton.Click += new System.EventHandler(this.AddNumberBatteryTextButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.IconBatteryCheckbox);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(383, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Battery icon";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // IconBatteryCheckbox
            // 
            this.IconBatteryCheckbox.AutoSize = true;
            this.IconBatteryCheckbox.Location = new System.Drawing.Point(15, 6);
            this.IconBatteryCheckbox.Name = "IconBatteryCheckbox";
            this.IconBatteryCheckbox.Size = new System.Drawing.Size(15, 14);
            this.IconBatteryCheckbox.TabIndex = 11;
            this.IconBatteryCheckbox.UseVisualStyleBackColor = true;
            this.IconBatteryCheckbox.CheckedChanged += new System.EventHandler(this.ChangeCheckValue);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AddImagesBatteryIconButton);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 251);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "     ";
            // 
            // AddImagesBatteryIconButton
            // 
            this.AddImagesBatteryIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddImagesBatteryIconButton.Location = new System.Drawing.Point(6, 23);
            this.AddImagesBatteryIconButton.Name = "AddImagesBatteryIconButton";
            this.AddImagesBatteryIconButton.Size = new System.Drawing.Size(355, 44);
            this.AddImagesBatteryIconButton.TabIndex = 0;
            this.AddImagesBatteryIconButton.Text = "Add images";
            this.AddImagesBatteryIconButton.UseVisualStyleBackColor = true;
            this.AddImagesBatteryIconButton.Click += new System.EventHandler(this.AddImagesBatteryIconButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LinearCheckbox);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(383, 263);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Linear";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LinearCheckbox
            // 
            this.LinearCheckbox.AutoSize = true;
            this.LinearCheckbox.Location = new System.Drawing.Point(15, 6);
            this.LinearCheckbox.Name = "LinearCheckbox";
            this.LinearCheckbox.Size = new System.Drawing.Size(15, 14);
            this.LinearCheckbox.TabIndex = 11;
            this.LinearCheckbox.UseVisualStyleBackColor = true;
            this.LinearCheckbox.CheckedChanged += new System.EventHandler(this.ChangeCheckValue);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.AddImagesLinearButton);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 251);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "     ";
            // 
            // AddImagesLinearButton
            // 
            this.AddImagesLinearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddImagesLinearButton.Location = new System.Drawing.Point(6, 23);
            this.AddImagesLinearButton.Name = "AddImagesLinearButton";
            this.AddImagesLinearButton.Size = new System.Drawing.Size(355, 44);
            this.AddImagesLinearButton.TabIndex = 0;
            this.AddImagesLinearButton.Text = "Add images";
            this.AddImagesLinearButton.UseVisualStyleBackColor = true;
            this.AddImagesLinearButton.Click += new System.EventHandler(this.AddImagesLinearButton_Click);
            // 
            // ImagePic
            // 
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Location = new System.Drawing.Point(409, 12);
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.Size = new System.Drawing.Size(126, 294);
            this.ImagePic.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(12, 312);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(523, 37);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // BatteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 361);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BatteryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NumberFormEdit_FormClosing);
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox textBatteryCheckbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddPreffixButton;
        private System.Windows.Forms.Button AddNumberBatteryTextButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox IconBatteryCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddImagesBatteryIconButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox LinearCheckbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddImagesLinearButton;
        private System.Windows.Forms.Panel ImagePic;
        private System.Windows.Forms.Button AddSuffixButton;
        private System.Windows.Forms.Button saveButton;
    }
}