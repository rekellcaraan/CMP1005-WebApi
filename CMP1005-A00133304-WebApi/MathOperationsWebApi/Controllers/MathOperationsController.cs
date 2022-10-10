using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MathOperationsLib;

namespace MathOperationsWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    // Math Operations Web Api
    public class MathOperationsController : ControllerBase
    {
        [HttpGet]
        // Get the sum of 2 or more addends
        public int Sum([FromQuery(Name = "addends[]")] int[] addends)
        {
            return MathOperationsLib.MathOperationsLib.Sum(addends);
        }
    }
}

