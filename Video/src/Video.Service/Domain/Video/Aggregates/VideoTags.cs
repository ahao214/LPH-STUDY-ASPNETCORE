namespace Video.Service.Domain.Video.Aggregates
{
    /// <summary>
    /// 视频标签
    /// </summary>
    public class VideoTags:Entity<long>
    {
        public string name;
        public string description;
        /// <summary>
        /// 标签名称
        /// </summary>
        public string Name { get => name; private set => name = value; }
        /// <summary>
        /// 标签描述
        /// </summary>
        public string Description { get => description; private set => description = value; }

        public VideoTags()
        {

        }

        public VideoTags(string name, string description)
        {
            UpdateName(name);
            UpdateDescription(description);
        }

        public void UpdateName(string name)
        {
            if (name == null)
            {
                throw new UserFriendlyException("标签名称不能为空");
            }
            Name = name;
        }

        public void UpdateDescription(string description)
        {
            if (description == null)
            {
                throw new ArgumentNullException("标签描述不能为空");
            }
            Description = description;
        }






    }
}
