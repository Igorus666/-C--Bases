using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execption_object
{
    internal class Games
    {
        public string tittle;
        public bool mult;
        public int hours;
        public string plat;

        public void Name()
        {
            string resp;
            Console.Write("\n\n\n   Enter the name of the game: ");
            resp = Console.ReadLine();
            tittle = resp;
        }
        public bool Multiplayer(bool trigger)
        {
            string resp;

            Console.Write("   Is the game multiplayer [Y/N]: ");
            resp = Console.ReadLine();

            while (resp != "y" && resp != "Y" && resp != "n" && resp != "N")
            {
                Console.Clear();
                trigger = true;
                Console.Write("\n INVALID RESPONSE");
                Thread.Sleep(1000);
                Console.Write("\n please enter [Y/N]: ");
                resp = Console.ReadLine();
                Console.Clear();
            }

            if (resp == "n" || resp == "N")
                mult = false;

            else mult = true;

            return trigger;
        }

        public void Time()
        {
            int resp;
            Console.Write("   How many hours is the game: ");
            while (!int.TryParse(Console.ReadLine(), out resp))
            {
                Console.Clear();
                Console.Write("\n INVALID RESPONSE");
                Thread.Sleep(1000);
                Console.Write("\n please enter the number of hours of the game: ");
            }

            hours = resp;
        }

        public void Plataform()
        {
            string resp;
            Console.Write("   For witch plataform is the game?\n\n      1-Playstation\n      2-Xbox\n      3-Nintendo\n");
            resp = Console.ReadLine();

            while (resp != "1" && resp != "2" && resp != "3")
            {
                Console.Clear();
                Console.Write("\n INVALID RESPONSE");
                Thread.Sleep(1000);
                Console.Write("\n please enter: ");
                Console.Write("\n      1-Playstation\n      2-Xbox\n      3-Nintendo\n");
                resp = Console.ReadLine();
            }


            switch (resp)
            {
                case "1":
                    plat = "Playstation";
                    break;

                case "2":
                    plat = "Xbox";
                    break;

                case "3":
                    plat = "Nintendo";
                    break;
            }

        }

    }
}
