using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartsScorer.Models
{
    public class Visit
    {
        public Player Player { get; }
        public int Score { get; }

        public Visit(Player player, int score)
        {
            ValidateScore(score);

            Player = player;
            Score = score;
        }

        private void ValidateScore(int score)
        {
            if (score > 180)
                throw new Exception("Score cannot exceed 180.");
            if (score < 0)
                throw new Exception("Score cannot be negative.");
            if ((new int[7] { 166, 169, 172, 173, 175, 176, 178 }).Contains(score))
                throw new Exception("Score cannot be achieved with 3 darts");
        }
    }
}
