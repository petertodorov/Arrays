using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class EightSumArrays
{
    static void Main()
    {
        int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int lengthFirst = firstArr.Length;
        int lengthSecond = secondArr.Length;
        int lengthResultArr = Math.Max(lengthFirst, lengthSecond);
        int[] resultArr = new int[lengthResultArr];

        WriteSumArrays(firstArr, secondArr, resultArr, lengthFirst, lengthSecond);
    }

    private static void WriteSumArrays(int[] firstArr, int[] secondArr, int[] resultArr, int lengthFirst, int lengthSecond)
    {
        for (int i = 0; i < resultArr.Length; i++)
        {
            int cycleOne = i % lengthFirst;
            int cycleTwo = i % lengthSecond;
            resultArr[i] = firstArr[cycleOne] + secondArr[cycleTwo];
        }
        Console.WriteLine(String.Join(" ", resultArr));
    }
}

