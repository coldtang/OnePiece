using Microsoft.AspNetCore.Mvc;
using OnePiece.Business;
using OnePiece.Entity.Response;
using System.Collections;
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
        public Response<string> MyCircularQueue(int length = 3)
        {
            return InitResponse(new ServiceBusiness().MyCircularQueue, length);
        }

        /// <summary>
        /// 岛屿数量
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        [HttpGet("BFSLandCount")]
        public Response<int> BFSLandCount(char[][] grid)
        {
            grid = new char[3][] {
                       new char[] { '1', '1', '1' },
                       new char[] { '0', '1', '0' },
                       new char[] { '1', '1', '1' }
            };
            return InitResponse(new ServiceBusiness().BFSLandCount, grid);
        }
    }
}
