namespace VideoAnalysisProcessSystem
{
    partial class frmMainForm
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
            this.menuStrip_frmMainForm = new System.Windows.Forms.MenuStrip();
            this.videoFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_FileInfoScan = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog_VideoFile = new System.Windows.Forms.OpenFileDialog();
            this.MenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_frmMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_frmMainForm
            // 
            this.menuStrip_frmMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoFileToolStripMenuItem});
            this.menuStrip_frmMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_frmMainForm.Name = "menuStrip_frmMainForm";
            this.menuStrip_frmMainForm.Size = new System.Drawing.Size(692, 24);
            this.menuStrip_frmMainForm.TabIndex = 0;
            this.menuStrip_frmMainForm.Text = "menuStrip1";
            // 
            // videoFileToolStripMenuItem
            // 
            this.videoFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_FileInfoScan,
            this.MenuItem_Exit});
            this.videoFileToolStripMenuItem.Name = "videoFileToolStripMenuItem";
            this.videoFileToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.videoFileToolStripMenuItem.Text = "VideoFile";
            // 
            // MenuItem_FileInfoScan
            // 
            this.MenuItem_FileInfoScan.Name = "MenuItem_FileInfoScan";
            this.MenuItem_FileInfoScan.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_FileInfoScan.Text = "FileInfoScan";
            this.MenuItem_FileInfoScan.Click += new System.EventHandler(this.MenuItem_FileInfoScan_Click);
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            this.MenuItem_Exit.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_Exit.Text = "Exit";
            this.MenuItem_Exit.Click += new System.EventHandler(this.MenuItem_Exit_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 473);
            this.Controls.Add(this.menuStrip_frmMainForm);
            this.MainMenuStrip = this.menuStrip_frmMainForm;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "视频分析处理系统";
            this.menuStrip_frmMainForm.ResumeLayout(false);
            this.menuStrip_frmMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_frmMainForm;
        private System.Windows.Forms.ToolStripMenuItem videoFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_FileInfoScan;
        private System.Windows.Forms.OpenFileDialog openFileDialog_VideoFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exit;
    }
}