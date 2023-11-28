

namespace Video.Service.Domain.System.Aggregates
{
    /// <summary>
    /// 文件名
    /// </summary>
    public class FileStorage : Entity<int>
    {
        public string name;
        public string path;
        public long size;
        public FileType type;
        /// <summary>
        /// 文件名称
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// 文件路径
        /// </summary>
        public string Path { get => path; set => path = value; }
        /// <summary>
        /// 文件大小
        /// </summary>
        public long Size { get => size; set => size = value; }
        /// <summary>
        /// 文件类型
        /// </summary>
        public FileType Type { get => type; private set => type = value; }


        protected FileStorage()
        {

        }

        public FileStorage(string name, string path, long size, FileType type)
        {
            UpdateName(name);
            UpdatePath(path);
            Size = size;
            Type = type;
        }

        public void UpdateName(string name)
        {
            if(name.IsNullOrWhiteSpace())
            {
                throw new UserFriendlyException("文件名称不能为空");
            }
            Name = name;
        }

        public void UpdatePath(string path)
        {
            if(path.IsNullOrWhiteSpace())
            {
                throw new UserFriendlyException("文件路径不能为空");
            }
            Path = path;
        }

    }
}
