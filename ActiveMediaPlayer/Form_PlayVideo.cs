using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;   //在Visual C#中调用dll动态库和API函数必需
using VideoAnalysisProcessSystem.ClassFile;
using System.Threading;


namespace ActiveMediaPlayer
{
    public partial class Form_PlayVideo : Form
    {

        public static string VideoFormat = "";     //定义视频格式
        public Image currentFrame = null;         //存放当前抓取的帧
        public Image previousFrame = null;        //前一帧
        public Image nextFrame = null;            //下一帧

        public int FrameNum = -1;                  //记录当前帧的编号
        public int TotalFrameNum = 0;              //记录当前视频的总帧数

        public Form_PlayVideo()
        {
            InitializeComponent();
        }
        private Video MyVideo = null; 

        /// <summary>
        /// 打开视频文件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 记录panel组件的大小
                int height = pictureBox_VideoWindow.Height;
                int width = pictureBox_VideoWindow.Width;

                // 如果存在打开的Video文件，释放它
                if (MyVideo != null)
                {
                    MyVideo.Dispose();
                }
                // 打开一个新的Video文件
                MyVideo = new Video(openFileDialog1.FileName);
                // 把Video文件分配给创建的Panel组件
                MyVideo.Owner = pictureBox_VideoWindow;
                // 以记录的panel组件的大小来重新定义
                pictureBox_VideoWindow.Width = width;
                pictureBox_VideoWindow.Height = height;

               
                //初始化视频播放的控件
                trackBar_Process.Minimum = 0;
                trackBar_Process.Maximum = (int)MyVideo.Duration;
                ShowVideoDuration();        //计算并显示视频的时间长度
                
                
                //分析视频的格式
                VideoFormat = openFileDialog1.FileName.Substring(openFileDialog1.FileName.Length - 3, 3);
                if (VideoFormat == "asf")                    //如果是asf格式的视频，则默认帧率为30
                {
                    TotalFrameNum = (int)MyVideo.Duration * 30;
                }
                else
                {
                    TotalFrameNum = (int)(MyVideo.Duration / MyVideo.AverageTimePerFrame);
                }

