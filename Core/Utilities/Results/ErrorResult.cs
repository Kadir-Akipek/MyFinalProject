using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(false, message) //base Result'ı kastediyor
        {
        }

        public ErrorResult() : base(false) //tek parametreli oluşturduk, false'u default verdik
        {
        }
    }
}
