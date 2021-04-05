using System;
using System.Collections.Generic;
using System.Text;

namespace LINQAssigment
{
    public class Book
    {
        public Book(Author author)
        {
            Id = Guid.NewGuid();

            Author = author;
            Author.Books.Add(this);
        }

        public Guid Id { get; private set; }

        public string Title { get; set; }

        public DateTime PublishDate { get; set; }

        public Author Author { get; set; }

        public List<string> Categories { get; set; }

        public override string ToString()
        {
            var a = Title + " " + PublishDate.Year + " " + " {" ;
            foreach (string category in Categories)
            {
                a += category;
                a += " ";
            }
            return a + "}" + "\n";
        }
    }
}
