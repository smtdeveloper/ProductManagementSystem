using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Temel Voidler için Başlangıc
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
