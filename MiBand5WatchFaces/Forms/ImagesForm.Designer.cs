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
            this.ImagesListBox.ContextMenuStrip = this.listImagesMenuStrip;
            this.ImagesListBox.FormattingEnabled = true;
            this.ImagesListBox.Location = new System.Drawing.Point(12, 28);
            this.ImagesListBox.Name = "ImagesListBox";
            this.ImagesListBox.Size = new System.Drawing.Size(166, 409);
            this.ImagesListBox.TabIndex = 0;
            this.ImagesListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ImagesListBox_ItemCheck);
            this.ImagesListBox.SelectedIndexChanged += new System.EventHandler(this.ImagesListBox_SelectedIndexChanged);
            this.ImagesListBox.SelectedValueChanged += new System.EventHandler(this.ImagesListBox_SelectedValueChanged);
            this.ImagesListBox.MouseLeave += new System.EventHandler(this.ImagesListBox_MouseLeave);
            this.ImagesListBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImagesListBox_MouseMove);
            // 
            // listImagesMenuStrip
            // 
            this.listImagesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteImageToolButton,
            this.addImageWithNumberToolButton,
            this.toolStripSeparator2,
            this.uncheckAllToolStripMenuItem});
            this.listImagesMenuStrip.Name = "listImagesMenuStrip";
            this.listImagesMenuStrip.Size = new System.Drawing.Size(204, 76);
            // 
            // deleteImageToolButton
            // 
            this.deleteImageToolButton.Name = "deleteImageToolButton";
            this.deleteImageToolButton.Size = new System.Drawing.Size(203, 22);
            this.deleteImageToolButton.Text = "Delete image";
            this.deleteImageToolButton.Click += new System.EventHandler(this.deleteImageToolButton_Click);
            // 
            // addImageWithNumberToolButton
            // 
            this.addImageWithNumberToolButton.Name = "addImageWithNumberToolButton";
            this.addImageWithNumberToolButton.Size = new System.Drawing.Size(203, 22);
            this.addImageWithNumberToolButton.Text = "Add image with number";
            this.addImageWithNumberToolButton.Click += new System.EventHandler(this.addImageWithNumberToolButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // uncheckAllToolStripMenuItem
            // 
            this.uncheckAllToolStripMenuItem.Name = "uncheckAllToolStripMenuItem";
            this.uncheckAllToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.uncheckAllToolStripMenuItem.Text = "Uncheck all";
            this.uncheckAllToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddImagesButton,
            this.DeleteImagesButton,
            this.toolStripSeparator1,
            this.saveImagesButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(486, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // AddImagesButton
            // 
            this.AddImagesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddImagesButton.Image = ((System.Drawing.Image)(resources.GetObject("AddImagesButton.Image")));
            this.AddImagesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddImagesButton.Name = "AddImagesButton";
            this.AddImagesButton.Size = new System.Drawing.Size(74, 22);
            this.AddImagesButton.Text = "Add images";
            this.AddImagesButton.Click += new System.EventHandler(this.AddImagesButton_Click);
            // 
            // DeleteImagesButton
            // 
            this.DeleteImagesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteImagesButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteImagesButton.Image")));
            this.DeleteImagesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteImagesButton.Name = "DeleteImagesButton";
            this.DeleteImagesButton.Size = new System.Drawing.Size(85, 22);
            this.DeleteImagesButton.Text = "Delete images";
            this.DeleteImagesButton.Click += new System.EventHandler(this.DeleteImagesButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // saveImagesButton
            // 
            this.saveImagesButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.saveImagesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveImagesButton.Image = ((System.Drawing.Image)(resources.GetObject("saveImagesButton.Image")));
            this.saveImagesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveImagesButton.Name = "saveImagesButton";
            this.saveImagesButton.Size = new System.Drawing.Size(35, 22);
            this.saveImagesButton.Text = "Save";
            this.saveImagesButton.Click += new System.EventHandler(this.saveImages_Click);
            // 
            // AddImagesToElement
            // 
            this.AddImagesToElement.Location = new System.Drawing.Point(184, 413);
            this.AddImagesToElement.Name = "AddImagesToElement";
            this.AddImagesToElement.Size = new System.Drawing.Size(295, 23);
            this.AddImagesToElement.TabIndex = 3;
            this.AddImagesToElement.Text = "Add images to element";
            this.AddImagesToElement.UseVisualStyleBackColor = true;
            this.AddImagesToElement.Click += new System.EventHandler(this.AddImagesToElement_Click);
            // 
            // ChangeImageButton
            // 
            this.ChangeImageButton.Enabled = false;
            this.ChangeImageButton.Location = new System.Drawing.Point(184, 384);
            this.ChangeImageButton.Name = "ChangeImageButton";
            this.ChangeImageButton.Size = new System.Drawing.Size(295, 23);
            this.ChangeImageButton.TabIndex = 4;
            this.ChangeImageButton.Text = "Edit image";
            this.ChangeImageButton.UseVisualStyleBackColor = true;
            this.ChangeImageButton.Click += new System.EventHandler(this.ChangeImageButton_Click);
            // 
            // imageBox
            // 
            this.imageBox.AllowDrop = true;
            this.imageBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageBox.Location = new System.Drawing.Point(184, 28);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(295, 350);
            this.imageBox.TabIndex = 5;
            this.imageBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageBox_DragDrop);
            this.imageBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.imageBox_DragEnter);
            // 
            // ImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.ChangeImageButton);
            this.Controls.Add(this.AddImagesToElement);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.ImagesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ImagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Images";
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