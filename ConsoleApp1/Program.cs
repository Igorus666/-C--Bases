using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

      static int Cube(int num)
        {
            int delta;

            Console.Write("psiu, escreve um numero ae: ");
            delta = Convert.ToInt32(Console.ReadLine());

            delta = delta*num;
            return delta;   

        }
          static void Main(string[] args)
          {
            int alpha, delta;

        
            Console.Write("Type your number: ");
            alpha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("your name is {0}", alpha);

            delta = Cube(alpha);

            Console.WriteLine("But actually is {0}", delta);

            Console.ReadKey();
          }


    }
}
