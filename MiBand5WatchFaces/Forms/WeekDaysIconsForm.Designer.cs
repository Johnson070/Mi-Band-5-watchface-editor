
namespace MiBand5WatchFaces.Forms
{
    partial class WeekDaysIconsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeekDaysIconsForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.mondayButton = new System.Windows.Forms.Button();
            this.tuesdayButton = new System.Windows.Forms.Button();
            this.wednesdayButton = new System.Windows.Forms.Button();
            this.thursdayButton = new System.Windows.Forms.Button();
            this.fridayButton = new System.Windows.Forms.Button();
            this.saturdayButton = new System.Windows.Forms.Button();
            this.sundayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(12, 312);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(450, 37);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ImagePic
            // 
            this.ImagePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Location = new System.Drawing.Point(336, 12);
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.Size = new System.Drawing.Size(126, 294);
            this.ImagePic.TabIndex = 15;
            // 
            // mondayButton
            // 
            this.mondayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mondayButton.Location = new System.Drawing.Point(12, 12);
            this.mondayButton.Name = "mondayButton";
            this.mondayButton.Size = new System.Drawing.Size(318, 35);
            this.mondayButton.TabIndex = 17;
            this.mondayButton.Text = "Add monday image";
            this.mondayButton.UseVisualStyleBackColor = true;
            this.mondayButton.Click += new System.EventHandler(this.weekDayClick);
            // 
            // tuesdayButton
            // 
            this.tuesdayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tuesdayButton.Location = new System.Drawing.Point(12, 53);
            this.tuesdayButton.Name = "tuesdayButton";
            this.tuesdayButton.Size = new System.Drawing.Size(318, 35);
            this.tuesdayButton.TabIndex = 18;
            this.tuesdayButton.Text = "Add tuesday image";
            this.tuesdayButton.UseVisualStyleBackColor = true;
            this.tuesdayButton.Click += new System.EventHandler(this.weekDayClick);
            // 
            // wednesdayButton
            // 
            this.wednesdayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wednesdayButton.Location = new System.Drawing.Point(12, 94);
            this.wednesdayButton.Name = "wednesdayButton";
            this.wednesdayButton.Size = new System.Drawing.Size(318, 35);
            this.wednesdayButton.TabIndex = 19;
            this.wednesdayButton.Text = "Add wednesday image";
            this.wednesdayButton.UseVisualStyleBackColor = true;
            this.wednesdayButton.Click += new System.EventHandler(this.weekDayClick);
            // 
            // thursdayButton
            // 
            this.thursdayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thursdayButton.Location = new System.Drawing.Point(12, 135);
            this.thursdayButton.Name = "thursdayButton";
            this.thursdayButton.Size = new System.Drawing.Size(318, 35);
            this.thursdayButton.TabIndex = 20;
            this.thursdayButton.Text = "Add thursday image";
            this.thursdayButton.UseVisualStyleBackColor = true;
            this.thursdayButton.Click += new System.EventHandler(this.weekDayClick);
            // 
            // fridayButton
            // 
            this.fridayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fridayButton.Location = new System.Drawing.Point(12, 176);
            this.fridayButton.Name = "fridayButton";
            this.fridayButton.Size = new System.Drawing.Size(318, 35);
            this.fridayButton.TabIndex = 21;
            this.fridayButton.Text = "Add friday image";
            this.fridayButton.UseVisualStyleBackColor = true;
            this.fridayButton.Click += new System.EventHandler(this.weekDayClick);
            // 
            // saturdayButton
            // 
            this.saturdayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saturdayButton.Location = new System.Drawing.Point(12, 217);
            this.saturdayButton.Name = "saturdayButton";
            this.saturdayButton.Size = new System.Drawing.Size(318, 35);
            this.saturdayButton.TabIndex = 22;
            this.saturdayButton.Text = "Add saturday image";
            this.saturdayButton.UseVisualStyleBackColor = true;
            this.saturdayButton.Click += new System.EventHandler(this.weekDayClick);
            // 
            // sundayButton
            // 
            this.sundayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sundayButton.Location = new System.Drawing.Point(12, 258);
            this.sundayButton.Name = "sundayButton";
            this.sundayButton.Size = new System.Drawing.Size(318, 35);
            this.sundayButton.TabIndex = 23;
            this.sundayButton.Text = "Add sunday image";
            this.sundayButton.UseVisualStyleBackColor = true;
            this.sundayButton.Click += new System.EventHandler(this.weekDayClick);
            // 
            // WeekDaysIconsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 358);
            this.Controls.Add(this.sundayButton);
            this.Controls.Add(this.saturdayButton);
            this.Controls.Add(this.fridayButton);
            this.Controls.Add(this.thursdayButton);
            this.Controls.Add(this.wednesdayButton);
            this.Controls.Add(this.tuesdayButton);
            this.Controls.Add(this.mondayButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ImagePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeekDaysIconsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Week days icons";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WeekDaysIconsForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel ImagePic;
        private System.Windows.Forms.Button mondayButton;
        private System.Windows.Forms.Button tuesdayButton;
        private System.Windows.Forms.Button wednesdayButton;
        private System.Windows.Forms.Button thursdayButton;
        private System.Windows.Forms.Button fridayButton;
        private System.Windows.Forms.Button saturdayButton;
        private System.Windows.Forms.Button sundayButton;
    }
}