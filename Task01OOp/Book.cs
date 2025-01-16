using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01OOp
{
    public struct Book
    {
        public string Title {  get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public Book(string title ,string author ,string _ISBN)
        { 
            Title = title;
            Author = author;
            ISBN = _ISBN;

        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
        }
    }
}
