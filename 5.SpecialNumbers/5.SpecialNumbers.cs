using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = 0;             
                string stringI = i.ToString();
                for (int j = 0; j < stringI.Length; j++)
                {
                    sum += int.Parse(stringI[j].ToString());
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> true", i);
                }
                else
                {
                    Console.WriteLine("{0} -> false", i);
                }
            }           
        }
    }
}
//A number is special when its sum of digits is 5, 7 or 11.
//Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not(True / False).

