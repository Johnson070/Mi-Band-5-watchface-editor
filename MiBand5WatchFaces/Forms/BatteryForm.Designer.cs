
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
            resources.ApplyResources(this.tabs, "tabs");
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBatteryCheckbox);
            this.tabPage1.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBatteryCheckbox
            // 
            resources.ApplyResources(this.textBatteryCheckbox, "textBatteryCheckbox");
            this.textBatteryCheckbox.Name = "textBatteryCheckbox";
            this.textBatteryCheckbox.UseVisualStyleBackColor = true;
            this.textBatteryCheckbox.CheckedChanged += new System.EventHandler(this.ChangeCheckValue);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.AddSuffixButton);
            this.groupBox3.Controls.Add(this.AddPreffixButton);
            this.groupBox3.Controls.Add(this.AddNumberBatteryTextButton);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // AddSuffixButton
            // 
            resources.ApplyResources(this.AddSuffixButton, "AddSuffixButton");
            this.AddSuffixButton.Name = "AddSuffixButton";
            this.AddSuffixButton.UseVisualStyleBackColor = true;
            this.AddSuffixButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddPreffixButton
            // 
            resources.ApplyResources(this.AddPreffixButton, "AddPreffixButton");
            this.AddPreffixButton.Name = "AddPreffixButton";
            this.AddPreffixButton.UseVisualStyleBackColor = true;
            this.AddPreffixButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddNumberBatteryTextButton
            // 
            resources.ApplyResources(this.AddNumberBatteryTextButton, "AddNumberBatteryTextButton");
            this.AddNumberBatteryTextButton.Name = "AddNumberBatteryTextButton";
            this.AddNumberBatteryTextButton.UseVisualStyleBackColor = true;
            this.AddNumberBatteryTextButton.Click += new System.EventHandler(this.AddNumberBatteryTextButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.IconBatteryCheckbox);
            this.tabPage2.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // IconBatteryCheckbox
            // 
            resources.ApplyResources(this.IconBatteryCheckbox, "IconBatteryCheckbox");
            this.IconBatteryCheckbox.Name = "IconBatteryCheckbox";
            this.IconBatteryCheckbox.UseVisualStyleBackColor = true;
            this.IconBatteryCheckbox.CheckedChanged += new System.EventHandler(this.ChangeCheckValue);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.AddImagesBatteryIconButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // AddImagesBatteryIconButton
            // 
            resources.ApplyResources(this.AddImagesBatteryIconButton, "AddImagesBatteryIconButton");
            this.AddImagesBatteryIconButton.Name = "AddImagesBatteryIconButton";
            this.AddImagesBatteryIconButton.UseVisualStyleBackColor = true;
            this.AddImagesBatteryIconButton.Click += new System.EventHandler(this.AddImagesBatteryIconButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LinearCheckbox);
            this.tabPage3.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LinearCheckbox
            // 
            resources.ApplyResources(this.LinearCheckbox, "LinearCheckbox");
            this.LinearCheckbox.Name = "LinearCheckbox";
            this.LinearCheckbox.UseVisualStyleBackColor = true;
            this.LinearCheckbox.CheckedChanged += new System.EventHandler(this.ChangeCheckValue);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.AddImagesLinearButton);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // AddImagesLinearButton
            // 
            resources.ApplyResources(this.AddImagesLinearButton, "AddImagesLinearButton");
            this.AddImagesLinearButton.Name = "AddImagesLinearButton";
            this.AddImagesLinearButton.UseVisualStyleBackColor = true;
            this.AddImagesLinearButton.Click += new System.EventHandler(this.AddImagesLinearButton_Click);
            // 
            // ImagePic
            // 
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.ImagePic, "ImagePic");
            this.ImagePic.Name = "ImagePic";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // BatteryForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BatteryForm";
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