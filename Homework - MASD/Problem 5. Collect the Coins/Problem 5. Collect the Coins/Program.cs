using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Collect_the_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> lineOne = Console.ReadLine().ToCharArray().ToList();
            List<char> lineTwo = Console.ReadLine().ToCharArray().ToList();
            List<char> lineThree = Console.ReadLine().ToCharArray().ToList();
            List<char> lineFour = Console.ReadLine().ToCharArray().ToList();
            List<char> commands = Console.ReadLine().ToCharArray().ToList();
            List<char> currL = new List<char>();
            Dictionary<int, List<char>> board = new Dictionary<int, List<char>>();
            board.Add(1, lineOne);
            board.Add(2, lineTwo);
            board.Add(3, lineThree);
            board.Add(4, lineFour);
            int currLine = 1;
            int currCol = 0;
            int walls = 0;
            int coins = 0;
            for (int i = 0; i < commands.Count; i++)
            {
                if (commands.ElementAt(i) == 'V')
                {
                    currLine++;
                    if (board.TryGetValue(currLine, out currL))
                    {
                        if (currCol > currL.Count)
                        {
                            walls++;
                            currLine--;
                        }
                        else
                        {
                            if (currL.ElementAt(currCol) == '$')
                            {
                                coins++;
                            }
                        }
                    }
                    else
                    {
                        walls++;
                        currLine--;
                    }
                }
                else if (commands.ElementAt(i) == '^')
                {
                    currLine--;
                    if (board.TryGetValue(currLine, out currL))
                    {
                        if (currCol > currL.Count)
                        {
                            walls++;
                            currLine++;
                        }
                        else
                        {
                            if (currL.ElementAt(currCol) == '$')
                            {
                                coins++;
                            }
                        }
                    }
                    else
                    {
                        walls++;
                        currLine++;
                    }
                }
                else if (commands.ElementAt(i) == '>')
                {
                    currCol++;
                    if (board.TryGetValue(currLine, out currL))
                    {
                        if (currCol > currL.Count)
                        {
                            walls++;
                            currCol--;
                        }
                        else
                        {
                            if (currL.ElementAt(currCol) == '$')
                            {
                                coins++;
                            }
                        }
                    }
                }
                else if (commands.ElementAt(i) == '<')
                {
                    if (board.TryGetValue(currLine, out currL))
                    {
                        currCol--;
                        if (currCol < 0)
                        {
                            walls++;
                            currCol++;
                        }
                        else
                        {
                            if (currL.ElementAt(currCol) == '$')
                            {
                                coins++;
                            }
                        }
                    }
                }

            }
            Console.WriteLine("Coins collected: {0}", coins);
            Console.WriteLine("Walls hit: {0}", walls);
        }
    }
}