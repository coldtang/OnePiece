using OnePiece.Entity.Response;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OnePiece.Business.Common
{
    public class ResponseCommon
    {
        /// <summary>
        /// 封装方法
        /// </summary>
        /// <typeparam name="T">请求参数类型</typeparam>
        /// <typeparam name="I">返回参数类型</typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Response<I> InitResponse<T, I>(Func<T, I> func, T request)
        {
            Exception e = new Exception();
            Response<I> result =new Response<I>();
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var response = func(request);
                sw.Stop();
                var aa = Convert.ToString(sw.ElapsedMilliseconds);
                var aaa = result.ServiceTime;
                result.ServiceTime = Convert.ToString(sw.ElapsedMilliseconds);
                result.Body = response;
            }
            catch (Exception ex)
            {
                e = ex;
            }
            return result;
        }
    }
}
