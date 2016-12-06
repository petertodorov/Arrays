using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class ExerciseTwoRotateAndSum
{
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());
            int[] result = new int[numbers.Length];
            RotateAndPrint(numbers, result, rotation);
        }
        private static void RotateAndPrint(int[] numbers, int[] result, int rotation)
        {
            for (int i = 0; i < rotation; i++)
            {
                RotateArr(numbers);
                SumResult(result, numbers);
            }
            Console.WriteLine(String.Join(" ", result));
        }
        private static void SumResult(int[] result, int[] numbers)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                result[j] += numbers[j];
            }
        }
        private static void RotateArr(int[] numbers)
        {
            int lastElement = numbers[numbers.Length - 1];
            Array.Copy(numbers, 0, numbers, 1, numbers.Length - 1);
            numbers[0] = lastElement;
        }
    }

