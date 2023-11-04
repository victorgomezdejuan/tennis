namespace Tennis;

public class TennisScoreCalculator
{
    public string Score(int player1Points, int player2Points)
    {
        if (player1Points == 1)
        {
            return "Fifteen-Love";
        }

        if (player1Points == 2)
        {
            return "Thirty-Love";
        }

        if (player1Points == 3)
        {
            return "Forty-Love";
        }
        
        return "Love-All";
    }
}
