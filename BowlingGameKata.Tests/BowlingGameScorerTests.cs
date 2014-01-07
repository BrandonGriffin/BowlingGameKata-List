using NUnit.Framework;
using System;
    
namespace BowlingGameKata.Tests
{
    [TestFixture]
    public class BowlingGameScorerTests
    {
        private BowlingGameScorer scorer;

        [SetUp]
        public void SetUp()
        {
            scorer = new BowlingGameScorer();
        }

        [Test]
        public void AGutterGameShouldReturn0()
        { 
            RollMany(0, 20);
            var actual = scorer.GetScore();

            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void AGameOfOnesShouldScore20()
        {
            RollMany(1, 20);
            var actual = scorer.GetScore();
            
            Assert.That(actual, Is.EqualTo(20));
        }

        [Test]
        public void ASpareShouldCountTheNextRollTwice()
        {
            scorer.Roll(4);
            scorer.Roll(6);
            scorer.Roll(3);
            RollMany(0, 17);

            var actual = scorer.GetScore();

            Assert.That(actual, Is.EqualTo(16));
        }

        [Test]
        public void AStrikeShouldCountTheNextTwoRolls()
        {
            scorer.Roll(10);
            scorer.Roll(4);
            scorer.Roll(3);
            RollMany(0, 17);

            var actual = scorer.GetScore();

            Assert.That(actual, Is.EqualTo(24));
        }

        [Test]
        public void APerfectGameShouldGive300()
        {
            RollMany(10, 12);
            var actual = scorer.GetScore();

            Assert.That(actual, Is.EqualTo(300));
        }

        [Test]
        public void ARandomGameShouldScore80()
        {
            RollMany(4, 8);
            RollMany(6, 4);
            RollMany(3, 8);

            var actual = scorer.GetScore();

            Assert.That(actual, Is.EqualTo(80));
        }

        private void RollMany(Int32 pins, Int32 timesToRoll)
        {
            for (Int32 i = 0; i < timesToRoll; i++)
            {
                scorer.Roll(pins);
            }
        }
    }
}
