namespace ActiveMediaPlayer
{
    partial class Form_PlayVideo
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Play = new System.Windows.Forms.Button();
            this.button_Pause = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_CaptureImage = new System.Windows.Forms.Button();
            this.button_FullScreen = new System.Windows.Forms.Button();
            this.trackBar_Process = new System.Windows.Forms.TrackBar();
            this.pictureBox_VideoWindow = new System.Windows.Forms.PictureBox();
            this.label_DurationTime = new System.Windows.Forms.Label();
            this.label_CurrentTime = new System.Windows.Forms.Label();
            this.textBox_ImagePath = new System.Windows.Forms.TextBox();
            this.button_ChooseFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog_ImagePath = new System.Windows.Forms.FolderBrowserDialog();
            this.timer_VideoCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox_QueryCondition = new System.Windows.Forms.GroupBox();
            this.dataGridView_VideoInformation = new System.Windows.Forms.DataGridView();
            this.groupBox_VideoWindow = new System.Windows.Forms.GroupBox();
            this.pictureBox_GrabFrame = new System.Windows.Forms.PictureBox();
            this.groupBox_GrabFrame = new System.Windows.Forms.GroupBox();
            this.button_NextFrame = new System.Windows.Forms.Button();
            this.button_CurrentFrame = new System.Windows.Forms.Button();
            this.button_PreviousFrame = new System.Windows.Forms.Button();
            this.button_DecreaseRate = new System.Windows.Forms.Button();
            this.button_IncreaseRate = new System.Windows.Forms.Button();
            this.button_NormalRate = new System.Windows.Forms.Button();
            this.button_FrameStep = new System.Windows.Forms.Button();
            this.timer_PlaySpeed = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VideoInformation)).BeginInit();
            this.groupBox_VideoWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GrabFrame)).BeginInit();
            this.groupBox_GrabFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(449, 357);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(45, 27);
            this.button_Open.TabIndex = 1;
            this.button_Open.Text = "打开";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Play
            // 
            this.button_Play.Location = new System.Drawing.Point(500, 357);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(45, 27);
            this.button_Play.TabIndex = 2;
            this.button_Play.Text = "播放";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // button_Pause
            // 
            this.button_Pause.Location = new System.Drawing.Point(552, 357);
            this.button_Pause.Name = "button_Pause";
            this.button_Pause.Size = new System.Drawing.Size(42, 28);
            this.button_Pause.TabIndex = 3;
            this.button_Pause.Text = "暂停";
            this.button_Pause.UseVisualStyleBackColor = true;
            this.button_Pause.Click += new System.EventHandler(this.button_Pause_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(602, 357);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(39, 28);
            this.button_Stop.TabIndex = 4;
            this.button_Stop.Text = "停止";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_CaptureImage
            // 
            this.button_CaptureImage.Location = new System.Drawing.Point(945, 357);
            this.button_CaptureImage.Name = "button_CaptureImage";
            this.button_CaptureImage.Size = new System.Drawing.Size(63, 27);
            this.button_CaptureImage.TabIndex = 5;
            this.button_CaptureImage.Text = "抓图";
            this.button_CaptureImage.UseVisualStyleBackColor = true;
            this.button_CaptureImage.Click += new System.EventHandler(this.button_CaptureImage_Click);
            // 
            // button_FullScreen
            // 
            this.button_FullScreen.Location = new System.Drawing.Point(648, 358);
            this.button_FullScreen.Name = "button_FullScreen";
            this.button_FullScreen.Size = new System.Drawing.Size(41, 26);
            this.button_FullScreen.TabIndex = 7;
            this.button_FullScreen.Text = "全屏";
            this.button_FullScreen.UseVisualStyleBackColor = true;
            this.button_FullScreen.Click += new System.EventHandler(this.button_FullScreen_Click);
            // 
            // trackBar_Process
            // 
            this.trackBar_Process.Location = new System.Drawing.Point(449, 310);
            this.trackBar_Process.Name = "trackBar_Process";
            this.trackBar_Process.Size = new System.Drawing.Size(564, 45);
            this.trackBar_Process.TabIndex = 8;
            this.trackBar_Process.Scroll += new System.EventHandler(this.trackBar_Process_Scroll);
            // 
            // pictureBox_VideoWindow
            // 
            this.pictureBox_VideoWindow.BackColor = System.Drawing.SystemColors.MenuText;
            this.pictureBox_VideoWindow.Location = new System.Drawing.Point(27, 12);
            this.pictureBox_VideoWindow.Name = "pictureBox_VideoWindow";
            this.pictureBox_VideoWindow.Size = new System.Drawing.Size(540, 260);
            this.pictureBox_VideoWindow.TabIndex = 6;
            this.pictureBox_VideoWindow.TabStop = false;
            // 
            // label_DurationTime
            // 
            this.label_DurationTime.AutoSize = true;
            this.label_DurationTime.Location = new System.Drawing.Point(943, 298);
            this.label_DurationTime.Name = "label_DurationTime";
            this.label_DurationTime.Size = new System.Drawing.Size(59, 12);
            this.label_DurationTime.TabIndex = 9;
            this.label_DurationTime.Text = "/00:00:00";
            // 
            // label_CurrentTime
            // 
            this.label_CurrentTime.AutoSize = true;
            this.label_CurrentTime.Location = new System.Drawing.Point(888, 298);
            this.label_CurrentTime.Name = "label_CurrentTime";
            this.label_CurrentTime.Size = new System.Drawing.Size(53, 12);
            this.label_CurrentTime.TabIndex = 10;
            this.label_CurrentTime.Text = "00:00:00";
            // 
            // textBox_ImagePath
            // 
            this.textBox_ImagePath.Location = new System.Drawing.Point(703, 360);
            this.textBox_ImagePath.Name = "textBox_ImagePath";
            this.textBox_ImagePath.Size = new System.Drawing.Size(118, 21);
            this.textBox_ImagePath.TabIndex = 11;
            this.textBox_ImagePath.Text = "F:\\";
            // 
            // button_ChooseFolder
            // 
            this.button_ChooseFolder.Location = new System.Drawing.Point(827, 357);
            this.button_ChooseFolder.Name = "button_ChooseFolder";
            this.button_ChooseFolder.Size = new System.Drawing.Size(118, 24);
            this.button_ChooseFolder.TabIndex = 12;
            this.button_ChooseFolder.Text = "选择图像保存路径";
            this.button_ChooseFolder.UseVisualStyleBackColor = true;
            this.button_ChooseFolder.Click += new System.EventHandler(this.button_ChooseFolder_Click);
            // 
            // timer_VideoCurrentTime
            // 
            this.timer_VideoCurrentTime.Tick += new System.EventHandler(this.timer_VideoCurrentTime_Tick);
            // 
            // groupBox_QueryCondition
            // 
            this.groupBox_QueryCondition.Location = new System.Drawing.Point(22, 12);
            this.groupBox_QueryCondition.Name = "groupBox_QueryCondition";
            this.groupBox_QueryCondition.Size = new System.Drawing.Size(382, 275);
            this.groupBox_QueryCondition.TabIndex = 13;
            this.groupBox_QueryCondition.TabStop = false;
            this.groupBox_QueryCondition.Text = "查询条件";
            // 
            // dataGridView_VideoInformation
            // 
            this.dataGridView_VideoInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_VideoInformation.Location = new System.Drawing.Point(22, 321);
            this.dataGridView_VideoInformation.Name = "dataGridView_VideoInformation";
            this.dataGridView_VideoInformation.RowTemplate.Height = 23;
            this.dataGridView_VideoInformation.Size = new System.Drawing.Size(382, 401);
            this.dataGridView_VideoInformation.TabIndex = 14;
            // 
            // groupBox_VideoWindow
            // 
            this.groupBox_VideoWindow.Controls.Add(this.pictureBox_VideoWindow);
            this.groupBox_VideoWindow.Location = new System.Drawing.Point(422, 12);
            this.groupBox_VideoWindow.Name = "groupBox_VideoWindow";
            this.groupBox_VideoWindow.Size = new System.Drawing.Size(591, 283);
            this.groupBox_VideoWindow.TabIndex = 15;
            this.groupBox_VideoWindow.TabStop = false;
            this.groupBox_VideoWindow.Text = "视频窗口";
            // 
            // pictureBox_GrabFrame
            // 
            this.pictureBox_GrabFrame.BackColor = System.Drawing.SystemColors.MenuText;
            this.pictureBox_GrabFrame.Location = new System.Drawing.Point(27, 47);
            this.pictureBox_GrabFrame.Name = "pictureBox_GrabFrame";
            this.pictureBox_GrabFrame.Size = new System.Drawing.Size(540, 260);
            this.pictureBox_GrabFrame.TabIndex = 16;
            this.pictureBox_GrabFrame.TabStop = false;
            // 
            // groupBox_GrabFrame
            // 
            this.groupBox_GrabFrame.Controls.Add(this.button_NextFrame);
            this.groupBox_GrabFrame.Controls.Add(this.button_CurrentFrame);
            this.groupBox_GrabFrame.Controls.Add(this.button_PreviousFrame);
            this.groupBox_GrabFrame.Controls.Add(this.pictureBox_GrabFrame);
            this.groupBox_GrabFrame.Location = new System.Drawing.Point(422, 453);
            this.groupBox_GrabFrame.Name = "groupBox_GrabFrame";
            this.groupBox_GrabFrame.Size = new System.Drawing.Size(580, 313);
            this.groupBox_GrabFrame.TabIndex = 17;
            this.groupBox_GrabFrame.TabStop = false;
            this.groupBox_GrabFrame.Text = "帧显示";
            // 
            // button_NextFrame
            // 
            this.button_NextFrame.Location = new System.Drawing.Point(383, 18);
            this.button_NextFrame.Name = "button_NextFrame";
            this.button_NextFrame.Size = new System.Drawing.Size(75, 23);
            this.button_NextFrame.TabIndex = 19;
            this.button_NextFrame.Text = "下一帧";
            this.button_NextFrame.UseVisualStyleBackColor = true;
            this.button_NextFrame.Click += new System.EventHandler(this.button_NextFrame_Click);
            // 
            // button_CurrentFrame
            // 
            this.button_CurrentFrame.Location = new System.Drawing.Point(226, 18);
            this.button_CurrentFrame.Name = "button_CurrentFrame";
            this.button_CurrentFrame.Size = new System.Drawing.Size(75, 23);
            this.button_CurrentFrame.TabIndex = 18;
            this.button_CurrentFrame.Text = "当前帧";
            this.button_CurrentFrame.UseVisualStyleBackColor = true;
            this.button_CurrentFrame.Click += new System.EventHandler(this.button_CurrentFrame_Click);
            // 
            // button_PreviousFrame
            // 
            this.button_PreviousFrame.Location = new System.Drawing.Point(78, 18);
            this.button_PreviousFrame.Name = "button_PreviousFrame";
            this.button_PreviousFrame.Size = new System.Drawing.Size(75, 23);
            this.button_PreviousFrame.TabIndex = 17;
            this.button_PreviousFrame.Text = "前一帧";
            this.button_PreviousFrame.UseVisualStyleBackColor = true;
            this.button_PreviousFrame.Click += new System.EventHandler(this.button_PreviousFrame_Click);
            // 
            // button_DecreaseRate
            // 
            this.button_DecreaseRate.Location = new System.Drawing.Point(449, 392);
            this.button_DecreaseRate.Name = "button_DecreaseRate";
            this.button_DecreaseRate.Size = new System.Drawing.Size(75, 23);
            this.button_DecreaseRate.TabIndex = 18;
            this.button_DecreaseRate.Text = "减速";
            this.button_DecreaseRate.UseVisualStyleBackColor = true;
            this.button_DecreaseRate.Click += new System.EventHandler(this.button_DecreaseRate_Click);
            // 
            // button_IncreaseRate
            // 
            this.button_IncreaseRate.Location = new System.Drawing.Point(638, 392);
            this.button_IncreaseRate.Name = "button_IncreaseRate";
            this.button_IncreaseRate.Size = new System.Drawing.Size(75, 23);
            this.button_IncreaseRate.TabIndex = 18;
            this.button_IncreaseRate.Text = "加速";
            this.button_IncreaseRate.UseVisualStyleBackColor = true;
            this.button_IncreaseRate.Click += new System.EventHandler(this.button_IncreaseRate_Click);
            // 
            // button_NormalRate
            // 
            this.button_NormalRate.Location = new System.Drawing.Point(541, 392);
            this.button_NormalRate.Name = "button_NormalRate";
            this.button_NormalRate.Size = new System.Drawing.Size(75, 23);
            this.button_NormalRate.TabIndex = 19;
            this.button_NormalRate.Text = "正常播放";
            this.button_NormalRate.UseVisualStyleBackColor = true;
            this.button_NormalRate.Click += new System.EventHandler(this.button_NormalRate_Click);
            // 
            // button_FrameStep
            // 
            this.button_FrameStep.Location = new System.Drawing.Point(736, 392);
            this.button_FrameStep.Name = "button_FrameStep";
            this.button_FrameStep.Size = new System.Drawing.Size(75, 23);
            this.button_FrameStep.TabIndex = 20;
            this.button_FrameStep.Text = "单帧播放";
            this.button_FrameStep.UseVisualStyleBackColor = true;
            this.button_FrameStep.Click += new System.EventHandler(this.button_FrameStep_Click);
            // 
            // timer_PlaySpeed
            // 
            this.timer_PlaySpeed.Tick += new System.EventHandler(this.timer_PlaySpeed_Tick);
            // 
            // Form_PlayVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1100, 778);
            this.Controls.Add(this.button_FrameStep);
            this.Controls.Add(this.button_NormalRate);
            this.Controls.Add(this.button_IncreaseRate);
            this.Controls.Add(this.button_DecreaseRate);
            this.Controls.Add(this.groupBox_GrabFrame);
            this.Controls.Add(this.groupBox_VideoWindow);
            this.Controls.Add(this.dataGridView_VideoInformation);
            this.Controls.Add(this.groupBox_QueryCondition);
            this.Controls.Add(this.button_ChooseFolder);
            this.Controls.Add(this.textBox_ImagePath);
            this.Controls.Add(this.label_CurrentTime);
            this.Controls.Add(this.label_DurationTime);
            this.Controls.Add(this.trackBar_Process);
            this.Controls.Add(this.button_FullScreen);
            this.Controls.Add(this.button_CaptureImage);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Pause);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.button_Open);
            this.Name = "Form_PlayVideo";
            this.Text = "Form_PlayVideo";
            this.Load += new System.EventHandler(this.Form_PlayVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VideoInformation)).EndInit();
            this.groupBox_VideoWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GrabFrame)).EndInit();
            this.groupBox_GrabFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Button button_Pause;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_CaptureImage;
        private System.Windows.Forms.Button button_FullScreen;
        private System.Windows.Forms.TrackBar trackBar_Process;
        private System.Windows.Forms.PictureBox pictureBox_VideoWindow;
        private System.Windows.Forms.Label label_DurationTime;
        private System.Windows.Forms.Label label_CurrentTime;
        private System.Windows.Forms.TextBox textBox_ImagePath;
        private System.Windows.Forms.Button button_ChooseFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_ImagePath;
        private System.Windows.Forms.Timer timer_VideoCurrentTime;
        private System.Windows.Forms.GroupBox groupBox_QueryCondition;
        private System.Windows.Forms.DataGridView dataGridView_VideoInformation;
        private System.Windows.Forms.GroupBox groupBox_VideoWindow;
        private System.Windows.Forms.PictureBox pictureBox_GrabFrame;
        private System.Windows.Forms.GroupBox groupBox_GrabFrame;
        private System.Windows.Forms.Button button_NextFrame;
        private System.Windows.Forms.Button button_CurrentFrame;
        private System.Windows.Forms.Button button_PreviousFrame;
        private System.Windows.Forms.Button button_DecreaseRate;
        private System.Windows.Forms.Button button_IncreaseRate;
        private System.Windows.Forms.Button button_NormalRate;
        private System.Windows.Forms.Button button_FrameStep;
        private System.Windows.Forms.Timer timer_PlaySpeed;
    }
}

