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

        public Mover()
        {
            PlayerLocations = new Dictionary<string,int>();
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
            if(!PlayerLocations.ContainsKey(playerName))
                PlayerLocations.Add(playerName, location);

            PlayerLocations[playerName] = location;
        }
    }
}
