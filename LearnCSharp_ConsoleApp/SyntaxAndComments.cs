using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class SyntaxAndComments
    {
        int value;
        public void PrintHellowWorld()
        {
            Console.WriteLine("Welcome to systax part.\n");
            Console.WriteLine("Hello World");
        }

        public void CommentsMethod()
        {
            Console.WriteLine("Welcome to Comments part.\n");
            Console.WriteLine("Enter 1 for show Single line comment\n");
            Console.WriteLine("Enter 2 for show Multi line comment\n");
            do
            {
                value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Console.WriteLine("The // character sequence marks the text following it as a single-line comment\n" + "Here’s an example\n");
                        Console.WriteLine("// This first line comment. \n\n");
                        Console.WriteLine("Enter 2 for show Multi line comment\n");
                        break;

                    case 2:
                        Console.WriteLine("Multi-line comments have one or more lines of narrative within a set of comment delimiters. The /* delimiter marks the beginning of the comment, and the */ marks the end" + "Here’s an example\n");
                        Console.WriteLine("/* This  line comment. \n" + "2nd line here \n" + "3rd line here \n" + "4th line here. */ \n\n");
                        Console.WriteLine("Press 0 for exit from this section.\n");
                        break;
                    default:
                        Console.WriteLine("Sorry you press wrong keyword.\n");
                        break;
                }
            } while (value != 0);
        }




    }
}
