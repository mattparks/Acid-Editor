using System;
using System.Drawing;
using System.Windows.Forms;

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
            this.SuspendLayout();
            // 
            // DockScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DefaultDockArea = Acid.UI.Docking.DarkDockArea.Document;
            this.DockText = "Scene";
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = global::Acid.Editor.Icons.RefactoringLog_12810;
            this.Name = "Scene";
            this.SerializationKey = "DockScene";
            this.Size = new System.Drawing.Size(720, 480);
			this.SizeChanged += DockResize;
            this.VisibleChanged += DockVisible;
            this.LocationChanged += DockLocation;
			this.ResumeLayout(false);
        }

        private void DockResize(object sender, System.EventArgs e)
        {
            // Display.Get().Dimensions = new Vector2(this.Size.Width, this.Size.Height);
            Console.WriteLine($"Scene resized: {this.Size}");
        }

        private void DockVisible(object sender, System.EventArgs e)
        {
            // Display.Get().Iconified = !this.Visible;
            Console.WriteLine($"Scene visiblity: {this.Visible}");
        }

        private void DockLocation(object sender, System.EventArgs e)
        {
            var screenLocation = this.Parent.PointToScreen(this.Location);
            // Display.Get().Position = new Vector2(screenLocation.X, screenLocation.Y);
            Console.WriteLine($"Scene position: {screenLocation}");
        }

        #endregion
    }
}
