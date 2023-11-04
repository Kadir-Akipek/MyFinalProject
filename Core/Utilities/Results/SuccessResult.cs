using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message) //base Result'ı kastediyor
        {
        }

        public SuccessResult() : base(true) //tek parametreli oluşturduk, true'yu default verdik
        {
        }
    }
}
