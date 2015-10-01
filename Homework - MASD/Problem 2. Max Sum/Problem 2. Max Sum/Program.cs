using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Max_Sum
{
    class Program
    {
        public static int sum = 0;
        public static int maxSum = 0;
        public static int maxSrow = 0;
        public static int maxScol = 0;
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string[] sizeArr = size.Split(' ');
            int rowLength = Convert.ToInt32(sizeArr[0]);
            int colLength = Convert.ToInt32(sizeArr[1]);
            int[,] matrix = new int[rowLength, colLength];
            input(ref matrix, rowLength, colLength);
            calculate(matrix, rowLength, colLength, ref sum, ref maxSum, ref maxSrow, ref maxScol);
            display(matrix, maxSum, maxSrow, maxScol);
        }
        static void input(ref int[,] matrix, int rowLength, int colLength)
        {
            for (int row = 0; row < rowLength; row++)
            {
                string line = Console.ReadLine();
                string[] lineArr = line.Split(' ');
                int[] lineInts = Array.ConvertAll(lineArr, int.Parse);
                for (int col = 0; col < colLength; col++)
                {
                    matrix[row, col] = lineInts[col];
                }
            }
        }
        static void calculate(int[,] matrix, int rowLength, int colLength, ref int sum, ref int maxSum, ref int maxSrow, ref int maxScol)
        {
            for (int row = 0; row < rowLength; row++)
            {
                for (int col = 0; col < colLength; col++)
                {
                    if (row + 2 < rowLength && col + 2 < colLength)
                    {
                        sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                            + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                            + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            maxSrow = row;
                            maxScol = col;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        static void display(int[,] matrix, int maxSum, int maxSrow, int maxScol)
        {
            Console.WriteLine("Sum = {0}", maxSum);
            for (int row = maxSrow; row < maxSrow + 3; row++)
            {
                for (int col = maxScol; col < maxScol + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
