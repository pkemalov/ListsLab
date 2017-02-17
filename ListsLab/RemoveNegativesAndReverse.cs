using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsLab
{
    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = new List<int>();
            for (int i = 0; i < firstList.Count; i++)
            {
                if (firstList[i] > 0)
                {
                    result.Add(firstList[i]);
                }
            }
            result.Reverse();

            if (result.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.Write(string.Join(" ", result));
                Console.WriteLine();
            }
            

        }
    }
}