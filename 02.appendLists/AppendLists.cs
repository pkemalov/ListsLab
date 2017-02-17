using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsLab
{
    public class AppendLists
    {
        public static void Main()
        {
            var first = Console.ReadLine().Split('|').ToList();

            first.Reverse();
            var result = new List<string>();

            foreach (var item in first)
            {
                List<string> nums = item.Split(' ').ToList();

                foreach (var num in nums)
                {
                    if (num != "")
                    {
                        result.Add(num);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
