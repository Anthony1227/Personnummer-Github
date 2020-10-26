using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnummer_Github
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawMenu();

            string input = Console.ReadLine();


            Console.ReadKey();
        }


        //Method for the Menu
        static void DrawMenu()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("*                                       *");
            Console.WriteLine("* Enter 12 digit Social Security Number *");
            Console.WriteLine("*                                       *");
            Console.WriteLine("*****************************************");
        }
    }
}
