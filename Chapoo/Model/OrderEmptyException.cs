using System;

namespace Chapoo.Model
{
    public class OrderEmptyException : Exception
    {
        public override string Message { get; }

        public OrderEmptyException(string _msg)
            : base(_msg)
        {
            Message = _msg;
        }
    }
}
