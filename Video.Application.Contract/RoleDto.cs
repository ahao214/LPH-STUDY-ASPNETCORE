using System;
using System.Collections.Generic;
using System.Text;
using Video.Application.Contract.Base;

namespace Video.Application.Contract
{
    public class RoleDto:EntityDto
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
