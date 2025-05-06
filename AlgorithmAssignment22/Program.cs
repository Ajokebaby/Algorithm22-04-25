using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAssignment22
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
           
           
            for (int i = 1; i <= 100; i++)
            {
                numbers.Add(i);
            }

            MultiplesOfThreeAndFive(numbers);
           

        }

        public  static void MultiplesOfThreeAndFive(List<int> nums)
        {
            

            foreach (var number in nums)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else  
                {
                    Console.WriteLine(number);
                }
                

            }
            
        }
    }


    
}
