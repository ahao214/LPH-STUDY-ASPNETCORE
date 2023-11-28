using Masa.BuildingBlocks.Ddd.Domain.Entities.Auditing;

namespace Video.Service.Domain.Video.Aggregates
{
    /// <summary>
    /// 视频播放记录
    /// </summary>
    public class VideoPlayRecords : Entity<long>, IAuditEntity<long>
    {
        public long videoId;
        public DateTime playTime;

        /// <summary>
        /// 视频ID
        /// </summary>
        public long VideoId { get => videoId; private set => videoId = value; }
        /// <summary>
        /// 播放时间
        /// </summary>
        public DateTime PlayTime { get => playTime; private set => playTime = value; }

        public long Creator { get; private set; }

        public DateTime CreationTime { get; private set; }

        public long Modifier { get; private set; }

        public DateTime ModificationTime { get; private set; }


        public VideoPlayRecords()
        {

        }

        public VideoPlayRecords(long videoId, DateTime playTime)
        {
            VideoId = videoId;
            PlayTime = playTime;

        }
    }

}
