using System;

namespace Labo_06
{
    public class WrongPercentageException : Exception
    {
        public WrongPercentageException(string message) : base(message)
        {
        }
    }
}