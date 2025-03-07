using System;
using System.Xml.XPath;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {

            GameItem player1 = Enum.Parse<GameItem>(args[0], true);
            GameItem player2 = Enum.Parse<GameItem>(args[1], true);

            RoPaSci.GameStatus result = RockPaperScissors(player1, player2);

            switch (result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {
            GameStatus result;

            if (player1 == player2)
            {
                result = GameStatus.Draw; // Draw
            }
            else if (((player1 == GameItem.Rock) && (player2 == GameItem.Scissors)) ||
                ((player1 == GameItem.Scissors) && (player2 == GameItem.Paper)) ||
                ((player1 == GameItem.Paper) && (player2 == GameItem.Rock)))
            {
                result = GameStatus.Player1Wins; // Player 1 wins
            }
            else
            {
                result = GameStatus.Player2Wins; // Player 2 wins
            }

            return result;
        }
    }
}
