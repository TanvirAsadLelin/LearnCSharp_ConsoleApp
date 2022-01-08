using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class DataTypes
    {

        public void dataTpyesMethod()
        {
            Console.WriteLine(" Welcome to data type part.\n");
            // declaring character
            char myLetter = 'G';
            Console.WriteLine(myLetter + " This is character value\n");
            // Integer data type is generally
            // used for numeric values
            int myNumI = 89;
            Console.WriteLine(myNumI + " This is integer value.Used for numeric values\n");
            short myShortNumS = 56;

            // this will give error as number
            // is larger than short range
            // short s1 = 87878787878;
            Console.WriteLine(myShortNumS + " This is short value.Smaller than short range 0 - 87878787878\n");
            // long uses Integer values which 
            // may signed or unsigned
            long myLongNuml = 4564;
            Console.WriteLine(myLongNuml + " This is long value.May signed or unsigned\n");
            // UInt data type is generally
            // used for unsigned integer values
            uint myUintValue = 95;
            Console.WriteLine(myUintValue + " This is uint value.used for unsigned integer values\n");
            ushort us = 76;
            // this will give error as number is
            // larger than short range
            Console.WriteLine(myShortNumS + " This is ushort value.Smaller than short range 0 - 87878787878 and use usigned values\n");
            // ulong data type is generally
            // used for unsigned integer values
            ulong myUlongvalue = 3624573;
            Console.WriteLine(myUlongvalue + " This is ulong value.used for unsigned integer values\n");
            // by default fraction value
            // is double in C#
            double myDoubleValue = 8.358674532d;
            Console.WriteLine(myDoubleValue + " This is double value. For double use 'd' as suffix\n");
            // for float use 'f' as suffix
            float myFloatValue = 3.7330645f;
            Console.WriteLine(myFloatValue + " This is float value. For double use 'f' as suffix\n");
            // for float use 'm' as suffix
            decimal myDecimalValue = 389.5m;
            Console.WriteLine(myDecimalValue + " This is decimal value. For decimal use 'm' as suffix\n");
            bool myBool = true;
            Console.WriteLine(myBool + " This is Boolean value .True or false are boolean.\n");// boolean
            string myText = "Hello";
            Console.WriteLine(myText + " This is String value\n\n");
        }
    }
}
