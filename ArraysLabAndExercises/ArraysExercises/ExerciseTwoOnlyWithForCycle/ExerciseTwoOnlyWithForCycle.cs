using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ExerciseTwoOnlyWithForCycle
{
    static void Main(string[] args)
    {
        int[] numToRotate = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int r = int.Parse(Console.ReadLine());
        int[] sum = new int[numToRotate.Length];
        for (int i = 0; i < r; i++)
        {
            int lastElement = numToRotate[numToRotate.Length - 1];
            for (int j = numToRotate.Length - 1; j > 0; j--)
            {
                numToRotate[j] = numToRotate[j - 1];
            }
            numToRotate[0] = lastElement;
            for (int k = 0; k < numToRotate.Length; k++)
            {
                sum[k] += numToRotate[k];
            }
        }
        Console.WriteLine(String.Join(" ", sum));
    }
}

