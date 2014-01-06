namespace BowlingGameKata
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class BowlingGameScorer
    {
        private int score;
        public void Roll(int pins)
        {
            score += pins;
        }

        public int GetScore()
        {
            return score;
        }
    }
}
