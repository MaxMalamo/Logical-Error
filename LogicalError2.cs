using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalError2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 50;

            if (age >= 18 && age < 30)
            {
                Console.WriteLine("Over 18");
            }
            
            if (age >= 30 && age < 50)
            {
                Console.WriteLine("Over 30");
            }
            
            if (age >= 50)
            {
                Console.WriteLine("Over 50");
            }

            Console.ReadLine();
        }
    }
}
