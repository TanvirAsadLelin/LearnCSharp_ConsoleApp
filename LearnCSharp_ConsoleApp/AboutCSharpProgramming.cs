using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class AboutCSharpProgramming
    {
        public String? aboutString;
      
       public string AboutShowMethod()
        {
            Console.WriteLine("Welcome to about C# part.\n");
            aboutString = "It is an object-oriented programming language created by Microsoft that runs on the .NET Framework.\n\n";
            Console.WriteLine(aboutString);
            return aboutString;

        }
    }
}
