// Here all variable declaration 
int pressValue;

Console.WriteLine("C# Programming at a glance.\r");
Console.WriteLine("----------------------------\n");

Console.WriteLine("This  is a Console appplication.Here i am try my best to add all basic concept of C# Programming language with OOP.\n"+"OOP stands for object oriented programming\n");

Console.WriteLine("1.About C# Programming." + "  " + "Press: 1\n");
Console.WriteLine("2.Syntax & Comments." + "  " + "Press: 2\n");
Console.WriteLine("3.Data Types." + "  " + "Press: 3\n");
Console.WriteLine("4.Type Casting." + "  " + "Press: 4\n");
Console.WriteLine("5.User Input." + "  " + "Press: 5\n");
Console.WriteLine("6.Operators." + "  " + "Press: 6\n");
Console.WriteLine("7.Math." + "  " + "Press: 7\n");
Console.WriteLine("8.String With Operations." + "  " + "Press: 8\n");
Console.WriteLine("9.Booleans Operation." + "  " + "Press: 9\n");
Console.WriteLine("10.If...Else & Switch Statement." + "  " + "Press: 10\n");
Console.WriteLine("11.Loops." + "  " + "Press:11\n");
Console.WriteLine("12.Arrays." + "  " + "Press:12\n");
Console.WriteLine("13.Methods & Return" + "  " + "Press:13\n");
Console.WriteLine("14.Exception Handling." + "  " + "Press:14\n");
Console.WriteLine("15.Class & Objects." + "  " + "Press:15\n");



Console.WriteLine("----------------------------\n");





//All class object here
LearnCSharp_ConsoleApp.AboutCSharpProgramming aboutObj = new LearnCSharp_ConsoleApp.AboutCSharpProgramming();
LearnCSharp_ConsoleApp.SyntaxAndComments syntaxAndCommentsObj = new LearnCSharp_ConsoleApp.SyntaxAndComments();
LearnCSharp_ConsoleApp.DataTypes dataTypesObj = new LearnCSharp_ConsoleApp.DataTypes();
LearnCSharp_ConsoleApp.TypeCasting typeCastingObj = new LearnCSharp_ConsoleApp.TypeCasting();
LearnCSharp_ConsoleApp.UserInput userInputObj = new LearnCSharp_ConsoleApp.UserInput();
LearnCSharp_ConsoleApp.Operators operatorsObj = new LearnCSharp_ConsoleApp.Operators();
LearnCSharp_ConsoleApp.MathOperation mathOperationObj = new LearnCSharp_ConsoleApp.MathOperation();
LearnCSharp_ConsoleApp.StringOperation stringOperationObj = new LearnCSharp_ConsoleApp.StringOperation();
LearnCSharp_ConsoleApp.BooleansOperation booleansOperationObj = new LearnCSharp_ConsoleApp.BooleansOperation();
LearnCSharp_ConsoleApp.IfElseAndSwitchStatement ifElseAndSwitchStatementObj = new LearnCSharp_ConsoleApp.IfElseAndSwitchStatement();
LearnCSharp_ConsoleApp.Loops loopsObj = new LearnCSharp_ConsoleApp.Loops();
LearnCSharp_ConsoleApp.Arrays arraysObj = new LearnCSharp_ConsoleApp.Arrays();
LearnCSharp_ConsoleApp.MethodAndReturn methodAndReturnObj = new LearnCSharp_ConsoleApp.MethodAndReturn();
LearnCSharp_ConsoleApp.ExceptionHandling ExceptionHandlingObj = new LearnCSharp_ConsoleApp.ExceptionHandling();
LearnCSharp_ConsoleApp.ClassAndObjects classAndObjectsObj = new LearnCSharp_ConsoleApp.ClassAndObjects();



do
{
    
    Console.WriteLine("Waiting for your choice ... Otherwise press 0 for Exit this application.\n");

    pressValue = Convert.ToInt32(Console.ReadLine());
    switch (pressValue)
    {
        case 1:
            aboutObj.AboutShowMethod();
            break;
        case 2:
            syntaxAndCommentsObj.PrintHellowWorld();
            Console.WriteLine("Check Comments in C#");
            syntaxAndCommentsObj.CommentsMethod();
            break;

        case 3:
            dataTypesObj.dataTpyesMethod();
            break;

        case 4:
            typeCastingObj.typeCastingMethod();
            break;
        case 5:
            userInputObj.userInputMethod();
            break;

        case 6:
            operatorsObj.operatorMethod();
            break;

        case 7:
           mathOperationObj.mathOperationMethod();
            break;
        case 8:
            stringOperationObj.stringOperationMethod();
            break;
        case 9:
            booleansOperationObj.booleansOperationMethod();
            break;

        case 10:
            ifElseAndSwitchStatementObj.ifElseAndSwitchSatementMethod();
            break;

        case 11:
            loopsObj.loopsMethod();
            break;
        case 12:
            arraysObj.arraysMethod();
            break;
        case 13:
            methodAndReturnObj.methodAndReturnMethod();
            break;
        case 14:
            ///Use for exception handling
            ///
            ExceptionHandlingObj.exceptionHandlingMethod();
            break;

        case 15:
            classAndObjectsObj.classAndObjectMethod();
            break;

        case 0:
            Console.WriteLine("Thank you");
            break;


        default:
            Console.WriteLine("You press a wrong key...\n \n");
            break;
    }
} while (pressValue != 0);
    
   


