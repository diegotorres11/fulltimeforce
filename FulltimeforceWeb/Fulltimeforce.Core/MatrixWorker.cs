using System.Text;

namespace Fulltimeforce.Core
{
    public class MatrixWorker
    {
        public int[,] Sum(int[,] firstMatrix, int[,] secondMatrix)
        {
            int Xlength = 3;
            int Ylength = 3;
            int[,] matrix = new int[3, 3];

            for (int i = 0; i < Xlength; i++)
            {
                for (int j = 0; j < Ylength; j++)
                {
                    matrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return matrix;
        }

        public string SumAndPrint(int[,] firstMatrix, int[,] secondMatrix)
        {
            var result = new StringBuilder();
            int Xlength = 3;
            int Ylength = 3;
            int[,] matrix = Sum(firstMatrix, secondMatrix);

            for (int i = 0; i < Xlength; i++)
            {
                for (int j = 0; j < Ylength; j++)
                {
                    int value = matrix[i, j];

                    result.Append(value + " ");
                }

                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
