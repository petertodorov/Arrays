using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LabSumMinMaxFirstLastAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int sum = numbers.Sum();
        int min = numbers.Min();
        int max = numbers.Max();
        int first = numbers.First();
        int last = numbers.Last();
        double average = numbers.Average();
        
        Console.WriteLine($"\n{sum}\n{min}\n{max}\n{first}\n{last}\n{average}");


    }
}

