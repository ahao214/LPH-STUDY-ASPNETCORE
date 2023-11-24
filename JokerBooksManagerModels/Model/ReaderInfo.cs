using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerModels.Model
{
    /// <summary>
    /// 读者信息表
    /// </summary>
    public class ReaderInfo
    {
        /// <summary>
        /// 读者自动编号
        /// </summary>
        public int ReaderId { get; set; }
        /// <summary>
        /// 读者类别ID
        /// </summary>
        public int ReaderTypeId { get; set; }
        /// <summary>
        /// 读者名称
        /// </summary>
        public string ReaderName { get; set; }
        /// <summary>
        /// 读者性别
        /// </summary>
        public string ReaderSex { get; set; }
        /// <summary>
        /// 读者编码
        /// </summary>
        public string ReaderNumber { get; set; }
        /// <summary>
        /// 读者身份证号
        /// </summary>
        public string ReaderIdCard { get; set; }
        /// <summary>
        /// 读者电话
        /// </summary>
        public string ReaderTel { get; set; }
        /// <summary>
        /// 备注信息
        /// </summary>
        public string ReaderRemark { get; set; }

    }
}
