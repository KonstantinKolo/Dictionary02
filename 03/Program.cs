using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameString;
            string email;
            SortedDictionary<string, string> dict = new SortedDictionary<string, string>();
            while (true)
            {
                nameString = Console.ReadLine();
                if(nameString == "stop")
                {
                    break;
                }
                email = Console.ReadLine();
                if (email.Contains("us") || email.Contains("uk"))
                {
                    continue;
                }
                else
                {
                    dict.Add(nameString, email);
                }
            }
            foreach (var pair in dict)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
