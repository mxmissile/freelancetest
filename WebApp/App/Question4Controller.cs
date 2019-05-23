using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.App
{
    [Route("question-4")]
    public class Question4Controller : Controller
    {
        [HttpPost]
        [Route("do-math")]
        public IActionResult DoMath(int a, int b)
        {
            var result = new DoMathResult
            {
                DeveloperName = "Travis",
                TodaysDate = DateTime.Today,
                Success = true
            };

            try
            {
                result.Result = Convert.ToDecimal(a) / Convert.ToDecimal(b);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return Json(result);
        }
    }

    public class DoMathResult
    {
        public string DeveloperName { get; set; }

        public DateTime TodaysDate { get; set; }

        public decimal Result { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }
    }
}