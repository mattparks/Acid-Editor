using Acid.Forms.Controls;

namespace Acid.Editor.Forms.Dialogs
{
    partial class DialogSettings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogSettings));
			this.pnlMain = new System.Windows.Forms.Panel();
			this.tblMain = new System.Windows.Forms.TableLayoutPanel();
			this.pnlMessageBox = new Acid.Forms.Controls.DarkSectionPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.darkTitle3 = new Acid.Forms.Controls.DarkTitle();
			this.pnlMain.SuspendLayout();
			this.tblMain.SuspendLayout();
			this.pnlMessageBox.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.Controls.Add(this.tblMain);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
			this.pnlMain.Size = new System.Drawing.Size(708, 410);
			this.pnlMain.TabIndex = 2;
			// 
			// tblMain
			// 
			this.tblMain.ColumnCount = 3;
			this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tblMain.Controls.Add(this.pnlMessageBox, 0, 0);
			this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblMain.Location = new System.Drawing.Point(5, 10);
			this.tblMain.Name = "tblMain";
			this.tblMain.RowCount = 1;
			this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tblMain.Size = new System.Drawing.Size(698, 400);
			this.tblMain.TabIndex = 0;
			// 
			// pnlMessageBox
			// 
			this.pnlMessageBox.Controls.Add(this.panel1);
			this.pnlMessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMessageBox.Location = new System.Drawing.Point(5, 0);
			this.pnlMessageBox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.pnlMessageBox.Name = "pnlMessageBox";
			this.pnlMessageBox.SectionHeader = "Appearance";
			this.pnlMessageBox.Size = new System.Drawing.Size(222, 400);
			this.pnlMessageBox.TabIndex = 12;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(1, 25);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10);
			this.panel1.Size = new System.Drawing.Size(220, 374);
			this.panel1.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.darkTitle3);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(10, 10);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(200, 100);
			this.panel5.TabIndex = 12;
			// 
			// darkTitle3
			// 
			this.darkTitle3.Dock = System.Windows.Forms.DockStyle.Top;
			this.darkTitle3.Location = new System.Drawing.Point(0, 0);
			this.darkTitle3.Name = "darkTitle3";
			this.darkTitle3.Size = new System.Drawing.Size(200, 23);
			this.darkTitle3.TabIndex = 16;
			this.darkTitle3.Text = "Themes";
			// 
			// DialogSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(708, 455);
			this.Controls.Add(this.pnlMain);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DialogSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.Controls.SetChildIndex(this.pnlMain, 0);
			this.pnlMain.ResumeLayout(false);
			this.tblMain.ResumeLayout(false);
			this.pnlMessageBox.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private DarkSectionPanel pnlMessageBox;
        private System.Windows.Forms.Panel panel1;
	    private System.Windows.Forms.Panel panel5;
        private DarkTitle darkTitle3;
    }
}