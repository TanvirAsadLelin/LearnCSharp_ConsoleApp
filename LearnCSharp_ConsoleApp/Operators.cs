using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class Operators
    {
        public void operatorMethod()
        {
            Console.WriteLine("Welcome to Operator part.\n\n");

            Console.WriteLine("Here i added 9 types of operators.\n");


            int value;
           
            Console.WriteLine("Enter 1 for Addition (+) Operator\n");
            Console.WriteLine("Enter 2 for Subtraction (-) Operator\n");
            Console.WriteLine("Enter 3 for Multiplication (*) Operator\n");
            Console.WriteLine("Enter 4 for Division (/) Operator\n");
            Console.WriteLine("Enter 5 for Modulus (%) Operator\n");
            Console.WriteLine("Enter 6 for Increment (++) Operator\n");
            Console.WriteLine("Enter 7 for Decrement (--) Operator\n");
            Console.WriteLine("Enter 8 for Assignment (=) Operator\n");
            Console.WriteLine("Enter 9 for Addition assignment (+=) Operator\n");
            do
            {
                value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Console.WriteLine("This is Addition (+) Operator :\n");
                        additionMthod();
                        Console.WriteLine("Enter 2 for Subtraction (-) Operator\n");
                        break;

                    case 2:
                        Console.WriteLine("This is Subtraction (-) Operator :\n");
                        subtractionMthod();
                        Console.WriteLine("Enter 3 for Multiplication (*) Operator\n");
                        break;

                    case 3:
                        Console.WriteLine("This is Multiplication (*) Operator :\n");
                        multiplicationMthod();
                        Console.WriteLine("Enter 4 for Division (/) Operator\n");
                        break;
                    case 4:
                        Console.WriteLine("This is Division (/) Operator :\n");
                        divisionMthod();
                        Console.WriteLine("Enter 5 for Modulus (%) Operator\n");
                        break;
                    case 5:
                        Console.WriteLine("This is Modulus (%) Operator :\n");
                        modulusMthod();
                        Console.WriteLine("Enter 6 for Increment (++) Operator\n");
                        break;
                    case 6:
                        Console.WriteLine("This is Increment (++) Operator :\n");
                        incrementMthod();
                        Console.WriteLine("Enter 7 for Decrement (--) Operator\n");
                        break;
                    case 7:
                        Console.WriteLine("This is Decrement (--) Operator :\n");
                        decrementMthod();
                        Console.WriteLine("Enter 8 for Assignment (=) Operator\n");
                        break;
                    case 8:
                        Console.WriteLine("This is Assignment (=) Operator :\n");
                        assignmentMthod();
                        Console.WriteLine("Enter 9 for Addition assignment (+=) Operator.\n");
                        break;
                    case 9:
                        Console.WriteLine("This is Addition assignment (+=) Operator :\n");
                        additionAssignmentMthod();
                        Console.WriteLine("Enter 0 for exit this section.\n");
                        break;
                    default:
                        Console.WriteLine("Sorry you press wrong keyword.\n");
                        break;
                }
            } while (value != 0);
        }
       
        

        public void additionMthod()
{
    Console.WriteLine("For addition: \n");
            Console.WriteLine("Enter two numbers : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int res = num1 + num2;
    Console.WriteLine("After added " + num1+ " and " + num2 + " = " + res);
}

public void subtractionMthod()
{
            Console.WriteLine("For subtraction: \n");
            Console.WriteLine("Enter two numbers : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int res = num1 - num2;
            Console.WriteLine("After subtraction " + num1 + " and " + num2 + " = " + res);
        }

        public void multiplicationMthod()
        {
            Console.WriteLine("For Multiplication: \n");
            Console.WriteLine("Enter two numbers : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int res = num1 * num2;
            Console.WriteLine("After multiplication " + num1 + " and " + num2 + " = " + res);
        }
        public void divisionMthod()
        {
            Console.WriteLine("For division: \n");
            Console.WriteLine("Enter two numbers : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int res = num1 / num2;
            Console.WriteLine("After division " + num1 + " and " + num2 + " = " + res);
        }
        public void modulusMthod()
        {
            Console.WriteLine("For modulus: \n");
            Console.WriteLine("Enter two numbers : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int res = num1 % num2;
            Console.WriteLine("After use modulus " + num1 + " and " + num2 + " = " + res);
        }
        public void incrementMthod()
        {
            Console.WriteLine("For increment: \n");
            Console.WriteLine("Enter a number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int res = num1++;
            Console.WriteLine("After use increment " + num1 +" = " + res);
        }
        public void decrementMthod()
        {
            Console.WriteLine("For decrement: \n");
            Console.WriteLine("Enter a number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int res = num1--;
            Console.WriteLine("After use decrement " + num1 + " = " + res);
        }
        public void assignmentMthod()
        {
            Console.WriteLine("For assignment: \n");
            Console.WriteLine("Enter a number which is store in another same type variable : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int res = num1;
            Console.WriteLine("After use assignment operator " + num1 + " = " + res);
        }
        public void additionAssignmentMthod()
        {
            Console.WriteLine("For Addition assignment: \n");
            Console.WriteLine("Enter a number which is changed by add 5 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            num1 += 5;
            int res = num1;
            Console.WriteLine("After use Addition assignment " + num1 + " = " + res);
        }

    }
}
