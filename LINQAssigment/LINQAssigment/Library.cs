using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQAssigment
{
    public class Library
    {
        public Library()
        {
            Books = new List<Book>();
        }

        public List<Book> Books { get; set; }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBookById(Guid bookId)
        {
            var book = Books.Single(b => b.Id == bookId);

            Books.Remove(book);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return Books;
        }

        public IEnumerable<Book> GetBooksAfterGivenYear(int year)
        {
            return Books
                .Where(b => b.PublishDate.Year > year)
                .ToList();
        }

        public IEnumerable<Book> GetBooksWithGivenCategory(string category)
        {
            return Books
                .Where(b => b.Categories.Any(c => c.Contains(category)))
                .ToList();
        }

        public IEnumerable<string> GetAuthorsWithGivenNumberOfBooks(int numberOfBooks)
        {
            return Books
                .Select(b => b.Author)
                .Where(a => a.Books.Count() >= numberOfBooks)
                .Select(a => a.Name)
                .Distinct()
                .ToList();
        }

        public IEnumerable<string> GetAuthorsBornBeforeGivenYearWithGivenNumberOfBooksOfCategory(int year, int numberOfBooks, string category)
        {
            return Books
                .Select(b => b.Author)
                .Where(a => 
                    a.Books.Count(b => b.Categories.Any(c => c.Contains(category))) >= numberOfBooks 
                    && a.DateOfBirth.Year < year
                    )
                .Select(a => a.Name)
                .Distinct()
                .ToList();
        }

        public IEnumerable<IGrouping<int,Book>> GetBooksGroupedByDecade()
        {
            return Books.GroupBy(b => GetDecade(b.PublishDate.Year)).ToList();
        }

        private int GetDecade(int year)
        {
            return year / 10;
        }
    }
}
