using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class ExceptionHandling
    {
        public void exceptionHandlingMethod()
        {
            Console.WriteLine("Welcome to Exception Handling part. \n");

            useExceptionOnly();

            defineSpecificException();

            Console.WriteLine("End of  Exception Handling part. \n");
        }

        public void useExceptionOnly()
        {
            Console.WriteLine("Part 1: " + " Use exception with exception message:  \n");
            try
            {
                Console.WriteLine("Enter a number: \n");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: \n");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Number 1 is Divide by Number 2 = " + Convert.ToDouble(num1 / num2));

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
        public void defineSpecificException()
        {
            Console.WriteLine("Part 2: " + " Use exception with specific exception message:  \n");
            try
            {
                Console.WriteLine("Enter a number: \n");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: \n");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Number 1 is Divide by Number 2 = " + Convert.ToDouble (num1 / num2));

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);

            }


        }

    }
}
