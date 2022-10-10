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

        [HttpGet]
        // Performs division between 2 decimal numbers
        public decimal Divide(decimal dividend, decimal divisor)
        {
            try
            {
                return MathOperationsLib.MathOperationsLib.Divide(dividend, divisor);
            }
            catch (DivideByZeroException ex)
            {
                HttpContext.Response.StatusCode = 400;
            }

            return 0.0m;
        }

        [HttpGet]
        // Performs Multiplication of 2 or more factors
        public int Multiply([FromQuery(Name = "factors[]")] int[] factors)
        {
            var product = 0;

            product = MathOperationsLib.MathOperationsLib.Multiply(factors);

            return product;
        }

        [HttpGet]
        // Performs subtraction between 2 integers
        public decimal Subtract(int minuend, int subtrahend)
        {
            return MathOperationsLib.MathOperationsLib.Subtract(minuend, subtrahend);
        }

    }
}

