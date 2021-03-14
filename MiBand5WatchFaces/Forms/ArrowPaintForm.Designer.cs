
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrowPaintForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.posPanel = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shapeListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteDotToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.panelArrow = new System.Windows.Forms.PictureBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.eraseRadioButton = new System.Windows.Forms.RadioButton();
            this.dotRadioButton = new System.Windows.Forms.RadioButton();
            this.HelpTip = new System.Windows.Forms.ToolTip(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posPanel});
            this.statusStrip1.Name = "statusStrip1";
            this.HelpTip.SetToolTip(this.statusStrip1, resources.GetString("statusStrip1.ToolTip"));
            // 
            // posPanel
            // 
            resources.ApplyResources(this.posPanel, "posPanel");
            this.posPanel.Name = "posPanel";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.HelpTip.SetToolTip(this.saveButton, resources.GetString("saveButton.ToolTip"));
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.shapeListBox);
            this.groupBox1.Controls.Add(this.panelArrow);
            this.groupBox1.Controls.Add(this.clearAllButton);
            this.groupBox1.Controls.Add(this.eraseRadioButton);
            this.groupBox1.Controls.Add(this.dotRadioButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.HelpTip.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // shapeListBox
            // 
            resources.ApplyResources(this.shapeListBox, "shapeListBox");
            this.shapeListBox.ContextMenuStrip = this.contextMenuStrip1;
            this.shapeListBox.FormattingEnabled = true;
            this.shapeListBox.Name = "shapeListBox";
            this.HelpTip.SetToolTip(this.shapeListBox, resources.GetString("shapeListBox.ToolTip"));
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDotToolStrip});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.HelpTip.SetToolTip(this.contextMenuStrip1, resources.GetString("contextMenuStrip1.ToolTip"));
            // 
            // deleteDotToolStrip
            // 
            resources.ApplyResources(this.deleteDotToolStrip, "deleteDotToolStrip");
            this.deleteDotToolStrip.Name = "deleteDotToolStrip";
            this.deleteDotToolStrip.Click += new System.EventHandler(this.deleteDotToolStrip_Click);
            // 
            // panelArrow
            // 
            resources.ApplyResources(this.panelArrow, "panelArrow");
            this.panelArrow.Name = "panelArrow";
            this.panelArrow.TabStop = false;
            this.HelpTip.SetToolTip(this.panelArrow, resources.GetString("panelArrow.ToolTip"));
            this.panelArrow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelArrow_Paint);
            this.panelArrow.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelArrow_MouseClick);
            this.panelArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.panelArrow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.panelArrow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // clearAllButton
            // 
            resources.ApplyResources(this.clearAllButton, "clearAllButton");
            this.clearAllButton.Name = "clearAllButton";
            this.HelpTip.SetToolTip(this.clearAllButton, resources.GetString("clearAllButton.ToolTip"));
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // eraseRadioButton
            // 
            resources.ApplyResources(this.eraseRadioButton, "eraseRadioButton");
            this.eraseRadioButton.Name = "eraseRadioButton";
            this.HelpTip.SetToolTip(this.eraseRadioButton, resources.GetString("eraseRadioButton.ToolTip"));
            this.eraseRadioButton.UseVisualStyleBackColor = true;
            // 
            // dotRadioButton
            // 
            resources.ApplyResources(this.dotRadioButton, "dotRadioButton");
            this.dotRadioButton.Checked = true;
            this.dotRadioButton.Name = "dotRadioButton";
            this.dotRadioButton.TabStop = true;
            this.HelpTip.SetToolTip(this.dotRadioButton, resources.GetString("dotRadioButton.ToolTip"));
            this.dotRadioButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.HelpTip.SetToolTip(this.deleteButton, resources.GetString("deleteButton.ToolTip"));
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ArrowPaintForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ArrowPaintForm";
            this.HelpTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArrowPaintForm_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelArrow)).EndInit();
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
        private System.Windows.Forms.Button deleteButton;
    }
}