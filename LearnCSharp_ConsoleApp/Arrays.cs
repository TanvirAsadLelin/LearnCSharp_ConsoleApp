using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class Arrays
    {
        public void arraysMethod()
        {
            Console.WriteLine("Welcome to Loop part. \n");
            createAndAccessValue();
            lenghtOfArray();
            printArrayByLoop();
            sortArraysValues();
            usingSystemLinq();

            Console.WriteLine("The end of Array part. \n");

        }


        public void createAndAccessValue()
        {
            Console.WriteLine("Part 1: " + " Create and access a value of an array:  \n");

            string[] myArray = { "Lelin", "Anik", "Dipu" };

            Console.WriteLine("\nAccess the first value : \n" + myArray[0]);
            Console.WriteLine("End create & access.\n");

        }

        public void lenghtOfArray()
        {
            Console.WriteLine("Part 2: " + " Print the length of an array:  \n");

            int[] myArray = { 1, 2, 3, 4, 5, 6, 7 };
            
                Console.WriteLine("The length of array is: " + myArray.Length);
          
            Console.WriteLine("End the length part\n");

        }
        public void printArrayByLoop()
        {
            
            Console.WriteLine("Part 3: " + " Print value by froeach loop through an array:  \n");

            string[] myArray = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string index in myArray)
            {
                Console.WriteLine(index);
            }
            Console.WriteLine("End the print value part. \n");

        }
        public void sortArraysValues()
        {
            Console.WriteLine("Part 4: " + " Sort an array:  \n");

        
            Console.WriteLine("Sort a string type array\n");
            string[] myStringArray = { "Lelin", "Anik", "Dipu", "Israt" };
            Array.Sort(myStringArray);
            foreach (string i in myStringArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Sort an int type array\n");
            
            int[] myIntegerArray = { 5, 1, 8, 7 };
            Array.Sort(myIntegerArray);
            foreach (int i in myIntegerArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("End the sort array part part. \n");

        }

        public void usingSystemLinq()
        {

            Console.WriteLine("Part 5: " + " Using System.Linq through an array:  \n");

            int[] myArray = { 2,6,8,9 };
            Console.WriteLine("Max value of this array: "+myArray.Max());  // largest value
            Console.WriteLine("Min value of this array: " + myArray.Min());  // smallest value
            Console.WriteLine("Sum of all value of this array: " + myArray.Sum());  // sum of myNumbers

            Console.WriteLine("End the part. \n");

        }
    }
}
