
namespace MiBand5WatchFaces.Forms
{
    partial class AlarmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.AddNumberButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddImageNoAlarmButton = new System.Windows.Forms.Button();
            this.AddImageOFFButton = new System.Windows.Forms.Button();
            this.AddImageOnButton = new System.Windows.Forms.Button();
            this.AddDelimeterButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ImagePic
            // 
            resources.ApplyResources(this.ImagePic, "ImagePic");
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Name = "ImagePic";
            // 
            // AddNumberButton
            // 
            resources.ApplyResources(this.AddNumberButton, "AddNumberButton");
            this.AddNumberButton.Name = "AddNumberButton";
            this.AddNumberButton.UseVisualStyleBackColor = true;
            this.AddNumberButton.Click += new System.EventHandler(this.AddNumberButton_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.AddImageNoAlarmButton);
            this.groupBox1.Controls.Add(this.AddImageOFFButton);
            this.groupBox1.Controls.Add(this.AddImageOnButton);
            this.groupBox1.Controls.Add(this.AddDelimeterButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // AddImageNoAlarmButton
            // 
            resources.ApplyResources(this.AddImageNoAlarmButton, "AddImageNoAlarmButton");
            this.AddImageNoAlarmButton.Name = "AddImageNoAlarmButton";
            this.AddImageNoAlarmButton.UseVisualStyleBackColor = true;
            this.AddImageNoAlarmButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddImageOFFButton
            // 
            resources.ApplyResources(this.AddImageOFFButton, "AddImageOFFButton");
            this.AddImageOFFButton.Name = "AddImageOFFButton";
            this.AddImageOFFButton.UseVisualStyleBackColor = true;
            this.AddImageOFFButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddImageOnButton
            // 
            resources.ApplyResources(this.AddImageOnButton, "AddImageOnButton");
            this.AddImageOnButton.Name = "AddImageOnButton";
            this.AddImageOnButton.UseVisualStyleBackColor = true;
            this.AddImageOnButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddDelimeterButton
            // 
            resources.ApplyResources(this.AddDelimeterButton, "AddDelimeterButton");
            this.AddDelimeterButton.Name = "AddDelimeterButton";
            this.AddDelimeterButton.UseVisualStyleBackColor = true;
            this.AddDelimeterButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AlarmForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddNumberButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ImagePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlarmForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlarmForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel ImagePic;
        private System.Windows.Forms.Button AddNumberButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddImageNoAlarmButton;
        private System.Windows.Forms.Button AddImageOFFButton;
        private System.Windows.Forms.Button AddImageOnButton;
        private System.Windows.Forms.Button AddDelimeterButton;
    }
}