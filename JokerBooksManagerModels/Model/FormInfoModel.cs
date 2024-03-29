﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerModels.Model
{
    /// <summary>
    /// 窗体信息类(用于在各个窗体间传输数据)
    /// </summary>
    public class FormInfoModel
    {
        /// <summary>
        /// 数据库主键ID
        /// </summary>
        public int KeyId { get; set; }
        /// <summary>
        /// 刷新数据库的委托
        /// </summary>
        public Action ReloadData { get; set; }
        /// <summary>
        /// 带参数的委托用于跳转到尾页
        /// </summary>
        public Action<int> RefreshData { get; set; }
        /// <summary>
        /// 用于跳转到尾页
        /// </summary>
        public int PageCount { get;set; }
    }
}
