using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet3._1.Controllers
{
    [ApiController]
    public class PerformanceComparisonController : ControllerBase
    {
        [HttpGet("/")]
        public String HelloWorld()
        {
            return "Hello World dotnet 3!";
        }

        [HttpGet("/readfile")]
        public async Task<String> Readfile()
        {
            var fileContent = await System.IO.File.ReadAllTextAsync("data.txt");
            return fileContent;
        }

        [HttpGet("/fibonacci")]
        public String Fibonacci()
        {
            ulong a = 0, b = 1, c = 0;
            for (ulong i = 2; i < 2000000; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return "done";
        }
    }
}
