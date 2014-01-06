namespace BowlingGameKata.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;
    
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

        private void RollMany(int pins, int timesToRoll)
        {
            for (int i = 0; i < timesToRoll; i++)
            {
                scorer.Roll(pins);
            }
        }
    }
}
