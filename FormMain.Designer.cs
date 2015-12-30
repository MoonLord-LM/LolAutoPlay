namespace MyCSharp
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PVP监控Timer = new System.Windows.Forms.Timer(this.components);
            this.LOL监控Timer = new System.Windows.Forms.Timer(this.components);
            this.退出监控Timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemPVP截图 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLOL截图 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem退出 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem帮助 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PVP监控Timer
            // 
            this.PVP监控Timer.Tick += new System.EventHandler(this.PVP监控);
            // 
            // LOL监控Timer
            // 
            this.LOL监控Timer.Tick += new System.EventHandler(this.LOL监控);
            // 
            // 退出监控Timer
            // 
            this.退出监控Timer.Tick += new System.EventHandler(this.退出监控);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LOL自动挂机";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem帮助,
            this.toolStripMenuItemPVP截图,
            this.toolStripMenuItemLOL截图,
            this.toolStripMenuItem退出});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 114);
            // 
            // toolStripMenuItemPVP截图
            // 
            this.toolStripMenuItemPVP截图.Name = "toolStripMenuItemPVP截图";
            this.toolStripMenuItemPVP截图.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemPVP截图.Text = "PVP界面截图";
            this.toolStripMenuItemPVP截图.Click += new System.EventHandler(this.toolStripMenuItemPVP截图_Click);
            // 
            // toolStripMenuItemLOL截图
            // 
            this.toolStripMenuItemLOL截图.Name = "toolStripMenuItemLOL截图";
            this.toolStripMenuItemLOL截图.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemLOL截图.Text = "LOL界面截图";
            this.toolStripMenuItemLOL截图.Click += new System.EventHandler(this.toolStripMenuItemLOL截图_Click);
            // 
            // toolStripMenuItem退出
            // 
            this.toolStripMenuItem退出.Name = "toolStripMenuItem退出";
            this.toolStripMenuItem退出.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem退出.Text = "退出";
            this.toolStripMenuItem退出.Click += new System.EventHandler(this.toolStripMenuItem退出_Click);
            // 
            // toolStripMenuItem帮助
            // 
            this.toolStripMenuItem帮助.Name = "toolStripMenuItem帮助";
            this.toolStripMenuItem帮助.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem帮助.Text = "帮助";
            this.toolStripMenuItem帮助.Click += new System.EventHandler(this.toolStripMenuItem帮助_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(441, 303);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer PVP监控Timer;
        private System.Windows.Forms.Timer LOL监控Timer;
        private System.Windows.Forms.Timer 退出监控Timer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPVP截图;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLOL截图;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem退出;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem帮助;
    }
}

