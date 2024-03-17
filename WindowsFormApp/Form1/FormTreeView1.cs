using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class FormTreeView1 : Form
    {
        public FormTreeView1()
        {
            InitializeComponent();
        }

        private void FormTreeView1_Load(object sender, EventArgs e)
        {
            TreeNode tnode;
            tnode = treeView1.Nodes.Add("Departments: ");

            treeView1.Nodes[0].Nodes.Add("Basic Science");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Microbiology");

            treeView1.Nodes[0].Nodes.Add("CPGS");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("CSA");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("ABM");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("BI");

            treeView1.Nodes[0].Nodes.Add("Agriculture");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("Floriculture");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("Agronomy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.FullPath.ToString());
        }
    }
}
