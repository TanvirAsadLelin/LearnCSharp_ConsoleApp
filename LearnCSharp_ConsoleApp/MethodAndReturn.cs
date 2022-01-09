using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class MethodAndReturn
    {
        public void methodAndReturnMethod()
        {
            Console.WriteLine("Welcome to Method and Return part. \n");
            createCallMthodWithParam();
            createReturnvalueFromMethod();
            methodOverloading();

           Console.WriteLine("The end of Method and Return part. \n");
        }

        public void createCallMthodWithParam()
        {
            Console.WriteLine("Part 1: " + " Create and call a method with parameter:  \n");

            callByMethod("Lelin");
            Console.WriteLine("End create & access.\n");

        }

        static void callByMethod(string myName)
        {
            Console.WriteLine("My  name is " + myName);
        }

        public void createReturnvalueFromMethod()
        {
            int num3, num4;
            Console.WriteLine("Part 2: " + " Create and return value from a method with parameter:  \n");

            Console.WriteLine("Enter two values as a parameter for method : \n");
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());
            callByReturn(num3, num4);
            Console.WriteLine("End Create and return value from a method with parameter.\n");
        }

        static int callByReturn(int num1,int num2)
        {
            
            int res = num1+num2;

            Console.WriteLine("My  name is " + res);

            return res;
        }

        public void methodOverloading()
        {
            Console.WriteLine("Part 3: " + " Method overloading:  \n");

            Console.WriteLine("With method overloading, multiple methods can have the same name with different parameters. \n");


            myMethod(1, 2);
            myMethod(1, 2, 3);
            myMethod(1, 2, 3, 4);
            Console.WriteLine("\nEnd Method overloading.\n");



        }

        int myMethod(int num1 , int num2)
        {
            int sum = num1+num2;
            Console.WriteLine("Sum two numbers:  " + sum);
            return sum;

        }

        int myMethod(int num1, int num2 , int num3)
        {
            int sum = num1 + num2 +num3;
            Console.WriteLine("Sum three numbers:  " + sum);
            return sum;

        }
        int myMethod(int num1, int num2,int num3 , int num4)
        {
            int sum = num1 + num2+num3+num4;
            Console.WriteLine("Sum four numbers:  " + sum);
            return sum;

        }




    }
}
