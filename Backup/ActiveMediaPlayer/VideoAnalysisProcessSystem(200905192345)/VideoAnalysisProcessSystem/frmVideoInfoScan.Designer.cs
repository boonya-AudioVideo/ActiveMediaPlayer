namespace VideoAnalysisProcessSystem
{
    partial class frmVideoInfoScan
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
            this.buttonVideoInfoScan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.propertyGrid_Media = new System.Windows.Forms.PropertyGrid();
            this.textBox_IntervalNum = new System.Windows.Forms.TextBox();
            this.label_IntervalNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVideoInfoScan
            // 
            this.buttonVideoInfoScan.Location = new System.Drawing.Point(270, 5);
            this.buttonVideoInfoScan.Name = "buttonVideoInfoScan";
            this.buttonVideoInfoScan.Size = new System.Drawing.Size(93, 28);
            this.buttonVideoInfoScan.TabIndex = 0;
            this.buttonVideoInfoScan.Text = "浏览";
            this.buttonVideoInfoScan.UseVisualStyleBackColor = true;
            this.buttonVideoInfoScan.Click += new System.EventHandler(this.buttonVideoInfoScan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(2, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(498, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(93, 28);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // propertyGrid_Media
            // 
            this.propertyGrid_Media.Location = new System.Drawing.Point(408, 41);
            this.propertyGrid_Media.Name = "propertyGrid_Media";
            this.propertyGrid_Media.Size = new System.Drawing.Size(280, 300);
            this.propertyGrid_Media.TabIndex = 2;
            // 
            // textBox_IntervalNum
            // 
            this.textBox_IntervalNum.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_IntervalNum.Location = new System.Drawing.Point(126, 6);
            this.textBox_IntervalNum.MaxLength = 3;
            this.textBox_IntervalNum.Name = "textBox_IntervalNum";
            this.textBox_IntervalNum.Size = new System.Drawing.Size(50, 27);
            this.textBox_IntervalNum.TabIndex = 3;
            this.textBox_IntervalNum.Text = "10";
            this.textBox_IntervalNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_IntervalNum
            // 
            this.label_IntervalNum.AutoSize = true;
            this.label_IntervalNum.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_IntervalNum.Location = new System.Drawing.Point(28, 10);
            this.label_IntervalNum.Name = "label_IntervalNum";
            this.label_IntervalNum.Size = new System.Drawing.Size(89, 18);
            this.label_IntervalNum.TabIndex = 4;
            this.label_IntervalNum.Text = "间隔帧数:";
            // 
            // frmVideoInfoScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 353);
            this.Controls.Add(this.label_IntervalNum);
            this.Controls.Add(this.textBox_IntervalNum);
            this.Controls.Add(this.propertyGrid_Media);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonVideoInfoScan);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 380);
            this.MinimumSize = new System.Drawing.Size(700, 380);
            this.Name = "frmVideoInfoScan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "视频信息浏览";
            this.Load += new System.EventHandler(this.frmVideoInfoScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVideoInfoScan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PropertyGrid propertyGrid_Media;
        private System.Windows.Forms.TextBox textBox_IntervalNum;
        private System.Windows.Forms.Label label_IntervalNum;
    }
}

