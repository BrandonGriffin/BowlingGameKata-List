namespace BowlingGameKata
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class BowlingGameScorer
    {
        private int _score;
        private List<int> _scores = new List<int>();
        public void Roll(int pins)
        {
            _scores.Add(pins);
        }

        public int GetScore()
        {
            for (int i = 0; i < _scores.Count; i++)
			{
			    if(i > 1)
                    if((_scores[i-1] + _scores[i-2]) == 10)
                        _score += _scores[i];

                _score += _scores[i];
			}
            return _score;
        }
    }
}
