using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Array.Sort(input);
            int br = 1;
            for (int i = 1; i <= input.Length; i++)
            {
                if (i != input.Length)
                {
                    if (input[i] == input[i - 1])
                    {
                        br++;
                    }
                    else
                    {
                        Console.WriteLine("{0}: {1} time/s", input[i - 1], br);
                        br = 1;
                    }
                }
                else
                {
                    Console.WriteLine("{0}: {1} time/s", input[i - 1], br);
                }
            }
        }
    }
}
