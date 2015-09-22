using DartsScorer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartsScorer
{
    public interface IMatch
    {
        void AddPlayer(Player player);
        Leg StartNewLeg();
        int AddLegWonToPlayer(Player player);
    }

    public class Match : IMatch
    {
        public IDictionary<Player, LegsWon> Players { get; }
        public int BestOfLegs { get; }
        public int LegStartScore { get; }
        public IList<Leg> Legs { get; }

        public Match(int bestOf, int startScore)
        {
            if (bestOf < 1)
                throw new Exception("The match must have at least 1 leg");
            if (startScore < 2)
                throw new Exception("The leg starting score must be at least 2");

            Players = new Dictionary<Player, LegsWon>();
            BestOfLegs = bestOf;
            LegStartScore = startScore;
            Legs = new List<Leg>();
        }

        public void AddPlayer(Player player)
        {
            if (Players.Where(p => p.Key.Name == player.Name).Count() > 0)
                throw new Exception("Duplicate player added to match.");

            Players.Add(player, new LegsWon());
        }

        public Leg StartNewLeg()
        {
            if (Legs.Count == BestOfLegs)
                throw new Exception("The Match has finished");

            var leg = new Leg(LegStartScore, Players.Keys.ToList());
            Legs.Add(leg);

            return leg;
        }

        public int AddLegWonToPlayer(Player player)
        {
            var playerEntry = Players.Where(p => p.Key.Name == player.Name).FirstOrDefault();

            return playerEntry.Value.Value += 1;
        }
    }
}
