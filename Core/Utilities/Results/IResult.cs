using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidleri için başlangıç
   public interface IResult
    {
        bool Success { get; }//getir
        string Message { get; }
    }
}
