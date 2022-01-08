using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class Loops
    {
        public void loopsMethod()
        {
            Console.WriteLine("Welcome to Loop part. \n");
            whileLoop();
            doWhileLoop();
            forLoop();
            foreachLoop();
            breakAndContinueInLoopMethod();

            Console.WriteLine("The end of Loop part. \n");

        }

        public void whileLoop()
        {
            Console.WriteLine("Part 1: "+" Print 0 to 5 using while loop:  \n");
            int i = 0;
            while (i < 6)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("End the while loop\n");

        }

        public void doWhileLoop()
        {
            Console.WriteLine("Part 2: " + " Print 0 to 5 using do..while loop:  \n");
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 6);
            Console.WriteLine("End the do..while loop\n");

        }
        public void forLoop()
        {
            int i;
            Console.WriteLine("Part 3: " + " Print 0 to 5 using for loop:  \n");
            
            for (i=0; i< 6;i++)
            {
                Console.WriteLine(i);
              
            }
            Console.WriteLine("End the for loop\n");

        }
        public void foreachLoop()
        {
            Console.WriteLine(" Print 0 to 5 using foreach loop:  \n");
         

            // creating an array
            int[] a_array = new int[] { 1, 2, 3, 4, 5};
            foreach (int items in a_array)
            {
                Console.WriteLine(items);
            }

        }

        public void breakAndContinueInLoopMethod()
        {
            Console.WriteLine("Part 4: " + "Use break and continue in loop:  \n");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("\nHere use continue because 4 is not here.\n");
                    continue;
                   // Console.WriteLine("4 is not here because here use continue.\n");
                }
                if (i == 7)
                {
                    Console.WriteLine("\nHere use break because 7 is not here.\n");
                    break;
                    //Console.WriteLine("8 is not here because here use break.\n");
                }
                
                Console.WriteLine(i);
            }
        }

    }
}
