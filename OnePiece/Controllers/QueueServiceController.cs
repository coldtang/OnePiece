using Microsoft.AspNetCore.Mvc;
using OnePiece.Business;
using OnePiece.Business.Common;
using static OnePiece.Business.Common.ResponseCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnePiece.Entity.Response;

namespace OnePiece.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class QueueServiceController : ControllerBase
    {
        [HttpGet("MyCircularQueue")]
        public Response<string> MyCircularQueue(int length = 3)
        {
            return InitResponse(new ServiceBusiness().MyCircularQueue, length);
        }
    }
}
