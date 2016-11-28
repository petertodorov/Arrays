using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FourLastKNumbersSumsSequence
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        long [] sequence = new long [n];
        sequence[0] = 1;

        for (int i = 1; i < n; i++)
        {
            int start = i - k;
            int end = i - 1;
            sequence[i] = SumElements(sequence, start, end);
        }
        PrintArray(sequence);
    }

    private static long SumElements(long [] sequence, int start, int end)
    {
        long sum = 0;
        for (int i = start; i <= end; i++) 
        {
            if (i>=0)
            {
                sum += sequence[i];
            }
        }
       return sum;
    }
    private static void PrintArray(long[] sequence)
    {
        Console.WriteLine(String.Join(" ", sequence));
    }
}


