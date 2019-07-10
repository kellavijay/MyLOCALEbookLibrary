using System;
using System.Collections.Generic;
using System.Text;
using EbookDomain.Interfaces;
using EbookDomain.Models;
using EbookInfraData.Context;

namespace EbookInfraData.Repository
{
    public class BookRepository : IBookRepository
    {
        private ebooklibraryDBcontext _ctx;

        public BookRepository(ebooklibraryDBcontext ctx)
        {
            _ctx = ctx;
        }

        IEnumerable<Book> IBookRepository.GetBooks()
        {
            return _ctx.Books;
        }
    }
}
