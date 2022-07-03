using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alpha, beta, delta;

            Console.Write("Enter First Number: ");
            alpha = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            beta = Convert.ToInt32(Console.ReadLine());

            delta = alpha+beta;

            Console.WriteLine("the result of the addition is "+ delta);

            Console.ReadKey();
        }
    }
}
