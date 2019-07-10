using EbookDomain.Models;
using Microsoft.EntityFrameworkCore;

namespace EbookInfraData.Context
{
    public class ebooklibraryDBcontext: DbContext
    {
        public ebooklibraryDBcontext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
