using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Night_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> data = new Dictionary<string, Dictionary<string, List<string>>>();
            Dictionary<string, List<string>> tempDict = new Dictionary<string,List<string>>();
            List<string> tempList = new List<string>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(';');
                if (input[0] == "END")
                {
                    break;
                }
                else
                {
                    //gradyt syshtestuwa
                    if (data.TryGetValue(input[0], out tempDict))
                    {
                        //zawedenieto syshtestwuwa
                        if (tempDict.TryGetValue(input[1], out tempList))
	                    {
                            //dobawq izpylnitelq
		                    tempList.Add(input[2]);
	                    }
                        //zawedenieto ne syshtestwuwa
                        else
	                    {
                            List<string> currPerformers = new List<string>();
                            //dobawq izpylnitelq w lista s izpylniteli
                            currPerformers.Add(input[2]);
                            //dobawq zawedenieto i lista s izpylniteli
                            tempDict.Add(input[1], currPerformers);
	                    }
                    }
                    //gradyt ne syshtestwuwa
                    else
	                {
                        Dictionary<string, List<string>> currVenues = new Dictionary<string,List<string>>();
                        List<string> currPerformers = new List<string>();
                        //dobawq izpylnitelq w lista s izpylniteli
                        currPerformers.Add(input[2]);
                        //dobawq zawedenieto w dictionary sys zawedeniq
                        currVenues.Add(input[1], currPerformers);
                        //dobawq grada i dicitonary na zawedeniqta s izpylnitelite
                        data.Add(input[0], currVenues);
	                }
                }
            }
            List<string> cities = new List<string>(data.Keys);
            Dictionary<string, List<string>> displayDict = new Dictionary<string,List<string>>();
            List<string> displayList = new List<string>();
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(cities[i]);
                if (data.TryGetValue(cities[i], out displayDict))
                {
                    List<string> venues = new List<string>(displayDict.Keys);
                    venues.Sort();
                    for (int j = 0; j < venues.Count; j++)
                    {
                        Console.Write("->{0}: ", venues[j]);
                        if (displayDict.TryGetValue(venues[j], out displayList))
                        {
                            displayList.Sort();
                            var uniquePerformers = new HashSet<string>(displayList);
                            int br = 1;
                            foreach (string name in uniquePerformers)
                            {
                                if (br == 1)
                                {
                                    Console.Write(name);
                                    br++;
                                }
                                else
                                {
                                    Console.Write(", " + name);
                                    br++;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
