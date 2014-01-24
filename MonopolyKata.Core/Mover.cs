using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyKata.Core
{
    public class Mover
    {
        private Dictionary<string, int> PlayerLocations;

        public Mover(List<string> players)
        {
            PlayerLocations = new Dictionary<string,int>();

            foreach (var player in players)
            {
                PlayerLocations.Add(player, 0);
            }
        }

        public void Move(string playerName, int spacesToMove)
        {
            var currentLocation = PlayerLocations[playerName];

            SetPlayerLocation(playerName, currentLocation + spacesToMove);
        }

        public int GetPlayerLocation(string playerName)
        {
            return PlayerLocations[playerName];
        }
       
        public void SetPlayerLocation(string playerName, int location)
        {
            PlayerLocations[playerName] = location;
        }
    }
}
