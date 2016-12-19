using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ExerciseElevenPairsByDifference
    {
    static void Main()
    {
        int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int difference = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            for (int j = 0; j < sequence.Length; j++)
            {
                int difToCheck = sequence[i] - sequence[j];
                if (difToCheck == difference)
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
}

