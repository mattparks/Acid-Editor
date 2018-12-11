using System;
using System.Drawing;
using System.Windows.Forms;
using Acid.Forms.Config;

namespace Acid.Editor.Forms.Docking
{
    partial class DockScene
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
			this.txtDocument = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtDocument
			// 
			this.txtDocument.AcceptsReturn = true;
			this.txtDocument.AcceptsTab = true;
			this.txtDocument.BackColor = Colours.DarkBackground;
			this.txtDocument.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDocument.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDocument.ForeColor = Colours.LightText;
			this.txtDocument.Location = new System.Drawing.Point(0, 25);
			this.txtDocument.Multiline = true;
			this.txtDocument.Name = "txtDocument";
			this.txtDocument.ReadOnly = true;
			this.txtDocument.Size = new System.Drawing.Size(720, 455);
			this.txtDocument.TabIndex = 2;
			// 
			// DockScene
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtDocument);
			this.DefaultDockArea = Acid.Forms.Docking.DarkDockArea.Document;
			this.DockText = "Scene";
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = global::Acid.Editor.Icons.RefactoringLog_12810;
			this.Name = "DockScene";
			this.SerializationKey = "DockScene";
			this.Size = new System.Drawing.Size(720, 480);
			this.Load += new System.EventHandler(this.DockScene_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private TextBox txtDocument;
	}
}
