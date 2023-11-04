namespace Tennis.Tests;

public class TennisScoreCalculatorDrawScoreTests
{
    [Fact]
    public void LoveAll()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(0, 0);
        Assert.Equal("Love-All", score);
    }

    [Fact]
    public void FifteenAll()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(1, 1);
        Assert.Equal("Fifteen-All", score);
    }

    [Fact]
    public void ThirtyAll()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(2, 2);
        Assert.Equal("Thirty-All", score);
    }

    [Fact]
    public void Deuce()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(3, 3);
        Assert.Equal("Deuce", score);
    }

    [Fact]
    public void Deuce4()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(4, 4);
        Assert.Equal("Deuce", score);
    }

    [Fact]
    public void Deuce5()
    {
        var calculator = new TennisScoreCalculator();
        var score = calculator.Score(5, 5);
        Assert.Equal("Deuce", score);
    }
}