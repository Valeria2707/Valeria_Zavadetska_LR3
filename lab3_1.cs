using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { -1, -3, 10, 5 };
            var max = numbers.Max();
            var min = numbers.Min();
            var indexOfMax = numbers.IndexOf(max);
            var indexOfMin = numbers.IndexOf(min);

            var c = numbers[indexOfMax];
            numbers[indexOfMax] = numbers[indexOfMin];
            numbers[indexOfMin] = c;

           foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
