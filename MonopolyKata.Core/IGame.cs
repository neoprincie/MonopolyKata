using System;
using System.Collections.Generic;

namespace MonopolyKata.Core
{
    public interface IGame
    {
        List<string> Players { get; set; }
    }
}
