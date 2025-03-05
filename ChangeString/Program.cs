using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string cOut = Console.ReadLine();

            char chosenChar = char.Parse(cOut);

            char substitute = char.Parse("x");

            foreach (char c in input)
            {
                if (c == chosenChar)
                {
                    System.Console.Write(substitute);
                }
                System.Console.Write(c);

            }



        }
    }
}
