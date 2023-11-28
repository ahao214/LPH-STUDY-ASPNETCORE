namespace Video.Service.Domain.Video.Aggregates
{
    /// <summary>
    /// 视频分类
    /// </summary>
    public class VideoCategories : Entity<int>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    }
}
