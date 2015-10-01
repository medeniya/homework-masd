using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4.Seq_in_Matrix
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
            string[] maxSeq = new string[1];
            int i, j;
            int max = 0;
            for (i = 0; i < rowLength; i++)
            {
                int longestSeq = 0;
                for (j = 0; j < colLength; j++)
                {
                    int br = 1;
                    int currSeqA = 1;
                    int currSeqB = 1;
                    int currSeqC = 1;
                    int currSeqD = 1;
                    while (i - br >= 0 && j + br < colLength)
                    {
                        if (matrix[i, j] == matrix[i - br, j + br])
                        {
                            currSeqA++;
                            br++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (currSeqA > longestSeq)
                    {
                        longestSeq = currSeqA;   
                    }
                    br = 1;
                    while (j + br < colLength)
                    {
                        if (matrix[i, j] == matrix[i, j + br])
                        {
                            currSeqB++;
                            br++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (currSeqB > longestSeq)
                    {
                        longestSeq = currSeqB;
                    }
                    br = 1;
                    while (i + br < rowLength && j + br < colLength)
                    {
                        if (matrix[i, j] == matrix[i + br, j + br])
                        {
                            currSeqC++;
                            br++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (currSeqC > longestSeq)
                    {
                        longestSeq = currSeqC;
                    }
                    br = 1;
                    while (i + br < rowLength)
                    {
                        if (matrix[i, j] == matrix[i + br, j])
                        {
                            currSeqD++;
                            br++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (currSeqD > longestSeq)
                    {
                        longestSeq = currSeqD;
                    }
                    if (longestSeq > max)
                    {
                        max = longestSeq;
                        maxSeq[0] = matrix[i, j];
                    }
                }
             }
            for (int n = 0; n < max; n++)
            {
                Console.Write(maxSeq[0] + " ");
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
    }
}
