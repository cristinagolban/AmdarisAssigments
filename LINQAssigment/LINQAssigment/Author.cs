using System;
using System.Collections.Generic;

namespace LINQAssigment
{
    public class Author
    {
        public Author()
        {
            Id = Guid.NewGuid();

            if (Books == null) 
                Books = new List<Book>();
        }

        public Guid Id { get; private set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<Book> Books { get; set; }

        public override string ToString()
        {
            var a= Name + " " + DateOfBirth.Year + ": "  ;
            foreach(Book book in Books)
            {
                a += book.Title;
                a += " ";
            }
            return a + "\n";
        }
    }
}
