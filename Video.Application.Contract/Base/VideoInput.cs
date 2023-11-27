using System;
using System.Collections.Generic;
using System.Text;

namespace Video.Application.Contract.Base
{
    /// <summary>
    /// 视频
    /// </summary>
    public class VideoInput
    {
        public string? KeyWord { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }


    }
}
