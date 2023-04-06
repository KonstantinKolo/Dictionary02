using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            SortedDictionary<double, int> dict = new SortedDictionary<double, int>();
            foreach(var element in input)
            {
                if (dict.ContainsKey(element))
                {
                    dict[element] = dict[element] + 1;
                }
                else
                {
                    dict.Add(element, 1);
                }
            }
            foreach (var pair in dict)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
