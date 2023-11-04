namespace Tennis.Tests;

public class TennisScoreCalculatorSimpleScoreTests
{
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

    [Fact]
    public void LoveFifteen()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(0, 1);
        Assert.Equal("Love-Fifteen", score);
    }

    [Fact]
    public void LoveThirty()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(0, 2);
        Assert.Equal("Love-Thirty", score);
    }

    [Fact]
    public void LoveForty()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(0, 3);
        Assert.Equal("Love-Forty", score);
    }

    [Fact]
    public void FifteenThirty()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(1, 2);
        Assert.Equal("Fifteen-Thirty", score);
    }
}