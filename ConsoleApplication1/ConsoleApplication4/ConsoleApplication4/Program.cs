
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class NameAgeChecker
{
    static void Main(string[] arg)
    {
        Console.Write("Enter number of entries: ");
        int times = int.Parse(Console.ReadLine());
        string[] name = new string[times];
        int[] age = new int[times];
        Console.Write("Enter acceptable length of Name: ");
        int nameLen = int.Parse(Console.ReadLine());
        for (int i = 0; i < times; i++)
        {

            Console.Write("Enter Name: ");
            name[i] = Console.ReadLine();


            CheckName(times,  name);

            Console.Write("Enter Age: ");
            age[i] = int.Parse(Console.ReadLine());
            CheckAge(times, age, name);

        }
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine($"the Name of the person is {name[i]} and he is {age[i]} years old");
        }
    }

    private static void CheckName(int times, string[] name)
    {
        for (int i = 0; i < times; i++)
        {

            while (name[i].Length > 5)
            {
                Console.WriteLine($"Name of person is too long, please enter name again: ");
                name[i] = Console.ReadLine();
            }
        }

    }

    private static void CheckAge(int times, int[] age, string[] name)
    {
        for (int i = 0; i < times; i++)
        {
            while (age[i] > 100)
            {
                Console.WriteLine($"Age of {name[i]} not valid, please enter age again: ");
                age[i] = int.Parse(Console.ReadLine());

            }
        }
    }


}




