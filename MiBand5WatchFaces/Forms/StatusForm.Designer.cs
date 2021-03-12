
namespace MiBand5WatchFaces.Forms
{
    partial class StatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusForm));
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bluetoothCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddImageOFFBluetooth = new System.Windows.Forms.Button();
            this.posYBluetooth = new System.Windows.Forms.NumericUpDown();
            this.posXBluetooth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.AddImageONBluetooth = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lockCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddImageOFFLock = new System.Windows.Forms.Button();
            this.posYLock = new System.Windows.Forms.NumericUpDown();
            this.posXLock = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AddImageONLock = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dndCheclbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddImageOFFDND = new System.Windows.Forms.Button();
            this.posYDND = new System.Windows.Forms.NumericUpDown();
            this.posXDND = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.AddImageONDND = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYBluetooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXBluetooth)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXLock)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYDND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXDND)).BeginInit();
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
            this.tabPage1.Controls.Add(this.bluetoothCheckbox);
            this.tabPage1.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bluetoothCheckbox
            // 
            resources.ApplyResources(this.bluetoothCheckbox, "bluetoothCheckbox");
            this.bluetoothCheckbox.Name = "bluetoothCheckbox";
            this.bluetoothCheckbox.UseVisualStyleBackColor = true;
            this.bluetoothCheckbox.CheckedChanged += new System.EventHandler(this.CheckChangedCheckBox);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.AddImageOFFBluetooth);
            this.groupBox3.Controls.Add(this.posYBluetooth);
            this.groupBox3.Controls.Add(this.posXBluetooth);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.AddImageONBluetooth);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // AddImageOFFBluetooth
            // 
            resources.ApplyResources(this.AddImageOFFBluetooth, "AddImageOFFBluetooth");
            this.AddImageOFFBluetooth.Name = "AddImageOFFBluetooth";
            this.AddImageOFFBluetooth.UseVisualStyleBackColor = true;
            this.AddImageOFFBluetooth.Click += new System.EventHandler(this.AddImageClick);
            // 
            // posYBluetooth
            // 
            resources.ApplyResources(this.posYBluetooth, "posYBluetooth");
            this.posYBluetooth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.posYBluetooth.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.posYBluetooth.Name = "posYBluetooth";
            this.posYBluetooth.ValueChanged += new System.EventHandler(this.ChangePosValue);
            // 
            // posXBluetooth
            // 
            resources.ApplyResources(this.posXBluetooth, "posXBluetooth");
            this.posXBluetooth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.posXBluetooth.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.posXBluetooth.Name = "posXBluetooth";
            this.posXBluetooth.ValueChanged += new System.EventHandler(this.ChangePosValue);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // AddImageONBluetooth
            // 
            resources.ApplyResources(this.AddImageONBluetooth, "AddImageONBluetooth");
            this.AddImageONBluetooth.Name = "AddImageONBluetooth";
            this.AddImageONBluetooth.UseVisualStyleBackColor = true;
            this.AddImageONBluetooth.Click += new System.EventHandler(this.AddImageClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lockCheckbox);
            this.tabPage2.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lockCheckbox
            // 
            resources.ApplyResources(this.lockCheckbox, "lockCheckbox");
            this.lockCheckbox.Name = "lockCheckbox";
            this.lockCheckbox.UseVisualStyleBackColor = true;
            this.lockCheckbox.CheckedChanged += new System.EventHandler(this.CheckChangedCheckBox);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.AddImageOFFLock);
            this.groupBox1.Controls.Add(this.posYLock);
            this.groupBox1.Controls.Add(this.posXLock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddImageONLock);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // AddImageOFFLock
            // 
            resources.ApplyResources(this.AddImageOFFLock, "AddImageOFFLock");
            this.AddImageOFFLock.Name = "AddImageOFFLock";
            this.AddImageOFFLock.UseVisualStyleBackColor = true;
            this.AddImageOFFLock.Click += new System.EventHandler(this.AddImageClick);
            // 
            // posYLock
            // 
            resources.ApplyResources(this.posYLock, "posYLock");
            this.posYLock.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.posYLock.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.posYLock.Name = "posYLock";
            this.posYLock.ValueChanged += new System.EventHandler(this.ChangePosValue);
            // 
            // posXLock
            // 
            resources.ApplyResources(this.posXLock, "posXLock");
            this.posXLock.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.posXLock.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.posXLock.Name = "posXLock";
            this.posXLock.ValueChanged += new System.EventHandler(this.ChangePosValue);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // AddImageONLock
            // 
            resources.ApplyResources(this.AddImageONLock, "AddImageONLock");
            this.AddImageONLock.Name = "AddImageONLock";
            this.AddImageONLock.UseVisualStyleBackColor = true;
            this.AddImageONLock.Click += new System.EventHandler(this.AddImageClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dndCheclbox);
            this.tabPage3.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dndCheclbox
            // 
            resources.ApplyResources(this.dndCheclbox, "dndCheclbox");
            this.dndCheclbox.Name = "dndCheclbox";
            this.dndCheclbox.UseVisualStyleBackColor = true;
            this.dndCheclbox.CheckedChanged += new System.EventHandler(this.CheckChangedCheckBox);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.AddImageOFFDND);
            this.groupBox2.Controls.Add(this.posYDND);
            this.groupBox2.Controls.Add(this.posXDND);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.AddImageONDND);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // AddImageOFFDND
            // 
            resources.ApplyResources(this.AddImageOFFDND, "AddImageOFFDND");
            this.AddImageOFFDND.Name = "AddImageOFFDND";
            this.AddImageOFFDND.UseVisualStyleBackColor = true;
            this.AddImageOFFDND.Click += new System.EventHandler(this.AddImageClick);
            // 
            // posYDND
            // 
            resources.ApplyResources(this.posYDND, "posYDND");
            this.posYDND.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.posYDND.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.posYDND.Name = "posYDND";
            this.posYDND.ValueChanged += new System.EventHandler(this.ChangePosValue);
            // 
            // posXDND
            // 
            resources.ApplyResources(this.posXDND, "posXDND");
            this.posXDND.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.posXDND.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.posXDND.Name = "posXDND";
            this.posXDND.ValueChanged += new System.EventHandler(this.ChangePosValue);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // AddImageONDND
            // 
            resources.ApplyResources(this.AddImageONDND, "AddImageONDND");
            this.AddImageONDND.Name = "AddImageONDND";
            this.AddImageONDND.UseVisualStyleBackColor = true;
            this.AddImageONDND.Click += new System.EventHandler(this.AddImageClick);
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
            // StatusForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StatusForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NumberFormEdit_FormClosing);
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYBluetooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXBluetooth)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXLock)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYDND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXDND)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox bluetoothCheckbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown posYBluetooth;
        private System.Windows.Forms.NumericUpDown posXBluetooth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddImageONBluetooth;
        private System.Windows.Forms.Button AddImageOFFBluetooth;
        private System.Windows.Forms.Panel ImagePic;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox lockCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddImageOFFLock;
        private System.Windows.Forms.NumericUpDown posYLock;
        private System.Windows.Forms.NumericUpDown posXLock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddImageONLock;
        private System.Windows.Forms.CheckBox dndCheclbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddImageOFFDND;
        private System.Windows.Forms.NumericUpDown posYDND;
        private System.Windows.Forms.NumericUpDown posXDND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddImageONDND;
    }
}