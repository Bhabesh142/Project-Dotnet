namespace Form1
{
    partial class FormTreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("CHILD2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("CHILD1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ROOT NODE", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node6", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node7", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Yellow;
            this.treeView1.Location = new System.Drawing.Point(270, 38);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "CHILD2";
            treeNode2.Name = "Node1";
            treeNode2.Text = "CHILD1";
            treeNode3.Name = "Node0";
            treeNode3.Text = "ROOT NODE";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Node4";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node5";
            treeNode6.Name = "Node10";
            treeNode6.Text = "Node10";
            treeNode7.Name = "Node11";
            treeNode7.Text = "Node11";
            treeNode8.Name = "Node12";
            treeNode8.Text = "Node12";
            treeNode9.Name = "Node6";
            treeNode9.Text = "Node6";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Node3";
            treeNode11.Name = "Node8";
            treeNode11.Text = "Node8";
            treeNode12.Name = "Node9";
            treeNode12.Text = "Node9";
            treeNode13.Name = "Node7";
            treeNode13.Text = "Node7";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode10,
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(165, 246);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(393, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Path";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(568, 38);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(309, 246);
            this.treeView2.TabIndex = 2;
            // 
            // FormTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.treeView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormTreeView";
            this.Text = "FormTreeView";
            this.Load += new System.EventHandler(this.FormTreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView2;
    }
}