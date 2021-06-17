using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public string Publication { get; set; }

        public Book(string title, string author, string publication)
        {
            this.Title = title;
            this.Author = author;
            this.Publication = publication;
        }

        public override string ToString()
        {
            return string.Format("Book: {0}, Author: {1}, Publication: {2}", Title, Author, Publication);
        }
    }
}
