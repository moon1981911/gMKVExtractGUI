﻿using gMKVToolNix.Controls;

namespace gMKVToolNix.Forms
{
    partial class frmMain2
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.prgBrStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.lblTrack = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlpMain = new gMKVToolNix.gTableLayoutPanel();
            this.grpActions = new gMKVToolNix.gGroupBox();
            this.chkJobs = new System.Windows.Forms.CheckBox();
            this.btnShowJobs = new System.Windows.Forms.Button();
            this.chkShowPopup = new System.Windows.Forms.CheckBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.lblExtractionMode = new System.Windows.Forms.Label();
            this.cmbExtractionMode = new gMKVToolNix.Controls.gComboBox();
            this.btnShowLog = new System.Windows.Forms.Button();
            this.lblChapterType = new System.Windows.Forms.Label();
            this.cmbChapterType = new gMKVToolNix.Controls.gComboBox();
            this.grpOutputDirectory = new gMKVToolNix.gGroupBox();
            this.chkLockOutputDirectory = new System.Windows.Forms.CheckBox();
            this.btnBrowseOutputDirectory = new System.Windows.Forms.Button();
            this.txtOutputDirectory = new gMKVToolNix.gTextBox();
            this.grpConfig = new gMKVToolNix.gGroupBox();
            this.txtMKVToolnixPath = new gMKVToolNix.gTextBox();
            this.btnBrowseMKVToolnixPath = new System.Windows.Forms.Button();
            this.grpInputFiles = new gMKVToolNix.gGroupBox();
            this.trvInputFiles = new gMKVToolNix.gTreeView();
            this.grpSelectedFileInfo = new gMKVToolNix.gGroupBox();
            this.txtSegmentInfo = new gMKVToolNix.gRichTextBox();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnAbortAll = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkAllTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllVideoTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllAudioTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllSubtitleTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllChapterTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllAttachmentTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.uncheckAllTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllInputFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedInputFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.addInputFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllVideoTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllAudioTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllSubtitleTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllChapterTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllAttachmentTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpOutputDirectory.SuspendLayout();
            this.grpConfig.SuspendLayout();
            this.grpInputFiles.SuspendLayout();
            this.grpSelectedFileInfo.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prgBrStatus,
            this.lblTrack,
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 525);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(624, 36);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // prgBrStatus
            // 
            this.prgBrStatus.AutoSize = false;
            this.prgBrStatus.Name = "prgBrStatus";
            this.prgBrStatus.Size = new System.Drawing.Size(200, 30);
            // 
            // lblTrack
            // 
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(33, 31);
            this.lblTrack.Text = "track";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 31);
            this.lblStatus.Text = "status";
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grpActions, 0, 4);
            this.tlpMain.Controls.Add(this.grpOutputDirectory, 0, 3);
            this.tlpMain.Controls.Add(this.grpConfig, 0, 0);
            this.tlpMain.Controls.Add(this.grpInputFiles, 0, 1);
            this.tlpMain.Controls.Add(this.grpSelectedFileInfo, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.Size = new System.Drawing.Size(624, 525);
            this.tlpMain.TabIndex = 1;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.chkJobs);
            this.grpActions.Controls.Add(this.btnShowJobs);
            this.grpActions.Controls.Add(this.chkShowPopup);
            this.grpActions.Controls.Add(this.btnExtract);
            this.grpActions.Controls.Add(this.lblExtractionMode);
            this.grpActions.Controls.Add(this.cmbExtractionMode);
            this.grpActions.Controls.Add(this.btnShowLog);
            this.grpActions.Controls.Add(this.lblChapterType);
            this.grpActions.Controls.Add(this.cmbChapterType);
            this.grpActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpActions.Location = new System.Drawing.Point(3, 468);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(618, 54);
            this.grpActions.TabIndex = 8;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // chkJobs
            // 
            this.chkJobs.AutoSize = true;
            this.chkJobs.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkJobs.Location = new System.Drawing.Point(201, 24);
            this.chkJobs.Name = "chkJobs";
            this.chkJobs.Size = new System.Drawing.Size(49, 19);
            this.chkJobs.TabIndex = 14;
            this.chkJobs.Text = "Jobs";
            this.chkJobs.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkJobs.UseVisualStyleBackColor = true;
            this.chkJobs.CheckedChanged += new System.EventHandler(this.chkJobs_CheckedChanged);
            // 
            // btnShowJobs
            // 
            this.btnShowJobs.Location = new System.Drawing.Point(71, 18);
            this.btnShowJobs.Name = "btnShowJobs";
            this.btnShowJobs.Size = new System.Drawing.Size(60, 30);
            this.btnShowJobs.TabIndex = 13;
            this.btnShowJobs.Text = "Jobs...";
            this.btnShowJobs.UseVisualStyleBackColor = true;
            this.btnShowJobs.Click += new System.EventHandler(this.btnShowJobs_Click);
            // 
            // chkShowPopup
            // 
            this.chkShowPopup.AutoSize = true;
            this.chkShowPopup.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkShowPopup.Location = new System.Drawing.Point(134, 24);
            this.chkShowPopup.Name = "chkShowPopup";
            this.chkShowPopup.Size = new System.Drawing.Size(61, 19);
            this.chkShowPopup.TabIndex = 12;
            this.chkShowPopup.Text = "Popup";
            this.chkShowPopup.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkShowPopup.UseVisualStyleBackColor = true;
            this.chkShowPopup.CheckedChanged += new System.EventHandler(this.chkShowPopup_CheckedChanged);
            // 
            // btnExtract
            // 
            this.btnExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtract.Location = new System.Drawing.Point(521, 18);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(90, 30);
            this.btnExtract.TabIndex = 10;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // lblExtractionMode
            // 
            this.lblExtractionMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExtractionMode.AutoSize = true;
            this.lblExtractionMode.Location = new System.Drawing.Point(361, 26);
            this.lblExtractionMode.Name = "lblExtractionMode";
            this.lblExtractionMode.Size = new System.Drawing.Size(45, 15);
            this.lblExtractionMode.TabIndex = 9;
            this.lblExtractionMode.Text = "Extract:";
            // 
            // cmbExtractionMode
            // 
            this.cmbExtractionMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExtractionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExtractionMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbExtractionMode.FormattingEnabled = true;
            this.cmbExtractionMode.Location = new System.Drawing.Point(411, 22);
            this.cmbExtractionMode.Name = "cmbExtractionMode";
            this.cmbExtractionMode.Size = new System.Drawing.Size(102, 23);
            this.cmbExtractionMode.TabIndex = 8;
            // 
            // btnShowLog
            // 
            this.btnShowLog.Location = new System.Drawing.Point(6, 18);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(60, 30);
            this.btnShowLog.TabIndex = 6;
            this.btnShowLog.Text = "Log...";
            this.btnShowLog.UseVisualStyleBackColor = true;
            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);
            // 
            // lblChapterType
            // 
            this.lblChapterType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChapterType.AutoSize = true;
            this.lblChapterType.Location = new System.Drawing.Point(250, 26);
            this.lblChapterType.Name = "lblChapterType";
            this.lblChapterType.Size = new System.Drawing.Size(49, 15);
            this.lblChapterType.TabIndex = 3;
            this.lblChapterType.Text = "Chapter";
            // 
            // cmbChapterType
            // 
            this.cmbChapterType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbChapterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChapterType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbChapterType.FormattingEnabled = true;
            this.cmbChapterType.Location = new System.Drawing.Point(303, 22);
            this.cmbChapterType.Name = "cmbChapterType";
            this.cmbChapterType.Size = new System.Drawing.Size(52, 23);
            this.cmbChapterType.TabIndex = 2;
            this.cmbChapterType.SelectedIndexChanged += new System.EventHandler(this.cmbChapterType_SelectedIndexChanged);
            // 
            // grpOutputDirectory
            // 
            this.grpOutputDirectory.Controls.Add(this.chkLockOutputDirectory);
            this.grpOutputDirectory.Controls.Add(this.btnBrowseOutputDirectory);
            this.grpOutputDirectory.Controls.Add(this.txtOutputDirectory);
            this.grpOutputDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOutputDirectory.Location = new System.Drawing.Point(3, 408);
            this.grpOutputDirectory.Name = "grpOutputDirectory";
            this.grpOutputDirectory.Size = new System.Drawing.Size(618, 54);
            this.grpOutputDirectory.TabIndex = 7;
            this.grpOutputDirectory.TabStop = false;
            this.grpOutputDirectory.Text = "Output Directory for Selected File (you can drag and drop the directory)";
            // 
            // chkLockOutputDirectory
            // 
            this.chkLockOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLockOutputDirectory.AutoSize = true;
            this.chkLockOutputDirectory.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLockOutputDirectory.Location = new System.Drawing.Point(474, 24);
            this.chkLockOutputDirectory.Name = "chkLockOutputDirectory";
            this.chkLockOutputDirectory.Size = new System.Drawing.Size(51, 19);
            this.chkLockOutputDirectory.TabIndex = 4;
            this.chkLockOutputDirectory.Text = "Lock";
            this.chkLockOutputDirectory.UseVisualStyleBackColor = true;
            this.chkLockOutputDirectory.CheckedChanged += new System.EventHandler(this.chkLockOutputDirectory_CheckedChanged);
            // 
            // btnBrowseOutputDirectory
            // 
            this.btnBrowseOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOutputDirectory.Location = new System.Drawing.Point(531, 18);
            this.btnBrowseOutputDirectory.Name = "btnBrowseOutputDirectory";
            this.btnBrowseOutputDirectory.Size = new System.Drawing.Size(80, 30);
            this.btnBrowseOutputDirectory.TabIndex = 3;
            this.btnBrowseOutputDirectory.Text = "Browse...";
            this.btnBrowseOutputDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseOutputDirectory.Click += new System.EventHandler(this.btnBrowseOutputDirectory_Click);
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.AllowDrop = true;
            this.txtOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputDirectory.Location = new System.Drawing.Point(6, 22);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.ShortcutsEnabled = false;
            this.txtOutputDirectory.Size = new System.Drawing.Size(462, 23);
            this.txtOutputDirectory.TabIndex = 2;
            this.txtOutputDirectory.WordWrap = false;
            this.txtOutputDirectory.TextChanged += new System.EventHandler(this.txtOutputDirectory_TextChanged);
            this.txtOutputDirectory.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_DragDrop);
            this.txtOutputDirectory.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_DragEnter);
            // 
            // grpConfig
            // 
            this.grpConfig.Controls.Add(this.txtMKVToolnixPath);
            this.grpConfig.Controls.Add(this.btnBrowseMKVToolnixPath);
            this.grpConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConfig.Location = new System.Drawing.Point(3, 3);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.Size = new System.Drawing.Size(618, 54);
            this.grpConfig.TabIndex = 0;
            this.grpConfig.TabStop = false;
            this.grpConfig.Text = "MKVToolnix Directory (you can drag and drop the directory)";
            // 
            // txtMKVToolnixPath
            // 
            this.txtMKVToolnixPath.AllowDrop = true;
            this.txtMKVToolnixPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMKVToolnixPath.Location = new System.Drawing.Point(6, 22);
            this.txtMKVToolnixPath.Name = "txtMKVToolnixPath";
            this.txtMKVToolnixPath.ReadOnly = true;
            this.txtMKVToolnixPath.ShortcutsEnabled = false;
            this.txtMKVToolnixPath.Size = new System.Drawing.Size(519, 23);
            this.txtMKVToolnixPath.TabIndex = 7;
            this.txtMKVToolnixPath.WordWrap = false;
            this.txtMKVToolnixPath.TextChanged += new System.EventHandler(this.txtMKVToolnixPath_TextChanged);
            this.txtMKVToolnixPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_DragDrop);
            this.txtMKVToolnixPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_DragEnter);
            // 
            // btnBrowseMKVToolnixPath
            // 
            this.btnBrowseMKVToolnixPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseMKVToolnixPath.Location = new System.Drawing.Point(531, 17);
            this.btnBrowseMKVToolnixPath.Name = "btnBrowseMKVToolnixPath";
            this.btnBrowseMKVToolnixPath.Size = new System.Drawing.Size(80, 30);
            this.btnBrowseMKVToolnixPath.TabIndex = 6;
            this.btnBrowseMKVToolnixPath.Text = "Browse...";
            this.btnBrowseMKVToolnixPath.UseVisualStyleBackColor = true;
            this.btnBrowseMKVToolnixPath.Click += new System.EventHandler(this.btnBrowseMKVToolnixPath_Click);
            // 
            // grpInputFiles
            // 
            this.grpInputFiles.Controls.Add(this.trvInputFiles);
            this.grpInputFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInputFiles.Location = new System.Drawing.Point(3, 63);
            this.grpInputFiles.Name = "grpInputFiles";
            this.grpInputFiles.Size = new System.Drawing.Size(618, 239);
            this.grpInputFiles.TabIndex = 1;
            this.grpInputFiles.TabStop = false;
            this.grpInputFiles.Text = "Input Files (you can drag and drop files or directories)";
            // 
            // trvInputFiles
            // 
            this.trvInputFiles.AllowDrop = true;
            this.trvInputFiles.CheckBoxes = true;
            this.trvInputFiles.ContextMenuStrip = this.contextMenuStrip;
            this.trvInputFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvInputFiles.Location = new System.Drawing.Point(3, 19);
            this.trvInputFiles.Name = "trvInputFiles";
            this.trvInputFiles.ShowNodeToolTips = true;
            this.trvInputFiles.Size = new System.Drawing.Size(612, 217);
            this.trvInputFiles.TabIndex = 0;
            this.trvInputFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvInputFiles_AfterSelect);
            this.trvInputFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.trvInputFiles_DragDrop);
            this.trvInputFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.trvInputFiles_DragEnter);
            // 
            // grpSelectedFileInfo
            // 
            this.grpSelectedFileInfo.AllowDrop = true;
            this.grpSelectedFileInfo.Controls.Add(this.txtSegmentInfo);
            this.grpSelectedFileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSelectedFileInfo.Location = new System.Drawing.Point(3, 308);
            this.grpSelectedFileInfo.Name = "grpSelectedFileInfo";
            this.grpSelectedFileInfo.Size = new System.Drawing.Size(618, 94);
            this.grpSelectedFileInfo.TabIndex = 6;
            this.grpSelectedFileInfo.TabStop = false;
            this.grpSelectedFileInfo.Text = "Selected File Information";
            this.grpSelectedFileInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.trvInputFiles_DragDrop);
            this.grpSelectedFileInfo.DragEnter += new System.Windows.Forms.DragEventHandler(this.trvInputFiles_DragEnter);
            // 
            // txtSegmentInfo
            // 
            this.txtSegmentInfo.DetectUrls = false;
            this.txtSegmentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSegmentInfo.Location = new System.Drawing.Point(3, 19);
            this.txtSegmentInfo.Name = "txtSegmentInfo";
            this.txtSegmentInfo.ReadOnly = true;
            this.txtSegmentInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtSegmentInfo.ShortcutsEnabled = false;
            this.txtSegmentInfo.Size = new System.Drawing.Size(612, 72);
            this.txtSegmentInfo.TabIndex = 1;
            this.txtSegmentInfo.Text = "";
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.Location = new System.Drawing.Point(512, 528);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(92, 30);
            this.btnAbort.TabIndex = 12;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnAbortAll
            // 
            this.btnAbortAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbortAll.Location = new System.Drawing.Point(414, 528);
            this.btnAbortAll.Name = "btnAbortAll";
            this.btnAbortAll.Size = new System.Drawing.Size(92, 30);
            this.btnAbortAll.TabIndex = 13;
            this.btnAbortAll.Text = "Abort All";
            this.btnAbortAll.UseVisualStyleBackColor = true;
            this.btnAbortAll.Click += new System.EventHandler(this.btnAbortAll_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAllTracksToolStripMenuItem,
            this.toolStripSeparator2,
            this.checkAllVideoTracksToolStripMenuItem,
            this.checkAllAudioTracksToolStripMenuItem,
            this.checkAllSubtitleTracksToolStripMenuItem,
            this.checkAllChapterTracksToolStripMenuItem,
            this.checkAllAttachmentTracksToolStripMenuItem,
            this.toolStripMenuItem1,
            this.uncheckAllTracksToolStripMenuItem,
            this.toolStripSeparator1,
            this.uncheckAllVideoTracksToolStripMenuItem,
            this.uncheckAllAudioTracksToolStripMenuItem,
            this.uncheckAllSubtitleTracksToolStripMenuItem,
            this.uncheckAllChapterTracksToolStripMenuItem,
            this.uncheckAllAttachmentTracksToolStripMenuItem,
            this.toolStripSeparator4,
            this.removeAllInputFilesToolStripMenuItem,
            this.removeSelectedInputFileToolStripMenuItem,
            this.toolStripSeparator3,
            this.addInputFileToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(240, 364);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // checkAllTracksToolStripMenuItem
            // 
            this.checkAllTracksToolStripMenuItem.Name = "checkAllTracksToolStripMenuItem";
            this.checkAllTracksToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.checkAllTracksToolStripMenuItem.Text = "Check All Tracks";
            this.checkAllTracksToolStripMenuItem.Click += new System.EventHandler(this.checkAllTracksToolStripMenuItem_Click);
            // 
            // checkAllVideoTracksToolStripMenuItem
            // 
            this.checkAllVideoTracksToolStripMenuItem.Name = "checkAllVideoTracksToolStripMenuItem";
            this.checkAllVideoTracksToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.checkAllVideoTracksToolStripMenuItem.Text = "Check All Video Tracks";
            this.checkAllVideoTracksToolStripMenuItem.Click += new System.EventHandler(this.checkAllVideoTracksToolStripMenuItem_Click);
            // 
            // checkAllAudioTracksToolStripMenuItem
            // 
            this.checkAllAudioTracksToolStripMenuItem.Name = "checkAllAudioTracksToolStripMenuItem";
            this.checkAllAudioTracksToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.checkAllAudioTracksToolStripMenuItem.Text = "Check All Audio Tracks";
            this.checkAllAudioTracksToolStripMenuItem.Click += new System.EventHandler(this.checkAllAudioTracksToolStripMenuItem_Click);
            // 
            // checkAllSubtitleTracksToolStripMenuItem
            // 
            this.checkAllSubtitleTracksToolStripMenuItem.Name = "checkAllSubtitleTracksToolStripMenuItem";
            this.checkAllSubtitleTracksToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.checkAllSubtitleTracksToolStripMenuItem.Text = "Check All Subtitle Tracks";
            this.checkAllSubtitleTracksToolStripMenuItem.Click += new System.EventHandler(this.checkAllSubtitleTracksToolStripMenuItem_Click);
            // 
            // checkAllChapterTracksToolStripMenuItem
            // 
            this.checkAllChapterTracksToolStripMenuItem.Name = "checkAllChapterTracksToolStripMenuItem";
            this.checkAllChapterTracksToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.checkAllChapterTracksToolStripMenuItem.Text = "Check All Chapter Tracks";
            this.checkAllChapterTracksToolStripMenuItem.Click += new System.EventHandler(this.checkAllChapterTracksToolStripMenuItem_Click);
            // 
            // checkAllAttachmentTracksToolStripMenuItem
            // 
            this.checkAllAttachmentTracksToolStripMenuItem.Name = "checkAllAttachmentTracksToolStripMenuItem";
            this.checkAllAttachmentTracksToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.checkAllAttachmentTracksToolStripMenuItem.Text = "Check All Attachment Tracks";
            this.checkAllAttachmentTracksToolStripMenuItem.Click += new System.EventHandler(this.checkAllAttachmentTracksToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(223, 6);
            // 
            // uncheckAllTracksToolStripMenuItem
            // 
            this.uncheckAllTracksToolStripMenuItem.Name = "uncheckAllTracksToolStripMenuItem";
            this.uncheckAllTracksToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.uncheckAllTracksToolStripMenuItem.Text = "Uncheck All Tracks";
            this.uncheckAllTracksToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllTracksToolStripMenuItem_Click);
            // 
            // removeAllInputFilesToolStripMenuItem
            // 
            this.removeAllInputFilesToolStripMenuItem.Name = "removeAllInputFilesToolStripMenuItem";
            this.removeAllInputFilesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.removeAllInputFilesToolStripMenuItem.Text = "Remove All Input Files";
            this.removeAllInputFilesToolStripMenuItem.Click += new System.EventHandler(this.removeAllInputFilesToolStripMenuItem_Click);
            // 
            // removeSelectedInputFileToolStripMenuItem
            // 
            this.removeSelectedInputFileToolStripMenuItem.Name = "removeSelectedInputFileToolStripMenuItem";
            this.removeSelectedInputFileToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.removeSelectedInputFileToolStripMenuItem.Text = "Remove Selected Input File";
            this.removeSelectedInputFileToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedInputFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(223, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(223, 6);
            // 
            // addInputFileToolStripMenuItem
            // 
            this.addInputFileToolStripMenuItem.Name = "addInputFileToolStripMenuItem";
            this.addInputFileToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.addInputFileToolStripMenuItem.Text = "Add Input File(s)...";
            this.addInputFileToolStripMenuItem.Click += new System.EventHandler(this.addInputFileToolStripMenuItem_Click);
            // 
            // uncheckAllVideoTracksToolStripMenuItem
            // 
            this.uncheckAllVideoTracksToolStripMenuItem.Name = "uncheckAllVideoTracksToolStripMenuItem";
            this.uncheckAllVideoTracksToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.uncheckAllVideoTracksToolStripMenuItem.Text = "Uncheck All Video Tracks";
            this.uncheckAllVideoTracksToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllVideoTracksToolStripMenuItem_Click);
            // 
            // uncheckAllAudioTracksToolStripMenuItem
            // 
            this.uncheckAllAudioTracksToolStripMenuItem.Name = "uncheckAllAudioTracksToolStripMenuItem";
            this.uncheckAllAudioTracksToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.uncheckAllAudioTracksToolStripMenuItem.Text = "Uncheck All Audio Tracks";
            this.uncheckAllAudioTracksToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllAudioTracksToolStripMenuItem_Click);
            // 
            // uncheckAllSubtitleTracksToolStripMenuItem
            // 
            this.uncheckAllSubtitleTracksToolStripMenuItem.Name = "uncheckAllSubtitleTracksToolStripMenuItem";
            this.uncheckAllSubtitleTracksToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.uncheckAllSubtitleTracksToolStripMenuItem.Text = "Uncheck All Subtitle Tracks";
            this.uncheckAllSubtitleTracksToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllSubtitleTracksToolStripMenuItem_Click);
            // 
            // uncheckAllChapterTracksToolStripMenuItem
            // 
            this.uncheckAllChapterTracksToolStripMenuItem.Name = "uncheckAllChapterTracksToolStripMenuItem";
            this.uncheckAllChapterTracksToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.uncheckAllChapterTracksToolStripMenuItem.Text = "Uncheck All Chapter Tracks";
            this.uncheckAllChapterTracksToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllChapterTracksToolStripMenuItem_Click);
            // 
            // uncheckAllAttachmentTracksToolStripMenuItem
            // 
            this.uncheckAllAttachmentTracksToolStripMenuItem.Name = "uncheckAllAttachmentTracksToolStripMenuItem";
            this.uncheckAllAttachmentTracksToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.uncheckAllAttachmentTracksToolStripMenuItem.Text = "Uncheck All Attachment Tracks";
            this.uncheckAllAttachmentTracksToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllAttachmentTracksToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(236, 6);
            // 
            // frmMain2
            // 
            this.ClientSize = new System.Drawing.Size(624, 561);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnAbortAll);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "frmMain2";
            this.Text = "gMKVExtractGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            this.ClientSizeChanged += new System.EventHandler(this.frmMain_ClientSizeChanged);
            this.Move += new System.EventHandler(this.frmMain_Move);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            this.grpOutputDirectory.ResumeLayout(false);
            this.grpOutputDirectory.PerformLayout();
            this.grpConfig.ResumeLayout(false);
            this.grpConfig.PerformLayout();
            this.grpInputFiles.ResumeLayout(false);
            this.grpSelectedFileInfo.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private gTableLayoutPanel tlpMain;
        private gGroupBox grpConfig;
        private System.Windows.Forms.Button btnBrowseMKVToolnixPath;
        private gTextBox txtMKVToolnixPath;
        private gGroupBox grpInputFiles;
        private gMKVToolNix.gTreeView trvInputFiles;
        private System.Windows.Forms.ToolStripProgressBar prgBrStatus;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnAbortAll;
        private gGroupBox grpSelectedFileInfo;
        private gRichTextBox txtSegmentInfo;
        private gGroupBox grpOutputDirectory;
        private System.Windows.Forms.CheckBox chkLockOutputDirectory;
        private System.Windows.Forms.Button btnBrowseOutputDirectory;
        private gTextBox txtOutputDirectory;
        private gGroupBox grpActions;
        private System.Windows.Forms.CheckBox chkShowPopup;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Label lblExtractionMode;
        private gComboBox cmbExtractionMode;
        private System.Windows.Forms.Button btnShowLog;
        private System.Windows.Forms.Label lblChapterType;
        private gComboBox cmbChapterType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Button btnShowJobs;
        private System.Windows.Forms.ToolStripStatusLabel lblTrack;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.CheckBox chkJobs;
        private System.Windows.Forms.ToolStripMenuItem checkAllTracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAllVideoTracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAllAudioTracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAllSubtitleTracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAllChapterTracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAllAttachmentTracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllTracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removeAllInputFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedInputFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem addInputFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllVideoTracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllAudioTracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllSubtitleTracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllChapterTracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllAttachmentTracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}
