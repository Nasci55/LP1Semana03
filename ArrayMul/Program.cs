using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(float[] args)
        {
            float[,] matrixA = new float[2, 2];

            matrixA[0, 0] = args[0];
            matrixA[0, 1] = args[1];
            matrixA[1, 0] = args[2];
            matrixA[1, 1] = args[3];


        }
    }
}
