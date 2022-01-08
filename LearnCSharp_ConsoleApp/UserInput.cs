using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class UserInput
    {
        

        public void userInputMethod()
        {
            Console.WriteLine("Welcome to UserInput part.\n\n");

            Console.WriteLine("Enter your name: ");

            string yourName = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is " + yourName+ " and your age is " + age);
            Console.WriteLine("\n The end of user input part section. \n ");
        }
    }
}
