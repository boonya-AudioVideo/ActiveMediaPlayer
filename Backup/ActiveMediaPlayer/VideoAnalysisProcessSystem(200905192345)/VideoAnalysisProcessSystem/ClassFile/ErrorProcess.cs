#region 命名空间
//////////////////////////////////////////////////////////////////////////自动生成的命名空间
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace VideoAnalysisProcessSystem.ClassFile
{
    /// <summary>
    /// 异常处理类
    /// </summary>
    public class ErrorProcess
    {
        /// <summary>
		/// 获得错误消息(vfwmsgs.h)
		/// </summary>
		/// <param name="errorCode">错误代码</param>
		/// <returns>错误信息</returns>
		public static string GetErrorMsg(uint errorCode)
        {
            string errorMsg = null;
			switch(errorCode)
            {
                case 0x80040200:	//VFW_E_INVALIDMEDIATYPE
                    errorMsg = "An invalid media type was specified";
                    break;
                case 0x80040201:	//VFW_E_INVALIDSUBTYPE
                    errorMsg = "An invalid media subtype was specified";
                    break;
                case 0x80040202:	//VFW_E_NEED_OWNER
                    errorMsg = "This object can only be created as an aggregated object";
                    break;
                case 0x80040203:	//VFW_E_ENUM_OUT_OF_SYNC
                    errorMsg = "The enumerator has become invalid";
                    break;
                case 0x80040204:	//VFW_E_ALREADY_CONNECTED
                    errorMsg = "At least one of the pins involved in the operation is already connected";
                    break;
                case 0x80040205:	//VFW_E_FILTER_ACTIVE
                    errorMsg = "This operation cannot be performed because the filter is active";
                    break;
                case 0x80040206:	//VFW_E_NO_TYPES
                    errorMsg = "One of the specified pins supports no media types";
                    break;
                case 0x80040207:	//VFW_E_NO_ACCEPTABLE_TYPES
                    errorMsg = "There is no common media type between these pins";
                    break;
                case 0x80040208:	//VFW_E_INVALID_DIRECTION
                    errorMsg = "Two pins of the same direction cannot be connected together";
                    break;
                case 0x80040209:	//VFW_E_NOT_CONNECTED
                    errorMsg = "The operation cannot be performed because the pins are not connected";
                    break;
                case 0x80040210:	//VFW_E_NO_ALLOCATOR
                    errorMsg = "No sample buffer allocator is available";
                    break;
                case 0x80040211:	//VFW_E_NOT_COMMITTED
                    errorMsg = "Cannot allocate a sample when the allocator is not active";
                    break;
                case 0x80040212:	//VFW_E_SIZENOTSET
                    errorMsg = "Cannot allocate memory because no size has been set";
                    break;
                case 0x80040213:	//VFW_E_NO_CLOCK
                    errorMsg = "Cannot lock for synchronization because no clock has been defined";
                    break;
                case 0x80040214:	//VFW_E_NO_SINK
                    errorMsg = "Quality messages could not be sent because no quality sink has been defined";
                    break;
                case 0x80040215:	//VFW_E_NO_INTERFACE
                    errorMsg = "A required interface has not been implemented";
                    break;
                case 0x80040216:	//VFW_E_NOT_FOUND
                    errorMsg = "An object or name was not found";
                    break;
                case 0x80040217:	//VFW_E_CANNOT_CONNECT
                    errorMsg = "No combination of intermediate filters could be found to make the connection";
                    break;
                case 0x80040218:	//VFW_E_CANNOT_RENDER
                    errorMsg = "No combination of filters could be found to render the stream";
                    break;
                case 0x80040219:	//VFW_E_CHANGING_FORMAT
                    errorMsg = "Could not change formats dynamically";
                    break;
                case 0x80040220:	//VFW_E_NO_COLOR_KEY_SET
                    errorMsg = "No color key has been set";
                    break;
                case 0x80040221:	//VFW_E_NO_DISPLAY_PALETTE
                    errorMsg = "Display does not use a palette";
                    break;
                case 0x80040222:	//VFW_E_TOO_MANY_COLORS
                    errorMsg = "Too many colors for the current display settings";
                    break;
                case 0x80040223:	//VFW_E_STATE_CHANGED
                    errorMsg = "The state changed while waiting to process the sample";
                    break;
                case 0x80040224:	//VFW_E_NOT_STOPPED
                    errorMsg = "The operation could not be performed because the filter is not stopped";
                    break;
                case 0x80040225:	//VFW_E_NOT_PAUSED
                    errorMsg = "The operation could not be performed because the filter is not paused";
                    break;
                case 0x80040226:	//VFW_E_NOT_RUNNING
                    errorMsg = "The operation could not be performed because the filter is not running";
                    break;
                case 0x80040227:	//VFW_E_WRONG_STATE
                    errorMsg = "The operation could not be performed because the filter is in the wrong state";
                    break;
                case 0x80040228:	//VFW_E_START_TIME_AFTER_END
                    errorMsg = "The sample start time is after the sample end time";
                    break;
                case 0x80040229:	//VFW_E_INVALID_RECT
                    errorMsg = "The supplied rectangle is invalid";
                    break;
                case 0x80040230:	//VFW_E_TYPE_NOT_ACCEPTED
                    errorMsg = "This pin cannot use the supplied media type";
                    break;
                case 0x80040231:	//VFW_E_CIRCULAR_GRAPH
                    errorMsg = "The filter graph is circular";
                    break;
                case 0x80040232:	//VFW_E_NOT_ALLOWED_TO_SAVE
                    errorMsg = "Updates are not allowed in this state";
                    break;
                case 0x80040233:	//VFW_E_TIME_ALREADY_PASSED
                    errorMsg = "An attempt was made to queue a command for a time in the past";
                    break;
                case 0x80040234:	//VFW_E_ALREADY_CANCELLED
                    errorMsg = "The queued command has already been canceled";
                    break;
                case 0x80040235:	//VFW_E_CORRUPT_GRAPH_FILE
                    errorMsg = "Cannot render the file because it is corrupt";
                    break;
                case 0x80040236:	//VFW_E_ADVISE_ALREADY_SET
                    errorMsg = "An overlay advise link already exists";
                    break;
                case 0x00040237:	//VFW_S_STATE_INTERMEDIATE
                    errorMsg = "The state transition has not completed";
                    break;
                case 0x80040239:	//VFW_E_NO_MODEX_AVAILABLE
                    errorMsg = "This Advise cannot be canceled because it was not successfully set";
                    break;
                case 0x80040240:	//VFW_E_NO_FULLSCREEN
                    errorMsg = "The media type of this file is not recognized";
                    break;
                case 0x80040241:	//VFW_E_CANNOT_LOAD_SOURCE_FILTER
                    errorMsg = "The source filter for this file could not be loaded";
                    break;
                case 0x00040242:	//VFW_S_PARTIAL_RENDER
                    errorMsg = "Some of the streams in this movie are in an unsupported format";
                    break;
                case 0x80040243:	//VFW_E_FILE_TOO_SHORT
                    errorMsg = "A file appeared to be incomplete";
                    break;
                case 0x80040244:	//VFW_E_INVALID_FILE_VERSION
                    errorMsg = "The version number of the file is invalid";
                    break;
                case 0x00040245:	//VFW_S_SOME_DATA_IGNORED
                    errorMsg = "The file contained some property settings that were not used";
                    break;
                case 0x00040246:	//VFW_S_CONNECTIONS_DEFERRED
                    errorMsg = "Some connections have failed and have been deferred";
                    break;
                case 0x00040103:	//VFW_E_INVALID_CLSID
                    errorMsg = "A registry entry is corrupt";
                    break;
                case 0x80040249:	//VFW_E_SAMPLE_TIME_NOT_SET
                    errorMsg = "No time stamp has been set for this sample";
                    break;
                case 0x00040250:	//VFW_S_RESOURCE_NOT_NEEDED
                    errorMsg = "The resource specified is no longer needed";
                    break;
                case 0x80040251:	//VFW_E_MEDIA_TIME_NOT_SET
                    errorMsg = "No media time stamp has been set for this sample";
                    break;
                case 0x80040252:	//VFW_E_NO_TIME_FORMAT_SET
                    errorMsg = "No media time format has been selected";
                    break;
                case 0x80040253:	//VFW_E_MONO_AUDIO_HW
                    errorMsg = "Cannot change balance because audio device is mono only";
                    break;
                case 0x00040260:	//VFW_S_MEDIA_TYPE_IGNORED
                    errorMsg = "ActiveMovie cannot play MPEG movies on this processor";
                    break;
                case 0x80040261:	//VFW_E_NO_TIME_FORMAT
                    errorMsg = "Cannot get or set time related information on an object that is using a time format of TIME_FORMAT_NONE";
                    break;
                case 0x80040262:	//VFW_E_READ_ONLY
                    errorMsg = "The connection cannot be made because the stream is read only and the filter alters the data";
                    break;
                case 0x00040263:	//VFW_S_RESERVED
                    errorMsg = "This success code is reserved for internal purposes within ActiveMovie";
                    break;
                case 0x80040264:	//VFW_E_BUFFER_UNDERFLOW
                    errorMsg = "The buffer is not full enough";
                    break;
                case 0x80040266:	//VFW_E_UNSUPPORTED_STREAM
                    errorMsg = "Pins cannot connect due to not supporting the same transport";
                    break;
                case 0x00040267:	//VFW_S_STREAM_OFF
                    errorMsg = "The stream has been turned off";
                    break;
                case 0x00040270:	//VFW_S_CANT_CUE
                    errorMsg = "The stop time for the sample was not set";
                    break;
                case 0x80040272:	//VFW_E_OUT_OF_VIDEO_MEMORY
                    errorMsg = "The VideoPort connection negotiation process has failed";
                    break;
                case 0x80040276:	//VFW_E_DDRAW_CAPS_NOT_SUITABLE
                    errorMsg = "This User Operation is inhibited by DVD Content at this time";
                    break;
                case 0x80040277:	//VFW_E_DVD_INVALIDDOMAIN
                    errorMsg = "This Operation is not permitted in the current domain";
                    break;
                case 0x00040280:	//VFW_E_DVD_NO_BUTTON
                    errorMsg = "This object cannot be used anymore as its time has expired";
                    break;
                case 0x80040281:	//VFW_E_DVD_WRONG_SPEED
                    errorMsg = "The operation cannot be performed at the current playback speed";
                    break;
                case 0x80040283:	//VFW_E_DVD_MENU_DOES_NOT_EXIST
                    errorMsg = "The specified command was either cancelled or no longer exists";
                    break;
                case 0x80040284:	//VFW_E_DVD_STATE_WRONG_VERSION
                    errorMsg = "The data did not contain a recognized version";
                    break;
                case 0x80040285:	//VFW_E_DVD_STATE_CORRUPT
                    errorMsg = "The state data was corrupt";
                    break;
                case 0x80040286:	//VFW_E_DVD_STATE_WRONG_DISC
                    errorMsg = "The state data is from a different disc";
                    break;
                case 0x80040287:	//VFW_E_DVD_INCOMPATIBLE_REGION
                    errorMsg = "The region was not compatible with the current drive";
                    break;
                case 0x80040288:	//VFW_E_DVD_NO_ATTRIBUTES
                    errorMsg = "The requested DVD stream attribute does not exist";
                    break;
                case 0x80040290:	//VFW_E_DVD_NO_GOUP_PGC
                    errorMsg = "The current parental level was too low";
                    break;
                case 0x80040291:	//VFW_E_DVD_INVALID_DISC
                    errorMsg = "The specified path does not point to a valid DVD disc";
                    break;
                case 0x80040292:	//VFW_E_DVD_NO_RESUME_INFORMATION
                    errorMsg = "There is currently no resume information";
                    break;
                case 0x80040295:	//VFW_E_PIN_ALREADY_BLOCKED_ON_THIS_THREAD
                    errorMsg = "An operation failed due to a certification failure";
                    break;
                case 0x80040296:	//VFW_E_VMR_NOT_IN_MIXER_MODE
                    errorMsg = "The VMR could not find any ProcAmp hardware on the current display device";
                    break;
                case 0x80040297:	//VFW_E_VMR_NO_AP_SUPPLIED
                    errorMsg = "The application has not yet provided the VMR filter with a valid allocator-presenter object";
                    break;
                case 0x80040298:	//VFW_E_VMR_NO_DEINTERLACE_HW
                    errorMsg = "The VMR could not find any ProcAmp hardware on the current display device";
                    break;
                case 0x80040299:	//VFW_E_VMR_NO_PROCAMP_HW
                    errorMsg = "VMR9 does not work with VPE-based hardware decoders";
                    break;
                case 0x8004029A:	//VFW_E_DVD_VMR9_INCOMPATIBLEDEC
                    errorMsg = "VMR9 does not work with VPE-based hardware decoders";
                    break;
                case 0x8004029B:	//VFW_E_NO_COPP_HW
                    errorMsg = "The current display device does not support Content Output Protection Protocol (COPP) H/W";
                    break;
            }
            return errorMsg;
        }
    }

    /// <summary>
    /// 非法视频文件异常
    /// </summary>
    public class InvalidVideoFileException : System.Exception
    {
        public InvalidVideoFileException() : base() { }
        public InvalidVideoFileException(string message) : base(message) { }
        public InvalidVideoFileException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        public InvalidVideoFileException(string message, Exception innerException) : base(message, innerException) { }
    }
    
}
