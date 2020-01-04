using System;
using System.Collections.Generic;
using System.Text;

namespace OnePiece.Business.Common
{
    /// <summary>
    /// 单实例
    /// </summary>
    public sealed class SingleExample
    {
        public SingleExample()
        {         
        }

        public static SingleExample Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        // 使用内部类+静态构造函数实现延迟初始化
        class Nested
        {
            static Nested() { }

            internal static readonly SingleExample instance = new SingleExample();
        }
    }
}
