
namespace MiBand5WatchFaces.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.PaletteModeCheckBox = new System.Windows.Forms.CheckBox();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChineseRadioButton = new System.Windows.Forms.RadioButton();
            this.SimpleChineseRadioButton = new System.Windows.Forms.RadioButton();
            this.PreviewSpeedTrack = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ForceImageCompressorCheck = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewSpeedTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // PaletteModeCheckBox
            // 
            resources.ApplyResources(this.PaletteModeCheckBox, "PaletteModeCheckBox");
            this.PaletteModeCheckBox.Name = "PaletteModeCheckBox";
            this.PaletteModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // EnglishRadioButton
            // 
            resources.ApplyResources(this.EnglishRadioButton, "EnglishRadioButton");
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.ChineseRadioButton);
            this.groupBox1.Controls.Add(this.SimpleChineseRadioButton);
            this.groupBox1.Controls.Add(this.EnglishRadioButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // ChineseRadioButton
            // 
            resources.ApplyResources(this.ChineseRadioButton, "ChineseRadioButton");
            this.ChineseRadioButton.Name = "ChineseRadioButton";
            this.ChineseRadioButton.TabStop = true;
            this.ChineseRadioButton.UseVisualStyleBackColor = true;
            // 
            // SimpleChineseRadioButton
            // 
            resources.ApplyResources(this.SimpleChineseRadioButton, "SimpleChineseRadioButton");
            this.SimpleChineseRadioButton.Name = "SimpleChineseRadioButton";
            this.SimpleChineseRadioButton.TabStop = true;
            this.SimpleChineseRadioButton.UseVisualStyleBackColor = true;
            // 
            // PreviewSpeedTrack
            // 
            resources.ApplyResources(this.PreviewSpeedTrack, "PreviewSpeedTrack");
            this.PreviewSpeedTrack.Maximum = 1000;
            this.PreviewSpeedTrack.Minimum = 50;
            this.PreviewSpeedTrack.Name = "PreviewSpeedTrack";
            this.PreviewSpeedTrack.Value = 50;
            this.PreviewSpeedTrack.ValueChanged += new System.EventHandler(this.PreviewSpeedTrack_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ForceImageCompressorCheck
            // 
            resources.ApplyResources(this.ForceImageCompressorCheck, "ForceImageCompressorCheck");
            this.ForceImageCompressorCheck.Name = "ForceImageCompressorCheck";
            this.ForceImageCompressorCheck.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ForceImageCompressorCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PreviewSpeedTrack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PaletteModeCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewSpeedTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox PaletteModeCheckBox;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ChineseRadioButton;
        private System.Windows.Forms.RadioButton SimpleChineseRadioButton;
        private System.Windows.Forms.TrackBar PreviewSpeedTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ForceImageCompressorCheck;
        private System.Windows.Forms.Button SaveButton;
    }
}