using Acid.UI.Controls;
using Acid.UI.Docking;

namespace Acid.Editor.Forms
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mnuMain = new Acid.UI.Controls.DarkMenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNewFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAssets = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuScene = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHierarchy = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuInspector = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuConsole = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.stripMain = new Acid.UI.Controls.DarkStatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.DockPanel = new Acid.UI.Docking.DarkDockPanel();
			this.darkSeparator1 = new Acid.UI.Controls.DarkSeparator();
			this.mnuMain.SuspendLayout();
			this.stripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.mnuMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuView,
            this.mnuWindow,
            this.mnuHelp});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
			this.mnuMain.Size = new System.Drawing.Size(1404, 24);
			this.mnuMain.TabIndex = 0;
			this.mnuMain.Text = "darkMenuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.mnuNewFile,
            this.toolStripMenuItem5,
            this.toolStripSeparator1,
            this.mnuClose});
			this.mnuFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(37, 20);
			this.mnuFile.Text = "&File";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.toolStripMenuItem1.Image = global::Acid.Editor.Icons.NewTable_16x;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.toolStripMenuItem1.Size = new System.Drawing.Size(218, 22);
			this.toolStripMenuItem1.Text = "&New Scene";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.toolStripMenuItem2.Image = global::Acid.Editor.Icons.Open_grey_16x;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.toolStripMenuItem2.Size = new System.Drawing.Size(218, 22);
			this.toolStripMenuItem2.Text = "&Open Scene";
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.toolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.toolStripMenuItem4.Image = global::Acid.Editor.Icons.Save_grey_16x;
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.toolStripMenuItem4.Size = new System.Drawing.Size(218, 22);
			this.toolStripMenuItem4.Text = "&Save Scene";
			// 
			// mnuNewFile
			// 
			this.mnuNewFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.mnuNewFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.mnuNewFile.Image = global::Acid.Editor.Icons.SaveAs_16x;
			this.mnuNewFile.Name = "mnuNewFile";
			this.mnuNewFile.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.mnuNewFile.Size = new System.Drawing.Size(218, 22);
			this.mnuNewFile.Text = "&Save Scene as";
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.toolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.toolStripMenuItem5.Image = global::Acid.Editor.Icons.NewTest_16x;
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
			this.toolStripMenuItem5.Size = new System.Drawing.Size(218, 22);
			this.toolStripMenuItem5.Text = "&New Entity";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
			// 
			// mnuClose
			// 
			this.mnuClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.mnuClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.mnuClose.Image = global::Acid.Editor.Icons.Close_16xLG;
			this.mnuClose.Name = "mnuClose";
			this.mnuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.mnuClose.Size = new System.Drawing.Size(218, 22);
			this.mnuClose.Text = "&Close";
			// 
			// mnuView
			// 
			this.mnuView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSettings});
			this.mnuView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.mnuView.Name = "mnuView";
			this.mnuView.Size = new System.Drawing.Size(44, 20);
			this.mnuView.Text = "&View";
			// 
			// mnuSettings
			// 
			this.mnuSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.mnuSettings.Image = global::Acid.Editor.Icons.properties_16xLG;
			this.mnuSettings.Name = "mnuSettings";
			this.mnuSettings.Size = new System.Drawing.Size(116, 22);
			this.mnuSettings.Text = "&Settings";
			// 
			// mnuWindow
			// 
			this.mnuWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAssets,
            this.mnuScene,
            this.mnuHierarchy,
            this.mnuInspector,
            this.mnuConsole});
			this.mnuWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.mnuWindow.Name = "mnuWindow";
			this.mnuWindow.Size = new System.Drawing.Size(63, 20);
			this.mnuWindow.Text = "&Window";
			// 
			// mnuAssets
			// 
			this.mnuAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.mnuAssets.Image = global::Acid.Editor.Icons.application_16x;
			this.mnuAssets.Name = "mnuAssets";
			this.mnuAssets.Size = new System.Drawing.Size(152, 22);
			this.mnuAssets.Text = "&Assets Explorer";
			// 
			// mnuScene
			// 
			this.mnuScene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.mnuScene.Image = global::Acid.Editor.Icons.RefactoringLog_12810;
			this.mnuScene.Name = "mnuScene";
			this.mnuScene.Size = new System.Drawing.Size(152, 22);
			this.mnuScene.Text = "&Scene";
			// 
			// mnuHierarchy
			// 
			this.mnuHierarchy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.mnuHierarchy.Image = global::Acid.Editor.Icons.Collection_16xLG;
			this.mnuHierarchy.Name = "mnuHierarchy";
			this.mnuHierarchy.Size = new System.Drawing.Size(152, 22);
			this.mnuHierarchy.Text = "&Hierarchy";
			// 
			// mnuInspector
			// 
			this.mnuInspector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.mnuInspector.Image = global::Acid.Editor.Icons.properties_16xLG;
			this.mnuInspector.Name = "mnuInspector";
			this.mnuInspector.Size = new System.Drawing.Size(152, 22);
			this.mnuInspector.Text = "&Inspector";
			// 
			// mnuConsole
			// 
			this.mnuConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.mnuConsole.Image = global::Acid.Editor.Icons.Console;
			this.mnuConsole.Name = "mnuConsole";
			this.mnuConsole.Size = new System.Drawing.Size(152, 22);
			this.mnuConsole.Text = "&Console";
			// 
			// mnuHelp
			// 
			this.mnuHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
			this.mnuHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size(44, 20);
			this.mnuHelp.Text = "&Help";
			// 
			// mnuAbout
			// 
			this.mnuAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.mnuAbout.Image = global::Acid.Editor.Icons.StatusAnnotations_Information_16xLG_color;
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size(107, 22);
			this.mnuAbout.Text = "&About";
			// 
			// stripMain
			// 
			this.stripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.stripMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.stripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel5});
			this.stripMain.Location = new System.Drawing.Point(0, 912);
			this.stripMain.Name = "stripMain";
			this.stripMain.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
			this.stripMain.Size = new System.Drawing.Size(1404, 24);
			this.stripMain.TabIndex = 2;
			this.stripMain.Text = "darkStatusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.AutoSize = false;
			this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(1, 0, 50, 0);
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 16);
			this.toolStripStatusLabel1.Text = "Ready";
			this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripStatusLabel6
			// 
			this.toolStripStatusLabel6.Margin = new System.Windows.Forms.Padding(0, 0, 50, 2);
			this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
			this.toolStripStatusLabel6.Size = new System.Drawing.Size(1217, 14);
			this.toolStripStatusLabel6.Spring = true;
			this.toolStripStatusLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(46, 16);
			this.toolStripStatusLabel5.Text = "512 MB";
			this.toolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DockPanel
			// 
			this.DockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DockPanel.Location = new System.Drawing.Point(0, 26);
			this.DockPanel.Name = "DockPanel";
			this.DockPanel.Size = new System.Drawing.Size(1404, 886);
			this.DockPanel.TabIndex = 3;
			// 
			// darkSeparator1
			// 
			this.darkSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
			this.darkSeparator1.Location = new System.Drawing.Point(0, 24);
			this.darkSeparator1.Name = "darkSeparator1";
			this.darkSeparator1.Size = new System.Drawing.Size(1404, 2);
			this.darkSeparator1.TabIndex = 4;
			this.darkSeparator1.Text = "darkSeparator1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1404, 936);
			this.Controls.Add(this.DockPanel);
			this.Controls.Add(this.stripMain);
			this.Controls.Add(this.darkSeparator1);
			this.Controls.Add(this.mnuMain);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mnuMain;
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Acid Editor";
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.stripMain.ResumeLayout(false);
			this.stripMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DarkMenuStrip mnuMain;
        private DarkStatusStrip stripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuNewFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DarkDockPanel DockPanel;
        private System.Windows.Forms.ToolStripMenuItem mnuAssets;
        private System.Windows.Forms.ToolStripMenuItem mnuScene;
        private System.Windows.Forms.ToolStripMenuItem mnuHierarchy;
        private System.Windows.Forms.ToolStripMenuItem mnuInspector;
        private System.Windows.Forms.ToolStripMenuItem mnuConsole;
        private DarkSeparator darkSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
	}
}
