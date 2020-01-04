using System;
using System.Collections.Generic;
using System.Text;

namespace OnePiece.Entity.Request
{
    /// <summary>
    /// 二维数组中的查找请求实体
    /// </summary>
    public class FindTheNumberRequest
    {
        /// <summary>
        /// 二维数组
        /// </summary>
        public int[,] Array { get; set; }

        /// <summary>
        /// 行数
        /// </summary>
        public int Rows { get; set; }

        /// <summary>
        /// 列数
        /// </summary>
        public int Colums { get; set; }

        /// <summary>
        /// 目标数字
        /// </summary>
        public int Num { get; set; }
    }
}
