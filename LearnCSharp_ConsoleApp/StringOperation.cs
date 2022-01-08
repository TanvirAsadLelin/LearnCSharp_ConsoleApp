using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class StringOperation
    {
        public void stringOperationMethod()
        {
            string value1 = "Hello";
            string value2 = "My name is \"Vikings\".";
            Console.WriteLine("Welcome to String part.\n\n");

            Console.WriteLine("Enter a string for some string operation: ");

            string stringvaule = Console.ReadLine();

            Console.WriteLine("After use stringvaule.Length :" + stringvaule.Length +"\n");
            Console.WriteLine("After use stringvaule.ToUpper :" + stringvaule.ToUpper() + "\n");
            Console.WriteLine("After use stringvaule.ToLower :" + stringvaule.ToLower() + "\n");
            Console.WriteLine("After use string.Concat :" + string.Concat(stringvaule , value1 ) + "\n");
            Console.WriteLine($"After use String interpolation: {value1} {stringvaule}" + "\n");
            Console.WriteLine("After access a single chracter which position is 2 from your entered string :" + stringvaule[1] + "\n");
            Console.WriteLine("After know a single character position in your entered string :" + stringvaule.IndexOf(stringvaule[1]) + "\n");
            Console.WriteLine("After use quotes in string :" +value2+ "\n");
            Console.WriteLine("\n The end of stringt part section. \n ");
        }
    }



    
}