                // 播放视频文件的第一帧，主要是为了在panel中显示
                MyVideo.Play();
                MyVideo.Pause();
                
            }
            //确定窗体中的各按钮状态
            if (MyVideo == null)
            {
                button_Play.Enabled = false;
                button_Pause.Enabled = false;
                button_Stop.Enabled = false;
            }
            else
            {
                button_Play.Enabled = true;
                button_Pause.Enabled = true;
                button_Stop.Enabled = true;
            }

        }

        /// <summary>
        /// 计算并显示视频的时间长度。
        /// </summary>
        private void ShowVideoDuration()
        {
            try
            {
                int hour =(int) MyVideo.Duration /3600;  //求小时
                int temp = (int)MyVideo.Duration % 3600; //小时余下的秒数
                int minute = temp / 60;     //求分
                int second = temp % 60;           //分余下的秒     

                if (hour < 10)
                {
                    label_DurationTime.Text = "/0" + hour.ToString();
                }
                else
                {
                    label_DurationTime.Text = "/" + hour.ToString();
                }
                if (minute < 10)
                {
                    label_DurationTime.Text += ":0" + minute.ToString();
                }
                else
                {
                    label_DurationTime.Text += ":" + minute.ToString();
                }
                if (second < 10)
                {
                    label_DurationTime.Text += ":0" + second.ToString();
                }
                else
                {
                    label_DurationTime.Text += ":" + second.ToString();
                }
               
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// 显示当前视频播放的时间。
        /// </summary>
        private void ShowVideoCurrentTime()
        {
            try
            {
                int hour =(int) MyVideo.CurrentPosition /3600;  //求小时
                int temp = (int)MyVideo.CurrentPosition % 3600; //小时余下的秒数
                int minute = temp / 60;     //求分
                int second = temp % 60;           //分余下的秒     

                if (hour < 10)
                {
                    this.label_CurrentTime.Text = "0" + hour.ToString();
                }
                else
                {
                    label_CurrentTime.Text =  hour.ToString();
                }
                if (minute < 10)
                {
                    label_CurrentTime.Text += ":0" + minute.ToString();
                }
                else
                {
                    label_CurrentTime.Text += ":" + minute.ToString();
                }
                if (second < 10)
                {
                    label_CurrentTime.Text += ":0" + second.ToString();
                }
                else
                {
                    label_CurrentTime.Text += ":" + second.ToString();
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        /// <summary>
        /// 播放。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Play_Click(object sender, EventArgs e)
        {
            if (MyVideo != null)
            {
                MyVideo.Play();
                timer_VideoCurrentTime.Start();
            }

        }

        /// <summary>
        /// 暂停。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Pause_Click(object sender, EventArgs e)
        {
            if (MyVideo != null)
            {
                MyVideo.Pause();
                timer_VideoCurrentTime.Stop();
            }

        }

        /// <summary>
        /// 停止。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Stop_Click(object sender, EventArgs e)
        {
            if (MyVideo != null)
            {
                MyVideo.Stop();
                trackBar_Process.Value = 0;
                ShowVideoCurrentTime();

                timer_VideoCurrentTime.Stop();
            }

        }

        /// <summary>
        /// 窗体加载。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_PlayVideo_Load(object sender, EventArgs e)
        {
            if (MyVideo == null)
            {
                button_Play.Enabled = false;
                button_Pause.Enabled = false;
                button_Stop.Enabled = false;
            }
            else
            {
                button_Play.Enabled = true;
                button_Pause.Enabled = true;
                button_Stop.Enabled = true;
            }
        }

        /// <summary>
        /// 抓图。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CaptureImage_Click(object sender, EventArgs e)
        {           
            try
            {
                if (openFileDialog1.FileName != "")
                {
                    
                    if (MyVideo.CurrentPosition >= 0 && MyVideo.CurrentPosition <= MyVideo.Duration)
                    {
                        double currentTime = MyVideo.CurrentPosition;

                        //分析视频的格式
                        if (VideoFormat == "asf")             //如果是asf格式的视频，则默认帧率为30
                        {
                            FrameNum = (int)(currentTime * 30);
                        }
                        else
                        {
                            FrameNum = (int)(MyVideo.CurrentPosition / MyVideo.AverageTimePerFrame);
                        }

                        //设置文件名
                        string ImageName = "";
                        if (folderBrowserDialog_ImagePath.SelectedPath != "")
                        {
                            ImageName = folderBrowserDialog_ImagePath.SelectedPath + DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒") + FrameNum.ToString() + ".bmp";
                        }
                        else
                        {
                            ImageName = textBox_ImagePath.Text + DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒") + FrameNum.ToString() + ".bmp";
                        }

                        Image tempImage = FrameGrabber.GetFrameFromVideo(openFileDialog1.FileName, FrameNum, Size.Empty, VideoFormat);
                        tempImage.Save(ImageName);
                        pictureBox_GrabFrame.Image = tempImage;
                        currentFrame = tempImage;
                    }
                    
                }
            }
            catch (Exception ex)
            {
            }
        }
     

        /// <summary>
        /// 设置全屏。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_FullScreen_Click(object sender, EventArgs e)
        {
            try
            {
                MyVideo.Fullscreen = true;
            }
            catch (Exception ex)
            {
            }
        }


        /// <summary>
        /// 选择截图保存路径。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ChooseFolder_Click(object sender, EventArgs e)
        {
            try
            {
                //设置初始的文件夹
                folderBrowserDialog_ImagePath.SelectedPath = textBox_ImagePath.Text;

                //设置图像的保存路径
                if (folderBrowserDialog_ImagePath.ShowDialog() == DialogResult.OK)
                {
                    textBox_ImagePath.Text = folderBrowserDialog_ImagePath.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        /// <summary>
        /// 视频拖动。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar_Process_Scroll(object sender, EventArgs e)
        {
            try
            {
                MyVideo.CurrentPosition = trackBar_Process.Value;
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// 时钟事件，用于显示滚动条和时间随视频播放改变。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_VideoCurrentTime_Tick(object sender, EventArgs e)
        {
            try
            {
                ShowVideoCurrentTime();
                trackBar_Process.Value = (int)MyVideo.CurrentPosition;
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// 显示前一帧。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CurrentFrame_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox_GrabFrame.Image = currentFrame;
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// 显示当前帧。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_PreviousFrame_Click(object sender, EventArgs e)
        {
            try
            {
                if (FrameNum >= 2)
                {
                    pictureBox_GrabFrame.Image = FrameGrabber.GetFrameFromVideo(openFileDialog1.FileName, FrameNum - 1, Size.Empty, VideoFormat);
                    previousFrame = FrameGrabber.GetFrameFromVideo(openFileDialog1.FileName, FrameNum - 1, Size.Empty, VideoFormat);
                }
                else
                {
                    MessageBox.Show("当前帧没有前一帧", "提示");
                }
            }
            catch (Exception ex)
            {
            }
        }


        /// <summary>
        /// 显示下一帧。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_NextFrame_Click(object sender, EventArgs e)
        {
            try
            {
                if (FrameNum + 1 <= TotalFrameNum)
                {
                    pictureBox_GrabFrame.Image = FrameGrabber.GetFrameFromVideo(openFileDialog1.FileName, FrameNum + 1, Size.Empty, VideoFormat);
                    nextFrame = FrameGrabber.GetFrameFromVideo(openFileDialog1.FileName, FrameNum + 1, Size.Empty, VideoFormat);
                }
                else
                {
                    MessageBox.Show("当前帧没有前一帧", "提示");
                }
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// 减速播放。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_DecreaseRate_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// 加速播放。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_IncreaseRate_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// 单帧播放。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_FrameStep_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < TotalFrameNum; i++)
                {
                    pictureBox_GrabFrame.Refresh();
                    Application.DoEvents();
                    pictureBox_GrabFrame.Image = FrameGrabber.GetFrameFromVideo(openFileDialog1.FileName, i, Size.Empty, VideoFormat);
                    Thread.Sleep(500);
                }
            }
            catch (Exception ex)
            {
            }

        }

        private void button_NormalRate_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
            }
        }

        private void timer_PlaySpeed_Tick(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                
            }
        }


    }
}