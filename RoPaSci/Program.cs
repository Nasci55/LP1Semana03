using System;
using System.Xml.XPath;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {
            int result = RockPaperScissors(args[0], args[1]);
            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(string player1, string player2)
        {
            int result;

            if (player1 == player2)
            {
                result = 0; // Draw
            }
            else if (((player1 == "Rock") && (player2 == "Scissors")) ||
                ((player1 == "Scissors") && (player2 == "Paper")) ||
                ((player1 == "Paper") && (player2 == "Rock")))
            {
                result = 1; // Player 1 wins
            }
            else
            {
                result = 2; // Player 2 wins
            }

            return result;
        }
    }
}
