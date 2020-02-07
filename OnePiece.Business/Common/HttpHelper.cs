using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnePiece.Business.Common
{
    public class HttpHelper
    {
        /// <summary>
        /// 在 Startup.cs Configure方法中进行赋值
        /// </summary>
        public static IHttpClientFactory httpClientFactory;

        private readonly string _urlEndPoint;

        public HttpHelper(string urlEndPoint)
        {
            _urlEndPoint = urlEndPoint;
        }

        /// <summary>
        /// 异步请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="method">请求类型</param>
        /// <param name="content">请求参数</param>
        /// <param name="methodType">参数格式</param>
        /// <param name="headers">头部</param>
        /// <param name="timeout">超时时间</param>
        /// <returns></returns>
        public static async Task<string> ToHttp(string url, HttpMethod method, string content = "", string methodType = "application/json", Dictionary<string, string> headers = null, int timeout = 20)
        {
            try
            {
                var cts = new CancellationTokenSource();
                cts.CancelAfter(timeout * 1000);

                var request = new HttpRequestMessage(method, url);
                var http = httpClientFactory.CreateClient();

                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        request.Headers.Add(header.Key, header.Value);
                    }
                }

                if (!content.IsNullOrEmpty())
                {
                    HttpContent httpContent = new StringContent(content, Encoding.UTF8, methodType);
                    request.Content = httpContent;
                }

                var response = await http.SendAsync(request, cts.Token);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch
            {
                throw;
            }

            return "";
        }
    }
}
