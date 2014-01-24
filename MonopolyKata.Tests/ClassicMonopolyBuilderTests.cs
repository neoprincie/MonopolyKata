using MonopolyKata.Core;
using MonopolyKata.Core.Exceptions;
using NUnit.Framework;
using System.Collections.Generic;

namespace MonopolyKata.Tests
{
    [TestFixture]
    public class ClassicMonopolyBuilderTests
    {
        private ClassicMonopolyBuilder gameBuilder;

        [SetUp]
        public void TestInitialize()
        {
            gameBuilder = new ClassicMonopolyBuilder();
        }

        [Test]
        public void GetGame_ShouldReturnGame()
        {
            var result = gameBuilder.GetGame();

            Assert.That(result, Is.InstanceOf<Game>());
        }

        [Test]
        public void SetPlayers_ShouldAddPlayers()
        {
            var players = new List<string>() { "Horse", "Car"};

            gameBuilder.SetPlayers(players);
            Assert.That(gameBuilder.GetGame().Players, Is.EquivalentTo(players));
        }

        [Test]
        public void SetPlayers_GivenAListOfOnePlayer_ShouldThrowATooFewPlayersException()
        {
            var players = new List<string>() { "Horse"};

            Assert.Throws<TooFewPlayersException>(() => gameBuilder.SetPlayers(players));
        }
    }
}
