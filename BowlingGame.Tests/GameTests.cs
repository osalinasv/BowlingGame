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
            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }

            // Assert.AreEqual(0, game.Score());
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Game_Score_Should_Be_20_When_All_Rolls_Are_1()
        {
            for (int i = 0; i < 20; i++)
            {
                game.Roll(1);
            }

            // Assert.AreEqual(20, game.Score());
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Game_Score_Should_Be_13_When_A_Spare_Is_Followed_By_A_3()
        {
            game.Roll(6);
            game.Roll(4);

            game.Roll(3);

            // Assert.AreEqual(13, game.Score());
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Game_Score_Should_Be_16_When_A_Spare_Is_Followed_By_A_3_And_A_0()
        {
            game.Roll(6);
            game.Roll(4);

            game.Roll(3);
            game.Roll(0);

            // Assert.AreEqual(16, game.Score());
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Game_Score_Should_Be_24_When_A_Strike_Is_Followed_By_A_3_And_A_4()
        {
            game.Roll(10);

            game.Roll(3);
            game.Roll(4);

            // Assert.AreEqual(24, game.Score());
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Game_Score_Should_Be_300_When_All_Rolls_Are_10()
        {
            for (int i = 0; i < 20; i++)
            {
                game.Roll(10);
            }

            // Assert.AreEqual(30, game.Score());
            Assert.Inconclusive();
        }
    }
}
