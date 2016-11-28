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
        int a = new int();
        int b = new int();
        for (int i = 0; i < elements.Length; i++)
        {
            for (int j = i + 1; j < elements.Length; j++)
            {
                a = elements[i];
                b = elements[j];
                if (i < j && elements.Contains(a + b))
                {
                    Console.WriteLine($"{a} + {b} == {a + b}");
                }
            }
        }
    }
}




