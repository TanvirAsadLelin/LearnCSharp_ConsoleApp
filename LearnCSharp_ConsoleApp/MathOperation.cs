using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class MathOperation
    {
        public void mathOperationMethod()
        {
            int value;
            Console.WriteLine("Welcome to Math operation part.\n\n");
            Console.WriteLine("Here added 7 types of math operations.\n");
            Console.WriteLine("Enter 1 for Math.Max(x,y) use\n");
            Console.WriteLine("Enter 2 for Math.Min(x,y) use\n");
            Console.WriteLine("Enter 3 for Math.Sqrt(x) use\n");
            Console.WriteLine("Enter 4 for Math.Abs(x) use\n");
            Console.WriteLine("Enter 5 for Math.Round(x) use\n");
            Console.WriteLine("Enter 6 for Math.PI use\n");
            Console.WriteLine("Enter 7 for Math.Log(x) use\n");
            do
            {
                value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Console.WriteLine("This is Math.Max(x,y) :\n");
                        mathMaxMthod();
                        Console.WriteLine("Enter 2 for Min(x,y)\n");
                        break;

                    case 2:
                        Console.WriteLine("This is Min(x,y) :\n");
                        mathMinMethod();
                        Console.WriteLine("Enter 3 for Math.Sqrt(x)\n");
                        break;

                    case 3:
                        Console.WriteLine("This is Math.Sqrt(x):\n");
                        mathSqrtMthod();
                        Console.WriteLine("Enter 4 for Math.Abs(x)\n\n");
                        break;
                    case 4:
                        Console.WriteLine("This is Math.Abs(x).\n");
                        mathAbsMthod();
                        Console.WriteLine("Enter 5 Math.Round(x).\n\n");
                        break;
                    case 5:
                        Console.WriteLine("This is Math.Round(x)\n");
                        mathRouondMthod();
                        Console.WriteLine("Enter 6 for Math.PI.\n\n");
                        break;
                    case 6:
                        Console.WriteLine("This is Math.PI\n");
                        mathPIMthod();
                        Console.WriteLine("Enter 7 for Math.Log(x).\n\n");
                        break;
                    case 7:
                        Console.WriteLine("This is Math.Log(x)\n");
                        mathLogMthod();
                        Console.WriteLine("Enter 0 for exit this section.\n\n");
                        break;


                    default:
                        Console.WriteLine("Sorry you press wrong keyword.\n");
                        break;
                }
            } while (value != 0);
        }

        public void mathMaxMthod()
        {
            Console.WriteLine("For want max value: \n");
            Console.WriteLine("Enter two numbers : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nAfter use Math.Max : " + Math.Max(num1,num2));

        }

        public void mathMinMethod()
        {
            Console.WriteLine("For want min value: \n");
            Console.WriteLine("Enter two numbers : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAfter use Math.Min : " + Math.Min(num1, num2));

        }

      public void mathSqrtMthod()
        {
            Console.WriteLine("For want Sqrt value: \n");
            Console.WriteLine("Enter a number for Sqrt : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("\nAfter use Math.Sqrt : " + Math.Sqrt(num1));

        }
        public void mathAbsMthod()
        {
            Console.WriteLine("For want a absolute (Positive) value : \n");
            Console.WriteLine("Enter a number for abs value : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nAfter use Math.Abs : " + Math.Abs(num1));

        }
        public void mathRouondMthod()
        {
            Console.WriteLine("For round a number to the nearest whole number : \n");
            Console.WriteLine("Enter a number for round value : ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nAfter use Math.Round : " + Math.Round(num1));

        }
        public void mathPIMthod()
        {
            Console.WriteLine("For know value of pie : \n");
            Console.WriteLine("\nAfter use Math.PI : "+ Math.PI);
        }
        public void mathLogMthod()
        {
            Console.WriteLine("For log operation : \n");
            Console.WriteLine("Enter a  number for log : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nAfter use Math.Log : " + Math.Log(num1));

        }


    }
}
