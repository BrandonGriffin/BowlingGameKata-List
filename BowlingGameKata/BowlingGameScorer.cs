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
                if (IsAStrike(roll))
                {
                    score = AddScoreForStrike(score, roll);
                    roll += 1;
                }
                else if (IsASpare(roll))
                {
                    score = AddScoreForSpare(score, roll);
                    roll += 2;
                }
                else
                {
                    score += AddScoreForFrame(roll);
                    roll += 2;
                }
			}

            return score;
        }

        private int AddScoreForFrame(int roll)
        {
            return scores[roll] + scores[roll + 1];
        }

        private int AddScoreForSpare(int score, int roll)
        {
            score += 10;
            score += scores[roll + 2];
            return score;
        }

        private int AddScoreForStrike(int score, int roll)
        {
            score += 10;
            score += scores[roll + 1];
            score += scores[roll + 2];
            return score;
        }

        private bool IsASpare(int roll)
        {
            return (scores[roll] + scores[roll + 1]) == 10;
        }

        private bool IsAStrike(int roll)
        {
            return scores[roll] == 10;
        }
    }
}
