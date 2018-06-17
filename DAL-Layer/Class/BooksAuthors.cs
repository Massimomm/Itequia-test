using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALLayer.Interface;
using Model;


namespace DALLayer.Class
{
    public class BooksAuthors : IBooksAuthors
    {
        List<Book> books = new List<Book>();
        List<Author> authors = new List<Author>();
        List<Book_Author> booksauthors = new List<Book_Author>();

        public BooksAuthors()
        {
            // Add Book
            books.Add(new Book { ID = 1, Title = "The Lord of the Rings", FirstPublished = 1954, AuthorsSummary = "Born in Almeria" });
            books.Add(new Book { ID = 2, Title = "The Destroyer", FirstPublished = 1971, AuthorsSummary = "Best Author of the Year" });
            books.Add(new Book { ID = 3, Title = "Tales from a Thousand and One Nights", FirstPublished = 0, AuthorsSummary = "" });

            // Add Author
            authors.Add(new Author { ID = 10, Name = "J. R. Tolkien" });
            authors.Add(new Author { ID = 20, Name = "Richard Sapir" });
            authors.Add(new Author { ID = 30, Name = "Warren Murphy" });

            // Add Relations Objects
            booksauthors.Add(new Book_Author { BookID = 1, AuthorID = 10});
            booksauthors.Add(new Book_Author { BookID = 2, AuthorID = 20 });
            booksauthors.Add(new Book_Author { BookID = 2, AuthorID = 30 });
            booksauthors.Add(new Book_Author { BookID = 3, AuthorID = null });

        }

        public List<Author> getAllAuthors()
        {
            return authors;
        }

        public List<Book> getAllABooks()
        {
            return books;
        }

        /// <summary>
        /// List Books on left join with Author
        /// </summary>
        /// <returns></returns>
        public List<BookAuthor> getAllABooksAuthors()
        {

            var result = (from booksAuthor in booksauthors
                          join book in books on booksAuthor.BookID equals book.ID
                          join author in authors on booksAuthor.AuthorID equals author.ID into authorsTMP
                          from subAuthors in authorsTMP.DefaultIfEmpty(new Author())
                          select new BookAuthor()
                          {
                              ID = book.ID,
                              Title = book.Title,
                              FirstPublished = book.FirstPublished,
                              AuthorsSummary = book.AuthorsSummary,
                              authorName = subAuthors.Name
                          }).OrderBy(o => o.FirstPublished).ToList();

            return result;

        }

        public List<BookAuthor> getFirstPublished()
        {
            var result = (from booksAuthor in booksauthors
                          join book in books on booksAuthor.BookID equals book.ID
                          join author in authors on booksAuthor.AuthorID equals author.ID into authorsTMP
                          from subAuthors in authorsTMP.DefaultIfEmpty(new Author())
                          where (book.FirstPublished != 0)
                          select new BookAuthor()
                          {
                              ID = book.ID,
                              Title = book.Title,
                              FirstPublished = book.FirstPublished,
                              AuthorsSummary = book.AuthorsSummary,
                              authorName = subAuthors.Name
                          }).OrderBy(o => o.FirstPublished).ToList();

            return result;
        }
    }
}
