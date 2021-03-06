
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
            this.AddImagesAnimationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SpeedUpDown = new System.Windows.Forms.NumericUpDown();
            this.RepeatCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatCountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimationsListBox
            // 
            this.AnimationsListBox.FormattingEnabled = true;
            this.AnimationsListBox.Location = new System.Drawing.Point(12, 12);
            this.AnimationsListBox.Name = "AnimationsListBox";
            this.AnimationsListBox.Size = new System.Drawing.Size(130, 264);
            this.AnimationsListBox.TabIndex = 0;
            this.AnimationsListBox.SelectedIndexChanged += new System.EventHandler(this.AnimationsListBox_SelectedIndexChanged);
            // 
            // AddAnimationButton
            // 
            this.AddAnimationButton.Location = new System.Drawing.Point(12, 283);
            this.AddAnimationButton.Name = "AddAnimationButton";
            this.AddAnimationButton.Size = new System.Drawing.Size(63, 23);
            this.AddAnimationButton.TabIndex = 1;
            this.AddAnimationButton.Text = "Add";
            this.AddAnimationButton.UseVisualStyleBackColor = true;
            this.AddAnimationButton.Click += new System.EventHandler(this.AddAnimationButton_Click);
            // 
            // RemoveAnimationButton
            // 
            this.RemoveAnimationButton.Location = new System.Drawing.Point(79, 283);
            this.RemoveAnimationButton.Name = "RemoveAnimationButton";
            this.RemoveAnimationButton.Size = new System.Drawing.Size(63, 23);
            this.RemoveAnimationButton.TabIndex = 2;
            this.RemoveAnimationButton.Text = "Remove";
            this.RemoveAnimationButton.UseVisualStyleBackColor = true;
            this.RemoveAnimationButton.Click += new System.EventHandler(this.RemoveAnimationButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RepeatCountUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SpeedUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddImagesAnimationButton);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(148, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 294);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animation";
            // 
            // AddImagesAnimationButton
            // 
            this.AddImagesAnimationButton.Location = new System.Drawing.Point(6, 19);
            this.AddImagesAnimationButton.Name = "AddImagesAnimationButton";
            this.AddImagesAnimationButton.Size = new System.Drawing.Size(276, 39);
            this.AddImagesAnimationButton.TabIndex = 0;
            this.AddImagesAnimationButton.Text = "Select images";
            this.AddImagesAnimationButton.UseVisualStyleBackColor = true;
            this.AddImagesAnimationButton.Click += new System.EventHandler(this.AddImagesAnimationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speed:";
            // 
            // SpeedUpDown
            // 
            this.SpeedUpDown.Enabled = false;
            this.SpeedUpDown.Location = new System.Drawing.Point(112, 66);
            this.SpeedUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.SpeedUpDown.Name = "SpeedUpDown";
            this.SpeedUpDown.Size = new System.Drawing.Size(84, 24);
            this.SpeedUpDown.TabIndex = 3;
            this.SpeedUpDown.ValueChanged += new System.EventHandler(this.SpeedUpDown_ValueChanged);
            // 
            // RepeatCountUpDown
            // 
            this.RepeatCountUpDown.Enabled = false;
            this.RepeatCountUpDown.Location = new System.Drawing.Point(112, 94);
            this.RepeatCountUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RepeatCountUpDown.Name = "RepeatCountUpDown";
            this.RepeatCountUpDown.Size = new System.Drawing.Size(84, 24);
            this.RepeatCountUpDown.TabIndex = 5;
            this.RepeatCountUpDown.ValueChanged += new System.EventHandler(this.RepeatCountUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Repeat count:";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(12, 312);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(556, 43);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ImagePic
            // 
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ImagePic.Location = new System.Drawing.Point(442, 12);
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.Size = new System.Drawing.Size(126, 294);
            this.ImagePic.TabIndex = 19;
            // 
            // AnimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 374);
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RemoveAnimationButton);
            this.Controls.Add(this.AddAnimationButton);
            this.Controls.Add(this.AnimationsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimationForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatCountUpDown)).EndInit();
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
    }
}