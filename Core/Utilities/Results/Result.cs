using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success,string message):this(success) //bunu kullandıgımızda alttakş fonksiyonu ve bunu set eter
        {
            Message = message;
        }
        public Result(bool success) //sadece bu fonksiyonu set eder
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
