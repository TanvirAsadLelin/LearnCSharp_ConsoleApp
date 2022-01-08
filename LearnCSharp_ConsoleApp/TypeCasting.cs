using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class TypeCasting
    {
        public void typeCastingMethod()
        {
            int value;
            Console.WriteLine("Welcome to Type Casting part.\n\n");
            Console.WriteLine("Enter 1 for Implicit casting\n");
            Console.WriteLine("Enter 2 for Explicit casting\n");
            Console.WriteLine("Enter 3 for Type Conversion method\n");
            do
            {
                value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Console.WriteLine("This is impilicit type casting :\n");
                        implicitCastingMthod();
                        Console.WriteLine("Enter 2 for Explicit casting\n");
                        break;

                    case 2:
                        Console.WriteLine("This is expilicit type casting :\n");
                          exlicitCastingMthod();
                        Console.WriteLine("Enter 3 for Type Conversion method\n");
                        break;

                    case 3:
                        Console.WriteLine("This is Type Conversion method :\n");
                        typeConvertUseMthod();
                        Console.WriteLine("Enter 0 for exit this section.\n\n");
                        break;
                    default:
                        Console.WriteLine("Sorry you press wrong keyword.\n");
                        break;
                }
            } while (value != 0);
        }

        public void implicitCastingMthod()
        {
            Console.WriteLine("Automatic casting: int to double");
            int myInt = 5;
            double myDouble = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine("After implicit casting: "+ myDouble);
        }

        public void exlicitCastingMthod()
        {
            Console.WriteLine("Manual casting: double to int");
            double myDouble = 5.25;
            int myInt = (int)myDouble;

            Console.WriteLine(myDouble);
            Console.WriteLine("After explicit casting: "+ myInt);
        }

        public void typeConvertUseMthod()
        {
            int myInt = 5;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine("Convert int to string use Convert.ToString method:  " + Convert.ToString(myInt));    
            Console.WriteLine("Convert int to double use Convert.ToDouble method:  " + Convert.ToDouble(myInt));    
            Console.WriteLine("Convert double to int use Convert.ToInt32 method:  " + Convert.ToInt32(myDouble));  
            Console.WriteLine("Convert bool to string use Convert.ToString method:  " + Convert.ToString(myBool));  

        }
    }
}
