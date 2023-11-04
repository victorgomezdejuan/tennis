# Tennis
Kata got from https://www.codurance.com/katas/tennis.

Developed with dotnet (c#) and Visual Studio Code.

## Practice objectives
- TDD
- GitHub Copilot

## Instructions
Write a program that accepts two integers, and converts them to a tennis-style score.

The scoring rules of tennis (per [Wikipedia](https://en.wikipedia.org/wiki/Tennis#Scoring)) are as follows:

- A game is won by the first player to have won at least four points in total and at least two points more than the opponent.
- Scores from zero to three points are described as “love”, “fifteen”, “thirty”, and “forty” respectively.
- If at least three points have been scored by each player and the scores are equal, the score is “deuce”.
- If at least three points have been scored by each player and a player has one more point than his opponent, the score is “advantage” for the player in the lead.

Start with with the following interface:

```
public class TennisScoreCalculator {
    public string Score(int player1Points, int player2Points);
}
```