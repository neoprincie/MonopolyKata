using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyKata.Core
{
    public interface IMonopolyBuilder
    {
        void SetPlayers(List<string> players);
        IGame GetGame();
    }
}
