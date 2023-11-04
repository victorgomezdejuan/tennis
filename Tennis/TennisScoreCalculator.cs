namespace Tennis;

public class TennisScoreCalculator
{
    public string Score(int player1Points, int player2Points)
    {

        if (player1Points == player2Points)
        {
            return EqualScore(player1Points);
        }
        else if (player1Points >= 4 || player2Points >= 4)
        {
            return AdvantageOrWin(player1Points, player2Points);
        }
        else
        {
            return SimpleScore(player1Points, player2Points);
        }
    }

    private static string EqualScore(int points)
    {
        if (points == 0)
        {
            return "Love-All";
        }
        else if (points == 1)
        {
            return "Fifteen-All";
        }
        else if (points == 2)
        {
            return "Thirty-All";
        }
        else if (points == 3)
        {
            return "Deuce";
        }
        else
        {
            throw new ArgumentException("Invalid points value");
        }
    }

    private static string AdvantageOrWin(int player1Points, int player2Points)
    {
        var minusResult = player1Points - player2Points;
        if (minusResult == 1)
        {
            return "Advantage player1";
        }
        else if (minusResult == -1)
        {
            return "Advantage player2";
        }
        else if (minusResult >= 2)
        {
            return "Win for player1";
        }
        else
        {
            return "Win for player2";
        }
    }

    private static string SimpleScore(int player1Points, int player2Points)
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
