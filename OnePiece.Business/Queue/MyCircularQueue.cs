using OnePiece.Business.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnePiece.Business
{
    /// <summary>
    /// 循环队列（时间复杂度和空间复杂度的初步探讨--后补）
    /// MyCircularQueue(k): 构造器，设置队列长度为 k 。
    /// Front: 从队首获取元素。如果队列为空，返回 -1 。
    /// Rear: 获取队尾元素。如果队列为空，返回 -1 。
    /// enQueue(value) : 向循环队列插入一个元素。如果成功插入则返回真。
    /// deQueue() : 从循环队列中删除一个元素。如果成功删除则返回真。
    /// isEmpty() : 检查循环队列是否为空。
    /// isFull() : 检查循环队列是否已满。
    /// </summary>
    public class MyCircularQueue
    {
        /// <summary>
        /// 空数组
        /// </summary>
        private int[] items;
        /// <summary>
        /// 头部指针
        /// </summary>
        private int head;
        /// <summary>
        /// 尾部指针
        /// </summary>
        private int tail;
        /// <summary>
        /// 队列长度
        /// </summary>
        private int size;

        /// <summary>
        /// Initialize your data structure here. Set the size of the queue to be k.
        /// </summary>
        /// <param name="k">size of the queue</param>
        /// <returns></returns>
        public MyCircularQueue(int k)
        {
            this.items = new int[k];
            this.head = -1;
            this.tail = -1;
            this.size = k;
        }

        /// <summary>
        /// Insert an element into the circular queue. Return true if the operation is successful.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }
            if (IsEmpty())
            {
                head = 0;
            }
            tail = (tail + 1) % size;
            items[tail] = value;
            return true;
        }

        /// <summary>
        /// Delete an element from the circular queue. Return true if the operation is successful.
        /// </summary>
        /// <returns></returns>
        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }
            if (head == tail)
            {
                head = -1;
                tail = -1;
                return true;
            }
            head = (head + 1) % size;
            return true;
        }

        /// <summary>
        /// Get the front item from the queue.
        /// </summary>
        /// <returns></returns>
        public int Front()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return items[head];
        }

        /// <summary>
        /// Get the last item from the queue.
        /// </summary>
        /// <returns></returns>
        public int Rear()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return items[tail];
        }

        /// <summary>
        /// Checks whether the circular queue is empty or not.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return head == -1;
        }

        /// <summary>
        /// Checks whether the circular queue is full or not.
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            var result = (tail + 1) % size == head;
            return result;
        }
    }
}
