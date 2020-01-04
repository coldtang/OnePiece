using OnePiece.Entity.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnePiece.Business.Array
{
    /// <summary>
    /// 数组类offer面试题
    /// </summary>
    public class ArrayOfferTest
    {
        /// <summary>
        /// 二维数组中的查找
        /// 在一个二维数组中，每一行都按照从左到右递增的顺序排序，每一列都按照从上到下递增的顺序排序。
        /// 请完成一个函数，输入这样的一个二维数组和一个整数，判断数组中是否含有该整数。
        /// </summary>
        /// <param name="array">二维数组</param>
        /// <param name="rows">行数</param>
        /// <param name="colums">列数</param>
        /// <param name="num">目标数字</param>
        /// <returns></returns>
        public bool FindTheNumber(FindTheNumberRequest request)
        {
            var result = false;

            //从右上角或者左下角开始寻找该数字，逐步缩小查找范围。此处选择右上角
            if (request != null && request.Array != null && request.Rows > 0 && request.Colums > 0)
            {
                int row = 0;
                int colum = request.Colums - 1;

                while (row < request.Rows && colum >= 0)
                {
                    if (request.Array[row, colum] == request.Num)
                    {
                        result = true;
                        break;
                    }
                    if (request.Array[row, colum] > request.Num)
                    {
                        colum--;
                    }
                    if (request.Array[row, colum] < request.Num)
                    {
                        row++;
                    }
                }
            }

            return result;
        }             
    }
}
