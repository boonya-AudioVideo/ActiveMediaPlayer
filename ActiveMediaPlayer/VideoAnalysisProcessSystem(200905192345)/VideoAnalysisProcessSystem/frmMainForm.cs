#region 命名空间
//////////////////////////////////////////////////////////////////////////自动生成的命名空间
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//////////////////////////////////////////////////////////////////////////手动添加的命名空间

#endregion


namespace VideoAnalysisProcessSystem
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 视频文件/文件信息浏览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_FileInfoScan_Click(object sender, EventArgs e)
        {
            openFileDialog_VideoFile.Filter = "AVI File|*.avi|MPG File|*.mpg|WMV File|*.wmv|MPEG File|*.mpeg |RM File|*.rm|RMVB File|*.rmvb|ASF File|*.asf|All File|*.*";
            openFileDialog_VideoFile.InitialDirectory = "F:\\";
            openFileDialog_VideoFile.Title = "Open Video File";
            if (openFileDialog_VideoFile.ShowDialog() == DialogResult.OK)
            {
                frmVideoInfoScan videoInfoScan = new frmVideoInfoScan(openFileDialog_VideoFile.FileName);
                videoInfoScan.ShowDialog(); 
            }           
        }

        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}