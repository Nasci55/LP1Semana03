using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            float[,] matrixA = new float[2, 2];


            matrixA[0, 0] = float.Parse(args[0], CultureInfo.InvariantCulture);
            matrixA[0, 1] = float.Parse(args[1], CultureInfo.InvariantCulture);
            matrixA[1, 0] = float.Parse(args[2], CultureInfo.InvariantCulture);
            matrixA[1, 1] = float.Parse(args[3], CultureInfo.InvariantCulture);

            float[,] matrixB = new float[2, 1];

            matrixB[0, 0] = float.Parse(args[4], CultureInfo.InvariantCulture);
            matrixB[1, 0] = float.Parse(args[5], CultureInfo.InvariantCulture);

            float[,] result = new float[2, 1];

            for (int l = 0; l < 2; l++)
            {
                for (int j = 0; j < 1; j++)
                {
                    result[l, j] = 0;
                    for (int c = 0; c < 2; c++)
                    {
                        result[l, j] += matrixA[l, c] * matrixB[c, j];
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine($"| {result[i, j],7:F2} |");
                }
            }


        }
    }
}
