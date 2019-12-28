using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OnePiece.Business
{
    /// <summary>
    /// 队列之广度优先搜索
    /// </summary>
    public class BFSQueue
    {
        /// <summary>
        /// 广度优先搜索（岛屿数量）
        ///给定一个由 '1'（陆地）和 '0'（水）组成的的二维网格，计算岛屿的数量。
        ///一个岛被水包围，并且它是通过水平方向或垂直方向上相邻的陆地连接而成的。
        ///你可以假设网格的四个边均被水包围。
        ///举例输入:
        ///11110
        ///11010
        ///11000
        ///00000
        ///输出: 1
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public int BFSLandCount(char[][] grid)
        {
            if (grid.Length <= 0)
            {
                return 0;
            }
            if (grid[0].Length <= 0)
            {
                return 0;
            }
            int landCount = 0;//陆地数量
            int m = grid.Length;
            int n = grid[0].Length;
            Queue queue;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        landCount++;
                        grid[i][j] = '0';//初始化
                        queue = new Queue();
                        queue.Enqueue(string.Format($"{i},{j}"));//第一坐标
                        while (queue.Count > 0)
                        {
                            //获取遍历的坐标点信息
                            var first = queue.Dequeue();
                            var rowInfo = first.ToString();
                            int row = Convert.ToInt32(rowInfo.Split(',')[0]);
                            int col = Convert.ToInt32(rowInfo.Split(',')[1]);

                            if (row - 1 >= 0 && grid[row - 1][col] == '1')
                            {
                                queue.Enqueue(string.Format($"{row - 1},{col}"));
                                grid[row - 1][col] = '0';
                            }
                            if (row + 1 < m && grid[row + 1][col] == '1')
                            {
                                queue.Enqueue(string.Format($"{row + 1},{col}"));
                                grid[row + 1][col] = '0';
                            }
                            if (col - 1 >= 0 && grid[row][col-1] == '1')
                            {
                                queue.Enqueue(string.Format($"{row},{col - 1}"));
                                grid[row][col - 1] = '0';
                            }
                            if (col + 1 < n && grid[row][col + 1] == '1')
                            {
                                queue.Enqueue(string.Format($"{row},{col + 1}"));
                                grid[row][col + 1] = '0';
                            }
                        }
                    }
                }
            }
            return landCount;
        }
    }
}
