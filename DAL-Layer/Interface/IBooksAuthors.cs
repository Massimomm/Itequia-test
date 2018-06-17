using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DALLayer.Interface
{
    public interface IBooksAuthors
    {
        List<Author> getAllAuthors();
        List<Book> getAllABooks();
        List<BookAuthor> getAllABooksAuthors();
        List<BookAuthor> getFirstPublished();
    }
}
