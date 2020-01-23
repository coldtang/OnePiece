using OnePiece.Business.Array;
using OnePiece.Entity.Request;
using System.Threading.Tasks;

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
        public async Task<string> MyCircularQueue(int length)
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

        /// <summary>
        /// 岛屿数量
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public async Task<int> BFSLandCount(char[][] grid)
        {
            return new BFSQueue().BFSLandCount(grid);
        }

        /// <summary>
        /// 二维数组中的查找
        /// </summary>
        /// <param name="array"></param>
        /// <param name="rows"></param>
        /// <param name="colums"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public async Task<bool> FindTheNumber(FindTheNumberRequest request)
        {
            return new ArrayOfferTest().FindTheNumber(request);
        }
    }
}
