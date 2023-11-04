using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message) //base(DataResult) //işlem sonucunu default olarak false verdik
        {
        }

        public ErrorDataResult(T data) : base(data, false) //mesaj göndermek istemeseydik
        {
        }

        public ErrorDataResult(string message) : base(default, false, message) //sadece mesaj döndürmek istersek
        {

        }

        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
