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
                    Console.WriteLine(w);
                }
            }
        }
    }
}
