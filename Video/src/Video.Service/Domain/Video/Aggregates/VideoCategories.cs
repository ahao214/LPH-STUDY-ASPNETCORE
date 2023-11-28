namespace Video.Service.Domain.Video.Aggregates
{
    /// <summary>
    /// 视频分类
    /// </summary>
    public class VideoCategories : Entity<int>
    {
        public string name;
        public string description;
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get => name; private set => name = value; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get => description; private set => description = value; }

        public VideoCategories()
        {

        }

        public VideoCategories(string name, string description)
        {
            UpdateName(name);
            UpdateDescription(description);
        }

        public void UpdateName(string name)
        {
            if (name == null)
            {
                throw new UserFriendlyException("分类名称不能为空");
            }
            Name = name;
        }

        public void UpdateDescription(string description)
        {
            if (description == null)
            {
                throw new ArgumentNullException("分类描述不能为空");
            }
            Description = description;
        }
    }
}
