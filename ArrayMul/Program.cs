using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            float[,] matrixA = new float[2, 2];


            matrixA[0, 0] = float.Parse(args[0]);
            matrixA[0, 1] = float.Parse(args[1]);
            matrixA[1, 0] = float.Parse(args[2]);
            matrixA[1, 1] = float.Parse(args[3]);


        }
    }
}
