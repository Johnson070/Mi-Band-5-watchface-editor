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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddTensHourBtn = new System.Windows.Forms.Button();
            this.editPosOnesHourBtn = new System.Windows.Forms.Button();
            this.editPosTensHourBtn = new System.Windows.Forms.Button();
            this.AddOnesHourBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddTensMinuteBtn = new System.Windows.Forms.Button();
            this.AddOnesMinuteBtn = new System.Windows.Forms.Button();
            this.editPosOnesMinuteBtn = new System.Windows.Forms.Button();
            this.editPosTensMinuteBtn = new System.Windows.Forms.Button();
            this.TZ1groupBox = new System.Windows.Forms.GroupBox();
            this.TZ1NoTime = new System.Windows.Forms.Button();
            this.TZ1DelimeterBtn = new System.Windows.Forms.Button();
            this.editPosTZ1Btn = new System.Windows.Forms.Button();
            this.timeZone1ButtonEdit = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.TZ2groupBox = new System.Windows.Forms.GroupBox();
            this.TZ2NoTime = new System.Windows.Forms.Button();
            this.TZ2DelimeterBtn = new System.Windows.Forms.Button();
            this.editPosTZ2Btn = new System.Windows.Forms.Button();
            this.timeZone2ButtonEdit = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeZone2Check = new System.Windows.Forms.CheckBox();
            this.timeZone1Check = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.posImageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TZ1groupBox.SuspendLayout();
            this.TZ2groupBox.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AddTensHourBtn);
            this.groupBox1.Controls.Add(this.editPosOnesHourBtn);
            this.groupBox1.Controls.Add(this.editPosTensHourBtn);
            this.groupBox1.Controls.Add(this.AddOnesHourBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(144, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hours";
            // 
            // AddTensHourBtn
            // 
            this.AddTensHourBtn.Location = new System.Drawing.Point(141, 19);
            this.AddTensHourBtn.Name = "AddTensHourBtn";
            this.AddTensHourBtn.Size = new System.Drawing.Size(124, 31);
            this.AddTensHourBtn.TabIndex = 3;
            this.AddTensHourBtn.Text = "Add Tens";
            this.AddTensHourBtn.UseVisualStyleBackColor = true;
            this.AddTensHourBtn.Click += new System.EventHandler(this.EditTwoDigits);
            // 
            // editPosOnesHourBtn
            // 
            this.editPosOnesHourBtn.Location = new System.Drawing.Point(141, 56);
            this.editPosOnesHourBtn.Name = "editPosOnesHourBtn";
            this.editPosOnesHourBtn.Size = new System.Drawing.Size(124, 31);
            this.editPosOnesHourBtn.TabIndex = 2;
            this.editPosOnesHourBtn.Text = "Edit pos Ones";
            this.editPosOnesHourBtn.UseVisualStyleBackColor = true;
            this.editPosOnesHourBtn.Click += new System.EventHandler(this.editPos_click);
            this.editPosOnesHourBtn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.editPosKeyArrowsPress);
            // 
            // editPosTensHourBtn
            // 
            this.editPosTensHourBtn.Location = new System.Drawing.Point(6, 56);
            this.editPosTensHourBtn.Name = "editPosTensHourBtn";
            this.editPosTensHourBtn.Size = new System.Drawing.Size(124, 31);
            this.editPosTensHourBtn.TabIndex = 1;
            this.editPosTensHourBtn.Text = "Edit pos Tens";
            this.editPosTensHourBtn.UseVisualStyleBackColor = true;
            this.editPosTensHourBtn.Click += new System.EventHandler(this.editPos_click);
            this.editPosTensHourBtn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.editPosKeyArrowsPress);
            // 
            // AddOnesHourBtn
            // 
            this.AddOnesHourBtn.Location = new System.Drawing.Point(6, 19);
            this.AddOnesHourBtn.Name = "AddOnesHourBtn";
            this.AddOnesHourBtn.Size = new System.Drawing.Size(124, 31);
            this.AddOnesHourBtn.TabIndex = 0;
            this.AddOnesHourBtn.Text = "Add Ones";
            this.AddOnesHourBtn.UseVisualStyleBackColor = true;
            this.AddOnesHourBtn.Click += new System.EventHandler(this.EditTwoDigits);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.AddTensMinuteBtn);
            this.groupBox2.Controls.Add(this.AddOnesMinuteBtn);
            this.groupBox2.Controls.Add(this.editPosOnesMinuteBtn);
            this.groupBox2.Controls.Add(this.editPosTensMinuteBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(144, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 96);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Minutes";
            // 
            // AddTensMinuteBtn
            // 
            this.AddTensMinuteBtn.Location = new System.Drawing.Point(141, 19);
            this.AddTensMinuteBtn.Name = "AddTensMinuteBtn";
            this.AddTensMinuteBtn.Size = new System.Drawing.Size(124, 31);
            this.AddTensMinuteBtn.TabIndex = 6;
            this.AddTensMinuteBtn.Text = "Add Tens";
            this.AddTensMinuteBtn.UseVisualStyleBackColor = true;
            this.AddTensMinuteBtn.Click += new System.EventHandler(this.EditTwoDigits);
            // 
            // AddOnesMinuteBtn
            // 
            this.AddOnesMinuteBtn.Location = new System.Drawing.Point(6, 19);
            this.AddOnesMinuteBtn.Name = "AddOnesMinuteBtn";
            this.AddOnesMinuteBtn.Size = new System.Drawing.Size(124, 31);
            this.AddOnesMinuteBtn.TabIndex = 5;
            this.AddOnesMinuteBtn.Text = "Add Ones";
            this.AddOnesMinuteBtn.UseVisualStyleBackColor = true;
            this.AddOnesMinuteBtn.Click += new System.EventHandler(this.EditTwoDigits);
            // 
            // editPosOnesMinuteBtn
            // 
            this.editPosOnesMinuteBtn.Location = new System.Drawing.Point(141, 56);
            this.editPosOnesMinuteBtn.Name = "editPosOnesMinuteBtn";
            this.editPosOnesMinuteBtn.Size = new System.Drawing.Size(124, 31);
            this.editPosOnesMinuteBtn.TabIndex = 4;
            this.editPosOnesMinuteBtn.Text = "Edit pos Ones";
            this.editPosOnesMinuteBtn.UseVisualStyleBackColor = true;
            this.editPosOnesMinuteBtn.Click += new System.EventHandler(this.editPos_click);
            this.editPosOnesMinuteBtn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.editPosKeyArrowsPress);
            // 
            // editPosTensMinuteBtn
            // 
            this.editPosTensMinuteBtn.Location = new System.Drawing.Point(6, 56);
            this.editPosTensMinuteBtn.Name = "editPosTensMinuteBtn";
            this.editPosTensMinuteBtn.Size = new System.Drawing.Size(124, 31);
            this.editPosTensMinuteBtn.TabIndex = 3;
            this.editPosTensMinuteBtn.Text = "Edit pos Tens";
            this.editPosTensMinuteBtn.UseVisualStyleBackColor = true;
            this.editPosTensMinuteBtn.Click += new System.EventHandler(this.editPos_click);
            this.editPosTensMinuteBtn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.editPosKeyArrowsPress);
            // 
            // TZ1groupBox
            // 
            this.TZ1groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TZ1groupBox.Controls.Add(this.TZ1NoTime);
            this.TZ1groupBox.Controls.Add(this.TZ1DelimeterBtn);
            this.TZ1groupBox.Controls.Add(this.editPosTZ1Btn);
            this.TZ1groupBox.Controls.Add(this.timeZone1ButtonEdit);
            this.TZ1groupBox.Enabled = false;
            this.TZ1groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TZ1groupBox.Location = new System.Drawing.Point(144, 216);
            this.TZ1groupBox.Name = "TZ1groupBox";
            this.TZ1groupBox.Size = new System.Drawing.Size(271, 131);
            this.TZ1groupBox.TabIndex = 5;
            this.TZ1groupBox.TabStop = false;
            this.TZ1groupBox.Text = "    Time Zone 1";
            // 
            // TZ1NoTime
            // 
            this.TZ1NoTime.Location = new System.Drawing.Point(141, 56);
            this.TZ1NoTime.Name = "TZ1NoTime";
            this.TZ1NoTime.Size = new System.Drawing.Size(124, 31);
            this.TZ1NoTime.TabIndex = 6;
            this.TZ1NoTime.Text = "Add no time";
            this.TZ1NoTime.UseVisualStyleBackColor = true;
            this.TZ1NoTime.Click += new System.EventHandler(this.TZNoTime_Click);
            // 
            // TZ1DelimeterBtn
            // 
            this.TZ1DelimeterBtn.Location = new System.Drawing.Point(6, 56);
            this.TZ1DelimeterBtn.Name = "TZ1DelimeterBtn";
            this.TZ1DelimeterBtn.Size = new System.Drawing.Size(124, 31);
            this.TZ1DelimeterBtn.TabIndex = 5;
            this.TZ1DelimeterBtn.Text = "Add delimeter";
            this.TZ1DelimeterBtn.UseVisualStyleBackColor = true;
            this.TZ1DelimeterBtn.Click += new System.EventHandler(this.addDelimeter);
            // 
            // editPosTZ1Btn
            // 
            this.editPosTZ1Btn.Enabled = false;
            this.editPosTZ1Btn.Location = new System.Drawing.Point(6, 93);
            this.editPosTZ1Btn.Name = "editPosTZ1Btn";
            this.editPosTZ1Btn.Size = new System.Drawing.Size(259, 31);
            this.editPosTZ1Btn.TabIndex = 4;
            this.editPosTZ1Btn.Text = "Edit pos";
            this.editPosTZ1Btn.UseVisualStyleBackColor = true;
            this.editPosTZ1Btn.Click += new System.EventHandler(this.editPosTZ);
            this.editPosTZ1Btn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.editPosKeyArrowsPress);
            // 
            // timeZone1ButtonEdit
            // 
            this.timeZone1ButtonEdit.Location = new System.Drawing.Point(6, 19);
            this.timeZone1ButtonEdit.Name = "timeZone1ButtonEdit";
            this.timeZone1ButtonEdit.Size = new System.Drawing.Size(259, 31);
            this.timeZone1ButtonEdit.TabIndex = 0;
            this.timeZone1ButtonEdit.Text = "Add";
            this.timeZone1ButtonEdit.UseVisualStyleBackColor = true;
            this.timeZone1ButtonEdit.Click += new System.EventHandler(this.timeZone1ButtonEdit_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(12, 490);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(403, 47);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // TZ2groupBox
            // 
            this.TZ2groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TZ2groupBox.Controls.Add(this.TZ2NoTime);
            this.TZ2groupBox.Controls.Add(this.TZ2DelimeterBtn);
            this.TZ2groupBox.Controls.Add(this.editPosTZ2Btn);
            this.TZ2groupBox.Controls.Add(this.timeZone2ButtonEdit);
            this.TZ2groupBox.Enabled = false;
            this.TZ2groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TZ2groupBox.Location = new System.Drawing.Point(144, 353);
            this.TZ2groupBox.Name = "TZ2groupBox";
            this.TZ2groupBox.Size = new System.Drawing.Size(271, 131);
            this.TZ2groupBox.TabIndex = 6;
            this.TZ2groupBox.TabStop = false;
            this.TZ2groupBox.Text = "    Time Zone 2";
            // 
            // TZ2NoTime
            // 
            this.TZ2NoTime.Location = new System.Drawing.Point(141, 56);
            this.TZ2NoTime.Name = "TZ2NoTime";
            this.TZ2NoTime.Size = new System.Drawing.Size(124, 31);
            this.TZ2NoTime.TabIndex = 8;
            this.TZ2NoTime.Text = "Add no time";
            this.TZ2NoTime.UseVisualStyleBackColor = true;
            this.TZ2NoTime.Click += new System.EventHandler(this.TZNoTime_Click);
            // 
            // TZ2DelimeterBtn
            // 
            this.TZ2DelimeterBtn.Location = new System.Drawing.Point(6, 56);
            this.TZ2DelimeterBtn.Name = "TZ2DelimeterBtn";
            this.TZ2DelimeterBtn.Size = new System.Drawing.Size(124, 31);
            this.TZ2DelimeterBtn.TabIndex = 7;
            this.TZ2DelimeterBtn.Text = "Add delimeter";
            this.TZ2DelimeterBtn.UseVisualStyleBackColor = true;
            this.TZ2DelimeterBtn.Click += new System.EventHandler(this.addDelimeter);
            // 
            // editPosTZ2Btn
            // 
            this.editPosTZ2Btn.Enabled = false;
            this.editPosTZ2Btn.Location = new System.Drawing.Point(6, 93);
            this.editPosTZ2Btn.Name = "editPosTZ2Btn";
            this.editPosTZ2Btn.Size = new System.Drawing.Size(259, 31);
            this.editPosTZ2Btn.TabIndex = 4;
            this.editPosTZ2Btn.Text = "Edit pos";
            this.editPosTZ2Btn.UseVisualStyleBackColor = true;
            this.editPosTZ2Btn.Click += new System.EventHandler(this.editPosTZ);
            this.editPosTZ2Btn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.editPosKeyArrowsPress);
            // 
            // timeZone2ButtonEdit
            // 
            this.timeZone2ButtonEdit.Location = new System.Drawing.Point(6, 19);
            this.timeZone2ButtonEdit.Name = "timeZone2ButtonEdit";
            this.timeZone2ButtonEdit.Size = new System.Drawing.Size(259, 31);
            this.timeZone2ButtonEdit.TabIndex = 0;
            this.timeZone2ButtonEdit.Text = "Add";
            this.timeZone2ButtonEdit.UseVisualStyleBackColor = true;
            this.timeZone2ButtonEdit.Click += new System.EventHandler(this.timeZone2ButtonEdit_Click);
            // 
            // ImagePic
            // 
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Location = new System.Drawing.Point(12, 68);
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.Size = new System.Drawing.Size(126, 294);
            this.ImagePic.TabIndex = 7;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // timeZone2Check
            // 
            this.timeZone2Check.AutoSize = true;
            this.timeZone2Check.Location = new System.Drawing.Point(153, 355);
            this.timeZone2Check.Name = "timeZone2Check";
            this.timeZone2Check.Size = new System.Drawing.Size(15, 14);
            this.timeZone2Check.TabIndex = 10;
            this.timeZone2Check.UseVisualStyleBackColor = true;
            this.timeZone2Check.CheckedChanged += new System.EventHandler(this.timeZoneChanged);
            // 
            // timeZone1Check
            // 
            this.timeZone1Check.AutoSize = true;
            this.timeZone1Check.Location = new System.Drawing.Point(153, 218);
            this.timeZone1Check.Name = "timeZone1Check";
            this.timeZone1Check.Size = new System.Drawing.Size(15, 14);
            this.timeZone1Check.TabIndex = 9;
            this.timeZone1Check.UseVisualStyleBackColor = true;
            this.timeZone1Check.CheckedChanged += new System.EventHandler(this.timeZoneChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posImageLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(427, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // posImageLabel
            // 
            this.posImageLabel.Name = "posImageLabel";
            this.posImageLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // TimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(427, 567);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.timeZone1Check);
            this.Controls.Add(this.timeZone2Check);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TZ1groupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TZ2groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.TZ1groupBox.ResumeLayout(false);
            this.TZ2groupBox.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editPosOnesHourBtn;
        private System.Windows.Forms.Button editPosTensHourBtn;
        private System.Windows.Forms.Button AddOnesHourBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button editPosOnesMinuteBtn;
        private System.Windows.Forms.Button editPosTensMinuteBtn;
        private System.Windows.Forms.GroupBox TZ1groupBox;
        private System.Windows.Forms.Button editPosTZ1Btn;
        private System.Windows.Forms.Button timeZone1ButtonEdit;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox TZ2groupBox;
        private System.Windows.Forms.Button editPosTZ2Btn;
        private System.Windows.Forms.Button timeZone2ButtonEdit;
        private System.Windows.Forms.Button AddTensHourBtn;
        private System.Windows.Forms.Button AddTensMinuteBtn;
        private System.Windows.Forms.Button AddOnesMinuteBtn;
        private System.Windows.Forms.Panel ImagePic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.CheckBox timeZone2Check;
        private System.Windows.Forms.CheckBox timeZone1Check;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel posImageLabel;
        private System.Windows.Forms.Button TZ1NoTime;
        private System.Windows.Forms.Button TZ1DelimeterBtn;
        private System.Windows.Forms.Button TZ2NoTime;
        private System.Windows.Forms.Button TZ2DelimeterBtn;
    }
}