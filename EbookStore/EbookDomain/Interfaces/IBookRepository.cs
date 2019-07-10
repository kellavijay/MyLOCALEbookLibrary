using EbookDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbookDomain.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
    }
}
