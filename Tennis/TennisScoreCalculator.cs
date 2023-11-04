namespace Tennis;

public class TennisScoreCalculator
{
    public string Score(int player1Points, int player2Points)
    {
        string result = string.Empty;

        if (player1Points == 0)
        {
            result = "Love";
        }
        else if (player1Points == 1)
        {
            result = "Fifteen";
        }
        else if (player1Points == 2)
        {
            result = "Thirty";
        }
        else if (player1Points == 3)
        {
            result = "Forty";
        }


        result += "-";

        if (player2Points == 0)
        {
            result += "Love";
        }
        else if (player2Points == 1)
        {
            result += "Fifteen";
        }
        else if (player2Points == 2)
        {
            result += "Thirty";
        }
        else if (player2Points == 3)
        {
            result += "Forty";
        }

        return result;
    }
}
