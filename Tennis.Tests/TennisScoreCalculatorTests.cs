namespace Tennis.Tests;

public class TennisScoreCalculatorTests
{
    [Fact]
    public void LoveAll()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(0, 0);
        Assert.Equal("Love-All", score);
    }

    [Fact]
    public void FifteenLove()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(1, 0);
        Assert.Equal("Fifteen-Love", score);
    }

    [Fact]
    public void ThirtyLove()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(2, 0);
        Assert.Equal("Thirty-Love", score);
    }

    [Fact]
    public void FortyLove()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(3, 0);
        Assert.Equal("Forty-Love", score);
    }
}