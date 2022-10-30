using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// the using statement below is the FILE name.Models;
using Day4PostApi.Models;

namespace Day4PostApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        [HttpGet]
        [Route("SayHello")]

        public string SayHello(SayHelloModel name)
        {
            return "Say Hello " + name.userName + " " + name.LastName;
        }


        [HttpGet]
        [Route("AddingNum")]

        public string AddingNumbers(AddingModel number1)
        {
            return $"The sum of your numbers is: \n{number1.Num1 + number1.num2}";
        }
    }
}