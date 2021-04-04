using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    
    public class Result : IResult
    {
        public bool Success { get; }

        public string Message { get; }

        //public string Message => throw new NotImplementedException(); lambda kullanımı yeni, aslında get'tir. Lambdadan sonra ne varsa onu geri döner.
    }
}
