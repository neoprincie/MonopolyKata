using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyKata.Core.Exceptions;

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
            if (!PlayerLocations.ContainsKey(playerName))
                throw new InvalidPlayerException(playerName + "does not exist. This makes me sad :(");

            var currentLocation = PlayerLocations[playerName];
            var newLocation = CalculateNewLocation(currentLocation, spacesToMove);

            SetPlayerLocation(playerName, newLocation);
        }

        private int CalculateNewLocation(int currentLocation, int spacesToMove)
        {
            var locationCandidate = currentLocation + spacesToMove;
            var numberOfBoardLocations = 40;

            return (locationCandidate >= numberOfBoardLocations)
                       ? locationCandidate % numberOfBoardLocations
                       : locationCandidate;
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
