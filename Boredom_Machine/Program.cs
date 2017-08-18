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
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Video Games");
            Console.WriteLine("2) Movies");
            Console.WriteLine("3) TV");
            Console.WriteLine("4) Random");

            c = Convert.ToInt32(Console.ReadLine());

            if (c == 1)
            {
                Console.WriteLine("");
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
