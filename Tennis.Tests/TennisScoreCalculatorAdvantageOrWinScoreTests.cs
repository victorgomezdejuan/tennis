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
    }
}