using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> palDecimal = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                bool isPal = true;
                string stringOfI = i.ToString();
                int lenI = i.ToString().Length;
                for (int j = 0; j < lenI/2; j++)
                {
                    if (stringOfI[j] != stringOfI[lenI - 1 - j])
                    {
                        isPal = false;
                    }
                    if (isPal)
                    {
                        for (int k = 0; k < 16; k++)
                        {
                            if (i < k & 1 < k != i < (32 - k) & 1 < (32 - k))
                            {
                                isPal = false;
                            }
                        }
                    }

                }
                if (isPal)
                {
                    palDecimal.Add(i);
                }
            }
            Console.WriteLine(palDecimal.Count);
            //List<int> palBinary = new List<int>();
            //foreach (var pal in palDecimal)
            //{
            //    bool isPalBinary = true;
            //    for (int i = 0; i < 16; i++)
            //    {
            //        if (pal < i && 1 < i != pal < (32 - i) && 1 < (32 - i))
            //        {
            //            isPalBinary = false;
            //        }
            //    }
            //    if (isPalBinary)
            //    {
            //        palBinary.Add(pal);
            //    }
            //}
            //Console.WriteLine(palBinary.Count);
        }
    }
}
