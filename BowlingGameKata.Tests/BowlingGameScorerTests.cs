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
            var actual = scorer.Roll(0);
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void KnockingDownOnePineShouldReturn1()
        {
            BowlingGameScorer scorer = new BowlingGameScorer();
            var actual = scorer.Roll(1);
            Assert.That(actual, Is.EqualTo(1));
        }
    }
}
