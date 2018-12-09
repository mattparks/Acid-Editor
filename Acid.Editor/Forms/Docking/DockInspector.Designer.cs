﻿using Acid.UI.Config;
using Acid.UI.Docking;

namespace Acid.Editor.Forms.Docking
{
    partial class DockInspector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.pnlMain = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.darkRadioButton3 = new Acid.UI.Controls.DarkRadioButton();
			this.darkRadioButton2 = new Acid.UI.Controls.DarkRadioButton();
			this.darkRadioButton1 = new Acid.UI.Controls.DarkRadioButton();
			this.darkTitle1 = new Acid.UI.Controls.DarkTitle();
			this.panel2 = new System.Windows.Forms.Panel();
			this.darkCheckBox3 = new Acid.UI.Controls.DarkCheckBox();
			this.darkCheckBox2 = new Acid.UI.Controls.DarkCheckBox();
			this.darkCheckBox1 = new Acid.UI.Controls.DarkCheckBox();
			this.darkTitle2 = new Acid.UI.Controls.DarkTitle();
			this.panel3 = new System.Windows.Forms.Panel();
			this.darkButton1 = new Acid.UI.Controls.DarkButton();
			this.darkTitle3 = new Acid.UI.Controls.DarkTitle();
			this.pnlMain.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.Controls.Add(this.panel1);
			this.pnlMain.Controls.Add(this.panel2);
			this.pnlMain.Controls.Add(this.panel3);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 25);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
			this.pnlMain.Size = new System.Drawing.Size(261, 362);
			this.pnlMain.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.darkRadioButton3);
			this.panel1.Controls.Add(this.darkRadioButton2);
			this.panel1.Controls.Add(this.darkRadioButton1);
			this.panel1.Controls.Add(this.darkTitle1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(10, 174);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.panel1.Size = new System.Drawing.Size(241, 93);
			this.panel1.TabIndex = 2;
			// 
			// darkRadioButton3
			// 
			this.darkRadioButton3.AutoSize = true;
			this.darkRadioButton3.Dock = System.Windows.Forms.DockStyle.Top;
			this.darkRadioButton3.Enabled = false;
			this.darkRadioButton3.Location = new System.Drawing.Point(0, 64);
			this.darkRadioButton3.Name = "darkRadioButton3";
			this.darkRadioButton3.Size = new System.Drawing.Size(241, 19);
			this.darkRadioButton3.TabIndex = 6;
			this.darkRadioButton3.TabStop = true;
			this.darkRadioButton3.Text = "Disabled radiobutton";
			// 
			// darkRadioButton2
			// 
			this.darkRadioButton2.AutoSize = true;
			this.darkRadioButton2.Dock = System.Windows.Forms.DockStyle.Top;
			this.darkRadioButton2.Location = new System.Drawing.Point(0, 45);
			this.darkRadioButton2.Name = "darkRadioButton2";
			this.darkRadioButton2.Size = new System.Drawing.Size(241, 19);
			this.darkRadioButton2.TabIndex = 5;
			this.darkRadioButton2.TabStop = true;
			this.darkRadioButton2.Text = "Radiobutton";
			// 
			// darkRadioButton1
			// 
			this.darkRadioButton1.AutoSize = true;
			this.darkRadioButton1.Dock = System.Windows.Forms.DockStyle.Top;
			this.darkRadioButton1.Location = new System.Drawing.Point(0, 26);
			this.darkRadioButton1.Name = "darkRadioButton1";
			this.darkRadioButton1.Size = new System.Drawing.Size(241, 19);
			this.darkRadioButton1.TabIndex = 4;
			this.darkRadioButton1.TabStop = true;
			this.darkRadioButton1.Text = "Radiobutton";
			// 
			// darkTitle1
			// 
			this.darkTitle1.Dock = System.Windows.Forms.DockStyle.Top;
			this.darkTitle1.Location = new System.Drawing.Point(0, 0);
			this.darkTitle1.Name = "darkTitle1";
			this.darkTitle1.Size = new System.Drawing.Size(241, 26);
			this.darkTitle1.TabIndex = 7;
			this.darkTitle1.Text = "Radio buttons";
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.Controls.Add(this.darkCheckBox3);
			this.panel2.Controls.Add(this.darkCheckBox2);
			this.panel2.Controls.Add(this.darkCheckBox1);
			this.panel2.Controls.Add(this.darkTitle2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(10, 81);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.panel2.Size = new System.Drawing.Size(241, 93);
			this.panel2.TabIndex = 1;
			// 
			// darkCheckBox3
			// 
			this.darkCheckBox3.AutoSize = true;
			this.darkCheckBox3.Checked = true;
			this.darkCheckBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.darkCheckBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.darkCheckBox3.Enabled = false;
			this.darkCheckBox3.Location = new System.Drawing.Point(0, 64);
			this.darkCheckBox3.Name = "darkCheckBox3";
			this.darkCheckBox3.Size = new System.Drawing.Size(241, 19);
			this.darkCheckBox3.TabIndex = 6;
			this.darkCheckBox3.Text = "Disabled checked checkbox";
			// 
			// darkCheckBox2
			// 
			this.darkCheckBox2.AutoSize = true;
			this.darkCheckBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.darkCheckBox2.Enabled = false;
			this.darkCheckBox2.Location = new System.Drawing.Point(0, 45);
			this.darkCheckBox2.Name = "darkCheckBox2";
			this.darkCheckBox2.Size = new System.Drawing.Size(241, 19);
			this.darkCheckBox2.TabIndex = 5;
			this.darkCheckBox2.Text = "Disabled checkbox";
			// 
			// darkCheckBox1
			// 
			this.darkCheckBox1.AutoSize = true;
			this.darkCheckBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.darkCheckBox1.Location = new System.Drawing.Point(0, 26);
			this.darkCheckBox1.Name = "darkCheckBox1";
			this.darkCheckBox1.Size = new System.Drawing.Size(241, 19);
			this.darkCheckBox1.TabIndex = 4;
			this.darkCheckBox1.Text = "Checkbox";
			// 
			// darkTitle2
			// 
			this.darkTitle2.Dock = System.Windows.Forms.DockStyle.Top;
			this.darkTitle2.Location = new System.Drawing.Point(0, 0);
			this.darkTitle2.Name = "darkTitle2";
			this.darkTitle2.Size = new System.Drawing.Size(241, 26);
			this.darkTitle2.TabIndex = 8;
			this.darkTitle2.Text = "Check boxes";
			// 
			// panel3
			// 
			this.panel3.AutoSize = true;
			this.panel3.Controls.Add(this.darkButton1);
			this.panel3.Controls.Add(this.darkTitle3);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(10, 10);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.panel3.Size = new System.Drawing.Size(241, 71);
			this.panel3.TabIndex = 1;
			// 
			// darkButton1
			// 
			this.darkButton1.AutoSize = true;
			this.darkButton1.Dock = System.Windows.Forms.DockStyle.Top;
			this.darkButton1.Location = new System.Drawing.Point(0, 26);
			this.darkButton1.Name = "darkButton1";
			this.darkButton1.Size = new System.Drawing.Size(241, 35);
			this.darkButton1.TabIndex = 4;
			this.darkButton1.Text = "Button";
			// 
			// darkTitle3
			// 
			this.darkTitle3.Dock = System.Windows.Forms.DockStyle.Top;
			this.darkTitle3.Location = new System.Drawing.Point(0, 0);
			this.darkTitle3.Name = "darkTitle3";
			this.darkTitle3.Size = new System.Drawing.Size(241, 26);
			this.darkTitle3.TabIndex = 8;
			this.darkTitle3.Text = "Buttons";
			// 
			// DockInspector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlMain);
			this.DefaultDockArea = Acid.UI.Docking.DarkDockArea.Right;
			this.DockText = "Inspector";
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = global::Acid.Editor.Icons.properties_16xLG;
			this.Name = "DockInspector";
			this.SerializationKey = "DockInspector";
			this.Size = new System.Drawing.Size(261, 387);
			this.pnlMain.ResumeLayout(false);
			this.pnlMain.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private Acid.UI.Controls.DarkRadioButton darkRadioButton3;
        private Acid.UI.Controls.DarkRadioButton darkRadioButton2;
        private Acid.UI.Controls.DarkRadioButton darkRadioButton1;
        private Acid.UI.Controls.DarkTitle darkTitle1;
        private System.Windows.Forms.Panel panel2;
        private Acid.UI.Controls.DarkCheckBox darkCheckBox3;
        private Acid.UI.Controls.DarkCheckBox darkCheckBox2;
        private Acid.UI.Controls.DarkCheckBox darkCheckBox1;
        private Acid.UI.Controls.DarkTitle darkTitle2;
        private System.Windows.Forms.Panel panel3;
        private Acid.UI.Controls.DarkButton darkButton1;
        private Acid.UI.Controls.DarkTitle darkTitle3;
    }
}