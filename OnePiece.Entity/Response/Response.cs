using System;
using System.Collections.Generic;
using System.Text;

namespace OnePiece.Entity.Response
{
    /// <summary>
    /// 统一返回格式
    /// </summary>
    public class Response<T>
    {
        /// <summary>
        /// 执行时长
        /// </summary>
        public string ServiceTime { get; set; } = string.Empty;

        /// <summary>
        /// 响应数据
        /// </summary>
        public T Body { get; set; }
    }
}
