using Masa.BuildingBlocks.Ddd.Domain.Entities.Full;
using System.Text.RegularExpressions;

namespace Video.Service.Domain.Video.Aggregates
{
    /// <summary>
    /// 视频聚合
    /// </summary>
    public class Videos : FullAggregateRoot<long, long>
    {
        /// <summary>
        /// 视频标题
        /// </summary>
        private string title;
        /// <summary>
        /// 视频描述
        /// </summary>
        private string description;
        /// <summary>
        /// 视频地址
        /// </summary>
        private string url;
        /// <summary>
        /// 视频总长度(秒)
        /// </summary>
        private int duration;
        /// <summary>
        /// 浏览量
        /// </summary>
        private int views;

        /// <summary>
        /// 视频标签
        /// </summary>
        private List<string> tags;
        /// <summary>
        /// 视频封面图片地址
        /// </summary>
        private string thumbnailUrl;
        /// <summary>
        /// 视频播放次数
        /// </summary>
        private long playCount;
        /// <summary>
        /// 视频点赞数
        /// </summary>
        private long likes;
        /// <summary>
        /// 视频踩数
        /// </summary>
        private long disLikes;
        /// <summary>
        /// 视频评论数
        /// </summary>
        private long commentsCount;


        /// <summary>
        /// 视频标题
        /// </summary>
        public string Title { get => title; set => title = value; }
        /// <summary>
        /// 视频描述
        /// </summary>
        public string Description { get => description; set => description = value; }
        /// <summary>
        /// 视频地址
        /// </summary>
        public string Url { get => url; set => url = value; }
        /// <summary>
        /// 视频总长度(秒)
        /// </summary>
        public int Duration { get => duration; private set => duration = value; }
        /// <summary>
        /// 浏览量
        /// </summary>
        public int Views { get => views; private set => views = value; }

        /// <summary>
        /// 视频标签
        /// </summary>
        public List<string> Tags { get => tags; set => tags = value; }
        /// <summary>
        /// 视频封面图片地址
        /// </summary>
        public string ThumbnailUrl { get => thumbnailUrl; set => thumbnailUrl = value; }
        /// <summary>
        /// 视频播放次数
        /// </summary>
        public long PlayCount { get => playCount; private set => playCount = value; }
        /// <summary>
        /// 视频点赞数
        /// </summary>
        public long Likes { get => likes; set => likes = value; }
        /// <summary>
        /// 视频踩数
        /// </summary>
        public long DisLikes { get => disLikes; private set => disLikes = value; }
        /// <summary>
        /// 视频评论数
        /// </summary>
        public long CommentsCount { get => commentsCount; private set => commentsCount = value; }


        protected Videos()
        {

        }

        public Videos(long id) : base(id)
        {

        }

        /// <summary>
        /// 修改视频总长度
        /// </summary>
        /// <param name="duration"></param>
        public void SetDuration(int duration)
        {
            Duration = duration;
        }



    }
}
