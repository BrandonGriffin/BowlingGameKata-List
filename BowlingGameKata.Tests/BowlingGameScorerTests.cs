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
        [Test]
        public void ThisTestFails()
        {
            Assert.Fail();
        }

        [Test]
        public void AGutterballShouldReturn0()
        { 
            BowlingGameScorer scorer = new BowlingGameScorer();
            scorer.Roll(0);
            var actual = scorer.GetScore();
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void KnockingDownOnePineShouldReturn1()
        {
            BowlingGameScorer scorer = new BowlingGameScorer();
            scorer.Roll(1);
            var actual = scorer.GetScore();
            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void AGameOfOnesShouldScore20()
        {
            BowlingGameScorer scorer = new BowlingGameScorer();
            for (int i = 0; i < 20; i++)
            {
                scorer.Roll(1);
            }
            var actual = scorer.GetScore();

            Assert.That(actual, Is.EqualTo(20));
        }
    }
}
