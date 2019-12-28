using OnePiece.Entity.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnePiece.Business
{
    /// <summary>
    /// 接口实现
    /// </summary>
    public class ServiceBusiness
    {
        /// <summary>
        /// 循环队列
        /// </summary>
        /// <returns></returns>
        public string MyCircularQueue(int length)
        {
            MyCircularQueue circularQueue = new MyCircularQueue(length); // 设置长度为 3
            var a = circularQueue.EnQueue(1);  // 返回 true
            var b = circularQueue.EnQueue(2);  // 返回 true
            var c = circularQueue.EnQueue(3);  // 返回 true
            var d = circularQueue.EnQueue(4);  // 返回 false，队列已满
            var e = circularQueue.Rear();  // 返回 3
            var f = circularQueue.IsFull();  // 返回 true
            var g = circularQueue.DeQueue();  // 返回 true
            var h = circularQueue.EnQueue(4);  // 返回 true
            var j = circularQueue.Rear();  // 返回 4

            return "hello world!";
        }
    }
}
