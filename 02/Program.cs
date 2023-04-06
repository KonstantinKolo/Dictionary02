using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            SortedDictionary<string, string> numberBook = new SortedDictionary<string, string>();
            while (true)
            {
                input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "A")
                {
                    if (numberBook.ContainsKey(input[1]))
                    {
                        numberBook[input[1]] = input[2];
                    }
                    else
                    {
                        numberBook.Add(input[1], input[2]);
                    }
                }
                else if (input[0] == "S")
                {
                    if (numberBook.ContainsKey(input[1]))
                    {
                        Console.WriteLine(input[1] + " -> " + numberBook[input[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", input[1]);
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var pair in numberBook)
                    {
                        Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                    }
                }
                else if (input[0] == "END")
                {
                    break;
                }
            }
        }
    }
}
