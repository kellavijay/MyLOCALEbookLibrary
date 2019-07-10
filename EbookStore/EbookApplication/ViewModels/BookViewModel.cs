using System;
using System.Collections.Generic;
using System.Text;
using EbookDomain.Models;

namespace EbookApplication.ViewModels
{
    public class BookViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
