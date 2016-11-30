using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SixRoundingNumbersAwayFromZero
    {
    static void Main(string[] args)
    {
        decimal[] numbers = Console.ReadLine().Replace('.', ',').Split(' ').Select(decimal.Parse).ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            int roundedNum = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
            Console.WriteLine($"{numbers[i]} => {roundedNum}");
            
        }
        Console.WriteLine("\nResults from SimpleSolution\n");
        SimpleSoulion(numbers);
    }

    private static void SimpleSoulion(decimal[] numbers)
    {
        foreach (var num in numbers)
        {
            if (num>0)
            {
                int temp = (int)(num + 0.5M);
                Console.WriteLine($"{num} => {temp}");
            }
            else if (num<0)
            {
                int temp = (int) num;
                temp = (int)(num - 0.5M);
                Console.WriteLine($"{num} => {temp}");
            }
            else
            {
                Console.WriteLine("0 => 0");
            }
        }
    }
}

