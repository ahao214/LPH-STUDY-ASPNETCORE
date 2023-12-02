using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerModels.Model
{
    /// <summary>
    /// 图书信息类
    /// </summary>
    public class BookInfo
    {
        /// <summary>
        /// 图书ID
        /// </summary>
        public int BookId { get; set; }
        /// <summary>
        /// 图书名称
        /// </summary>
        public string BookName { get; set; }
        /// <summary>
        /// 图书编号
        /// </summary>
        public string BookNumber { get; set; }
        /// <summary>
        /// 出版社
        /// </summary>
        public int PublishId { get; set; }
        /// <summary>
        /// 出版时间
        /// </summary>
        public DateTime PublishDate { get; set; }
        /// <summary>
        /// 图书类型
        /// </summary>
        public int BookTypeId { get; set; }
        /// <summary>
        /// 作者ID
        /// </summary>
        public int AuthorId { get; set; }
        /// <summary>
        /// 图书价格
        /// </summary>
        public decimal BookPrice { get; set; }
        /// <summary>
        /// 录入人员
        /// </summary>
        public string InputName { get; set; }
        /// <summary>
        /// 借阅次数
        /// </summary>
        public int BorowCount { get; set; }
        /// <summary>
        /// 总册数
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public string BookSamry { get; set; }
        /// <summary>
        /// 图书封面
        /// </summary>
        public string ConvrImage { get; set; }

    }
}
