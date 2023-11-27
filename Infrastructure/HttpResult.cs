using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class HttpResult
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 信息
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public object? Data { get; set; }

        public HttpResult(int code)
        {
            this.Code = code;
        }

        public HttpResult(int code, string? message)
        {
            this.Code = code;
            this.Message = message;
        }

        public HttpResult(int code, object? data)
        {
            this.Code = code;
            this.Data = data;
        }

        public HttpResult(int code, string? message, object? data)
        {
            this.Code = code;
            this.Message = message;
            this.Data = data;
        }
    }
}
