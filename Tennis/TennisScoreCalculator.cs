namespace Tennis;

public class TennisScoreCalculator
{
    public string Score(int player1Points, int player2Points)
    {
        string result = string.Empty;
        result += SinglePlayerSimpleScore(player1Points);
        result += "-";
        result += SinglePlayerSimpleScore(player2Points);

        return result;
    }

    private static string SinglePlayerSimpleScore(int points)
    {
        if (points == 0)
        {
            return "Love";
        }
        else if (points == 1)
        {
            return "Fifteen";
        }
        else if (points == 2)
        {
            return "Thirty";
        }
        else if (points == 3)
        {
            return "Forty";
        }
        else
        {
            throw new ArgumentException("Invalid points value");
        }
    }
}
