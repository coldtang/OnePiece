using Microsoft.AspNetCore.Mvc;
using OnePiece.Business;
using OnePiece.Entity.Request;
using OnePiece.Entity.Response;
using System.Collections;
using System.Threading.Tasks;
using static OnePiece.Business.Common.ResponseCommon;

namespace OnePiece.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class QueueServiceController : ControllerBase
    {
        /// <summary>
        /// 队列之循环队列
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        [HttpGet("MyCircularQueue")]
        public async Task<Response<string>> MyCircularQueue(int length = 3)
        {
            return await AsyncInitResponse(new ServiceBusiness().MyCircularQueue, length);
        }

        /// <summary>
        /// 岛屿数量
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        [HttpGet("BFSLandCount")]
        public async Task<Response<int>> BFSLandCount(char[][] grid)
        {
            grid = new char[3][] {
                       new char[] { '1', '1', '1' },
                       new char[] { '0', '1', '0' },
                       new char[] { '1', '1', '1' }
            };
            return await AsyncInitResponse(new ServiceBusiness().BFSLandCount, grid);
        }

        /// <summary>
        /// 二维数组中的查找
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("FindTheNumber")]
        public async Task<Response<bool>> FindTheNumber([FromBody]FindTheNumberRequest request)
        {
            return await AsyncInitResponse(new ServiceBusiness().FindTheNumber, request);
        }
    }
}
