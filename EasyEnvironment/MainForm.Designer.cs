namespace EasyEnvironment
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("VSCode");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("F", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.newTask_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.New_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.load_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AutoInstall = new System.Windows.Forms.ToolStripMenuItem();
            this.EnvironmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoStartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.CheckBox_SelectAll = new System.Windows.Forms.CheckBox();
            this.Button_AllStart = new System.Windows.Forms.Button();
            this.Button_AllPause = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 38);
            this.treeView1.Name = "treeView1";
            treeNode3.Name = "节点1";
            treeNode3.Text = "VSCode";
            treeNode4.Name = "节点0";
            treeNode4.Text = "F";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(126, 575);
            this.treeView1.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTask_ToolStripMenuItem,
            this.directoryToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(960, 35);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // newTask_ToolStripMenuItem
            // 
            this.newTask_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_MenuItem,
            this.load_MenuItem,
            this.Save_MenuItem});
            this.newTask_ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.newTask_ToolStripMenuItem.Name = "newTask_ToolStripMenuItem";
            this.newTask_ToolStripMenuItem.Size = new System.Drawing.Size(109, 31);
            this.newTask_ToolStripMenuItem.Text = "NewTask";
            // 
            // New_MenuItem
            // 
            this.New_MenuItem.Name = "New_MenuItem";
            this.New_MenuItem.Size = new System.Drawing.Size(180, 32);
            this.New_MenuItem.Text = "New";
            this.New_MenuItem.Click += new System.EventHandler(this.New_MenuItem_Click);
            // 
            // load_MenuItem
            // 
            this.load_MenuItem.Name = "load_MenuItem";
            this.load_MenuItem.Size = new System.Drawing.Size(180, 32);
            this.load_MenuItem.Text = "Load";
            this.load_MenuItem.Click += new System.EventHandler(this.Load_MenuItem_Click);
            // 
            // Save_MenuItem
            // 
            this.Save_MenuItem.Name = "Save_MenuItem";
            this.Save_MenuItem.Size = new System.Drawing.Size(180, 32);
            this.Save_MenuItem.Text = "Save";
            this.Save_MenuItem.Click += new System.EventHandler(this.Save_MenuItem_Click);
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.MenuItem_AutoInstall,
            this.EnvironmentToolStripMenuItem});
            this.directoryToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(112, 31);
            this.directoryToolStripMenuItem.Text = "Directory";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.openToolStripMenuItem.Text = "OpenFile";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // MenuItem_AutoInstall
            // 
            this.MenuItem_AutoInstall.Name = "MenuItem_AutoInstall";
            this.MenuItem_AutoInstall.Size = new System.Drawing.Size(205, 32);
            this.MenuItem_AutoInstall.Text = "AutoInstall";
            this.MenuItem_AutoInstall.Click += new System.EventHandler(this.MenuItem_AutoInstall_Click);
            // 
            // EnvironmentToolStripMenuItem
            // 
            this.EnvironmentToolStripMenuItem.Name = "EnvironmentToolStripMenuItem";
            this.EnvironmentToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.EnvironmentToolStripMenuItem.Text = "Environment";
            this.EnvironmentToolStripMenuItem.Click += new System.EventHandler(this.EnvironmentToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoStartMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(100, 31);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // AutoStartMenuItem
            // 
            this.AutoStartMenuItem.Name = "AutoStartMenuItem";
            this.AutoStartMenuItem.Size = new System.Drawing.Size(196, 32);
            this.AutoStartMenuItem.Text = "AutoStart ×";
            this.AutoStartMenuItem.Click += new System.EventHandler(this.AutoStartToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(132, 80);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(828, 536);
            this.MainPanel.TabIndex = 2;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Location = new System.Drawing.Point(0, 38);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(127, 578);
            this.LeftPanel.TabIndex = 0;
            // 
            // CheckBox_SelectAll
            // 
            this.CheckBox_SelectAll.AutoSize = true;
            this.CheckBox_SelectAll.Font = new System.Drawing.Font("宋体", 15F);
            this.CheckBox_SelectAll.Location = new System.Drawing.Point(133, 50);
            this.CheckBox_SelectAll.Name = "CheckBox_SelectAll";
            this.CheckBox_SelectAll.Size = new System.Drawing.Size(68, 24);
            this.CheckBox_SelectAll.TabIndex = 3;
            this.CheckBox_SelectAll.Text = "全选";
            this.CheckBox_SelectAll.UseVisualStyleBackColor = true;
            this.CheckBox_SelectAll.CheckedChanged += new System.EventHandler(this.CheckBox_SelectAll_CheckedChanged);
            // 
            // Button_AllStart
            // 
            this.Button_AllStart.Font = new System.Drawing.Font("宋体", 12F);
            this.Button_AllStart.Location = new System.Drawing.Point(657, 38);
            this.Button_AllStart.Name = "Button_AllStart";
            this.Button_AllStart.Size = new System.Drawing.Size(93, 35);
            this.Button_AllStart.TabIndex = 4;
            this.Button_AllStart.Text = "全部开始";
            this.Button_AllStart.UseVisualStyleBackColor = true;
            // 
            // Button_AllPause
            // 
            this.Button_AllPause.Font = new System.Drawing.Font("宋体", 12F);
            this.Button_AllPause.Location = new System.Drawing.Point(756, 38);
            this.Button_AllPause.Name = "Button_AllPause";
            this.Button_AllPause.Size = new System.Drawing.Size(93, 35);
            this.Button_AllPause.TabIndex = 5;
            this.Button_AllPause.Text = "全部暂停";
            this.Button_AllPause.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F);
            this.button2.Location = new System.Drawing.Point(855, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "全部开始";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(960, 617);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button_AllPause);
            this.Controls.Add(this.Button_AllStart);
            this.Controls.Add(this.CheckBox_SelectAll);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem newTask_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem New_MenuItem;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.ToolStripMenuItem load_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_AutoInstall;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoStartMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnvironmentToolStripMenuItem;
        private System.Windows.Forms.CheckBox CheckBox_SelectAll;
        private System.Windows.Forms.Button Button_AllStart;
        private System.Windows.Forms.Button Button_AllPause;
        private System.Windows.Forms.Button button2;
    }
}

