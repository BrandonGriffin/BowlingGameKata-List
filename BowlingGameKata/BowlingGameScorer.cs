using System;

namespace BowlingGameKata
{ 
    public class BowlingGameScorer
    {
        private Int32[] scores = new Int32[21];
        private Int32 numberOfRolls = 0;

        public void Roll(Int32 pins)
        {
            scores[numberOfRolls] = pins;
            numberOfRolls++;
        }

        public Int32 GetScore()
        {
            var score = 0;
            var roll = 0;

            for (Int32 frame = 0; frame < 10; frame++)
			{
                if (IsAStrike(roll))
                {
                    score += AddScoreForStrike(roll);
                    roll += 1;
                }
                else if (IsASpare(roll))
                {
                    score += AddScoreForSpare(roll);
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

        private Int32 AddScoreForFrame(Int32 roll)
        {
            return scores[roll] + scores[roll + 1];
        }

        private Int32 AddScoreForSpare(Int32 roll)
        {
            return 10 + scores[roll + 2];
        }

        private Int32 AddScoreForStrike(Int32 roll)
        {
            return 10 + scores[roll + 1] + scores[roll + 2];
        }

        private Boolean IsASpare(Int32 roll)
        {
            return (scores[roll] + scores[roll + 1]) == 10;
        }

        private Boolean IsAStrike(Int32 roll)
        {
            return scores[roll] == 10;
        }
    }
}
