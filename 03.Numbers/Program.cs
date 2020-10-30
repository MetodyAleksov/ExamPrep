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
            List<int> arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            double average = arr.Sum() / arr.Count;
            arr.RemoveAll(x => x <= average);
            arr.Sort();
            arr.Reverse();
            List<int> top5nums = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                top5nums.Add(arr[i]);
            }
            Console.WriteLine(string.Join(" ", top5nums));
        }
    }
}
