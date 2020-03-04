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
  }
}