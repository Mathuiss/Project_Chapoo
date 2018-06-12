using System;

namespace Chapoo.Model
{
    public class OutOfStockException : Exception
    {
        public override string Message { get; }

        public OutOfStockException(string _msg)
            : base(_msg)
        {
            Message = _msg;
        }
    }
}
