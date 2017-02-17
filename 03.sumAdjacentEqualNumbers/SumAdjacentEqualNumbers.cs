using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.sumAdjacentEqualNumbers
{
    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var equalNumbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 0; i < equalNumbers.Count-1; i++)
            {
                if (equalNumbers[i+1]==equalNumbers[i])
                {
                    equalNumbers[i] += equalNumbers[i + 1];
                    equalNumbers.RemoveAt(i + 1);

                    if (i<1)
                    {
                        i--;
                    }
                    else
                    {
                        i = i - 2;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", equalNumbers));



        }
    }
}
