using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FiveTripleSum
{
    static void Main(string[] args)
    {
        int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        ComparePairs(elements);
    }
    private static void ComparePairs(int[] elements)
    {
        int count = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            
            for (int j = i + 1; j < elements.Length; j++)
            {
                int a = elements[i];
                int b = elements[j];
                if (i < j && elements.Contains(a + b))
                {
                    Console.WriteLine($"{a} + {b} == {a + b}");
                    count++;
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}




