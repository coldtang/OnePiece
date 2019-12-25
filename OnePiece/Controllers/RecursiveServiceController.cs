using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnePiece.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class RecursiveServiceController: ControllerBase
    {
        [HttpGet("GetNewMessage")]
        public string GetNewMessage()
        {
            return "hello";
        }
    }
}
