using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExerciseSevenCountNumbersForCycle
{
    static void Main(string[] args)
    {
        string fullName = "First name: second name:";
        Console.WriteLine(fullName);
        Console.WriteLine("Entries =?");
        int entries = int.Parse(Console.ReadLine());
        string [][] names = new string [entries][];
       
        for (int row = 0; row < entries; row++)
        {
           names[row] = new string[2];
            for (int col= 0; col < 2; col++)
            {
                names[row][col] = Console.ReadLine();
            } 
        }
        for (int i = 0; i < names.Length; i++)
            {
            Console.WriteLine(String.Join("" ,names[i]));
            }
        //    Console.WriteLine(fullName);
        //    fullName = string.Format("First name: {0} second name: {1}", names[i], names[i+1]);
    }
}
