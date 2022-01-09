using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class Destructor
    {
        public string name;
        public int age;

        public Destructor(string aName , int aAge)
        {
            name = aName;
            age = aAge;
        }
        //Add destructor here
        ~Destructor(){
            Console.WriteLine("Destructor wrok here. it's destroy memory where this class object are used done. \n");

        }
    }

   
}
