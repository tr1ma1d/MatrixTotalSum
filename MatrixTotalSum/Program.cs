using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTotalSum
{
    internal class Program
    {
        static int findSumMatrix(int[,] matrix)
        {
            int sum = 0, negative = 0, minimum = 100_000_000;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int num = matrix[i, j];
                    sum += Math.Abs(num);
                    if(num < 0)
                    {
                        negative++;
                    }
                    minimum = Math.Min(minimum, Math.Abs(num));
                }
            }
            if(negative % 2 == 0)
            {
                return sum;
            }
            return sum - 2 * minimum;
        }

        static int GenerateRandomCount()
        {
            Random rnd = new Random();
            return rnd.Next(-50, 50);
        }

        static void Main(string[] args)
        {

            int n = 5;
            int m = 5;
            int[,] matrix = new int[n,m];
            for(int i = 0; i < n;i++)
            {
                for(int j = 0; j < m; j++)
                {
                    matrix[i, j] = GenerateRandomCount();
                }
            }
            int result = findSumMatrix(matrix);


            Console.WriteLine(result);
        }
    }
}
