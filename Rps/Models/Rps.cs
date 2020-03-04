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
  }
}