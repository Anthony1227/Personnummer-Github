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
                MonthCheck(input);
                DayCheck(input);
                DateExist(input);
                BirthDayNumCheck(input);
                IsMale(input);
                Output(input);
               
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

        //Method that checks if the month is valid
        static bool MonthCheck(string input)
        {
            string month = input.Substring(4, 2);

            if (Int32.Parse(month) <= 12 && Int32.Parse(month) >= 1) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method that checks if the day is between 1 and 31

        static bool DayCheck(string input)
        {
            string day = input.Substring(6, 2);

            if (Int32.Parse(day) <= 31 && Int32.Parse(day) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method that checks if the date exists
        static bool DateExist(string input)
        {
            string year = input.Substring(0, 4);
            string month = input.Substring(4, 2);
            string day = input.Substring(6, 2);
            return Int32.Parse(day) <= DateTime.DaysInMonth(Int32.Parse(year), Int32.Parse(month));
        }

        //Method that checks if the birthday number is between 1 and 999
        static bool BirthDayNumCheck(string input)
        {
            string birthDayNum = input.Substring(8, 3);

            if (Int32.Parse(birthDayNum) <= 999 && Int32.Parse(birthDayNum) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method checks if the person is a male
        static bool IsMale(string input)
        {
            string genderNum = input.Substring(10, 1);

            if (Int32.Parse(genderNum) % 2 == 0)
                return false;
            else
                return true;
        }

        //Outputs diffrent messages based on result
        static void Output(string input)
        {
            if (AmountCheck(input) && YearCheck(input) && MonthCheck(input) && DayCheck(input) && BirthDayNumCheck(input) && DateExist(input))
            {
                Console.WriteLine("ssn is correct");
                if (IsMale(input))
                    Console.WriteLine("person is Male");
                else
                    Console.WriteLine("person is Woman");
            }
            else
            {
                Console.WriteLine("ssn is not correct");
            }
        }
    }
}
