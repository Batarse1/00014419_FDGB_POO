using System;

namespace Labo_06
{
    public class OutOfLimitsException : Exception
    {
        public OutOfLimitsException(string message) : base(message)
        {
        }
    }
}