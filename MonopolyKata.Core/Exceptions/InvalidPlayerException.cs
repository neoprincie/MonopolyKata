using System;

namespace MonopolyKata.Core.Exceptions
{
    public class InvalidPlayerException : Exception
    {
        public InvalidPlayerException(string message) : base(message) { }
    }
}
