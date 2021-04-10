namespace MiBand5WatchFaces
{
    partial class ImagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagesForm));
            this.ImagesListBox = new System.Windows.Forms.CheckedListBox();
            this.listImagesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteImageToolButton = new System.Windows.Forms.ToolStripMenuItem();
            this.addImageWithNumberToolButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uncheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.AddImagesButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteImagesButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveImagesButton = new System.Windows.Forms.ToolStripButton();
            this.AddImagesToElement = new System.Windows.Forms.Button();
            this.ChangeImageButton = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.Panel();
            this.listImagesMenuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImagesListBox
            // 
            resources.ApplyResources(this.ImagesListBox, "ImagesListBox");
            this.ImagesListBox.ContextMenuStrip = this.listImagesMenuStrip;
            this.ImagesListBox.FormattingEnabled = true;
            this.ImagesListBox.Name = "ImagesListBox";
            this.ImagesListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ImagesListBox_ItemCheck);
            this.ImagesListBox.SelectedIndexChanged += new System.EventHandler(this.ImagesListBox_SelectedIndexChanged);
            this.ImagesListBox.SelectedValueChanged += new System.EventHandler(this.ImagesListBox_SelectedValueChanged);
            this.ImagesListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ImagesListBox_KeyUp);
            this.ImagesListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImagesListBox_MouseDown);
            this.ImagesListBox.MouseLeave += new System.EventHandler(this.ImagesListBox_MouseLeave);
            this.ImagesListBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImagesListBox_MouseMove);
            this.ImagesListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImagesListBox_MouseUp);
            this.ImagesListBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ImagesListBox_PreviewKeyDown);
            // 
            // listImagesMenuStrip
            // 
            this.listImagesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteImageToolButton,
            this.addImageWithNumberToolButton,
            this.toolStripSeparator2,
            this.uncheckAllToolStripMenuItem});
            this.listImagesMenuStrip.Name = "listImagesMenuStrip";
            resources.ApplyResources(this.listImagesMenuStrip, "listImagesMenuStrip");
            // 
            // deleteImageToolButton
            // 
            this.deleteImageToolButton.Name = "deleteImageToolButton";
            resources.ApplyResources(this.deleteImageToolButton, "deleteImageToolButton");
            this.deleteImageToolButton.Click += new System.EventHandler(this.deleteImageToolButton_Click);
            // 
            // addImageWithNumberToolButton
            // 
            this.addImageWithNumberToolButton.Name = "addImageWithNumberToolButton";
            resources.ApplyResources(this.addImageWithNumberToolButton, "addImageWithNumberToolButton");
            this.addImageWithNumberToolButton.Click += new System.EventHandler(this.addImageWithNumberToolButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // uncheckAllToolStripMenuItem
            // 
            this.uncheckAllToolStripMenuItem.Name = "uncheckAllToolStripMenuItem";
            resources.ApplyResources(this.uncheckAllToolStripMenuItem, "uncheckAllToolStripMenuItem");
            this.uncheckAllToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddImagesButton,
            this.DeleteImagesButton,
            this.toolStripSeparator1,
            this.saveImagesButton});
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.Name = "toolStrip";
            // 
            // AddImagesButton
            // 
            this.AddImagesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.AddImagesButton, "AddImagesButton");
            this.AddImagesButton.Name = "AddImagesButton";
            this.AddImagesButton.Click += new System.EventHandler(this.AddImagesButton_Click);
            // 
            // DeleteImagesButton
            // 
            this.DeleteImagesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.DeleteImagesButton, "DeleteImagesButton");
            this.DeleteImagesButton.Name = "DeleteImagesButton";
            this.DeleteImagesButton.Click += new System.EventHandler(this.DeleteImagesButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // saveImagesButton
            // 
            this.saveImagesButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.saveImagesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.saveImagesButton, "saveImagesButton");
            this.saveImagesButton.Name = "saveImagesButton";
            this.saveImagesButton.Click += new System.EventHandler(this.saveImages_Click);
            // 
            // AddImagesToElement
            // 
            resources.ApplyResources(this.AddImagesToElement, "AddImagesToElement");
            this.AddImagesToElement.Name = "AddImagesToElement";
            this.AddImagesToElement.UseVisualStyleBackColor = true;
            this.AddImagesToElement.Click += new System.EventHandler(this.AddImagesToElement_Click);
            // 
            // ChangeImageButton
            // 
            resources.ApplyResources(this.ChangeImageButton, "ChangeImageButton");
            this.ChangeImageButton.Name = "ChangeImageButton";
            this.ChangeImageButton.UseVisualStyleBackColor = true;
            this.ChangeImageButton.Click += new System.EventHandler(this.ChangeImageButton_Click);
            // 
            // imageBox
            // 
            this.imageBox.AllowDrop = true;
            resources.ApplyResources(this.imageBox, "imageBox");
            this.imageBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imageBox.Name = "imageBox";
            this.imageBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageBox_DragDrop);
            this.imageBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.imageBox_DragEnter);
            // 
            // ImagesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.ChangeImageButton);
            this.Controls.Add(this.AddImagesToElement);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.ImagesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "ImagesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImagesForm_FormClosing);
            this.Shown += new System.EventHandler(this.ImagesForm_Shown);
            this.listImagesMenuStrip.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ImagesListBox;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton AddImagesButton;
        private System.Windows.Forms.ToolStripButton DeleteImagesButton;
        private System.Windows.Forms.Button AddImagesToElement;
        private System.Windows.Forms.Button ChangeImageButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton saveImagesButton;
        private System.Windows.Forms.Panel imageBox;
        private System.Windows.Forms.ContextMenuStrip listImagesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addImageWithNumberToolButton;
        private System.Windows.Forms.ToolStripMenuItem deleteImageToolButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllToolStripMenuItem;
    }
}