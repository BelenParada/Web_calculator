using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculadoraa.Properties.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]

    public class CalculadoraaController : ControllerBase
    {
        [HttpGet]
        [Route("suma")]
        public int suma(int num1, int num2)
        {
            return num1 + num2;
        }

        [HttpPost]
        [Route("suma")]
        public int sumar([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 + num2;
        }
    }
}
