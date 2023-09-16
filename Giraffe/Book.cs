using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string name)
        {
            Console.WriteLine("Creating Book, initialization done!" + name);
        }
    }
}
