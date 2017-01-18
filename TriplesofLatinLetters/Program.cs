using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesofLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char endChar = (char)(98 + n - 1);
            for (char i = 'a'; (int)i < endChar; i = (char)(i + 1))
            {
                for (char j = 'a'; (int)j < endChar; j = (char)(j + 1))
                {
                    for (char k = 'a'; (int)k < endChar; k = (char)(k + 1))
                    {
                        Console.WriteLine("{0}{1}{2}", i, j, k);
                    }
                }
            }
        }
    }
}
//Write a program to read an integer n and print all triples of the first n small Latin letters, ordered alphabetically: