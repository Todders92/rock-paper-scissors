using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rps.Models;

namespace Rps.Tests
{
  [TestClass]
  public class Rpstests
  {
    [TestMethod]
    public void Round_CheckForStingInput_String()
    {
      string player1 = "rock";
      string player2 = "paper";
      Round round = new Round(player1, player2);
      Assert.AreEqual(typeof(Round), round.GetType());
    }

    [TestMethod]
    public void WinnerCheck_CheckForMatchingHands_Draw()
    {
      string player1 = "rock";
      string player2 = "rock";
      Round round = new Round(player1, player2);
      string winner = round.WinnerCheck();
      Assert.AreEqual(winner, "draw");
    }

    [TestMethod]

    public void WinnerCheck_CheckForWinner_Player1Wins()
    {
      string player1 = "paper";
      string player2 = "rock";
      Round round = new Round(player1, player2);
      string winner = round.WinnerCheck();
      Assert.AreEqual(winner, "player 1 wins");
    } 

    [TestMethod]

    public void WinnerCheck_CheckforWinner_player2Wins()
    {
      string player1 = "paper";
      string player2 = "scissors";
      Round round = new Round(player1, player2);
      string winner = round.WinnerCheck();
      Assert.AreEqual(winner, "player 2 wins");
    }   
    [TestMethod]

    public void WinnerCheck_CheckforWinner_RockBeatsScissors()
    {
      string player1 = "rock";
      string player2 = "scissors";
      Round round = new Round(player1, player2);
      string winner = round.WinnerCheck();
      Assert.AreEqual(winner, "player 1 wins");
    }
    [TestMethod]

    public void WinnerCheck_CheckforWinner_ScissorsBeatsPaper()
    {
      string player1 = "scissors";
      string player2 = "paper";
      Round round = new Round(player1, player2);
      string winner = round.WinnerCheck();
      Assert.AreEqual(winner, "player 1 wins");
    }   
  }
}