using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessNumber;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumber.Tests
{
    [TestClass()]
    public class RandomNumberTests
    {
        [TestMethod()]
        public void MatchToRandomNumber_EqualOrGreater_Test()
        {
            RandomNumber matchNumber = new RandomNumber(1);

            Assert.AreEqual(0, matchNumber.MatchToRandomNumber(0));
            Assert.AreEqual(1, matchNumber.MatchToRandomNumber(3));
        }
    }
}