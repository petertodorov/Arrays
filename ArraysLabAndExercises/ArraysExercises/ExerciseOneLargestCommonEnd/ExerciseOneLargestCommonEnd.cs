using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ExerciseOneLargestCommonEnd
{
    static void Main(string[] args)
    {
        string[] firstLine = Console.ReadLine().Split(' ');
        string[] secondLine = Console.ReadLine().Split(' ');
        int shortest = Math.Min(firstLine.Length, secondLine.Length);
        int leftCount = FindCommonEnd(firstLine, secondLine, shortest);
        Array.Reverse(firstLine);
        Array.Reverse(secondLine);
        int rightCount = FindCommonEnd(firstLine, secondLine, shortest);
        int result = Math.Max(leftCount, rightCount);
        Console.WriteLine(result);
    }
    private static int FindCommonEnd(string[] firstLine, string[] secondLine, int shortest)
    {
        int count = 0;
        for (int i = 0; i < shortest; i++)
        {
            if (firstLine[i] == secondLine[i])
            {
                count++;
            }
        }
        return count;
    }
}


