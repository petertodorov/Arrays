using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ArraysLab
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int numberOfLines = n;
        string[] arrayOfNumbers = new string[n];
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            arrayOfNumbers[i] = Console.ReadLine();
        }
        Array.Reverse(arrayOfNumbers);

        foreach (var number in arrayOfNumbers)
        {
            Console.Write($"{number} ");
        }

        
    }
}