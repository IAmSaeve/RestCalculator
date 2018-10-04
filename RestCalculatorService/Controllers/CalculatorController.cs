using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestCalculatorService.Models;

namespace RestCalculatorService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // POST: api/Calculator
        [HttpPost("Add", Name = "Add")]
        public int PostAdd([FromBody] Data data)
        {
            return data.A + data.B;
        }
        
        // POST: api/Calculator
        [HttpPost("Sub", Name = "Sub")]
        public int PostSub([FromBody] Data data)
        {
            return data.A - data.B;
        }

        // POST: api/Calculator
        [HttpPost("Mul", Name = "Mul")]
        public int PostMul([FromBody] Data data)
        {
            return data.A * data.B;
        }

        // POST: api/Calculator
        [HttpPost("Div", Name = "Div")]
        public int PostDiv([FromBody] Data data)
        {
            return data.A / data.B;
        }
    }
}
