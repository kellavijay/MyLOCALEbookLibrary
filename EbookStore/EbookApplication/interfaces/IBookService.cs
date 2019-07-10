using EbookApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbookApplication.interfaces
{
    public interface IBookService
    {
        IEnumerable<BookViewModel> GetBooks();
    }
}
