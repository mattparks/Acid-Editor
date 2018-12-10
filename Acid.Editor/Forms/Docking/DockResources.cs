using Acid.Forms.Controls;
using Acid.Forms.Docking;
using System;
using System.IO;

namespace Acid.Editor.Forms.Docking
{
    public partial class DockResources : DarkToolWindow
    {
        #region Constructor Region

        public DockResources()
        {
            InitializeComponent();

            SearchDirectory(Directory.GetCurrentDirectory()); // @"C:\Users\mattp\Documents\Acid Workspace\Acid\Resources"
		}

        #endregion

        private void SearchDirectory(string path, DarkTreeNode parentNode = null)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(path))
                {
                    var node = new DarkTreeNode(Path.GetFileName(d))
                    {
                        ExpandedIcon = Icons.folder_open,
                        Icon = Icons.folder_closed
                    };

                    SearchDirectory(d, node);

                    foreach (string f in Directory.GetFiles(d))
                    {
                        var childNode = new DarkTreeNode(Path.GetFileName(f))
                        {
                            Icon = Icons.files
                        };
                        node.Nodes.Add(childNode);
                    }
                    
                    if (parentNode == null)
                    {
	                    darktreeView1.Nodes.Add(node);
                    }
                    else
                    {
                        parentNode.Nodes.Add(node);
                    }
                }

                if (parentNode == null)
                {
                    foreach (string f in Directory.GetFiles(path))
                    {
                        var childNode = new DarkTreeNode(Path.GetFileName(f))
                        {
                            Icon = Icons.files
                        };
	                    darktreeView1.Nodes.Add(childNode);
                    }
                }
            }
            catch (Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}
