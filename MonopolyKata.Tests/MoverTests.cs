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
            mover.SetPlayerLocation("Prinsy", "Xero");

            mover.Move("Prinsy", 7);

            Assert.That(mover.GetPlayerLocation("Prinsy", Is.EqualTo("Seven)")));
        }
    }
}
