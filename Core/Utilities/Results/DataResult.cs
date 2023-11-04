using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success, string message) : base(success, message) //base sayesinde Result'daki success ve message'ın kodları tekrar yazmamıza gerek yok
        {
            Data = data;
        }

        public DataResult(T data, bool success):base(success) //mesaj göndermek istemeseydik
        {
            Data = data;
        }

        public T Data { get; } //Data'ya getter verdik
    }
}
