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
            try
            {
                string input = Console.ReadLine();

                AmountCheck(input);
                YearCheck(input);

               
            }
            catch
            {
                Console.WriteLine("SSN is not correct");
            } 
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

        //Method that checks if the input is a 12 character string
        static bool AmountCheck(string input)
        {
            int amount = 0;

            foreach (var num in input)
            {
                amount += 1;
            }

            if (amount != 12)
                return false;
            else
                return true;
        }

        //Method that checks if the year is between 1753 and 2020
        static bool YearCheck(string input)
        {
            string year = input.Substring(0, 4);

            if (Int32.Parse(year) <= 2020 && Int32.Parse(year) >= 1753)
                return true;
            else
                return false;
        }
    }
}
