using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            numbers[0] = 1;
            SumLastKNumbers(numbers,k);
        }

        private static void SumLastKNumbers(int[] numbers, int k)
        {
            for (int currentNumber = 1; currentNumber < numbers.Length; currentNumber++)
            {
                int start =  currentNumber- k;
                int end = currentNumber - 1;
                int sum = 0;
                for (int i = start; i <end; i++)
                {
                    sum += numbers[i];
                }
                numbers[currentNumber] = sum;
               
            }
            PrintArray(numbers);
        }

        private static void PrintArray(int[] numbers)
        {
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
