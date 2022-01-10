using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class Polymorphism
    {
        public void polymorphismMethod()
        {
            Console.WriteLine("Welcome to polymorphism part. \n");

            Console.WriteLine("polymorphism - poly(Many) + morphism(forms/behaviors). \n" +"Two types : \n");
            Console.WriteLine("1. Compile time or Static polymorphism (Achieved using Method overloading). \n" + "1. Runtime or Dynamic polymorphism.(Achieved using Method overriding) \n");
            Console.WriteLine("1.Method overloading: \n");
            MethodOverloading methodOverloadingObj = new MethodOverloading();
            methodOverloadingObj.sum(2, 3);

            Console.WriteLine("1.Method overriding: \n");

            Console.WriteLine("The end of polymorphism part. \n");
        }
    }

    class MethodOverloading
    {
        int res;
       public   void sum(int num1 , int num2)
        {
            res = num1 + num2;
            Console.WriteLine("Sum: " + res);
        }
       public void sum(int num1, int num2,int num3)
        {
            res = num1 + num2 +num3;
            Console.WriteLine("Sum: " + res);
        }
      public  void sum(float num1, float num2)
        {
            float resFloat = num1 + num2;
            Console.WriteLine("Sum: " + res);
        }
    }
}
