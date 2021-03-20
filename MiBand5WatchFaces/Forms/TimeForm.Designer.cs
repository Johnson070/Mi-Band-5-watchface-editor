namespace MiBand5WatchFaces.Forms
{
    partial class TimeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddTensHourBtn = new System.Windows.Forms.Button();
            this.AddOnesHourBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddTensMinuteBtn = new System.Windows.Forms.Button();
            this.AddOnesMinuteBtn = new System.Windows.Forms.Button();
            this.TZ1groupBox = new System.Windows.Forms.GroupBox();
            this.TZ1NoTime = new System.Windows.Forms.Button();
            this.TZ1DelimeterBtn = new System.Windows.Forms.Button();
            this.timeZone1ButtonEdit = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.TZ2groupBox = new System.Windows.Forms.GroupBox();
            this.TZ2NoTime = new System.Windows.Forms.Button();
            this.TZ2DelimeterBtn = new System.Windows.Forms.Button();
            this.timeZone2ButtonEdit = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeZone2Check = new System.Windows.Forms.CheckBox();
            this.timeZone1Check = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TZ1groupBox.SuspendLayout();
            this.TZ2groupBox.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.AddTensHourBtn);
            this.groupBox1.Controls.Add(this.AddOnesHourBtn);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // AddTensHourBtn
            // 
            resources.ApplyResources(this.AddTensHourBtn, "AddTensHourBtn");
            this.AddTensHourBtn.Name = "AddTensHourBtn";
            this.AddTensHourBtn.UseVisualStyleBackColor = true;
            this.AddTensHourBtn.Click += new System.EventHandler(this.EditTwoDigits);
            // 
            // AddOnesHourBtn
            // 
            resources.ApplyResources(this.AddOnesHourBtn, "AddOnesHourBtn");
            this.AddOnesHourBtn.Name = "AddOnesHourBtn";
            this.AddOnesHourBtn.UseVisualStyleBackColor = true;
            this.AddOnesHourBtn.Click += new System.EventHandler(this.EditTwoDigits);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.AddTensMinuteBtn);
            this.groupBox2.Controls.Add(this.AddOnesMinuteBtn);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // AddTensMinuteBtn
            // 
            resources.ApplyResources(this.AddTensMinuteBtn, "AddTensMinuteBtn");
            this.AddTensMinuteBtn.Name = "AddTensMinuteBtn";
            this.AddTensMinuteBtn.UseVisualStyleBackColor = true;
            this.AddTensMinuteBtn.Click += new System.EventHandler(this.EditTwoDigits);
            // 
            // AddOnesMinuteBtn
            // 
            resources.ApplyResources(this.AddOnesMinuteBtn, "AddOnesMinuteBtn");
            this.AddOnesMinuteBtn.Name = "AddOnesMinuteBtn";
            this.AddOnesMinuteBtn.UseVisualStyleBackColor = true;
            this.AddOnesMinuteBtn.Click += new System.EventHandler(this.EditTwoDigits);
            // 
            // TZ1groupBox
            // 
            resources.ApplyResources(this.TZ1groupBox, "TZ1groupBox");
            this.TZ1groupBox.Controls.Add(this.TZ1NoTime);
            this.TZ1groupBox.Controls.Add(this.TZ1DelimeterBtn);
            this.TZ1groupBox.Controls.Add(this.timeZone1ButtonEdit);
            this.TZ1groupBox.Name = "TZ1groupBox";
            this.TZ1groupBox.TabStop = false;
            // 
            // TZ1NoTime
            // 
            resources.ApplyResources(this.TZ1NoTime, "TZ1NoTime");
            this.TZ1NoTime.Name = "TZ1NoTime";
            this.TZ1NoTime.UseVisualStyleBackColor = true;
            this.TZ1NoTime.Click += new System.EventHandler(this.TZNoTime_Click);
            // 
            // TZ1DelimeterBtn
            // 
            resources.ApplyResources(this.TZ1DelimeterBtn, "TZ1DelimeterBtn");
            this.TZ1DelimeterBtn.Name = "TZ1DelimeterBtn";
            this.TZ1DelimeterBtn.UseVisualStyleBackColor = true;
            this.TZ1DelimeterBtn.Click += new System.EventHandler(this.addDelimeter);
            // 
            // timeZone1ButtonEdit
            // 
            resources.ApplyResources(this.timeZone1ButtonEdit, "timeZone1ButtonEdit");
            this.timeZone1ButtonEdit.Name = "timeZone1ButtonEdit";
            this.timeZone1ButtonEdit.UseVisualStyleBackColor = true;
            this.timeZone1ButtonEdit.Click += new System.EventHandler(this.timeZone1ButtonEdit_Click);
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // TZ2groupBox
            // 
            resources.ApplyResources(this.TZ2groupBox, "TZ2groupBox");
            this.TZ2groupBox.Controls.Add(this.TZ2NoTime);
            this.TZ2groupBox.Controls.Add(this.TZ2DelimeterBtn);
            this.TZ2groupBox.Controls.Add(this.timeZone2ButtonEdit);
            this.TZ2groupBox.Name = "TZ2groupBox";
            this.TZ2groupBox.TabStop = false;
            // 
            // TZ2NoTime
            // 
            resources.ApplyResources(this.TZ2NoTime, "TZ2NoTime");
            this.TZ2NoTime.Name = "TZ2NoTime";
            this.TZ2NoTime.UseVisualStyleBackColor = true;
            this.TZ2NoTime.Click += new System.EventHandler(this.TZNoTime_Click);
            // 
            // TZ2DelimeterBtn
            // 
            resources.ApplyResources(this.TZ2DelimeterBtn, "TZ2DelimeterBtn");
            this.TZ2DelimeterBtn.Name = "TZ2DelimeterBtn";
            this.TZ2DelimeterBtn.UseVisualStyleBackColor = true;
            this.TZ2DelimeterBtn.Click += new System.EventHandler(this.addDelimeter);
            // 
            // timeZone2ButtonEdit
            // 
            resources.ApplyResources(this.timeZone2ButtonEdit, "timeZone2ButtonEdit");
            this.timeZone2ButtonEdit.Name = "timeZone2ButtonEdit";
            this.timeZone2ButtonEdit.UseVisualStyleBackColor = true;
            this.timeZone2ButtonEdit.Click += new System.EventHandler(this.timeZone2ButtonEdit_Click);
            // 
            // ImagePic
            // 
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.ImagePic, "ImagePic");
            this.ImagePic.Name = "ImagePic";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            // 
            // timeZone2Check
            // 
            resources.ApplyResources(this.timeZone2Check, "timeZone2Check");
            this.timeZone2Check.Name = "timeZone2Check";
            this.timeZone2Check.UseVisualStyleBackColor = true;
            this.timeZone2Check.CheckedChanged += new System.EventHandler(this.timeZoneChanged);
            // 
            // timeZone1Check
            // 
            resources.ApplyResources(this.timeZone1Check, "timeZone1Check");
            this.timeZone1Check.Name = "timeZone1Check";
            this.timeZone1Check.UseVisualStyleBackColor = true;
            this.timeZone1Check.CheckedChanged += new System.EventHandler(this.timeZoneChanged);
            // 
            // TimeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.timeZone1Check);
            this.Controls.Add(this.timeZone2Check);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TZ1groupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TZ2groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TimeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.TZ1groupBox.ResumeLayout(false);
            this.TZ2groupBox.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddOnesHourBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox TZ1groupBox;
        private System.Windows.Forms.Button timeZone1ButtonEdit;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox TZ2groupBox;
        private System.Windows.Forms.Button timeZone2ButtonEdit;
        private System.Windows.Forms.Button AddTensHourBtn;
        private System.Windows.Forms.Button AddTensMinuteBtn;
        private System.Windows.Forms.Button AddOnesMinuteBtn;
        private System.Windows.Forms.Panel ImagePic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.CheckBox timeZone2Check;
        private System.Windows.Forms.CheckBox timeZone1Check;
        private System.Windows.Forms.Button TZ1NoTime;
        private System.Windows.Forms.Button TZ1DelimeterBtn;
        private System.Windows.Forms.Button TZ2NoTime;
        private System.Windows.Forms.Button TZ2DelimeterBtn;
    }
}