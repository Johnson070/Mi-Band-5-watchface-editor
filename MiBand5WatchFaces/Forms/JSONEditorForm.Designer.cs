
namespace MiBand5WatchFaces.Forms
{
    partial class JSONEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JSONEditorForm));
            this.RenderButton = new System.Windows.Forms.Button();
            this.ImagePic = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.jsonTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePic)).BeginInit();
            this.SuspendLayout();
            // 
            // RenderButton
            // 
            resources.ApplyResources(this.RenderButton, "RenderButton");
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.UseVisualStyleBackColor = true;
            this.RenderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // ImagePic
            // 
            this.ImagePic.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.ImagePic, "ImagePic");
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.TabStop = false;
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // jsonTextBox
            // 
            resources.ApplyResources(this.jsonTextBox, "jsonTextBox");
            this.jsonTextBox.Name = "jsonTextBox";
            this.jsonTextBox.TextChanged += new System.EventHandler(this.jsonTextBox_TextChanged);
            // 
            // JSONEditorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.jsonTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.RenderButton);
            this.Controls.Add(this.ImagePic);
            this.Name = "JSONEditorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JSONEditorForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RenderButton;
        private System.Windows.Forms.PictureBox ImagePic;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox jsonTextBox;
    }
}