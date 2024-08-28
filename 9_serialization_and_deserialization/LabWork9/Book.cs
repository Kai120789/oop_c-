using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork8
{
    class Book
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }

        public Book(string title, string genre, string author)
        {
            Title = title ;
            Genre = genre;
            Author = author;
        }
    }
}
