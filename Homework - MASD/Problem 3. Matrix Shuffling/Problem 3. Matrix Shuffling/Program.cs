using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string[] sizeArr = size.Split(' ');
            int rowLength = Convert.ToInt32(sizeArr[0]);
            int colLength = Convert.ToInt32(sizeArr[1]);
            string[,] matrix = new string[rowLength, colLength];
            input(ref matrix, rowLength, colLength);
            while (true)
            {
                string strCommand = Console.ReadLine();
                string[] command = strCommand.Split(' ');
                int result;
                if (command[0] == "swap" && int.TryParse(command[1], out result) && int.TryParse(command[2], out result) && int.TryParse(command[3], out result) && int.TryParse(command[4], out result) && Convert.ToInt32(command[1]) < rowLength && Convert.ToInt32(command[2]) < colLength && Convert.ToInt32(command[3]) < rowLength && Convert.ToInt32(command[4]) < colLength)
                {
                    int x1 = Convert.ToInt32(command[1]);
                    int y1 = Convert.ToInt32(command[2]);
                    int x2 = Convert.ToInt32(command[3]);
                    int y2 = Convert.ToInt32(command[4]);
                    string temp = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = temp;
                    display(matrix, rowLength, colLength);
                }
                else if (command[0] == "END")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
        static void input(ref string[,] matrix, int rowLength, int colLength)
        {
            for (int row = 0; row < rowLength; row++)
            {
                string line = Console.ReadLine();
                string[] lineArr = line.Split(' ');
                for (int col = 0; col < colLength; col++)
                {
                    matrix[row, col] = lineArr[col];
                }
            }
        }
        
        static void display(string[,] matrix, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
