using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSApp;

namespace RPSUnitTestProject
{
    [TestClass]
    public class ThrowUnitTest
    {
        [TestMethod]
        public void AllThrows()
        {
            //paper
            Assert.AreEqual(RPS.Compare(RPS.ThrowEnum.Paper, RPS.ThrowEnum.Paper), 0);
            Assert.AreEqual(RPS.Compare(RPS.ThrowEnum.Paper, RPS.ThrowEnum.Scissors), 1);
            Assert.AreEqual(RPS.Compare(RPS.ThrowEnum.Paper, RPS.ThrowEnum.Rock), -1);

            //rock
            Assert.AreEqual(RPS.Compare(RPS.ThrowEnum.Rock, RPS.ThrowEnum.Rock), 0);
            Assert.AreEqual(RPS.Compare(RPS.ThrowEnum.Rock, RPS.ThrowEnum.Paper), 1);
            Assert.AreEqual(RPS.Compare(RPS.ThrowEnum.Rock, RPS.ThrowEnum.Scissors), -1);

            //scissors
            Assert.AreEqual(RPS.Compare(RPS.ThrowEnum.Scissors, RPS.ThrowEnum.Scissors), 0);
            Assert.AreEqual(RPS.Compare(RPS.ThrowEnum.Scissors, RPS.ThrowEnum.Rock), 1);
            Assert.AreEqual(RPS.Compare(RPS.ThrowEnum.Scissors, RPS.ThrowEnum.Paper), -1);
        }
    }
}
