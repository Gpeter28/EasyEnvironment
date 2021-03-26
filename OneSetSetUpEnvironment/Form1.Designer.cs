namespace OneSetSetUpEnvironment
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("VSCode");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("F", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTool_New = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode11.Name = "节点1";
            treeNode11.Text = "VSCode";
            treeNode12.Name = "节点0";
            treeNode12.Text = "F";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(174, 539);
            this.treeView1.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(930, 35);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTool_New});
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(62, 31);
            this.newToolStripMenuItem.Text = "Test";
            // 
            // newTool_New
            // 
            this.newTool_New.Name = "newTool_New";
            this.newTool_New.Size = new System.Drawing.Size(180, 32);
            this.newTool_New.Text = "New";
            this.newTool_New.Click += new System.EventHandler(this.newTool_New_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(180, 77);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(750, 539);
            this.MainPanel.TabIndex = 2;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.treeView1);
            this.LeftPanel.Location = new System.Drawing.Point(0, 77);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(174, 539);
            this.LeftPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 617);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTool_New;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel LeftPanel;
    }
}

