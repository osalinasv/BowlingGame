using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace BowlingGame.Tests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class GameTests
    {
        private Game game;

        [TestInitialize]
        public void Initialize()
        {
            game = new Game();
        }

        [TestMethod]
        public void Game_Score_Should_Be_0_When_All_Rolls_Are_0()
        {
            RollMany(20, 0);
            AssertGameScoreEquals(0);
        }

        [TestMethod]
        public void Game_Score_Should_Be_20_When_All_Rolls_Are_1()
        {
            RollMany(20, 1);
            AssertGameScoreEquals(20);
        }

        [TestMethod]
        public void Game_Score_Should_Be_13_When_A_Spare_Is_Followed_By_A_3()
        {
            RollSpare();
            game.Roll(3);

            AssertGameScoreEquals(13);
        }

        [TestMethod]
        public void Game_Score_Should_Be_16_When_A_Spare_Is_Followed_By_A_3_And_A_0()
        {
            RollSpare();

            game.Roll(3);
            game.Roll(0);

            AssertGameScoreEquals(16);
        }

        [TestMethod]
        public void Game_Score_Should_Be_24_When_A_Strike_Is_Followed_By_A_3_And_A_4()
        {
            RollStrike();

            game.Roll(3);
            game.Roll(4);

            // AssertGameScoreEquals(24);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Game_Score_Should_Be_300_When_All_Rolls_Are_10()
        {
            RollMany(20, 10);

            // AssertGameScoreEquals(300);
            Assert.Inconclusive();
        }

        private void AssertGameScoreEquals(int score)
        {
            Assert.AreEqual(score, game.Score());
        }

        private void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.Roll(pins);
            }
        }

        private void RollSpare()
        {
            game.Roll(6);
            game.Roll(4);
        }

        private void RollStrike()
        {
            game.Roll(10);
        }
    }
}
