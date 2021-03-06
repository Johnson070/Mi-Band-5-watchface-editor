
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
            this.AddDelimeterButton = new System.Windows.Forms.Button();
            this.AddImageOnButton = new System.Windows.Forms.Button();
            this.AddImageOFFButton = new System.Windows.Forms.Button();
            this.AddImageNoAlarmButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(12, 312);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(523, 37);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ImagePic
            // 
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Location = new System.Drawing.Point(409, 12);
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.Size = new System.Drawing.Size(126, 294);
            this.ImagePic.TabIndex = 17;
            // 
            // AddNumberButton
            // 
            this.AddNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNumberButton.Location = new System.Drawing.Point(12, 12);
            this.AddNumberButton.Name = "AddNumberButton";
            this.AddNumberButton.Size = new System.Drawing.Size(391, 46);
            this.AddNumberButton.TabIndex = 19;
            this.AddNumberButton.Text = "Add number";
            this.AddNumberButton.UseVisualStyleBackColor = true;
            this.AddNumberButton.Click += new System.EventHandler(this.AddNumberButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddImageNoAlarmButton);
            this.groupBox1.Controls.Add(this.AddImageOFFButton);
            this.groupBox1.Controls.Add(this.AddImageOnButton);
            this.groupBox1.Controls.Add(this.AddDelimeterButton);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 242);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // AddDelimeterButton
            // 
            this.AddDelimeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDelimeterButton.Location = new System.Drawing.Point(6, 23);
            this.AddDelimeterButton.Name = "AddDelimeterButton";
            this.AddDelimeterButton.Size = new System.Drawing.Size(379, 46);
            this.AddDelimeterButton.TabIndex = 20;
            this.AddDelimeterButton.Text = "Add delimeter";
            this.AddDelimeterButton.UseVisualStyleBackColor = true;
            this.AddDelimeterButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddImageOnButton
            // 
            this.AddImageOnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddImageOnButton.Location = new System.Drawing.Point(6, 75);
            this.AddImageOnButton.Name = "AddImageOnButton";
            this.AddImageOnButton.Size = new System.Drawing.Size(379, 46);
            this.AddImageOnButton.TabIndex = 21;
            this.AddImageOnButton.Text = "Add image ON";
            this.AddImageOnButton.UseVisualStyleBackColor = true;
            this.AddImageOnButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddImageOFFButton
            // 
            this.AddImageOFFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddImageOFFButton.Location = new System.Drawing.Point(6, 127);
            this.AddImageOFFButton.Name = "AddImageOFFButton";
            this.AddImageOFFButton.Size = new System.Drawing.Size(379, 46);
            this.AddImageOFFButton.TabIndex = 22;
            this.AddImageOFFButton.Text = "Add image OFF";
            this.AddImageOFFButton.UseVisualStyleBackColor = true;
            this.AddImageOFFButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AddImageNoAlarmButton
            // 
            this.AddImageNoAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddImageNoAlarmButton.Location = new System.Drawing.Point(6, 179);
            this.AddImageNoAlarmButton.Name = "AddImageNoAlarmButton";
            this.AddImageNoAlarmButton.Size = new System.Drawing.Size(379, 46);
            this.AddImageNoAlarmButton.TabIndex = 23;
            this.AddImageNoAlarmButton.Text = "Add image no alarm";
            this.AddImageNoAlarmButton.UseVisualStyleBackColor = true;
            this.AddImageNoAlarmButton.Click += new System.EventHandler(this.AddImageClick);
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddNumberButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ImagePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlarmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
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