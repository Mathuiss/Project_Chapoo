using System;

namespace Chapoo.Model
{
    public class OrderCompletedException : Exception
    {
        public override string Message { get; }
        
        public OrderCompletedException(string _msg)
            : base(_msg)
        {
            Message = _msg;
        }
    }
}
