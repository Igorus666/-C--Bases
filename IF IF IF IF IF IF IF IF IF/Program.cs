using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_IF_IF_IF_IF_IF_IF_IF_IF
{
    internal class Program
    {

        static int Big(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
                return num1;

            else if (num2 > num3 && num2 > num1)
                return num2;

            else 
            return num3;
            
        }

        static void Main(string[] args)
        {
            string name;
            bool test = false;
            int num1, num2, num3;

            Console.WriteLine("");
            Console.Write(" input your name: ");
            name = Console.ReadLine();

            if (!test)
                Console.WriteLine("");


            if (name == "igor")
                Console.WriteLine("Your name is {0}", name);

            else if (name == "gomorrah")
                Console.WriteLine("My son... you are alive");

            else if (name != "igor")
                Console.WriteLine("your name is shit bro");

            Console.WriteLine("");
            Console.Write("now enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("now enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("now enter YET another number: ");
            num3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("{0} is the bigger", Big(num1,num2,num3));


            Console.ReadKey();

        }
    }
}
