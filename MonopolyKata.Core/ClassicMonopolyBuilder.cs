using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyKata.Core
{
    public class ClassicMonopolyBuilder : IMonopolyBuilder
    {
        IGame game;

        public ClassicMonopolyBuilder()
        {
            game = new Game();
        }

        public void SetPlayers(List<string> players)
        {
            game.Players = players;
        }

        public IGame GetGame()
        {
            return game;
        }
       
    }
}
