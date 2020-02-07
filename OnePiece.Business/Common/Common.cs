using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnePiece.Business.Common
{
    /// <summary>
    /// 扩展方法群
    /// </summary>
    public static class Common
    {
        /// <summary>
        /// 验证字符串是否为空
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// 验证枚举是否为空
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable==null)
            {
                return false;
            }

            var collection = enumerable as ICollection<T>;
            if (collection != null)
            {
                return collection.Count < 1;
            }
            return !enumerable.Any();
        }
    }
}
