
namespace MiBand5WatchFaces.Forms
{
    partial class ArrowPaintForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.posPanel = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelArrow = new System.Windows.Forms.PictureBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.eraseRadioButton = new System.Windows.Forms.RadioButton();
            this.dotRadioButton = new System.Windows.Forms.RadioButton();
            this.shapeListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteDotToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelArrow)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posPanel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(658, 22);
            this.statusStrip1.TabIndex = 1;
            // 
            // posPanel
            // 
            this.posPanel.Name = "posPanel";
            this.posPanel.Size = new System.Drawing.Size(0, 17);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(7, 543);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(639, 30);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.shapeListBox);
            this.groupBox1.Controls.Add(this.panelArrow);
            this.groupBox1.Controls.Add(this.clearAllButton);
            this.groupBox1.Controls.Add(this.eraseRadioButton);
            this.groupBox1.Controls.Add(this.dotRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 525);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // panelArrow
            // 
            this.panelArrow.Location = new System.Drawing.Point(129, 19);
            this.panelArrow.Name = "panelArrow";
            this.panelArrow.Size = new System.Drawing.Size(500, 500);
            this.panelArrow.TabIndex = 9;
            this.panelArrow.TabStop = false;
            this.panelArrow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelArrow_Paint);
            this.panelArrow.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelArrow_MouseClick);
            this.panelArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.panelArrow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.panelArrow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearAllButton.Location = new System.Drawing.Point(6, 486);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(117, 33);
            this.clearAllButton.TabIndex = 8;
            this.clearAllButton.Text = "Clear all";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // eraseRadioButton
            // 
            this.eraseRadioButton.AutoSize = true;
            this.eraseRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eraseRadioButton.Location = new System.Drawing.Point(6, 47);
            this.eraseRadioButton.Name = "eraseRadioButton";
            this.eraseRadioButton.Size = new System.Drawing.Size(65, 22);
            this.eraseRadioButton.TabIndex = 7;
            this.eraseRadioButton.Text = "Erase";
            this.HelpTip.SetToolTip(this.eraseRadioButton, "Double click for erase dot");
            this.eraseRadioButton.UseVisualStyleBackColor = true;
            // 
            // dotRadioButton
            // 
            this.dotRadioButton.AutoSize = true;
            this.dotRadioButton.Checked = true;
            this.dotRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dotRadioButton.Location = new System.Drawing.Point(6, 19);
            this.dotRadioButton.Name = "dotRadioButton";
            this.dotRadioButton.Size = new System.Drawing.Size(50, 22);
            this.dotRadioButton.TabIndex = 6;
            this.dotRadioButton.TabStop = true;
            this.dotRadioButton.Text = "Dot";
            this.HelpTip.SetToolTip(this.dotRadioButton, "Double click for place dot");
            this.dotRadioButton.UseVisualStyleBackColor = true;
            // 
            // shapeListBox
            // 
            this.shapeListBox.ContextMenuStrip = this.contextMenuStrip1;
            this.shapeListBox.FormattingEnabled = true;
            this.shapeListBox.Location = new System.Drawing.Point(6, 75);
            this.shapeListBox.Name = "shapeListBox";
            this.shapeListBox.Size = new System.Drawing.Size(117, 407);
            this.shapeListBox.TabIndex = 10;
            this.HelpTip.SetToolTip(this.shapeListBox, "Right click for show context menu\r\nPlace the points in sequence, because the arro" +
        "w is a polygon.  \r\n");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDotToolStrip});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 26);
            // 
            // deleteDotToolStrip
            // 
            this.deleteDotToolStrip.Name = "deleteDotToolStrip";
            this.deleteDotToolStrip.Size = new System.Drawing.Size(180, 22);
            this.deleteDotToolStrip.Text = "Delete dot";
            this.deleteDotToolStrip.Click += new System.EventHandler(this.deleteDotToolStrip_Click);
            // 
            // ArrowPaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 598);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ArrowPaintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArrowPaintForm_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelArrow)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel posPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.RadioButton eraseRadioButton;
        private System.Windows.Forms.RadioButton dotRadioButton;
        private System.Windows.Forms.PictureBox panelArrow;
        private System.Windows.Forms.ListBox shapeListBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteDotToolStrip;
        private System.Windows.Forms.ToolTip HelpTip;
    }
}