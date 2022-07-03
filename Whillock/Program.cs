using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whillock
{
    internal class Program
    {
       static string[] Restore(int slc2)
       {
            string[] up;
            up = new string[6];

            switch (slc2)
            {
                case 1:
                    up[0] = "[][][][][][][][][][][][][][][][][][][]";
                    up[4] = "1000";
                    up[5] = "82";
                    up[2] = "6";
                    up[3] = "                ";
                    break;

                case 2:
                    up[1] = ")))))))))))))))";
                    up[5] = "300";
                    up[4] = "152";
                    up[2] = "6";
                    up[3] = "                ";
                    break;

                case 3:
                    up[2] = "34";
                    up[3] = "                ";
                    up[4] = "152";
                    up[5] = "82";
                    break;

                case 4:
                    up[3] = "-_-_-_-_-_-_-_-_-_";
                    up[2] = "34";
                    up[4] = "152";
                    up[5] = "82";
                    break;
                
                default:
                up[0] = "this error message will never be displayed";
                break;
            }  

                

          return up;
       }

            static void Main(string[] args)
        {
            string blt="6";
            int slc;
            string[] up = new string[5];

            Console.WriteLine("\n\n   HP 152/1000 [][][][][][]");
            Console.WriteLine("   MP 82/300 ))))))");
            Console.WriteLine("   BULLETS X{0}",blt);
            Console.WriteLine("   WRATH (-_-_-_-_                )");

            Console.WriteLine("\n\n you found a energy kit, press to restore:\n\n 1-HP\n 2-MP\n 3-BULLETS\n 4-WRATH\n");
            slc=Convert.ToInt32(Console.ReadLine());

            while (slc != 1 && slc != 2 && slc != 3 && slc != 4)
            {
                Console.WriteLine("    -INVALID NUMBER-    ");
                Console.WriteLine("\n\n you found a energy kit, press to restore:\n\n 1-HP\n 2-MP\n 3-BULLETS\n 4-WRATH\n");
                slc = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            up = Restore(slc);

            Console.WriteLine("\n\n   HP {0}/1000 [][][][][][]{1}", up[4], up[0]);
            Console.WriteLine("   MP {0}/300 )))))){1}", up[5], up[1]);
            Console.WriteLine("   BULLETS X{0}", up[2] );
            Console.WriteLine("   WRATH (-_-_-_-_{0})", up[3]);        

            Console.ReadKey();
        }
    }
}
