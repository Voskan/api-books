using Microsoft.EntityFrameworkCore;
using My_books.Data.Models;

namespace My_books.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<Book> Books { get; set; }
    }
}