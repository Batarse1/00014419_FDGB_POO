using System;

namespace Labo_06
{
    public class EmptyStringException : Exception
    {
        public EmptyStringException(string message) : base(message)
        {
        }
    }
}