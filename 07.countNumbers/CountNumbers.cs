using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.countNumbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            var integersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var countArray = new int[1001];

            foreach (var number in integersList)
            {
                countArray[number]++;
            }

            for (int i = 0; i < countArray.Length; i++)
            {
                if (countArray[i]>0)
                {
                    Console.WriteLine("{0} -> {1}", i, countArray[i]);
                }
                
            }

                
            
        }
    }
}
