using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boredom_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            string yn = "no";
            string genre;
            string activity;
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Video Games");
            Console.WriteLine("2) Movies");
            Console.WriteLine("3) TV");
            Console.WriteLine("4) Random");

            c = Convert.ToInt32(Console.ReadLine());

            if (c == 1)
            {
                Console.WriteLine("Do you have a genre in mind?");
                yn = Console.ReadLine();
                if (yn == "yes")
                {
                    Console.WriteLine("Please pick a genre:");
                    Console.WriteLine("FPS");
                    Console.WriteLine("TPS");
                    Console.WriteLine("RTS");
                    Console.WriteLine("TBS");
                    genre = Console.ReadLine();
                } else
                {
                    //Pick a random game
                    activity = "Halo";
                    Console.WriteLine("I've chosen "+activity+" for you.");
                }
            }
            if (c == 2)
            {
                Console.WriteLine("");
            }
            if (c == 3)
            {
                Console.WriteLine("");
            }
            if (c == 4)
            {
                Console.WriteLine("");
            }


            Console.ReadLine();
        }
    }
}
