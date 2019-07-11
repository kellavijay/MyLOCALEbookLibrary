﻿using EbookApplication.interfaces;
using EbookApplication.ViewModels;
using EbookDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbookApplication.Services
{
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public BookViewModel GetBooks()
        {
            return new BookViewModel()
            {
                Books = _bookRepository.GetBooks()
            };
        }
    }
}
