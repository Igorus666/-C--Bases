using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = "jkj";
            int count = 3;

            Console.WriteLine("\n\n  guess the secret word");

            while (pass != "kenobi" && count != 0)
            {
                Console.WriteLine("\n\n{0} Gesses left", count);
                pass = Console.ReadLine();
                Console.Clear();                        
                count--;
            }             

            if (pass == "kenobi")
                Console.WriteLine("\n\n  you won congratulations, was it worth it?");
            else
                Console.WriteLine("\n\n   VOCÊ PERDEU PALHAÇO");

            Console.Read();

        }
    }
}
