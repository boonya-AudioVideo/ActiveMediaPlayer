#region 版权说明
#endregion

#region 命名空间
//////////////////////////////////////////////////////////////////////////自动生成的命名空间
using System;
using System.Collections.Generic;
using System.Text;
//////////////////////////////////////////////////////////////////////////手动添加的命名空间
using System.Drawing;   //Bitmap类,Imaging空间
using System.Runtime.InteropServices;   //Marshal类
using DexterLib;    //MediaDetClass类 _AMMediaType结构
using VideoAnalysisProcessSystem.ClassFile; //InvalidVideoFileException类




#endregion

namespace VideoAnalysisProcessSystem.ClassFile
{
    /// <summary>
    /// 从视频文件中抓取某桢图片，用于生成视频文件的缩略图
    /// 支持格式有wmv,rm,avi,rmvb,mpg,mepg,asf
    /// 主要使用的是DexterLib中的媒体探测器类(MediaDetClass)中的函数
    /// 媒体探测器这个组件的CLSID为CLSID_MediaDet，实现的接口为ImediaDet。它有两种工作模式。信息获取模式和抓图模式。
    /// 当组件创建后，初始为信息获取模式；我们可以调用接口方法EnterBitmapGrabMode、GetBitmapBits或WriteBitmapBits进入抓图模式。
    /// 但要注意，进入抓图模式之后，将不能再返回到信息获取模式。
    /// 当媒体探测器工作在抓图模式时,一般也是首先在信息获取模式下选择一个想要抓取的输出流,然后调用MediaDetClass::WriteBitmapBits()抓取指定时刻的那一帧
    /// </summary>
    public class FrameGrabber
    {
        //////////////////////////////////////////////////////////////////////////公有函数       
        /// <summary>
        /// 从视频文件的特定位置抽取一帧图像
        /// </summary>
        /// <param name="videoFile">视频文件的绝对路径</param>
        /// <param name="percentagePosition">抽取帧的位置，合法范围是0.0-1.0</param>
        /// <param name="streamLength">视频流的长度(秒)</param>
        /// <param name="target">限制图像的大小，如果为空则为原视频帧的大小</param>
        /// <param name="videoformate">视频的格式，主要是判断判断判asf格式视频</param>
        /// <returns></returns>
        public static Bitmap GetFrameFromVideo(string videoFile, int currentFrameNo, Size target,string videoformate)
        {
            //视频文件的绝对路径为空时，抛出异常
            if (string.IsNullOrEmpty(videoFile))
            {
                throw new ArgumentNullException("videoFile");
            }
            
            try
            {
                MediaDetClass mediaDet; //定义媒体探测器类的对象
                _AMMediaType mediaType;
                //打开视频流时，获取相应的信息
                if (OpenVideoStream(videoFile, out mediaDet, out mediaType))
                {
                    double streamLength = mediaDet.StreamLength;   //获取当前视频流的总时间长度


                    double frameRate;      //获取视频流的输出帧率
                    if (videoformate == "asf")
                    {
                        frameRate = 30;     //默认为30
                    }
                    else
                    {
                        frameRate = mediaDet.FrameRate;
                    }

                    double dlTotalFrames = Math.Floor(streamLength * frameRate);    //获取视频总帧数(可能与实际的总帧数相差1)
                    int itTotalFrames = Convert.ToInt32(dlTotalFrames); //将视频总帧数转化为整数
                    if (currentFrameNo < 0 || currentFrameNo > itTotalFrames)
                    {
                        throw new ArgumentOutOfRangeException("currentFrameNo", currentFrameNo, "Invalid FrameNo!");
                    }
                    double percentagePosition = currentFrameNo / dlTotalFrames;
                    Size videoFrameSize = GetVideoSize(mediaType);
                    //获取视频帧的大小
                    if (target == Size.Empty)
                    {
                        target = videoFrameSize; 
                    }
                    else
                    {
                        target = ScaleToFit(target, videoFrameSize);
                    }

                    //使用MediaDetClass::GetBitmapBits()获取视频帧
                    unsafe
                    {
                        int bmpInfoHeaderSize = sizeof(WinStructs.BITMAPINFOHEADER); //
                        //获取图像缓冲区大小(包括图像头)
                        int bufferSize = ((target.Width * target.Height) * 24) / 8 + bmpInfoHeaderSize;   //等效mediaDet.GetBitmapBits(0d, ref bufferSize, ref *buffer, target.Width, target.Height)
                        //分配足够内存来存储视频帧
                        IntPtr frameBuffer = Marshal.AllocHGlobal(bufferSize);
                        byte* pFrameBuffer = (byte*)frameBuffer.ToPointer();
                        //取得视频帧，放入frameBuffer(BITMAPINFOHEADER结构类型)
                        mediaDet.GetBitmapBits(streamLength * percentagePosition, ref bufferSize, ref *pFrameBuffer, target.Width, target.Height);

                        int bytes = target.Width * target.Height * 3;   //获取图像数据的大小
                        byte[] rgbValues = new byte[bytes];
                        Marshal.Copy(frameBuffer, rgbValues, 0, bytes); //数据从InPtr指定的内存复制到一维字节数组中
                        double colorTemp = 0;   //用于保存像素的灰度值
                        for (int i = 0; i < rgbValues.Length; i += 3)
                        {
                            //在一维字节数组中按BGR排列，即[0]为B,[1]为G,[2]为R，i一次自增3.
                            colorTemp = rgbValues[i + 2] * 0.299 + rgbValues[i + 1] * 0.587 + rgbValues[i] * 0.114;
                            rgbValues[i + 2] = rgbValues[i + 1] = rgbValues[i] = (byte)colorTemp;
                        }
                        Marshal.Copy(rgbValues, 0, frameBuffer, bytes); //数据从一维字节数组复制到InPtr指定的内存中
                        Bitmap bmp = new Bitmap(target.Width, target.Height, target.Width * 3, System.Drawing.Imaging.PixelFormat.Format24bppRgb,new IntPtr(pFrameBuffer + bmpInfoHeaderSize) );
                        bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
                        Marshal.FreeHGlobal(frameBuffer);
                        return bmp;
                    }
                }
            }
            catch (COMException ex)
            {
                throw new InvalidVideoFileException(ErrorProcess.GetErrorMsg((uint)ex.ErrorCode), ex);
            }
            throw new InvalidVideoFileException("没有视频流文件！");
        }


