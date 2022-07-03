using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, res;
            int opr;
            string opr_n;

            Console.WriteLine("\n   CALCULATOR");
            Console.WriteLine("\n   1-Addition");
            Console.WriteLine("   2-Subtraction");
            Console.WriteLine("   3-Multiplication");
            Console.WriteLine("   4-Division");

            Console.Write("\n\n Write first number:" );
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n What will be the operation?");;
            opr = Convert.ToInt32(Console.ReadLine());

            if (opr != 1 && opr != 2 && opr != 3 && opr != 4)
                Console.WriteLine(" -INVALID OPERATION-");

            else
            {

                Console.Write("\n Write second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                if (opr == 1)
                {
                    res = num1 + num2;
                    opr_n = "addition";
                }
                else if (opr == 2)
                {
                    res = num1 - num2;
                    opr_n = "subtraction";
                }
                else if (opr == 3)
                {
                    res = num1 * num2;
                    opr_n = "product";
                }
                else
                {
                    res = num1 / num2;
                    opr_n = "division";
                }

                Console.Write("\n the result of your {0} is: {1}", opr_n, res);
            }


            Console.ReadKey();
        }
    }
}
