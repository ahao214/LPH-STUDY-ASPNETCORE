﻿using Simple.EntityFramworkCore.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Video.Domains
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class Role : Entity
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 角色编号
        /// </summary>
        public string? Code { get; set; }


    }
}
