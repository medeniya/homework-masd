using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Fill_the_Matrix_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            int[,] output = new int[4, 4];
            filler(input, ref output);
            display(output);
        }

        static void filler(int[] input, ref int[,] matrix)
        {
            matrix = new int[4, 4];
            int nextNum = 0;
            for (int col = 0; col < 4; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < 4; row++, nextNum++)
                    {
                        matrix[row, col] = input[nextNum];
                    }
                }
                else
                {
                    for (int row = 3; row >= 0; row--, nextNum++)
                    {
                        matrix[row, col] = input[nextNum];
                    }
                }
            }
        }

        static void display(int[,] matrix)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
