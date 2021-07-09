using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Duplicatefinder
{
    public partial class SearchForm : Form
    {
        public Dictionary<string, TreeNode> hashtonode;
        public HashManager hmgr;

        public SearchForm()
        {
            hashtonode = new Dictionary<string, TreeNode>();
            hmgr = new HashManager();
            InitializeComponent();
        }

        private void ResetView()
        {
            FileTreeView.Nodes.Clear(); hashtonode.Clear(); 
            FileCountLabel.Text = string.Empty;
            FileTreeView.Visible = false;
        }

        private void ShowDuplicates(string[] fles)
        {
            int dupcount = 0;
            foreach (string fle in fles)
            {
                string hash = hmgr.GetHash(fle);
                if (hash != null)
                {
                    if (hashtonode.ContainsKey(hash))
                    {
                        FileTreeView.SelectedNode = hashtonode[hash];
                        FileTreeView.SelectedNode.Nodes.Add(fle);
                        dupcount++;
                    }
                    else
                    {
                        hashtonode.Add(hash, FileTreeView.Nodes.Add(fle));
                    }
                }
            }
            List<TreeNode> toremove = new List<TreeNode>();
            foreach (TreeNode tn in FileTreeView.Nodes)
            {
                if (tn.GetNodeCount(true) == 0)
                {
                    toremove.Add(tn);
                }
            }
            foreach (TreeNode leftover in toremove) { FileTreeView.Nodes.Remove(leftover); }
            FileCountLabel.Text += ", " + dupcount.ToString() + " of which were duplicates.";
        }

        private void ChooseDirButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult res = fbd.ShowDialog();
            string[] fles = new string[] {};
            if (res == DialogResult.OK)
            {
                ResetView();
                fles = Directory.GetFiles(
                    fbd.SelectedPath, "*.*" , 
                    SearchOption.AllDirectories
                );
                FileCountLabel.Visible = true; FileTreeView.Visible = true;
                FileCountLabel.Text = fles.Length.ToString() + " files were found";
                ShowDuplicates(fles);
            }
        }
    }
}
