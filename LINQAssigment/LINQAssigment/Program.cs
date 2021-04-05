using System;
using System.Collections.Generic;

namespace LINQAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            var author = new Author()
            {
                Name = "Ion Creanga",
                DateOfBirth = new DateTime(1975, 10,10)
            };

            var author2 = new Author()
            {
                Name = "Ana Maria",
                DateOfBirth = new DateTime(1945, 4, 7)
            };

            var author3 = new Author()
            {
                Name = "Jhon Jhon",
                DateOfBirth = new DateTime(1995, 11, 8)
            };

            var book1 = new Book(author)
            {
                PublishDate = new DateTime(1975, 1, 1),
                Title = "Capra cu trei iezi",
                Categories = new List<string> { "drama" }
            };

            var book2 = new Book(author)
            {
                PublishDate = new DateTime(1979, 1, 1),
                Title = "Cei trei purcelusi",
                Categories = new List<string> { "drama", "action", "science-fiction" }
            };

            var book3 = new Book(author2)
            {
                PublishDate = new DateTime(1982, 1, 1),
                Title = "Alice in tara minunilor",
                Categories = new List<string> { "science-fiction", "action" }
            };

            var book4 = new Book(author)
            {
                PublishDate = new DateTime(1992, 11, 12),
                Title = "O vara rece",
                Categories = new List<string> { "romantic" }
            };

            var book5 = new Book(author2)
            {
                PublishDate = new DateTime(1990, 12, 12),
                Title = "New York City",
                Categories = new List<string> { "drama" }
            };

            var book6 = new Book(author)
            {
                PublishDate = new DateTime(1966, 2, 6),
                Title = "Godzila",
                Categories = new List<string> { "science-fiction" }
            };

            var book7 = new Book(author)
            {
                PublishDate = new DateTime(1966, 2, 6),
                Title = "Cand te-am cunoscut",
                Categories = new List<string> { "drama" }
            };

            var book8 = new Book(author3)
            {
                PublishDate = new DateTime(1988, 12, 6),
                Title = "Jurastic World",
                Categories = new List<string> { "science-fiction" }
            };

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);
            library.AddBook(book7);
            library.AddBook(book8);

            library.RemoveBookById(book1.Id);

            var books = library.GetAllBooks();
           // Display(books);

            var booksAfter1980 = library.GetBooksAfterGivenYear(1980);
           // Display(booksAfter1980);

            var booksDrama = library.GetBooksWithGivenCategory("drama");
           //  Display(booksDrama);


            var authors = library.GetAuthorsWithGivenNumberOfBooks(3);
           //  Display(authors);

            var authorsWithGivenCondition = library.GetAuthorsBornBeforeGivenYearWithGivenNumberOfBooksOfCategory(1990, 2, "science-fiction");
           //  Display(authorsWithGivenCondition);

            var booksGroupedByDecade = library.GetBooksGroupedByDecade();

            foreach (var item in booksGroupedByDecade)
            {
                Console.WriteLine( item.Key );
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2.ToString());
                }
            }



        }

        static void Display<T>(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString()); 
            }
        }
    }
}
