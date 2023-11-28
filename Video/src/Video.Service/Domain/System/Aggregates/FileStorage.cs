using Video.Contracts.Shared;

namespace Video.Service.Domain.System.Aggregates
{
    /// <summary>
    /// 文件名
    /// </summary>
    public class FileStorage:Entity<int>
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath { get; set; }
        /// <summary>
        /// 文件大小
        /// </summary>
        public long FileSize { get; set; }
        /// <summary>
        /// 文件类型
        /// </summary>
        public FileType FileType { get; set; }
    }
}
