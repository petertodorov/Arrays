﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFourSieveOfEratosthenes
{
    class ExerciseFourSieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }
            primes[0] = false;
            primes[1] = false;
            for (int p = 2; p <= n; p++)
            {
                if (primes[p] == true)
                {
                    for (int multiplier = 2; multiplier * p <= n; multiplier++)
                    {
                        primes[multiplier * p] = false;
                    }
                    Console.WriteLine(p + " ");
                }
            }
        }
    }
}
