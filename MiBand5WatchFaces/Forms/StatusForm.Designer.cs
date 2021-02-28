
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bluetoothCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.posYBluetooth = new System.Windows.Forms.NumericUpDown();
            this.posXBluetooth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.AddImageONBluetooth = new System.Windows.Forms.Button();
            this.AddImageOFFBluetooth = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.lockCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddImageOFFLock = new System.Windows.Forms.Button();
            this.posYLock = new System.Windows.Forms.NumericUpDown();
            this.posXLock = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AddImageONLock = new System.Windows.Forms.Button();
            this.dndCheclbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddImageOFFDND = new System.Windows.Forms.Button();
            this.posYDND = new System.Windows.Forms.NumericUpDown();
            this.posXDND = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.AddImageONDND = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYBluetooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXBluetooth)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXLock)).BeginInit();
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
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(450, 294);
            this.tabs.TabIndex = 0;
            this.tabs.Click += new System.EventHandler(this.AddImageClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bluetoothCheckbox);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(442, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bluetooth";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lockCheckbox);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(442, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lock";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dndCheclbox);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(442, 263);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Do not disturb";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bluetoothCheckbox
            // 
            this.bluetoothCheckbox.AutoSize = true;
            this.bluetoothCheckbox.Location = new System.Drawing.Point(15, 6);
            this.bluetoothCheckbox.Name = "bluetoothCheckbox";
            this.bluetoothCheckbox.Size = new System.Drawing.Size(15, 14);
            this.bluetoothCheckbox.TabIndex = 9;
            this.bluetoothCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.AddImageOFFBluetooth);
            this.groupBox3.Controls.Add(this.posYBluetooth);
            this.groupBox3.Controls.Add(this.posXBluetooth);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.AddImageONBluetooth);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 251);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "     ";
            // 
            // posYBluetooth
            // 
            this.posYBluetooth.Enabled = false;
            this.posYBluetooth.Location = new System.Drawing.Point(143, 123);
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
            this.posYBluetooth.Size = new System.Drawing.Size(49, 24);
            this.posYBluetooth.TabIndex = 20;
            // 
            // posXBluetooth
            // 
            this.posXBluetooth.Enabled = false;
            this.posXBluetooth.Location = new System.Drawing.Point(86, 123);
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
            this.posXBluetooth.Size = new System.Drawing.Size(49, 24);
            this.posXBluetooth.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Position:";
            // 
            // AddImageONBluetooth
            // 
            this.AddImageONBluetooth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddImageONBluetooth.Location = new System.Drawing.Point(6, 23);
            this.AddImageONBluetooth.Name = "AddImageONBluetooth";
            this.AddImageONBluetooth.Size = new System.Drawing.Size(414, 44);
            this.AddImageONBluetooth.TabIndex = 0;
            this.AddImageONBluetooth.Text = "Add image ON";
            this.AddImageONBluetooth.UseVisualStyleBackColor = true;
            this.AddImageONBluetooth.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddImageOFFBluetooth
            // 
            this.AddImageOFFBluetooth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddImageOFFBluetooth.Location = new System.Drawing.Point(6, 73);
            this.AddImageOFFBluetooth.Name = "AddImageOFFBluetooth";
            this.AddImageOFFBluetooth.Size = new System.Drawing.Size(414, 44);
            this.AddImageOFFBluetooth.TabIndex = 21;
            this.AddImageOFFBluetooth.Text = "Add image OFF";
            this.AddImageOFFBluetooth.UseVisualStyleBackColor = true;
            this.AddImageOFFBluetooth.Click += new System.EventHandler(this.AddImageClick);
            // 
            // ImagePic
            // 
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Location = new System.Drawing.Point(468, 12);
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.Size = new System.Drawing.Size(126, 294);
            this.ImagePic.TabIndex = 14;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(16, 312);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(577, 37);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // lockCheckbox
            // 
            this.lockCheckbox.AutoSize = true;
            this.lockCheckbox.Location = new System.Drawing.Point(15, 6);
            this.lockCheckbox.Name = "lockCheckbox";
            this.lockCheckbox.Size = new System.Drawing.Size(15, 14);
            this.lockCheckbox.TabIndex = 11;
            this.lockCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AddImageOFFLock);
            this.groupBox1.Controls.Add(this.posYLock);
            this.groupBox1.Controls.Add(this.posXLock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddImageONLock);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 251);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "     ";
            // 
            // AddImageOFFLock
            // 
            this.AddImageOFFLock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddImageOFFLock.Location = new System.Drawing.Point(6, 73);
            this.AddImageOFFLock.Name = "AddImageOFFLock";
            this.AddImageOFFLock.Size = new System.Drawing.Size(414, 44);
            this.AddImageOFFLock.TabIndex = 21;
            this.AddImageOFFLock.Text = "Add image OFF";
            this.AddImageOFFLock.UseVisualStyleBackColor = true;
            this.AddImageOFFLock.Click += new System.EventHandler(this.AddImageClick);
            // 
            // posYLock
            // 
            this.posYLock.Enabled = false;
            this.posYLock.Location = new System.Drawing.Point(143, 123);
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
            this.posYLock.Size = new System.Drawing.Size(49, 24);
            this.posYLock.TabIndex = 20;
            // 
            // posXLock
            // 
            this.posXLock.Enabled = false;
            this.posXLock.Location = new System.Drawing.Point(86, 123);
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
            this.posXLock.Size = new System.Drawing.Size(49, 24);
            this.posXLock.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Position:";
            // 
            // AddImageONLock
            // 
            this.AddImageONLock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddImageONLock.Location = new System.Drawing.Point(6, 23);
            this.AddImageONLock.Name = "AddImageONLock";
            this.AddImageONLock.Size = new System.Drawing.Size(414, 44);
            this.AddImageONLock.TabIndex = 0;
            this.AddImageONLock.Text = "Add image ON";
            this.AddImageONLock.UseVisualStyleBackColor = true;
            this.AddImageONLock.Click += new System.EventHandler(this.AddImageClick);
            // 
            // dndCheclbox
            // 
            this.dndCheclbox.AutoSize = true;
            this.dndCheclbox.Location = new System.Drawing.Point(15, 6);
            this.dndCheclbox.Name = "dndCheclbox";
            this.dndCheclbox.Size = new System.Drawing.Size(15, 14);
            this.dndCheclbox.TabIndex = 11;
            this.dndCheclbox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.AddImageOFFDND);
            this.groupBox2.Controls.Add(this.posYDND);
            this.groupBox2.Controls.Add(this.posXDND);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.AddImageONDND);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 251);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "     ";
            // 
            // AddImageOFFDND
            // 
            this.AddImageOFFDND.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddImageOFFDND.Location = new System.Drawing.Point(6, 73);
            this.AddImageOFFDND.Name = "AddImageOFFDND";
            this.AddImageOFFDND.Size = new System.Drawing.Size(414, 44);
            this.AddImageOFFDND.TabIndex = 21;
            this.AddImageOFFDND.Text = "Add image OFF";
            this.AddImageOFFDND.UseVisualStyleBackColor = true;
            this.AddImageOFFDND.Click += new System.EventHandler(this.AddImageClick);
            // 
            // posYDND
            // 
            this.posYDND.Enabled = false;
            this.posYDND.Location = new System.Drawing.Point(143, 123);
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
            this.posYDND.Size = new System.Drawing.Size(49, 24);
            this.posYDND.TabIndex = 20;
            // 
            // posXDND
            // 
            this.posXDND.Enabled = false;
            this.posXDND.Location = new System.Drawing.Point(86, 123);
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
            this.posXDND.Size = new System.Drawing.Size(49, 24);
            this.posXDND.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Position:";
            // 
            // AddImageONDND
            // 
            this.AddImageONDND.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddImageONDND.Location = new System.Drawing.Point(6, 23);
            this.AddImageONDND.Name = "AddImageONDND";
            this.AddImageONDND.Size = new System.Drawing.Size(414, 44);
            this.AddImageONDND.TabIndex = 0;
            this.AddImageONDND.Text = "Add image ON";
            this.AddImageONDND.UseVisualStyleBackColor = true;
            this.AddImageONDND.Click += new System.EventHandler(this.AddImageClick);
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 360);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StatusForm";
            this.Text = "StatusForm";
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYBluetooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXBluetooth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posYLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXLock)).EndInit();
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