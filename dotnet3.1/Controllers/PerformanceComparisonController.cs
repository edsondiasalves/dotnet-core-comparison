using System;
using System.Collections;
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

        [HttpGet("/bubblesort")]
        public IEnumerable BubbleSort()
        {
            var maxNumber = 1500;
            var array = new int[maxNumber];

            for (int i = 0; i < maxNumber; i++)
            {
                array[i] = maxNumber - i;
            }

            int tempBox;
            var lastIndex = array.Length - 1;

            for (int outerIndex = 0; outerIndex < lastIndex; outerIndex++)
            {
                for (int currentIndex = 0; currentIndex < lastIndex; currentIndex++)
                {
                    var nextIndex = currentIndex + 1;

                    if (array[currentIndex] > array[nextIndex])
                    {
                        tempBox = array[nextIndex];
                        array[nextIndex] = array[currentIndex];
                        array[currentIndex] = tempBox;
                    }
                }
            }

            return array;
        }
    }
}
