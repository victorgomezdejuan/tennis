namespace Tennis.Tests;

public class TennisScoreCalculatorTests
{
    [Fact]
    public void LoveAll()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(0, 0);
        Assert.Equal("Love-Love", score);
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
    public void FifteenAll()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(1, 1);
        Assert.Equal("Fifteen-Fifteen", score);
    }

    [Fact]
    public void ThirtyAll()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(2, 2);
        Assert.Equal("Thirty-Thirty", score);
    }
}