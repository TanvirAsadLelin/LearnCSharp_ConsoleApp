using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class Constructor
    {

        public string titleBook;
        public string authorBook;
        public int pagesBook;
        public Constructor(string aTitleBook, string aAuthorBook, int aPagesBook)
        {
            titleBook = aTitleBook;
            authorBook = aAuthorBook;
            pagesBook = aPagesBook;
        }
        
    }




}
