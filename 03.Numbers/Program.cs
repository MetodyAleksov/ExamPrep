using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> arr = Console.ReadLine()
                .Split()
                .Select(double
                .Parse)
                .ToList();
            double average = arr.Sum() / arr.Count;
            average = Math.Floor(average);
            arr.RemoveAll(x => x <= average);
            arr.Sort();
            arr.Reverse();
            List<double> top5nums = new List<double>();
            if (arr.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i >= arr.Count)
                    {
                        break;
                    }
                    top5nums.Add(arr[i]);
                }
                Console.WriteLine(string.Join(" ", top5nums));
            }
        }
    }
}
