using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CondenseArrayToNumber
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        while (numbers.Length > 1)
        {
            int[] condensed = new int[numbers.Length - 1];
            for (int i = 0; i < condensed.Length; i++)
            {
                condensed[i] = numbers[i] + numbers[i + 1];
            }
            numbers = condensed;
        }
        Console.WriteLine(String.Join(" ", numbers));
    }
}

