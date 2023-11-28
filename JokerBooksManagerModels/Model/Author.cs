using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerModels.Model
{
    /// <summary>
    /// 作者
    /// </summary>
    public class Author
    {
        /// <summary>
        /// 作者ID
        /// </summary>
        public int AuthorId { get; set; }
        /// <summary>
        /// 作者名称
        /// </summary>
        public string AuthorName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
