using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execption_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp, plural = "";
            bool trigger = false;
            int libnum = 0, sequence = 0;
            Games[] lib = new Games[100];


            var Green = ConsoleColor.Green;
            Console.ForegroundColor = Green;

            Console.Write("\n\n\n       Well cum to to gamestop, would you");
            Console.Write("\n    like to enter a game in the stock? [Y/N]: ");
            resp = Console.ReadLine();

            while (resp != "y" && resp != "Y" && resp != "n" && resp != "N")
            {
                Console.Clear();
                Console.Write("\n INVALID RESPONSE");
                Thread.Sleep(1000);
                Console.Write("\n please enter [Y/N]: ");
                resp = Console.ReadLine();
                Console.Clear();
            }

            if(resp == "n" || resp == "N")
            {
                Console.Write("\n the FUCK you doing here them?");
                Console.ReadKey();
                return;
            }          

            for (int count=0; resp != "n" && resp != "N"; count++)
            {
                lib[count] = new Games();

                lib[count].Name();
                trigger = lib[count].Multiplayer(trigger);

                if (trigger == true)
                {
                    trigger = false;
                    Console.WriteLine("\n\n\n   Enter the name of the game: {0}", lib[count].tittle);
                    if (lib[count].mult == true)
                        Console.WriteLine("   The game is 1-4 multiplayer");
                    else
                        Console.WriteLine("   The game is singleplayer");
                }

                lib[count].Time();
                lib[count].Plataform();

                Console.Clear();
                Console.Write("\n\n\n     Would you like to add another game? [Y/N]: ");
                resp = Console.ReadLine();

                libnum++;
            }
            if (libnum > 1)
                plural = "s";

            Console.Clear();
            Console.WriteLine("\n\n\n     your library contains {0} game{1}", libnum, plural);

            while (libnum > 0)
            {
                Console.WriteLine("\n     {0}º game\n", sequence+1);
                Console.WriteLine("  Name: {0}", lib[sequence].tittle);

                if (lib[sequence].mult == true)
                   Console.WriteLine("  The game is 1-4 multiplayer");
                else
                Console.WriteLine("  The game is singleplayer");
                Console.WriteLine("  Play time: {0} hours", lib[sequence].hours);
                Console.WriteLine("  Plataform: {0}\n\n", lib[sequence].plat);

                sequence++;
                libnum--;
            }
            Console.ReadKey();
        }

    }
}
