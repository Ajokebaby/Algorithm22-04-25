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
            Console.WriteLine(MultiplesOfThreeAndFive(10));
            
        }

        public  static int MultiplesOfThreeAndFive(int num)
        {
            int sum = 0;

            for (int i = 1; i < num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }


    class MyClass
    {

    }
}
