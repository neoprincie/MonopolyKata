using MonopolyKata.Core;
using NUnit.Framework;
using System.Collections.Generic;

namespace MonopolyKata.Tests
{
    [TestFixture]
    public class GameCreatorTests
    {
        [Test]
        public void CanCreate()
        {
            var gameBuilder = new GameBuilder();
        }

        [Test]
        public void SetPlayers_ShouldAddPlayers()
        {
            var gameBuilder = new GameBuilder();
            var players = new List<string>() { "Horse", "Car"};

            gameBuilder.SetPlayers(players);
            Assert.That(gameBuilder.GetGame().Players, Is.EquivalentTo(players));
        }
    }
}
