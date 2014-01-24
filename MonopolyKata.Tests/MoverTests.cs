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
            var mover = new Mover(new List<string> {"Prinsy"} );
            mover.SetPlayerLocation("Prinsy", 0);

            mover.Move("Prinsy", 7);

            Assert.That(mover.GetPlayerLocation("Prinsy"), Is.EqualTo(7));
        }

        [Test]
        public void Move_WhenGivenANonexistingPlayer_ShouldThrowAnInvalidPlayerException()
        {
            var mover = new Mover(new List<string>());

            Assert.Throws<InvalidPlayerException>(() => mover.Move("Prinsy", 7));
        }
    }
}
