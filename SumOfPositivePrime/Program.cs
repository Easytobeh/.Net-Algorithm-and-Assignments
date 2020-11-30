using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPositivePrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started");
            int length = int.MaxValue;

            try
            {
                //Check if length is too large
            }
            catch (Exception)
            {

                throw;
            }

          //  List<int> numbers = new List<int>();

            int[] arr = new int[1]{0}; 


            Console.WriteLine(length);
            //Loop through array for primeNumbers
            for (int i = 1; i <= length; i++)
            {
                int count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && i != 1)
                    arr[0] += i;
               
                
            }
            Console.WriteLine("Sum of all Prime numbers between 0 and {0} is {1}", length, arr[0]);

            //Console.WriteLine(String.Join(", ", numbers));
            // numbers.ForEach(Console.WriteLine);

            // foreach (var primeNumber in numbers)
            //   Console.WriteLine(primeNumber);
        }

    }
}
