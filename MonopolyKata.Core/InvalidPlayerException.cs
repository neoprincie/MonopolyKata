using System;

namespace MonopolyKata.Core
{
    public class InvalidPlayerException : Exception
    {
        public InvalidPlayerException(string message) : base(message) { }
    }
}
