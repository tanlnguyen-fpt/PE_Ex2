using Microsoft.EntityFrameworkCore;
using PE_Ex2.Models;

namespace PE_Ex2.Data
{
    public class BookManagementSystemContext : DbContext
    {
        public BookManagementSystemContext(DbContextOptions<BookManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = null!;
    }
}
