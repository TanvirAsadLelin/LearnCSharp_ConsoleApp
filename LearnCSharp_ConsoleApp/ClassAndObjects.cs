using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LearnCSharp_ConsoleApp
{
    internal class ClassAndObjects
    {
        public void classAndObjectMethod()
        {
            Console.WriteLine("Welcome to Class and Object part. \n");

            Console.WriteLine("Class: \n");
            Console.WriteLine("Class is the blueprint for the object. \n");
            Console.WriteLine("A class can contain. \n" + "Fields And Methods\n");

            Console.WriteLine("Fields : Variables to store data\n " + "Methods : Functions to perform specific tasks\n");


            Console.WriteLine("Object: \n");
            Console.WriteLine("An object is an instance of a class. \n");
            Console.WriteLine("Creating an Object of a class\n" + "In C#, here's how we create an object of the class.\n");

            Console.WriteLine("ClassName objectName = new ClassName();\n ");
            Console.WriteLine("For more details about class and object please click this website: \n ");
            var uri = "https://www.programiz.com/csharp-programming/class-objects";
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            Process.Start(psi);



            Console.WriteLine("The end of Calss and Object part. \n");
        }
    }
}
