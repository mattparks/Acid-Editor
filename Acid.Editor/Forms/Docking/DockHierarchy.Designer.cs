using Acid.Forms.Config;
using Acid.Forms.Controls;
using Acid.Forms.Docking;

namespace Acid.Editor.Forms.Docking
{
    partial class DockHierarchy
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
            this.treeHierarchy = new Acid.Forms.Controls.DarkTreeView();
            this.SuspendLayout();
			// 
			// treeHierarchy
			// 
			this.treeHierarchy.AllowMoveNodes = true;
            this.treeHierarchy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeHierarchy.Location = new System.Drawing.Point(0, 25);
            this.treeHierarchy.MaxDragChange = 20;
            this.treeHierarchy.MultiSelect = true;
            this.treeHierarchy.Name = "treeAssets";
            this.treeHierarchy.ShowIcons = true;
            this.treeHierarchy.Size = new System.Drawing.Size(200, 175);
            this.treeHierarchy.TabIndex = 0;
            this.treeHierarchy.Text = "darkTreeView1";
			// 
			// DockHierarchy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeHierarchy);
            this.DefaultDockArea = Acid.Forms.Docking.DarkDockArea.Left;
            this.DockText = "Hierarchy";
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::Acid.Editor.Icons.Collection_16xLG;
            this.Name = "DockHierarchy";
            this.SerializationKey = "DockHierarchy";
            this.Size = new System.Drawing.Size(200, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private DarkTreeView treeHierarchy;
    }
}
