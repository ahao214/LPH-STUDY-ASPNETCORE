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
        public int BookId { get; set; }

        public string BookName { get; set; }

        public string BookNumber { get; set; }

        public int PublishId { get; set; }

        public DateTime PublishDate { get; set; }

        public int BookTypeId { get; set; }

        public int AuthorId { get; set; }

        public decimal BookPrice { get; set; }

        public string InputName { get; set; }

        public int Brown { get; set; }

        public int TotalCount { get; set; }

        public string BookSamry { get; set; }

        public string ConvrImage { get; set; }

    }
}
