using System;
using System.Collections.Generic; // Use for list
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class List
    {

        public void listMethod()
        {
            Console.WriteLine("Welcome to List. \n");
            List<string> listname = new List<string>();

            listname.Add("Lelin");
            listname.Add("Israt");
            listname.Add("Anik");

            for(int i=0; i < listname.Count; i++)
            {
                Console.WriteLine(listname[i]);
            }

            
            Console.WriteLine("The end of List. \n");
        }
    }
}
