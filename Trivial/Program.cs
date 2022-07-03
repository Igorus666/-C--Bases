using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alpha, delta;
            delta = 69;

            Console.WriteLine("Enter a number");

            if (!int.TryParse(Console.ReadLine(), out alpha))
                Console.WriteLine("Invalid value entered");

            else
                Console.WriteLine("You entered {0}", alpha);

            Console.ReadKey();

        }
            
    }
}
