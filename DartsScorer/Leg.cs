using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DartsScorer.Models;

namespace DartsScorer
{
    public interface ILeg
    {
        int Visit(Visit visit);
        void AddPlayer(Player player);
        bool HasPlayerWon(Player player);
    }
    public class Leg : ILeg
    {
        public int StartScore { get; }
        public IList<Player> Players { get; }

        public Leg(int startScore)
        {
            if (startScore < 2)
                throw new Exception("Leg cannot have a start score lower than 2.");

            StartScore = startScore;
            Players = new List<Player>();
        }

        public Leg(int startScore, IList<Player> players)
        {
            if (startScore < 2)
                throw new Exception("Leg cannot have a start score lower than 2.");

            StartScore = startScore;
            Players = players;
        }

        public int Visit(Visit visit)
        {
            var player = Players.Where(p => p.Name.Equals(visit.Player.Name)).FirstOrDefault();

            if (player == null)
                throw new Exception("Player is not in the leg.");

            var newScore = player.Score - visit.Score;

            if (newScore < 2 && newScore != 0)
                newScore = player.Score;

            if (newScore == 0)
                ValidateCheckout(player.Score);

            return player.Score = newScore;
        }

        public void AddPlayer(Player player)
        {
            if (player.Name == null || player.Name == string.Empty)
                throw new Exception("A player must have a name.");
            if (player.Name.Count() > 10)
                throw new Exception("A players name cannot exceep 10 characters");
            if (Players.Where(p => p.Name == player.Name).Count() > 0)
                throw new Exception("Duplicate player added to leg.");

            player.Score = StartScore;
            Players.Add(player);
        }

        public bool HasPlayerWon(Player player)
        {
            if (player.Score == 0)
                return true;
            return false;
        }

        private void ValidateCheckout(int checkout)
        {
            if ((new int[7] { 169, 168, 166, 165, 163, 162, 159 }.Contains(checkout)))
                throw new Exception("Impossible Checkout");
        }
    }
}
