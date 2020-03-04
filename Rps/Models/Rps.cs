namespace Rps.Models
{
  public class Round
  {
    public string P1Hand { get; set; }
    public string P2Hand { get; set; }

    public Round(string player1, string player2)
    {
      P1Hand = player1;
      P2Hand = player2;
    }

    public string WinnerCheck()
    {
      if (P1Hand == P2Hand)
      {
        return "draw";
      }
      else if (P1Hand == "rock" && P2Hand == "scissors")
      {
        return "player 1 wins";
      }
      else
      {
        return "player 2 wins";
      }
    }
  }
}