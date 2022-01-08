using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class BooleansOperation
    {
        public void booleansOperationMethod()
        {
            Console.WriteLine("Welcome to String part.\n\n");

            Console.WriteLine("Enter a two integer value for boolean operation: ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());

           

            Console.WriteLine("After use value 1 is less then value 2 (value1<value2) :" + (value1<value2) + "\n");
            Console.WriteLine("After use value 1 is equal to value 2 (value1==value2) :" + (value1 == value2) + "\n");
        
           
            Console.WriteLine("\n The end of boolean part section. \n ");
           

        }

        
    }
}
