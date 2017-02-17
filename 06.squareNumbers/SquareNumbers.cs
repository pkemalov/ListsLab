using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.squareNumbers
{
    public class SquareNumbers
    {
        public static void Main()
        {
            var listIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squaresList = new List<int>();

            foreach (var num in listIntegers)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squaresList.Add(num);
                }
                
            }
            squaresList.Sort();
            squaresList.Reverse();

            for (int i = 0; i < squaresList.Count; i++)
            {

            }
            Console.WriteLine(string.Join(" ", squaresList));
        }
    }
}
