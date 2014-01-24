using System;

namespace MonopolyKata.Core.Exceptions
{
    public class TooFewPlayersException : Exception
    {
        public TooFewPlayersException(string message) : base(message) { }
    }
}
