using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countdownnn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beta = 1,alpha = 5;

            var Green = ConsoleColor.Green;
            //Console.ForegroundColor = Green;
            var Red = ConsoleColor.Red;
            var Blue = ConsoleColor.Blue;
            var Yellow = ConsoleColor.Yellow;
            var White = ConsoleColor.White;
            var Cyan = ConsoleColor.Cyan;
            var Gray = ConsoleColor.Gray;
            var Magenta = ConsoleColor.Magenta;

            Random rd = new Random();

            do
            {
                int rand_num = rd.Next(1,8);

                switch (rand_num)
                {
                    case 1:
                        Console.ForegroundColor = Green;
                        break;

                    case 2:
                        Console.ForegroundColor = Red;
                        break;

                    case 3:
                        Console.ForegroundColor = Blue;
                        break;

                    case 4:
                        Console.ForegroundColor = Yellow;
                        break;

                    case 5:
                        Console.ForegroundColor = White;
                        break;

                    case 6:
                        Console.ForegroundColor = Cyan;
                        break;

                    case 7:
                        Console.ForegroundColor = Gray;
                        break;

                    case 8:
                        Console.ForegroundColor = Magenta;
                        break;

                }

                Console.WriteLine("\n\n\n      {0}", beta);
                System.Threading.Thread.Sleep(100);
                beta++;
                Console.Clear();
            } while (alpha != 4);

            Console.ReadKey();

            Environment.Exit(0);
        }
    }
}
