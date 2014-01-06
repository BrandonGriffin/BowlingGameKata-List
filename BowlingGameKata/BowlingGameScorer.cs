namespace BowlingGameKata
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class BowlingGameScorer
    {
        
        private int[] scores = new int[21];
        private int numberOfRolls = 0;
        public void Roll(int pins)
        {
            scores[numberOfRolls] = pins;
            numberOfRolls++;
        }

        public int GetScore()
        {
            var score = 0;
            var roll = 0;

            for (int frame = 0; frame < 10; frame++)
			{
                if (scores[roll] == 10)
                {
                    score += 10;
                    score += scores[roll + 1];
                    score += scores[roll + 2];
                    roll += 1;
                }

                else if ((scores[roll] + scores[roll + 1]) == 10)
                {
                    score += 10;
                    score += scores[roll + 2];
                    roll += 2;
                }
                else
                {
                    score += scores[roll] + scores[roll + 1];
                    roll += 2;
                }
			}

            return score;
        }
    }
}
