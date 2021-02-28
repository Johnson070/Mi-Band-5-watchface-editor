namespace MiBand5WatchFaces
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SetWatchfaceState = new System.Windows.Forms.Button();
            this.RenderButton = new System.Windows.Forms.Button();
            this.listViewElements = new System.Windows.Forms.ListView();
            this.listMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchfacePreviewImage = new System.Windows.Forms.PictureBox();
            this.AddElement = new System.Windows.Forms.ToolStripDropDownButton();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weatherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepsProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batteryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analogDialFaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heartProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weekDaysIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caloriesProgressToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusSimplifiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFormImages = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.listMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchfacePreviewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddElement,
            this.toolStripDropDownButton1,
            this.OpenFormImages});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(656, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SetWatchfaceState);
            this.groupBox1.Location = new System.Drawing.Point(470, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 559);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contorols";
            // 
            // SetWatchfaceState
            // 
            this.SetWatchfaceState.Location = new System.Drawing.Point(6, 19);
            this.SetWatchfaceState.Name = "SetWatchfaceState";
            this.SetWatchfaceState.Size = new System.Drawing.Size(162, 23);
            this.SetWatchfaceState.TabIndex = 0;
            this.SetWatchfaceState.Text = "Set watchface state";
            this.SetWatchfaceState.UseVisualStyleBackColor = true;
            this.SetWatchfaceState.Click += new System.EventHandler(this.SetWatchfaceState_Click);
            // 
            // RenderButton
            // 
            this.RenderButton.Location = new System.Drawing.Point(291, 452);
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.Size = new System.Drawing.Size(75, 23);
            this.RenderButton.TabIndex = 8;
            this.RenderButton.Text = "Rerender";
            this.RenderButton.UseVisualStyleBackColor = true;
            this.RenderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // listViewElements
            // 
            this.listViewElements.ContextMenuStrip = this.listMenuStrip;
            this.listViewElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.listViewElements.HideSelection = false;
            this.listViewElements.Location = new System.Drawing.Point(12, 28);
            this.listViewElements.Name = "listViewElements";
            this.listViewElements.Size = new System.Drawing.Size(174, 559);
            this.listViewElements.TabIndex = 9;
            this.listViewElements.UseCompatibleStateImageBehavior = false;
            this.listViewElements.View = System.Windows.Forms.View.List;
            this.listViewElements.DoubleClick += new System.EventHandler(this.listViewElements_DoubleClick);
            // 
            // listMenuStrip
            // 
            this.listMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.listMenuStrip.Name = "listMenuStrip";
            this.listMenuStrip.Size = new System.Drawing.Size(118, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // watchfacePreviewImage
            // 
            this.watchfacePreviewImage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.watchfacePreviewImage.Location = new System.Drawing.Point(265, 152);
            this.watchfacePreviewImage.Name = "watchfacePreviewImage";
            this.watchfacePreviewImage.Size = new System.Drawing.Size(126, 294);
            this.watchfacePreviewImage.TabIndex = 7;
            this.watchfacePreviewImage.TabStop = false;
            // 
            // AddElement
            // 
            this.AddElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddElement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.timeToolStripMenuItem,
            this.activityToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.weatherToolStripMenuItem,
            this.stepsProgressToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.batteryToolStripMenuItem,
            this.analogDialFaceToolStripMenuItem,
            this.animationToolStripMenuItem,
            this.heartProgressToolStripMenuItem,
            this.weekDaysIconsToolStripMenuItem,
            this.caloriesProgressToolStripMenuItem1,
            this.alarmToolStripMenuItem,
            this.statusSimplifiedToolStripMenuItem});
            this.AddElement.Image = ((System.Drawing.Image)(resources.GetObject("AddElement.Image")));
            this.AddElement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddElement.Name = "AddElement";
            this.AddElement.Size = new System.Drawing.Size(88, 22);
            this.AddElement.Text = "Add Element";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.timeToolStripMenuItem.Text = "Time";
            this.timeToolStripMenuItem.Click += new System.EventHandler(this.timeToolStripMenuItem_Click);
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activityToolStripMenuItem.Text = "Activity";
            this.activityToolStripMenuItem.Click += new System.EventHandler(this.activityToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateToolStripMenuItem.Text = "Date";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // weatherToolStripMenuItem
            // 
            this.weatherToolStripMenuItem.Name = "weatherToolStripMenuItem";
            this.weatherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.weatherToolStripMenuItem.Text = "Weather";
            this.weatherToolStripMenuItem.Click += new System.EventHandler(this.weatherToolStripMenuItem_Click);
            // 
            // stepsProgressToolStripMenuItem
            // 
            this.stepsProgressToolStripMenuItem.Name = "stepsProgressToolStripMenuItem";
            this.stepsProgressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stepsProgressToolStripMenuItem.Text = "StepsProgress";
            this.stepsProgressToolStripMenuItem.Click += new System.EventHandler(this.stepsProgressToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // batteryToolStripMenuItem
            // 
            this.batteryToolStripMenuItem.Name = "batteryToolStripMenuItem";
            this.batteryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.batteryToolStripMenuItem.Text = "Battery";
            // 
            // analogDialFaceToolStripMenuItem
            // 
            this.analogDialFaceToolStripMenuItem.Name = "analogDialFaceToolStripMenuItem";
            this.analogDialFaceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.analogDialFaceToolStripMenuItem.Text = "AnalogDialFace";
            // 
            // animationToolStripMenuItem
            // 
            this.animationToolStripMenuItem.Name = "animationToolStripMenuItem";
            this.animationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.animationToolStripMenuItem.Text = "Animation";
            // 
            // heartProgressToolStripMenuItem
            // 
            this.heartProgressToolStripMenuItem.Name = "heartProgressToolStripMenuItem";
            this.heartProgressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.heartProgressToolStripMenuItem.Text = "HeartProgress";
            // 
            // weekDaysIconsToolStripMenuItem
            // 
            this.weekDaysIconsToolStripMenuItem.Name = "weekDaysIconsToolStripMenuItem";
            this.weekDaysIconsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.weekDaysIconsToolStripMenuItem.Text = "WeekDaysIcons";
            // 
            // caloriesProgressToolStripMenuItem1
            // 
            this.caloriesProgressToolStripMenuItem1.Name = "caloriesProgressToolStripMenuItem1";
            this.caloriesProgressToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.caloriesProgressToolStripMenuItem1.Text = "CaloriesProgress";
            // 
            // alarmToolStripMenuItem
            // 
            this.alarmToolStripMenuItem.Name = "alarmToolStripMenuItem";
            this.alarmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alarmToolStripMenuItem.Text = "Alarm";
            // 
            // statusSimplifiedToolStripMenuItem
            // 
            this.statusSimplifiedToolStripMenuItem.Name = "statusSimplifiedToolStripMenuItem";
            this.statusSimplifiedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statusSimplifiedToolStripMenuItem.Text = "StatusSimplified";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileButton,
            this.saveToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // openFileButton
            // 
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(103, 22);
            this.openFileButton.Text = "Open";
            this.openFileButton.Click += new System.EventHandler(this.OpenFileJson);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // OpenFormImages
            // 
            this.OpenFormImages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenFormImages.Image = ((System.Drawing.Image)(resources.GetObject("OpenFormImages.Image")));
            this.OpenFormImages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFormImages.Name = "OpenFormImages";
            this.OpenFormImages.Size = new System.Drawing.Size(49, 22);
            this.OpenFormImages.Text = "Images";
            this.OpenFormImages.Click += new System.EventHandler(this.OpenFormImages_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(656, 599);
            this.Controls.Add(this.listViewElements);
            this.Controls.Add(this.RenderButton);
            this.Controls.Add(this.watchfacePreviewImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watch Face for MI Band 5 Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.listMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.watchfacePreviewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton AddElement;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weatherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepsProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batteryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analogDialFaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heartProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weekDaysIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caloriesProgressToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusSimplifiedToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RenderButton;
        private System.Windows.Forms.ListView listViewElements;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem openFileButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip listMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton OpenFormImages;
        private System.Windows.Forms.PictureBox watchfacePreviewImage;
        private System.Windows.Forms.Button SetWatchfaceState;
    }
}

