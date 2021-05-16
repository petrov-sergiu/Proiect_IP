using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace proiectIP
{
    public partial class Form2 : Form
    {

        public string path;
        public Form2()
        {
            InitializeComponent();
            PopulateTreeView();
            path = "";
        }

        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../..");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info, rootNode);
                GetFiles(info, rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }
        private void GetDirectories(DirectoryInfo dir, TreeNode nodeToAddTo)
        {
            DirectoryInfo[] subDirs = dir.GetDirectories();
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subDir, aNode);
                    GetFiles(subDir, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }
        private void GetFiles(DirectoryInfo dir, TreeNode nodeToAddTo)
        {
            FileInfo[] files = dir.GetFiles();
            TreeNode aNode;
            foreach (FileInfo file in files)
            {
                aNode = new TreeNode(file.Name, 0, 0);
                aNode.Tag = file;
                aNode.ImageKey = "file";             
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            path = "";
            this.Close();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            string _path = treeView1.SelectedNode.Text;
            string[] sir = _path.Split('.');
            if (sir.Length == 1)
            {
                MessageBox.Show("Alege un fisier.");
            }
            else if (sir[1] == "jpg" || sir[1] == "gif" || sir[1] == "jpeg" || sir[1] == "png" || sir[1] == "pdf")
            {
                path = _path;
                this.Close();
            }
            else
                MessageBox.Show("Alege o imagine");
        }

        
    }
}
