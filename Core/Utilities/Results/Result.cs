using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //IResult'ın somut class'ını yaptık
    public class Result: IResult //IResult result'ın referansını tutabilir
    {
        //C#'ta this class'ın kendisini(Result'ı) ifade eder
        //2 adet parametre alan bir constructor oluşturduk
        public Result(bool success, string message):this(success)  //2 adet parametre gönderirsek success'te çalışır
        {
            Message = message;
        }

        public Result(bool success) //success'i set etme işini buraya verdik
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
