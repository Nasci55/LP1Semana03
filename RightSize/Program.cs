using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string w in args)
            {
                if (w.Length > 3)
                {
                    if (w.Length >= 8)
                    {
                        System.Console.WriteLine("[EARLY STOP]");
                        break;
                    }
                    Console.WriteLine(w);
                }
            }
        }
    }
}
