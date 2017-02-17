using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.sortNumbers
{
    public class SortNumbers
    {
        public static void Main()
        {
            var sortNumbersList = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            sortNumbersList.Sort();

            for (var i = 0; i < sortNumbersList.Count; i++)
            {
                       
            }
            Console.WriteLine(string.Join(" <= ", sortNumbersList));
        }
    }
}
