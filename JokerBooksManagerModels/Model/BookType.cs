using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerModels.Model
{
    /// <summary>
    /// 图书类别表
    /// </summary>
    public class BookType
    {
        /// <summary>
        /// 图书ID
        /// </summary>
        public int BookTypeId { get; set; }
        /// <summary>
        /// 图书名称
        /// </summary>
        public string BookTypeName { get; set; }        
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        
    }
}
