using MonopolyKata.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyKata.Tests
{
    [TestFixture]
    public class MoverTests
    {

        [Test]
        public void Move_ShouldIncreaseThePlayerLocationByTheSpecifiedAmount()
        {
            var mover = new Mover(new List<string> { "Princie" });
            mover.SetPlayerLocation("Princie", 0);

            mover.Move("Princie", 7);

            Assert.That(mover.GetPlayerLocation("Princie"), Is.EqualTo(7));
        }

        [Test]
        public void Move_WhenGivenANonexistingPlayer_ShouldThrowAnInvalidPlayerException()
        {
            var mover = new Mover(new List<string>());

            Assert.Throws<InvalidPlayerException>(() => mover.Move("Princie", 7));
        }

        [Test]
        public void Move_ShouldWrapPlayerWhenEndOfBoardIsReached()
        {
            var mover = new Mover(new List<string>());
            mover.SetPlayerLocation("Princie", 39);

            mover.Move("Princie", 6);
            Assert.That(mover.GetPlayerLocation("Princie"), Is.EqualTo(5));
        }
    }
}
