using Masa.BuildingBlocks.Ddd.Domain.Entities.Auditing;

namespace Video.Service.Domain.Video.Aggregates
{
    /// <summary>
    /// 视频评论
    /// </summary>
    public class VideoComments : Entity<long>
    {
        public long videoId;
        public string comment;
        public long? parentId;



        /// <summary>
        /// 视频ID
        /// </summary>
        public long VideoId { get => videoId; private set => videoId = value; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Comment { get => comment; private set => comment = value; }

        public long? ParentId { get => parentId; private set => parentId = value; }


        public long Create { get; private set; }

        public DateTime CreationTime { get; private set; }

        public long Modifier { get; private set; }

        public DateTime ModificationTime { get; private set; }


        public VideoComments()
        {
        }

        public VideoComments(long videoId, string comment, long? parentId)
        {
            if (videoId == null)
                throw new UserFriendlyException("视频id为空");

            if (comment == null)
                throw new UserFriendlyException("你的评论为空");

            VideoId = videoId;
            Comment = comment;
            ParentId = parentId;
        }
    }
}
