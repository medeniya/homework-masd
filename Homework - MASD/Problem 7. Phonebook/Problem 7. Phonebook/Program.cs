using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> phonebook = new Dictionary<string,List<string>>();
            List<string> existingContact = new List<string>();
            while (true)
            {
                string[] contact = Console.ReadLine().Split('-');
                if (contact[0] == "search")
                {
                    while (true)
                    {
                        string lookup = Console.ReadLine();
                        List<string> numbers = new List<string>();
                        if (phonebook.TryGetValue(lookup, out numbers))
                        {
                            Console.Write("{0} -> ", lookup);
                            foreach (var number in numbers)
                            {
                                Console.Write(number + " ");
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Contact {0} does not exist.", lookup);
                        }
                    }
                }
                else
                {
                    if (phonebook.TryGetValue(contact[0], out existingContact))
                    {
                        existingContact.Add(" // ");
                        existingContact.Add(contact[1]);
                    }
                    else
	                {
                        List<string> currCont = new List<string>();
                        currCont.Add(contact[1]);
                        phonebook.Add(contact[0], currCont);
	                }
                }
            }
        }
    }
}
