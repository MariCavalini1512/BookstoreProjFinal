using Microsoft.EntityFrameworkCore;
using Bookstoret2.Models;

namespace Bookstoret2.Data
{
	public class BookstoreContext : DbContext
	{
		public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
		{
		}

        public DbSet<Genre> Genres { get; set; }
    }
}
