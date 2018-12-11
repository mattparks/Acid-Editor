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
			this.pnlMain.SuspendLayout();
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
			this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblMain.Location = new System.Drawing.Point(5, 10);
			this.tblMain.Name = "tblMain";
			this.tblMain.RowCount = 1;
			this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tblMain.Size = new System.Drawing.Size(698, 400);
			this.tblMain.TabIndex = 0;
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
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tblMain;
    }
}