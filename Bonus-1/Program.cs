using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            bool validInput, shouldContinue;
            string input;

            Console.WriteLine("Welcome to the Letter Grade Converter!");
            do
            {

                do
                {
                    Console.WriteLine("Enter a numerical grade:");
                    string integer = Console.ReadLine();
                    i = int.Parse(integer);
                    validInput = i < 1 || i > 100;
                }
                while (validInput);

                if (i >= 0 && i <= 60)
                {
                    Console.WriteLine("Letter Grade: F");
                }
                if (i >= 61 && i <= 62)
                {
                    Console.WriteLine("Letter Grade: D-");
                }
                if (i >= 63 && i <= 64)
                {
                    Console.WriteLine("Letter Grade: D");
                }
                if (i >= 65 && i <= 66)
                {
                    Console.WriteLine("Letter Grade: D+");
                }
                if (i >= 67 && i <= 71)
                {
                    Console.WriteLine("Letter Grade: C-");
                }
                if (i >= 72 && i <= 75)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                if (i >= 76 && i <= 79)
                {
                    Console.WriteLine("Letter Grade: C+");
                }
                if (i >= 80 && i <= 82)
                {
                    Console.WriteLine("Letter Grade: B-");
                }
                if (i >= 83 && i <= 85)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                if (i >= 86 && i <= 87)
                {
                    Console.WriteLine("Letter Grade: B+");
                }
                if (i >= 88 && i <= 92)
                {
                    Console.WriteLine("Letter Grade: A-");
                }
                if (i >= 93 && i <= 97)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                if (i >= 98 && i <= 100)
                {
                    Console.WriteLine("Letter Grade: A+");
                }
                else
                {
                }

                Console.WriteLine("Continue? (y/n)");
                input = Console.ReadLine();
                shouldContinue = input == "y";
            }
            while (shouldContinue);
        }
    }
}
