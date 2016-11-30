using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SevenReverseAnArrayOfStrings
{
    static void Main(string[] args)
    {
        string [] input= Console.ReadLine().Split(' ').Select(Convert.ToString).ToArray();
        Array.Reverse(input);
        Console.Write(String.Join ("  ",input));
    }
}
