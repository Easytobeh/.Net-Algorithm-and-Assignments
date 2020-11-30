using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbersIsThirty
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int firstNumber, secondNumber;
            Console.Write($"Kindly enter two Numbers;\n" +
                "First Number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            Console.WriteLine($"Test Result: {ValidateNumber(sum, firstNumber, secondNumber)}");//, ValidateNumber(sum, firstNumber, secondNumber));
            
        }

        static bool ValidateNumber(int sum, int x, int y)
        {
            if (sum == 30 || x == 30 || y == 30)
                return true;
            else
                return false;
        }
    }
}
