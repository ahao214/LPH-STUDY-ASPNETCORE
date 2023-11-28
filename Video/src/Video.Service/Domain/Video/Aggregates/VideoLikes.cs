using System.Diagnostics.Eventing.Reader;

namespace Video.Service.Domain.Video.Aggregates
{
    /// <summary>
    /// 点赞表
    /// </summary>
    public class VideoLikes
    {
        public long Id { get; set; }
        /// <summary>
        /// 视频ID
        /// </summary>
        public long VideoId { get; set; }
        /// <summary>
        /// 点赞用户ID
        /// </summary>
        public long UserId { get; set; }
    }
}
