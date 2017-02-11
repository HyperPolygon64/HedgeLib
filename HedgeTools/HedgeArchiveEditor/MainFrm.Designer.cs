﻿namespace HedgeArchiveEditor
{
    partial class MainFrm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.fileStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFromDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFilesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.extractSelectedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.extractAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileStrip.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 33);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(538, 403);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Location = new System.Drawing.Point(0, 436);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(538, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // fileStrip
            // 
            this.fileStrip.BackColor = System.Drawing.Color.White;
            this.fileStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fileStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.fileStrip.Location = new System.Drawing.Point(0, 0);
            this.fileStrip.Name = "fileStrip";
            this.fileStrip.Size = new System.Drawing.Size(538, 33);
            this.fileStrip.TabIndex = 2;
            this.fileStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newArchiveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addFilesToolStripMenuItem,
            this.extractAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newArchiveToolStripMenuItem
            // 
            this.newArchiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewArchiveToolStripMenuItem,
            this.createFromDirectoryToolStripMenuItem});
            this.newArchiveToolStripMenuItem.Name = "newArchiveToolStripMenuItem";
            this.newArchiveToolStripMenuItem.Size = new System.Drawing.Size(294, 30);
            this.newArchiveToolStripMenuItem.Text = "&New";
            // 
            // createNewArchiveToolStripMenuItem
            // 
            this.createNewArchiveToolStripMenuItem.Name = "createNewArchiveToolStripMenuItem";
            this.createNewArchiveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createNewArchiveToolStripMenuItem.Size = new System.Drawing.Size(395, 30);
            this.createNewArchiveToolStripMenuItem.Text = "Create &New Archive";
            this.createNewArchiveToolStripMenuItem.Click += new System.EventHandler(this.createNewArchiveToolStripMenuItem_Click);
            // 
            // createFromDirectoryToolStripMenuItem
            // 
            this.createFromDirectoryToolStripMenuItem.Name = "createFromDirectoryToolStripMenuItem";
            this.createFromDirectoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.createFromDirectoryToolStripMenuItem.Size = new System.Drawing.Size(395, 30);
            this.createFromDirectoryToolStripMenuItem.Text = "Create From &Directory...";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(294, 30);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(294, 30);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(294, 30);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(291, 6);
            // 
            // addFilesToolStripMenuItem
            // 
            this.addFilesToolStripMenuItem.Enabled = false;
            this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            this.addFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.addFilesToolStripMenuItem.Size = new System.Drawing.Size(294, 30);
            this.addFilesToolStripMenuItem.Text = "&Add Files...";
            this.addFilesToolStripMenuItem.Click += new System.EventHandler(this.addFilesToolStripMenuItem_Click);
            // 
            // extractAllToolStripMenuItem
            // 
            this.extractAllToolStripMenuItem.Enabled = false;
            this.extractAllToolStripMenuItem.Name = "extractAllToolStripMenuItem";
            this.extractAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.extractAllToolStripMenuItem.Size = new System.Drawing.Size(294, 30);
            this.extractAllToolStripMenuItem.Text = "&Extract All...";
            this.extractAllToolStripMenuItem.Click += new System.EventHandler(this.extractAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(291, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Enabled = false;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(294, 30);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(294, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.Color.White;
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilesToolStripMenuItem1,
            this.extractAllToolStripMenuItem1,
            this.toolStripSeparator3,
            this.extractSelectedFilesToolStripMenuItem,
            this.removeSelectedFilesToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(342, 163);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // addFilesToolStripMenuItem1
            // 
            this.addFilesToolStripMenuItem1.Name = "addFilesToolStripMenuItem1";
            this.addFilesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.addFilesToolStripMenuItem1.Size = new System.Drawing.Size(341, 30);
            this.addFilesToolStripMenuItem1.Text = "&Add Files...";
            this.addFilesToolStripMenuItem1.Click += new System.EventHandler(this.addFilesToolStripMenuItem_Click);
            // 
            // extractSelectedFilesToolStripMenuItem
            // 
            this.extractSelectedFilesToolStripMenuItem.Name = "extractSelectedFilesToolStripMenuItem";
            this.extractSelectedFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.extractSelectedFilesToolStripMenuItem.Size = new System.Drawing.Size(341, 30);
            this.extractSelectedFilesToolStripMenuItem.Text = "Extract &Selected File(s)...";
            // 
            // removeSelectedFilesToolStripMenuItem
            // 
            this.removeSelectedFilesToolStripMenuItem.Name = "removeSelectedFilesToolStripMenuItem";
            this.removeSelectedFilesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeSelectedFilesToolStripMenuItem.Size = new System.Drawing.Size(341, 30);
            this.removeSelectedFilesToolStripMenuItem.Text = "&Remove Selected File(s)...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(338, 6);
            // 
            // extractAllToolStripMenuItem1
            // 
            this.extractAllToolStripMenuItem1.Name = "extractAllToolStripMenuItem1";
            this.extractAllToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.extractAllToolStripMenuItem1.Size = new System.Drawing.Size(341, 30);
            this.extractAllToolStripMenuItem1.Text = "&Extract All...";
            this.extractAllToolStripMenuItem1.Click += new System.EventHandler(this.extractAllToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 458);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.fileStrip);
            this.MainMenuStrip = this.fileStrip;
            this.Name = "MainFrm";
            this.Text = "Hedge Archive Editor";
            this.fileStrip.ResumeLayout(false);
            this.fileStrip.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip fileStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newArchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewArchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFromDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem extractAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem extractSelectedFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedFilesToolStripMenuItem;
    }
}
