using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EbookInfraData.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EbookUI.Controllers
{
    public class BooksController : Controller
    {
        private readonly ebooklibraryDBcontext _context;

        public BooksController(ebooklibraryDBcontext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Books.ToListAsync());
        }

    }
}