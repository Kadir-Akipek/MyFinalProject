using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message) //base(DataResult), işlem sonucunu default olarak true verdik
        {
        }

        public SuccessDataResult(T data) : base(data, true) //mesaj göndermek istemeseydik
        {
        }

        public SuccessDataResult(string message) : base(default, true, message) //sadece mesaj döndürmek istersek
        {

        }

        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