        /// <summary>
        /// 获得视频文件的基本信息
        /// </summary>
        /// <param name="videoFile">视频文件的绝对路径</param>
        /// <returns>视频文件的基本信息</returns>
        public static WinStructs.VIDEOBASICINFO GetVideoBasicInfo(string videoFile)
        {
            MediaDetClass mediaDet;
            _AMMediaType mediaType;
            WinStructs.VIDEOBASICINFO videoBasicInfo;
            if (OpenVideoStream(videoFile, out mediaDet, out mediaType))
            {
                videoBasicInfo.fileName = mediaDet.Filename;
                videoBasicInfo.frameRate = mediaDet.FrameRate;
                videoBasicInfo.frameRate = 20;
                videoBasicInfo.frameSize = GetVideoSize(mediaType);
                videoBasicInfo.duringTime = mediaDet.StreamLength;
                videoBasicInfo.totalFrames = Convert.ToInt32(Math.Floor(20 * mediaDet.StreamLength));
            }
            else
            {
                videoBasicInfo.fileName = "";
                videoBasicInfo.frameRate = 0.0;
                videoBasicInfo.frameSize = new Size(0, 0);
                videoBasicInfo.duringTime = 0.0;
                videoBasicInfo.totalFrames = 0;
            }
            return videoBasicInfo;
        }


        //////////////////////////////////////////////////////////////////////////私有函数
        /// <summary>
        /// 如果打开视频文件成功,便可以正常实例化成为一个合法的对象
        /// </summary>
        /// <param name="videoFile">视频文件的绝对路径</param>
        /// <param name="mediaDetClass">MediaDetClass类的实例</param>
        /// <param name="aMMediaType">视频类型</param>
        /// <returns>true为找到视频流，false为没有发现视频流(或不支持此视频格式)</returns>
        private static bool OpenVideoStream(string videoFile, out MediaDetClass mediaDetClass, out _AMMediaType aMMediaType)
        {
            MediaDetClass mediaDet = new MediaDetClass();
            mediaDet.Filename = videoFile;  //加载视频文件
            int streamsNumber = mediaDet.OutputStreams; //获得输出流的个数(只统计媒体类型为MEDIATYPE_Video和MEDIATYPE_Audio的流)
            //获得视频文件流,并抓取一帧
            for (int i = 0; i < streamsNumber; i++)
            {
                mediaDet.CurrentStream = i;
                _AMMediaType mediaType = mediaDet.StreamMediaType;
                //发现流媒体类型为视频时，传出对象
                if (mediaType.majortype == MayorTypes.MEDIATYPE_Video)
                {
                    mediaDetClass = mediaDet;
                    aMMediaType = mediaType;
                    return true;
                }
            }
            //没有发现视频流时，对象置空
            mediaDetClass = null;
            aMMediaType = new _AMMediaType();
            return false;
        }

        /// <summary>
        /// 从视频文件里面获得视频帧的大小(宽和高)
        /// </summary>
        /// <param name="mediaType"></param>
        /// <returns></returns>
        private static Size GetVideoSize(_AMMediaType mediaType)
        {
            WinStructs.VIDEOINFOHEADER videoInfo = (WinStructs.VIDEOINFOHEADER)Marshal.PtrToStructure(mediaType.pbFormat, typeof(WinStructs.VIDEOINFOHEADER));
            return new Size(videoInfo.bmiHeader.biWidth, videoInfo.bmiHeader.biHeight);
        }

        /// <summary>
        /// 规划为合适大小
        /// </summary>
        /// <param name="target">目标大小</param>
        /// <param name="original">源大小</param>
        /// <returns>实际大小</returns>
        private static Size ScaleToFit(Size target, Size original)
        {
            if (target.Height * original.Width > target.Width * original.Height)
            {
                target.Height = target.Width * original.Height / original.Width;
            }
            else
            {
                target.Width = target.Height * original.Width / original.Height;
            }
            return target;
        }



        //////////////////////////////////////////////////////////////////////////保留函数
        /// <summary>
        /// 获得视频文件帧大小
        /// </summary>
        /// <param name="videoFile">视频文件的绝对路径</param>
        /// <returns>视频文件帧大小,返回Size.Empty表示没有视频流或不支持此视频格式</returns>
        public static Size GetVideoSize(string videoFile)
        {
            MediaDetClass mediaDet;
            _AMMediaType mediaType;
            if (OpenVideoStream(videoFile, out mediaDet, out mediaType))
            {
                return GetVideoSize(mediaType);
            }

            return Size.Empty;
        }
    }
}
