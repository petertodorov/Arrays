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
    }

}

