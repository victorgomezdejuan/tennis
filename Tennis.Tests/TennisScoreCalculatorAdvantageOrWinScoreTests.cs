using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tennis.Tests
{
    public class TennisScoreCalculatorAdvantageOrWinScoreTests
    {
        [Fact]
        public void AdvantagePlayer1()
        {
            var calculator = new TennisScoreCalculator();
            var score = calculator.Score(4, 3);
            Assert.Equal("Advantage player1", score);
        }

        [Fact]
        public void AdvantagePlayer2()
        {
            var calculator = new TennisScoreCalculator();
            var score = calculator.Score(3, 4);
            Assert.Equal("Advantage player2", score);
        }

        [Fact]
        public void AdvantagePlayer1AfterDeuce()
        {
            var calculator = new TennisScoreCalculator();
            var score = calculator.Score(5, 4);
            Assert.Equal("Advantage player1", score);
        }

        [Fact]
        public void AdvantagePlayer2AfterDeuce()
        {
            var calculator = new TennisScoreCalculator();
            var score = calculator.Score(4, 5);
            Assert.Equal("Advantage player2", score);
        }

        [Fact]
        public void WinForPlayer1()
        {
            var calculator = new TennisScoreCalculator();
            var score = calculator.Score(5, 3);
            Assert.Equal("Win for player1", score);
        }

        [Fact]
        public void WinForPlayer2()
        {
            var calculator = new TennisScoreCalculator();
            var score = calculator.Score(3, 5);
            Assert.Equal("Win for player2", score);
        }

        [Fact]
        public void WinForPlayer1AfterDeuce()
        {
            var calculator = new TennisScoreCalculator();
            var score = calculator.Score(6, 4);
            Assert.Equal("Win for player1", score);
        }

        [Fact]
        public void WinForPlayer2AfterDeuce()
        {
            var calculator = new TennisScoreCalculator();
            var score = calculator.Score(4, 6);
            Assert.Equal("Win for player2", score);
        }
    }
}