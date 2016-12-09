using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = input.Length / 4;
        int[] firstKElements = new int[k];
        int[] lastKElements= new int[k];
        int[] middleElements = new int[k * 2];
        int[] sum = new int[middleElements.Length];
        for (int i = 0; i < k; i++)
        {
            firstKElements[i] = input[i];
            lastKElements[i] = input[i + (3 * k) ];
        }
        Array.Reverse(firstKElements);
        Array.Reverse(lastKElements);
        int[] firstRow = new int[2 * k];
        firstRow = firstKElements.Concat(lastKElements).ToArray();
        for (int i = 0; i < middleElements.Length; i++)
        {
            middleElements[i] = input[i + k]; 
        }
        for (int i = 0; i < middleElements.Length; i++)
        {
            sum[i] = firstRow[i]+middleElements[i];
        }
        Console.WriteLine(String.Join(" ", sum));
    }
}

