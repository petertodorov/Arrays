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
        int [] result = ExtractcMiddleArr(numbers);
        Console.WriteLine("{ " + String.Join(" ", result) + " }");
    }

    private static int[] ExtractcMiddleArr(int[] numbers)
    {
        int start = (numbers.Length / 2) - 1;
        int end = (numbers.Length / 2) + 1;
        int length = numbers.Length;
        if ( length== 1)
        {
            return numbers;
        }
        else if (length % 2 == 0)
        {
            return new int[] { numbers[start], numbers[end - 1] };
        }
        else 
        {
            return new int[] {numbers[start], numbers[start+1], numbers[end]};
        }
    }
}

