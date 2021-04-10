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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.miBand5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miBand6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.findBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.wkiProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportMeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenJsonButton = new System.Windows.Forms.ToolStripButton();
            this.CloseProjectButton = new System.Windows.Forms.ToolStripButton();
            this.listMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WatchFaceEXE = new System.Diagnostics.Process();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SaveFileStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerWatchFaceEXE = new System.Windows.Forms.Timer(this.components);
            this.AnimateTimer = new System.Windows.Forms.Timer(this.components);
            this.DeleteTrash = new System.Windows.Forms.Timer(this.components);
            this.SetWatchfaceState = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SupportAuthorButton = new System.Windows.Forms.Button();
            this.convertGIFToPNGButton = new System.Windows.Forms.Button();
            this.watchfacePreviewImage = new System.Windows.Forms.PictureBox();
            this.RenderButton = new System.Windows.Forms.Button();
            this.listViewElements = new System.Windows.Forms.ListView();
            this.AnimateCheckBox = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.listMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchfacePreviewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddElement,
            this.toolStripDropDownButton1,
            this.OpenFormImages,
            this.toolStripSeparator1,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripSeparator3,
            this.OpenJsonButton,
            this.CloseProjectButton});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
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
            resources.ApplyResources(this.AddElement, "AddElement");
            this.AddElement.Name = "AddElement";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            resources.ApplyResources(this.backgroundToolStripMenuItem, "backgroundToolStripMenuItem");
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            resources.ApplyResources(this.timeToolStripMenuItem, "timeToolStripMenuItem");
            this.timeToolStripMenuItem.Click += new System.EventHandler(this.timeToolStripMenuItem_Click);
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            resources.ApplyResources(this.activityToolStripMenuItem, "activityToolStripMenuItem");
            this.activityToolStripMenuItem.Click += new System.EventHandler(this.activityToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            resources.ApplyResources(this.dateToolStripMenuItem, "dateToolStripMenuItem");
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // weatherToolStripMenuItem
            // 
            this.weatherToolStripMenuItem.Name = "weatherToolStripMenuItem";
            resources.ApplyResources(this.weatherToolStripMenuItem, "weatherToolStripMenuItem");
            this.weatherToolStripMenuItem.Click += new System.EventHandler(this.weatherToolStripMenuItem_Click);
            // 
            // stepsProgressToolStripMenuItem
            // 
            this.stepsProgressToolStripMenuItem.Name = "stepsProgressToolStripMenuItem";
            resources.ApplyResources(this.stepsProgressToolStripMenuItem, "stepsProgressToolStripMenuItem");
            this.stepsProgressToolStripMenuItem.Click += new System.EventHandler(this.stepsProgressToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            resources.ApplyResources(this.statusToolStripMenuItem, "statusToolStripMenuItem");
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // batteryToolStripMenuItem
            // 
            this.batteryToolStripMenuItem.Name = "batteryToolStripMenuItem";
            resources.ApplyResources(this.batteryToolStripMenuItem, "batteryToolStripMenuItem");
            this.batteryToolStripMenuItem.Click += new System.EventHandler(this.batteryToolStripMenuItem_Click);
            // 
            // analogDialFaceToolStripMenuItem
            // 
            this.analogDialFaceToolStripMenuItem.Name = "analogDialFaceToolStripMenuItem";
            resources.ApplyResources(this.analogDialFaceToolStripMenuItem, "analogDialFaceToolStripMenuItem");
            this.analogDialFaceToolStripMenuItem.Click += new System.EventHandler(this.analogDialFaceToolStripMenuItem_Click);
            // 
            // animationToolStripMenuItem
            // 
            this.animationToolStripMenuItem.Name = "animationToolStripMenuItem";
            resources.ApplyResources(this.animationToolStripMenuItem, "animationToolStripMenuItem");
            this.animationToolStripMenuItem.Click += new System.EventHandler(this.animationToolStripMenuItem_Click);
            // 
            // heartProgressToolStripMenuItem
            // 
            this.heartProgressToolStripMenuItem.Name = "heartProgressToolStripMenuItem";
            resources.ApplyResources(this.heartProgressToolStripMenuItem, "heartProgressToolStripMenuItem");
            this.heartProgressToolStripMenuItem.Click += new System.EventHandler(this.heartProgressToolStripMenuItem_Click);
            // 
            // weekDaysIconsToolStripMenuItem
            // 
            this.weekDaysIconsToolStripMenuItem.Name = "weekDaysIconsToolStripMenuItem";
            resources.ApplyResources(this.weekDaysIconsToolStripMenuItem, "weekDaysIconsToolStripMenuItem");
            this.weekDaysIconsToolStripMenuItem.Click += new System.EventHandler(this.weekDaysIconsToolStripMenuItem_Click);
            // 
            // caloriesProgressToolStripMenuItem1
            // 
            this.caloriesProgressToolStripMenuItem1.Name = "caloriesProgressToolStripMenuItem1";
            resources.ApplyResources(this.caloriesProgressToolStripMenuItem1, "caloriesProgressToolStripMenuItem1");
            this.caloriesProgressToolStripMenuItem1.Click += new System.EventHandler(this.caloriesProgressToolStripMenuItem1_Click);
            // 
            // alarmToolStripMenuItem
            // 
            this.alarmToolStripMenuItem.Name = "alarmToolStripMenuItem";
            resources.ApplyResources(this.alarmToolStripMenuItem, "alarmToolStripMenuItem");
            this.alarmToolStripMenuItem.Click += new System.EventHandler(this.alarmToolStripMenuItem_Click);
            // 
            // statusSimplifiedToolStripMenuItem
            // 
            this.statusSimplifiedToolStripMenuItem.Name = "statusSimplifiedToolStripMenuItem";
            resources.ApplyResources(this.statusSimplifiedToolStripMenuItem, "statusSimplifiedToolStripMenuItem");
            this.statusSimplifiedToolStripMenuItem.Click += new System.EventHandler(this.statusSimplifiedToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileButton,
            this.saveToolStripMenuItem});
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // openFileButton
            // 
            this.openFileButton.Name = "openFileButton";
            resources.ApplyResources(this.openFileButton, "openFileButton");
            this.openFileButton.Click += new System.EventHandler(this.OpenFileJson);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // OpenFormImages
            // 
            this.OpenFormImages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.OpenFormImages, "OpenFormImages");
            this.OpenFormImages.Name = "OpenFormImages";
            this.OpenFormImages.Click += new System.EventHandler(this.OpenFormImages_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBand5ToolStripMenuItem,
            this.miBand6ToolStripMenuItem});
            resources.ApplyResources(this.toolStripDropDownButton4, "toolStripDropDownButton4");
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            // 
            // miBand5ToolStripMenuItem
            // 
            this.miBand5ToolStripMenuItem.Name = "miBand5ToolStripMenuItem";
            resources.ApplyResources(this.miBand5ToolStripMenuItem, "miBand5ToolStripMenuItem");
            this.miBand5ToolStripMenuItem.Click += new System.EventHandler(this.miBand5ToolStripMenuItem_Click);
            // 
            // miBand6ToolStripMenuItem
            // 
            this.miBand6ToolStripMenuItem.Name = "miBand6ToolStripMenuItem";
            resources.ApplyResources(this.miBand6ToolStripMenuItem, "miBand6ToolStripMenuItem");
            this.miBand6ToolStripMenuItem.Click += new System.EventHandler(this.miBand6ToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findBugToolStripMenuItem,
            this.changeLogToolStripMenuItem,
            this.checkUpdateToolStripMenuItem,
            this.toolStripSeparator2,
            this.wkiProgramToolStripMenuItem,
            this.supportMeButton,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.toolStripDropDownButton2, "toolStripDropDownButton2");
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            // 
            // findBugToolStripMenuItem
            // 
            this.findBugToolStripMenuItem.Name = "findBugToolStripMenuItem";
            resources.ApplyResources(this.findBugToolStripMenuItem, "findBugToolStripMenuItem");
            this.findBugToolStripMenuItem.Click += new System.EventHandler(this.findBugToolStripMenuItem_Click);
            // 
            // changeLogToolStripMenuItem
            // 
            this.changeLogToolStripMenuItem.Name = "changeLogToolStripMenuItem";
            resources.ApplyResources(this.changeLogToolStripMenuItem, "changeLogToolStripMenuItem");
            this.changeLogToolStripMenuItem.Click += new System.EventHandler(this.changeLogToolStripMenuItem_Click);
            // 
            // checkUpdateToolStripMenuItem
            // 
            this.checkUpdateToolStripMenuItem.Name = "checkUpdateToolStripMenuItem";
            resources.ApplyResources(this.checkUpdateToolStripMenuItem, "checkUpdateToolStripMenuItem");
            this.checkUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkUpdateToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // wkiProgramToolStripMenuItem
            // 
            this.wkiProgramToolStripMenuItem.Name = "wkiProgramToolStripMenuItem";
            resources.ApplyResources(this.wkiProgramToolStripMenuItem, "wkiProgramToolStripMenuItem");
            this.wkiProgramToolStripMenuItem.Click += new System.EventHandler(this.wkiProgramToolStripMenuItem_Click);
            // 
            // supportMeButton
            // 
            this.supportMeButton.Image = global::MiBand5WatchFaces.Properties.Resources.pngtree_black_coin_icon_image_11303561;
            this.supportMeButton.Name = "supportMeButton";
            resources.ApplyResources(this.supportMeButton, "supportMeButton");
            this.supportMeButton.Click += new System.EventHandler(this.supportMeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.russianToolStripMenuItem});
            resources.ApplyResources(this.toolStripDropDownButton3, "toolStripDropDownButton3");
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Tag = "en-US";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.ChangeLang);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            resources.ApplyResources(this.russianToolStripMenuItem, "russianToolStripMenuItem");
            this.russianToolStripMenuItem.Tag = "ru-RU";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.ChangeLang);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // OpenJsonButton
            // 
            this.OpenJsonButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.OpenJsonButton, "OpenJsonButton");
            this.OpenJsonButton.Name = "OpenJsonButton";
            this.OpenJsonButton.Click += new System.EventHandler(this.OpenJsonButton_Click);
            // 
            // CloseProjectButton
            // 
            this.CloseProjectButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseProjectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.CloseProjectButton, "CloseProjectButton");
            this.CloseProjectButton.Name = "CloseProjectButton";
            this.CloseProjectButton.Click += new System.EventHandler(this.CloseProjectButton_Click);
            // 
            // listMenuStrip
            // 
            this.listMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.listMenuStrip.Name = "listMenuStrip";
            resources.ApplyResources(this.listMenuStrip, "listMenuStrip");
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            resources.ApplyResources(this.removeToolStripMenuItem, "removeToolStripMenuItem");
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // WatchFaceEXE
            // 
            this.WatchFaceEXE.EnableRaisingEvents = true;
            this.WatchFaceEXE.StartInfo.Domain = "";
            this.WatchFaceEXE.StartInfo.LoadUserProfile = false;
            this.WatchFaceEXE.StartInfo.Password = null;
            this.WatchFaceEXE.StartInfo.StandardErrorEncoding = null;
            this.WatchFaceEXE.StartInfo.StandardOutputEncoding = null;
            this.WatchFaceEXE.StartInfo.UserName = "";
            this.WatchFaceEXE.SynchronizingObject = this;
            this.WatchFaceEXE.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(this.WatchFaceEXE_OutputDataReceived);
            this.WatchFaceEXE.Exited += new System.EventHandler(this.WatchFaceEXE_Exited);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveFileStatus});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // SaveFileStatus
            // 
            this.SaveFileStatus.Name = "SaveFileStatus";
            resources.ApplyResources(this.SaveFileStatus, "SaveFileStatus");
            // 
            // timerWatchFaceEXE
            // 
            this.timerWatchFaceEXE.Interval = 20000;
            this.timerWatchFaceEXE.Tick += new System.EventHandler(this.timerWatchFaceEXE_Tick);
            // 
            // AnimateTimer
            // 
            this.AnimateTimer.Interval = 150;
            this.AnimateTimer.Tick += new System.EventHandler(this.AnimateTimer_Tick);
            // 
            // DeleteTrash
            // 
            this.DeleteTrash.Enabled = true;
            this.DeleteTrash.Interval = 300;
            this.DeleteTrash.Tick += new System.EventHandler(this.DeleteTrash_Tick);
            // 
            // SetWatchfaceState
            // 
            resources.ApplyResources(this.SetWatchfaceState, "SetWatchfaceState");
            this.SetWatchfaceState.Name = "SetWatchfaceState";
            this.SetWatchfaceState.UseVisualStyleBackColor = true;
            this.SetWatchfaceState.Click += new System.EventHandler(this.SetWatchfaceState_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.SupportAuthorButton);
            this.groupBox1.Controls.Add(this.convertGIFToPNGButton);
            this.groupBox1.Controls.Add(this.SetWatchfaceState);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // SupportAuthorButton
            // 
            resources.ApplyResources(this.SupportAuthorButton, "SupportAuthorButton");
            this.SupportAuthorButton.Name = "SupportAuthorButton";
            this.SupportAuthorButton.UseVisualStyleBackColor = true;
            this.SupportAuthorButton.Click += new System.EventHandler(this.supportMeToolStripMenuItem_Click);
            // 
            // convertGIFToPNGButton
            // 
            resources.ApplyResources(this.convertGIFToPNGButton, "convertGIFToPNGButton");
            this.convertGIFToPNGButton.Name = "convertGIFToPNGButton";
            this.convertGIFToPNGButton.UseVisualStyleBackColor = true;
            this.convertGIFToPNGButton.Click += new System.EventHandler(this.convertGIFToPNGToolStripMenuItem_Click);
            // 
            // watchfacePreviewImage
            // 
            resources.ApplyResources(this.watchfacePreviewImage, "watchfacePreviewImage");
            this.watchfacePreviewImage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.watchfacePreviewImage.Name = "watchfacePreviewImage";
            this.watchfacePreviewImage.TabStop = false;
            this.watchfacePreviewImage.Tag = "0";
            // 
            // RenderButton
            // 
            resources.ApplyResources(this.RenderButton, "RenderButton");
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.UseVisualStyleBackColor = true;
            this.RenderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // listViewElements
            // 
            resources.ApplyResources(this.listViewElements, "listViewElements");
            this.listViewElements.ContextMenuStrip = this.listMenuStrip;
            this.listViewElements.HideSelection = false;
            this.listViewElements.Name = "listViewElements";
            this.listViewElements.UseCompatibleStateImageBehavior = false;
            this.listViewElements.View = System.Windows.Forms.View.List;
            this.listViewElements.DoubleClick += new System.EventHandler(this.listViewElements_DoubleClick);
            // 
            // AnimateCheckBox
            // 
            resources.ApplyResources(this.AnimateCheckBox, "AnimateCheckBox");
            this.AnimateCheckBox.Name = "AnimateCheckBox";
            this.AnimateCheckBox.UseVisualStyleBackColor = true;
            this.AnimateCheckBox.CheckedChanged += new System.EventHandler(this.AnimateCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.AnimateCheckBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listViewElements);
            this.Controls.Add(this.RenderButton);
            this.Controls.Add(this.watchfacePreviewImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.listMenuStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem openFileButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip listMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton OpenFormImages;
        private System.Diagnostics.Process WatchFaceEXE;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SaveFileStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLogToolStripMenuItem;
        private System.Windows.Forms.Timer timerWatchFaceEXE;
        private System.Windows.Forms.ToolStripMenuItem supportMeButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem wkiProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton OpenJsonButton;
        private System.Windows.Forms.Timer AnimateTimer;
        private System.Windows.Forms.Timer DeleteTrash;
        private System.Windows.Forms.CheckBox AnimateCheckBox;
        private System.Windows.Forms.ListView listViewElements;
        private System.Windows.Forms.Button RenderButton;
        private System.Windows.Forms.PictureBox watchfacePreviewImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SetWatchfaceState;
        private System.Windows.Forms.Button SupportAuthorButton;
        private System.Windows.Forms.Button convertGIFToPNGButton;
        private System.Windows.Forms.ToolStripButton CloseProjectButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem miBand5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miBand6ToolStripMenuItem;
    }
}

