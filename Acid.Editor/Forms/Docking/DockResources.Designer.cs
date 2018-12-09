using Acid.UI.Config;
using Acid.UI.Controls;
using Acid.UI.Docking;

namespace Acid.Editor.Forms.Docking
{
    partial class DockResources
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
			this.darktreeView1 = new Acid.UI.Controls.DarkTreeView();
			this.SuspendLayout();
			// 
			// darktreeView
			// 
			this.darktreeView1.AllowDrop = true;
			this.darktreeView1.AllowMoveNodes = true;
			this.darktreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.darktreeView1.Location = new System.Drawing.Point(0, 25);
			this.darktreeView1.MaxDragChange = 20;
			this.darktreeView1.MultiSelect = true;
			this.darktreeView1.Name = "darktreeView1";
			this.darktreeView1.ShowIcons = true;
			this.darktreeView1.Size = new System.Drawing.Size(200, 175);
			this.darktreeView1.TabIndex = 0;
			// 
			// DockResources
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.darktreeView1);
			this.DefaultDockArea = Acid.UI.Docking.DarkDockArea.Bottom;
			this.DockText = "Resources";
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = global::Acid.Editor.Icons.ListViewTable_16x;
			this.Name = "DockResources";
			this.SerializationKey = "DockResources";
			this.Size = new System.Drawing.Size(200, 200);
			this.ResumeLayout(false);

        }

        #endregion

        private DarkTreeView darktreeView1;
    }
}
