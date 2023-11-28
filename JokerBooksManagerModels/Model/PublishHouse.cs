using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerModels.Model
{
    /// <summary>
    /// 出版社
    /// </summary>
    public class PublishHouse
    {
        /// <summary>
        /// 出版社ID
        /// </summary>
        public int PublishId { get; set; }
        /// <summary>
        /// 出版社名称
        /// </summary>
        public string PublishName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
