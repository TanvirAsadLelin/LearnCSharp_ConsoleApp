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
Console.WriteLine("13.List." + "  " + "Press:13\n");
Console.WriteLine("14.Methods & Return" + "  " + "Press:14\n");
Console.WriteLine("15.Exception Handling." + "  " + "Press:15\n");
Console.WriteLine("16.Class & Objects." + "  " + "Press:16\n");
Console.WriteLine("17.Constructors." + "  " + "Press:17\n");
Console.WriteLine("18.Destructors Concept." + "  " + "Press:18\n");
Console.WriteLine("19.Encapsulation & Properties Concept." + "  " + "Press:19\n");
Console.WriteLine("20.Abstruction Concept." + "  " + "Press:20\n");
Console.WriteLine("21.Inheritance." + "  " + "Press:21\n");
Console.WriteLine("22.Polymorphism." + "  " + "Press:22\n");




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

LearnCSharp_ConsoleApp.List listObj = new LearnCSharp_ConsoleApp.List();
LearnCSharp_ConsoleApp.MethodAndReturn methodAndReturnObj = new LearnCSharp_ConsoleApp.MethodAndReturn();
LearnCSharp_ConsoleApp.ExceptionHandling ExceptionHandlingObj = new LearnCSharp_ConsoleApp.ExceptionHandling();
LearnCSharp_ConsoleApp.ClassAndObjects classAndObjectsObj = new LearnCSharp_ConsoleApp.ClassAndObjects();
//LearnCSharp_ConsoleApp.Constructor constructorObj = new LearnCSharp_ConsoleApp.Constructor(); use in switch case 16
//LearnCSharp_ConsoleApp.Destructor destructorObj = new LearnCSharp_ConsoleApp.Destructor(); use in switch case 17
LearnCSharp_ConsoleApp.EncapsulationAndPropertiesConcepts encapsulationAndPropertiesConceptsObj = new LearnCSharp_ConsoleApp.EncapsulationAndPropertiesConcepts();
LearnCSharp_ConsoleApp.Abstraction abstractionObj = new LearnCSharp_ConsoleApp.Abstraction();
LearnCSharp_ConsoleApp.Inheritance inheritanceObj = new LearnCSharp_ConsoleApp.Inheritance();
LearnCSharp_ConsoleApp.Polymorphism polymorphismObj = new LearnCSharp_ConsoleApp.Polymorphism();



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
            //list

            listObj.listMethod();
            break;

        case 14:
            methodAndReturnObj.methodAndReturnMethod();
            break;
        case 15:
            ///Use for exception handling
            ///
            ExceptionHandlingObj.exceptionHandlingMethod();
            break;

        case 16:
            classAndObjectsObj.classAndObjectMethod();
            break;
        case 17:
            //Constructor part
            Console.WriteLine("Welcome to Constructor part. \n");
            LearnCSharp_ConsoleApp.Constructor constructorObj = new LearnCSharp_ConsoleApp.Constructor("Bangla book", "Lelin Books Ltd.", 400);
            Console.WriteLine(constructorObj.titleBook +"\n");
            Console.WriteLine(constructorObj.authorBook + "\n");
            Console.WriteLine(constructorObj.pagesBook + "\n");
            Console.WriteLine("The end of Constructor part. \n");
           

            break;

        case 18:
            //Destructor part
            Console.WriteLine("Welcome to Desstructor part. \n");
            LearnCSharp_ConsoleApp.Destructor destructorObj = new LearnCSharp_ConsoleApp.Destructor("lelin",25);

            Console.WriteLine(destructorObj.name);
            Console.WriteLine(destructorObj.age);
            Console.WriteLine("The end of Desstructor part. \n");

            break;

        case 19:
            //Encapsulation 
            encapsulationAndPropertiesConceptsObj.encapAndProMethod();
            break;

        case 20:
            //Abstruction Concept

            abstractionObj.abstractionMethod();

            break;
        case 21:
            //Inheritance

            Console.WriteLine("Welcome to Inheritance part. \n");

            inheritanceObj.inheritenceMethod();
             
            Console.WriteLine("The end of Inheritance part. \n");

            break;

        case 22:
            //Polymorphism Concept

            polymorphismObj.polymorphismMethod();

            break;


        case 0:
            Console.WriteLine("Thank you");
            break;


        default:
            Console.WriteLine("You press a wrong key...\n \n");
            break;
    }
} while (pressValue != 0);
    
   


