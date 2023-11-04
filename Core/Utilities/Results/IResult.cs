using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel void'ler için
    public interface IResult
    {
        bool Success { get; } //getter okumak için setter yazmak için
        string Message { get; }
    }
}
