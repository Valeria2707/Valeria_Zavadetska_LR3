using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3._3
{
   
      

        class Program
        {

       
            static void Main(string[] args)
            {
            List<int> numbers = new List<int>() {-1, -3, -20, -5 };


            //int minNumber = (from x in numbers where x > 0 select x ).Min();

            // Console.WriteLine("Minimal positive element: " + minNumber);


             int minNumber = numbers.Select(num => {
                 if (num > 0)
                 {
                     return num;
                 }
                 else
                 {
                     return int.MaxValue;
                 }
             }).Min();

             var result = minNumber == int.MaxValue ? 0 : minNumber;
             Console.WriteLine("Min Positive Number = " + result);


        }
        
    }
}
