
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
            // mondayButton
            // 
            resources.ApplyResources(this.mondayButton, "mondayButton");
            this.mondayButton.Name = "mondayButton";
            this.mondayButton.UseVisualStyleBackColor = true;
            this.mondayButton.Click += new System.EventHandler(this.weekDayClick);
            // 
            // tuesdayButton
            // 
            resources.ApplyResources(this.tuesdayButton, "tuesdayButton");
            this.tuesdayButton.Name = "tuesdayButton";
            this.tuesdayButton.UseVisualStyleBackColor = true;
            this.tuesdayButton.Click += new System.EventHandler(this.weekDayClick);
            // 
            // wednesdayButton
            // 
            resources.ApplyResources(this.wednesdayButton, "wednesdayButton");
            this.wednesdayButton.Name = "wednesdayButton";
            this.wednesdayButton.UseVisualStyleBackColor = true;
            this.wednesdayButton.Click += new System.EventHandler(this.weekDayClick);
            // 
            // thursdayButton
            // 
            resources.ApplyResources(this.thursdayButton, "thursdayButton");
            this.thursdayButton.Name = "thursdayButton";
            this.thursdayButton.UseVisualStyleBackColor = true;
            this.thursdayButton.Click += new System.EventHandler(this.weekDayClick);
            // 
            // fridayButton
            // 
            resources.ApplyResources(this.fridayButton, "fridayButton");
            this.fridayButton.Name = "fridayButton";
            this.fridayButton.UseVisualStyleBackColor = true;
            this.fridayButton.Click += new System.EventHandler(this.weekDayClick);
            // 
            // saturdayButton
            // 
            resources.ApplyResources(this.saturdayButton, "saturdayButton");
            this.saturdayButton.Name = "saturdayButton";
            this.saturdayButton.UseVisualStyleBackColor = true;
            this.saturdayButton.Click += new System.EventHandler(this.weekDayClick);
            // 
            // sundayButton
            // 
            resources.ApplyResources(this.sundayButton, "sundayButton");
            this.sundayButton.Name = "sundayButton";
            this.sundayButton.UseVisualStyleBackColor = true;
            this.sundayButton.Click += new System.EventHandler(this.weekDayClick);
            // 
            // WeekDaysIconsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "WeekDaysIconsForm";
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