using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TenExtractMiddleElements
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = numbers.Length;
        int coef = numbers.Length / 2;
        int coefOdd = ((numbers.Length - 1) / 2);
        if (n == 1)
        {
            Console.WriteLine(numbers[0]);
        }
        else if (n % 2 == 0)
        {
            Console.WriteLine($"{numbers[coef - 1]},  {numbers[coef]}");
        }
        else if (n % 2 != 0)
        {
            Console.WriteLine($"{numbers[coefOdd - 1]}, {numbers[coefOdd]}, {numbers[coefOdd + 1]}");
        }
    }
}

