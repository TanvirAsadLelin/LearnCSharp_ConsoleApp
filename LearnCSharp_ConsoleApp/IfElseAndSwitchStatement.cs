using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class IfElseAndSwitchStatement
    {
        public void ifElseAndSwitchSatementMethod()
        {
            Console.WriteLine("Welcome to If...else & Switch statement. \n");

            Console.WriteLine("Enter a value for switch : \n");
            Console.WriteLine("N:B: 4 and 5 use for if..else and nested if..else. \n");
            int value;


            do
            {
                value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {

                    case 1:
                        Console.WriteLine("You enter 1.\n");
                        break;
                    case 2:
                        Console.WriteLine("You enter 2.\n");
                        break;
                    case 3:
                        Console.WriteLine("You enter 3.\n");
                        break;
                    case 4:
                        Console.WriteLine("This is if..else part.\n");
                        ifElse();
                        break;
                    case 5:
                        Console.WriteLine("This is nested if..else part.\n");
                        nestedIfElse();
                        break;

                    default:
                        Console.WriteLine("Thank you for see this section");
                        break;

                }
            } while (value != 0);




        }

        public void ifElse()
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("After use this age < 18 : you are younger than 18");
            }
            else
            {
                Console.WriteLine("Else part: you older than 18  ");
            }

        }
        public void nestedIfElse()
        {
            Console.WriteLine("Enter your age:  N:B: must enter an integer number .\n");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age >= 50)
            {
                if (age <= 100)
                {
                    Console.WriteLine("Your age range : 50 between 100");
                }
                else
                {
                    Console.WriteLine("Your age is larger than 100");
                }
            }
            else
            {
                Console.WriteLine("Your age is smaller than 50");
            }
        }
    }
}
