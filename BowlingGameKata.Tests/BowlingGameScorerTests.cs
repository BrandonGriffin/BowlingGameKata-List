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
        public void ThisTestFails()
        {
            Assert.Fail();
        }

        [Test]
        public void AGutterballShouldReturn0()
        { 
            _scorer.Roll(0);
            var actual = _scorer.GetScore();

            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void KnockingDownOnePinShouldReturn1()
        {
            _scorer.Roll(1);
            var actual = _scorer.GetScore();

            Assert.That(actual, Is.EqualTo(1));
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
            var actual = _scorer.GetScore();

            Assert.That(actual, Is.EqualTo(16));
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
