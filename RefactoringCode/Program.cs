using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNum = int.Parse(Console.ReadLine());
            int sum = 0;            
            bool isSpecial = false;
            for (int num = 1; num <= lastNum; num++)
            {
                int temp = num;
                while (temp > 0)
                {
                    sum += temp % 10;
                    temp = temp / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{num} -> {isSpecial}");
                sum = 0;                
            }

        }
    }
}
