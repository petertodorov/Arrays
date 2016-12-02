using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SevenNewSollutionWithSwapMethod
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            SwapElements(numbers, i, numbers.Length - 1 - i);
        }   
        Console.WriteLine(String.Join(" ", numbers));
    }
    private static void SwapElements(int[] numbers, int i, int j)
    {
        int old = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = old;
    }
}

