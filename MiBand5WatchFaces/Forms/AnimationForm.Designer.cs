
namespace MiBand5WatchFaces.Forms
{
    partial class AnimationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimationForm));
            this.AnimationsListBox = new System.Windows.Forms.ListBox();
            this.AddAnimationButton = new System.Windows.Forms.Button();
            this.RemoveAnimationButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RepeatCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeedUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AddImagesAnimationButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimationsListBox
            // 
            resources.ApplyResources(this.AnimationsListBox, "AnimationsListBox");
            this.AnimationsListBox.FormattingEnabled = true;
            this.AnimationsListBox.Name = "AnimationsListBox";
            this.AnimationsListBox.SelectedIndexChanged += new System.EventHandler(this.AnimationsListBox_SelectedIndexChanged);
            // 
            // AddAnimationButton
            // 
            resources.ApplyResources(this.AddAnimationButton, "AddAnimationButton");
            this.AddAnimationButton.Name = "AddAnimationButton";
            this.AddAnimationButton.UseVisualStyleBackColor = true;
            this.AddAnimationButton.Click += new System.EventHandler(this.AddAnimationButton_Click);
            // 
            // RemoveAnimationButton
            // 
            resources.ApplyResources(this.RemoveAnimationButton, "RemoveAnimationButton");
            this.RemoveAnimationButton.Name = "RemoveAnimationButton";
            this.RemoveAnimationButton.UseVisualStyleBackColor = true;
            this.RemoveAnimationButton.Click += new System.EventHandler(this.RemoveAnimationButton_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.RepeatCountUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SpeedUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddImagesAnimationButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // RepeatCountUpDown
            // 
            resources.ApplyResources(this.RepeatCountUpDown, "RepeatCountUpDown");
            this.RepeatCountUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RepeatCountUpDown.Name = "RepeatCountUpDown";
            this.RepeatCountUpDown.ValueChanged += new System.EventHandler(this.RepeatCountUpDown_ValueChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // SpeedUpDown
            // 
            resources.ApplyResources(this.SpeedUpDown, "SpeedUpDown");
            this.SpeedUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.SpeedUpDown.Name = "SpeedUpDown";
            this.SpeedUpDown.ValueChanged += new System.EventHandler(this.SpeedUpDown_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // AddImagesAnimationButton
            // 
            resources.ApplyResources(this.AddImagesAnimationButton, "AddImagesAnimationButton");
            this.AddImagesAnimationButton.Name = "AddImagesAnimationButton";
            this.AddImagesAnimationButton.UseVisualStyleBackColor = true;
            this.AddImagesAnimationButton.Click += new System.EventHandler(this.AddImagesAnimationButton_Click);
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ImagePic
            // 
            resources.ApplyResources(this.ImagePic, "ImagePic");
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.Tag = "0";
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Enabled = true;
            this.AnimationTimer.Interval = 150;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimateTimer_Tick);
            // 
            // AnimationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RemoveAnimationButton);
            this.Controls.Add(this.AddAnimationButton);
            this.Controls.Add(this.AnimationsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnimationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimationForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AnimationsListBox;
        private System.Windows.Forms.Button AddAnimationButton;
        private System.Windows.Forms.Button RemoveAnimationButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddImagesAnimationButton;
        private System.Windows.Forms.NumericUpDown RepeatCountUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown SpeedUpDown;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel ImagePic;
        private System.Windows.Forms.Timer AnimationTimer;
    }
}