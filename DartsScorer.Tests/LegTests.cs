using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DartsScorer.Models;
using System.Collections.Generic;

namespace DartsScorer.Tests
{
    [TestClass]
    public class LegTests
    {
        [TestMethod]
        public void ICanCreateA501Leg()
        {
            var leg = new Leg(501);
            Assert.AreEqual(501, leg.StartScore);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Leg cannot have a start score lower than 2.")]
        public void ICannotCreateALegWithAStartScoreLowerThan2()
        {
            var leg = new Leg(-1);
        }

        [TestMethod]
        public void ICanAddAPlayerToALeg()
        {
            var leg = new Leg(501);
            var player = new Player("Andy");

            leg.AddPlayer(player);

            Assert.AreEqual(1, leg.Players.Count);
            Assert.AreEqual("Andy", leg.Players[0].Name);
            Assert.AreEqual(501, leg.Players[0].Score);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Duplicate player added to leg.")]
        public void ICannotAdd2PlayersToALegWithTheSameName()
        {
            var leg = new Leg(501);
            var player = new Player("Andy");

            leg.AddPlayer(player);
            leg.AddPlayer(player);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "A player must have a name.")]
        public void ICannotAddAPlayerToALegWithoutAName()
        {
            var leg = new Leg(501);
            var player = new Player(null);

            leg.AddPlayer(player);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "A player must have a name.")]
        public void ICannotAddAPlayerToALegWithANameAsEmptyString()
        {
            var leg = new Leg(501);
            var player = new Player("");

            leg.AddPlayer(player);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "A players name cannot exceed 10 characters.")]
        public void ICannotAddAPlayerToALegWithANameLongerThan10Characters()
        {
            var leg = new Leg(501);
            var player = new Player("12345678910");

            leg.AddPlayer(player);
        }

        [TestMethod]
        public void APlayerCanHaveAVisitAndSeeTheirScoreChange()
        {
            var leg = new Leg(501);
            var player = new Player("Andy");
            leg.AddPlayer(player);
            var visit = new Visit(player, 100);

            var newScore = leg.Visit(visit);

            Assert.AreEqual(401, newScore);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Player is not in the leg.")]
        public void AnErrorIsThrownIfAPlayerHasAVisitWhoIsNotInTheLeg()
        {
            var leg = new Leg(501);
            var player = new Player("Andy");
            var visit = new Visit(player, 100);

            var newScore = leg.Visit(visit);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Score cannot exceed 180.")]
        public void AnErrorIsThrownIfAPlayerHasAScoreHigherThan180()
        {
            var player = new Player("Andy");
            var visit = new Visit(player, 181);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Score cannot be negative")]
        public void AnErrorIsThrownIfAPlayerHasAScoreLessThan0()
        {
            var player = new Player("Andy");
            var visit = new Visit(player, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Score cannot be negative")]
        public void AnErrorIsThrownWhenAnInvalidScoreIsAddedToAVisit()
        {
            var player = new Player("Andy");
            var visit = new Visit(player, 175);
        }

        [TestMethod]
        public void APlayersScoreRemainsTheSameWhenTheirOverallScoreGoBelow2()
        {
            var leg = new Leg(501);
            var player = new Player("Andy");
            leg.AddPlayer(player);
            var visit = new Visit(player, 100);

            leg.Visit(visit);//401
            leg.Visit(visit);//301
            leg.Visit(visit);//201
            leg.Visit(visit);//101
            var score = leg.Visit(visit);//1 = bust, therefore 101

            Assert.AreEqual(101, leg.Players[0].Score);
        }

        [TestMethod]
        public void APlayersScoreCanReachExacly0()
        {
            var leg = new Leg(501);
            var player = new Player("Andy");
            leg.AddPlayer(player);
            var visit = new Visit(player, 100);
            var checkoutVisit = new Visit(player, 101);

            leg.Visit(visit);//401
            leg.Visit(visit);//301
            leg.Visit(visit);//201
            leg.Visit(visit);//101
            var score = leg.Visit(checkoutVisit);//1 = bust, therefore 101

            Assert.AreEqual(0, leg.Players[0].Score);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Impossible checkout")]
        public void AnErrorIsThronWhenAPlayerReaches0WithAnImpossibleCheckout()
        {
            var leg = new Leg(501);
            var player = new Player("Andy");
            leg.AddPlayer(player);
            var visit = new Visit(player, 100);
            var checkoutVisit = new Visit(player, 101);

            leg.Visit(new Visit(player, 100));//401
            leg.Visit(new Visit(player, 100));//301
            leg.Visit(new Visit(player, 100));//201
            leg.Visit(new Visit(player, 39));//162
            leg.Visit(new Visit(player, 162));
        }

        private List<Player> GetPlayerList()
        {
            return new List<Player>()
            {
                new Player("Andy"),
                new Player("Arthur")
            };
        }

        [TestMethod]
        public void ICanPassInTheListOfPlayers()
        {
            var players = GetPlayerList();

            var leg = new Leg(501, players);

            Assert.AreEqual(2, leg.Players.Count);
        }

        [TestMethod]
        public void ICanCheckIfTheLegHasBeenWonWhenPlayerHasWon()
        {
            var leg = new Leg(501);
            var player = new Player("Andy");
            leg.AddPlayer(player);

            leg.Visit(new Visit(player, 100));//401
            leg.Visit(new Visit(player, 100));//301
            leg.Visit(new Visit(player, 100));//201
            leg.Visit(new Visit(player, 100));//101
            leg.Visit(new Visit(player, 101));//0

            var hasWon = leg.HasPlayerWon(player);

            Assert.IsTrue(hasWon);
        }

        [TestMethod]
        public void ICanCheckIfTheLegHasBeenWonWhenPlayerHasNotWon()
        {
            var leg = new Leg(501);
            var player = new Player("Andy");
            leg.AddPlayer(player);

            leg.Visit(new Visit(player, 100));//401
            leg.Visit(new Visit(player, 100));//301
            leg.Visit(new Visit(player, 100));//201
            leg.Visit(new Visit(player, 100));//101

            var hasWon = leg.HasPlayerWon(player);

            Assert.IsFalse(hasWon);
        }
    }
}
