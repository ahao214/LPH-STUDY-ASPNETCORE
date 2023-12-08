using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerModels.Model
{
    /// <summary>
    /// 图书借阅表
    /// </summary>
    public class BorrowBook
    {
        /// <summary>
        /// 借阅ID
        /// </summary>
        public int BorrowId { get; set; }
        /// <summary>
        /// 图书ID
        /// </summary>
        public int BookId { get; set; }
        /// <summary>
        /// 读者ID
        /// </summary>
        public int ReaderId { get; set; }
        public int BorrowBookCount { get; set; }
        /// <summary>
        /// 借阅时间
        /// </summary>
        public DateTime BorrowDate { get; set; }
        /// <summary>
        /// 应该归还时间
        /// </summary>
        public DateTime ShouldDate { get; set; }
        /// <summary>
        /// 实际归还时间
        /// </summary>
        public DateTime ActualDate { get; set; }
        public string Remark { get; set; }
    }
}
