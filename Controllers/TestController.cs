using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationRateLimit.Controllers
{
    public class TestController : Controller
    {
        [Route("api/test/get")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}