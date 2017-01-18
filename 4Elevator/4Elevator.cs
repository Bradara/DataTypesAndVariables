using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            if (numberOfPeople%capacity==0)
            {
                Console.WriteLine("{0}", numberOfPeople/capacity);
            }
            else
            {
                Console.WriteLine("{0}", numberOfPeople / capacity+1);
            }
            
        }
    }
}
