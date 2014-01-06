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
        private BowlingGameScorer _scorer;

        [SetUp]
        public void SetUp()
        {
            _scorer = new BowlingGameScorer();
        }

        [Test]
        public void AGutterGameShouldReturn0()
        { 
            RollMany(0, 20);
            var actual = _scorer.GetScore();

            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void AGameOfOnesShouldScore20()
        {
            RollMany(1, 20);
            var actual = _scorer.GetScore();
            
            Assert.That(actual, Is.EqualTo(20));
        }

        [Test]
        public void ASpareShouldCountTheNextRollTwice()
        {
            _scorer.Roll(4);
            _scorer.Roll(6);
            _scorer.Roll(3);
            RollMany(0, 17);
            var actual = _scorer.GetScore();

            Assert.That(actual, Is.EqualTo(16));
        }

        [Test]
        public void AStrikeShouldCountTheNextTwoRolls()
        {
            _scorer.Roll(10);
            _scorer.Roll(4);
            _scorer.Roll(3);
            RollMany(0, 17);
            var actual = _scorer.GetScore();

            Assert.That(actual, Is.EqualTo(24));
        }

        [Test]
        public void APerfectGameShouldGive300()
        {
            RollMany(10, 12);
            var actual = _scorer.GetScore();

            Assert.That(actual, Is.EqualTo(300));
        }

        private void RollMany(int pins, int timesToRoll)
        {
            for (int i = 0; i < timesToRoll; i++)
            {
                _scorer.Roll(pins);
            }
        }
    }
}
