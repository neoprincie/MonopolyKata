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
        public void CanCreate()
        {
            var mover = new Mover();

            Assert.That(mover, Is.Not.Null);
        }

        [Test]
        public void Move_ShouldIncreaseThePlayerLocationByTheSpecifiedAmount()
        {
            var mover = new Mover();
            mover.SetPlayerLocation("Prinsy", 0);

            mover.Move("Prinsy", 7);

            Assert.That(mover.GetPlayerLocation("Prinsy"), Is.EqualTo(7));
        }

        //TODO: Test for GetPlayerLocation

        //TODO: Test for SetPlayerLocation

        //TODO: How do players ger into the mover?

        //TODO: What if the players do not exist in the mover? Should they just be added with a default position?
    }
}
