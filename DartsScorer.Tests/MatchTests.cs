using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DartsScorer.Models;
using System.Linq;

namespace DartsScorer.Tests
{
    [TestClass]
    public class MatchTests
    {
        [TestMethod]
        public void ICanCreateAMatch()
        {
            var match = new Match(7, 501);

            Assert.AreEqual(7, match.BestOfLegs);
            Assert.AreEqual(501, match.LegStartScore);
        }

        [TestMethod]
        public void ICanAddAPlayerToAMatch()
        {
            var match = new Match(7, 501);
            var player = new Player("Andy");
            match.AddPlayer(player);

            Assert.AreEqual(1, match.Players.Count);
            Assert.AreEqual("Andy", match.Players.FirstOrDefault().Key.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Duplicate player added to match.")]
        public void ICannotAdd2PlayersToAMatchWithTheSameName()
        {
            var match = new Match(7, 501);
            var player = new Player("Andy");
            match.AddPlayer(player);
            match.AddPlayer(player);
        }

        [TestMethod]
        public void ICanStartANewLeg()
        {
            var match = new Match(7, 501);
            var player = new Player("Andy");
            match.AddPlayer(player);
            var player2 = new Player("Arthur");
            match.AddPlayer(player2);

            var leg = match.StartNewLeg();

            Assert.AreEqual(2, leg.Players.Count);
            Assert.AreEqual(501, leg.StartScore);
        }

        [TestMethod]
        public void ICanAddALegWonToAPlayer()
        {
            var match = new Match(7, 501);
            var player = new Player("Andy");
            match.AddPlayer(player);

            var numberOfLegsWon = match.AddLegWonToPlayer(player);

            Assert.AreEqual(1, numberOfLegsWon);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "The Match has finished")]
        public void ErrorIsThrownWhenTheMatchEnds()
        {
            var match = new Match(2, 501);
            var player = new Player("Andy");
            match.StartNewLeg();
            match.StartNewLeg();
            match.StartNewLeg();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "The match must have at least 1 leg")]
        public void ErrorIsThrownWhenThereIs0LegsSelected()
        {
            var match = new Match(0, 501);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "The leg starting score must be at least 2")]
        public void ErrorIsThrownWhenThereIsLessThan2StartingScore()
        {
            var match = new Match(1, 1);
        }
    }
}
