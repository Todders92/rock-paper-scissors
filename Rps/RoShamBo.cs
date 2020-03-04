using System;
using Rps.Models;

namespace Rps
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("It's the World's Best Game!\n Rock, Paper, Scissors!");
			NewGame();
		}
			
		public static void NewGame()
		{	
			Console.WriteLine("Player 1, please enter your move. [rock] [paper] [scissors]");
			string player1Hand = Console.ReadLine().ToLower();
			Console.WriteLine("Player 2, please enter your move! [rock] [paper] [scissors]");
			string player2Hand = Console.ReadLine().ToLower();
			Round round = new Round(player1Hand, player2Hand);
			string winner = round.WinnerCheck();
			Console.WriteLine(winner);
		}
	}
}