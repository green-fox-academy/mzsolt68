using NUnit.Framework;
using NUnit;
using System;
using PokerDojo;

namespace PokerDojo.Test
{
    [TestFixture]
    public class UnitTest1
    {
        PokerEval eval = new PokerEval();
        [Test]
        public void ShouldReturnErrorMoreThanFourSameRank()
        {
            string[] black = { "2H", "2D", "2S", "2C", "3C" };
            string[] white = { "3C", "3D", "3S", "3H", "3H" };
            string result = eval.Evaluate(black, white);
            Assert.AreEqual(result, "Hiba");
        }

        [Test]
        public void ShouldReturnErrorWhenSameCardsDealt()
        {
            string[] black = { "2H", "3D", "KD", "AH", "TC" };
            string[] white = { "3C", "4D", "5S", "2S", "2H" };
            string result = eval.Evaluate(black, white);
            Assert.AreEqual(result, "Hiba");
        }
    }
}
