#region 命名空间
//////////////////////////////////////////////////////////////////////////自动生成的命名空间
using System;
using System.Collections.Generic;
using System.Text;
//////////////////////////////////////////////////////////////////////////手动添加的命名空间
using System.Runtime.InteropServices;   //StructLayout类
using System.Drawing;   //Size类型
#endregion


namespace VideoAnalysisProcessSystem.ClassFile
{
    /// <summary>
    /// 来自uuids.h的主类型
    /// </summary>
    public class MayorTypes
    {
        public static Guid MEDIATYPE_Video = new Guid(0x73646976, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
    }


    /// <summary>
    /// 与视频相关的信息
    /// </summary>
    public class WinStructs
    {
        /// <summary>
        /// 视频信息头结构用来描述视频图像的bitmap和颜色信息
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct VIDEOINFOHEADER
        {
            public RECT rcSource;   //此矩形可以选择原始视频流的一部分
            public RECT rcTarget;   //此矩形可以指定目标视频窗口
            public uint dwBitRate;  //视频流的数据率，单位为bits/s
            public uint dwBitErrorRate; //视频流的数据错误率，单位为bits/s
            public long avgTimePerFrame;    //视频帧的平均显示时间，以100ns为单位
            public BITMAPINFOHEADER bmiHeader;  //视频帧头信息
        };

        /// <summary>
        /// 矩形
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            int left;
            int top;
            int right;
            int bottom;
        };

        /// <summary>
        /// 视频基本信息
        /// </summary>
        //[StructLayout(LayoutKind.Sequential)]
        public struct VIDEOBASICINFO
        {
            public string fileName;
            public double frameRate;
            public Size frameSize;
            public double duringTime;
            public int totalFrames;
        };

        /// <summary>
        /// bitmap信息头结构用来描述bitmap图像的维度和颜色信息。
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct BITMAPINFOHEADER
        {
            public uint biSize; //表示结构所需要的字节数
            public int biWidth; //图像宽度
            public int biHeight;    //图像高度
            public ushort biPlanes; //表示目标设备的平面数，其值必须为1
            public ushort biBitCount;   //表示每个像素的bits数
            public uint biCompression;  //对压缩视频和YUV视频来说，是FOURCC编码
            public uint biSizeImage;    //表示图像的大小(单位为bytes)，当为非压缩的RGB位图时置0
            public int biXPelsPerMeter; //表示目标设备水平分辨率(pixels/meter)
            public int biYPelsPerMeter; //表示目标设备垂直分辨率(pixels/meter)
            public uint biClrUsed;  //表示颜色表中的颜色数
            public uint biClrImportant; //表示重要的颜色数(若值为0，则所遇颜色都重要)
        };
    }
}
