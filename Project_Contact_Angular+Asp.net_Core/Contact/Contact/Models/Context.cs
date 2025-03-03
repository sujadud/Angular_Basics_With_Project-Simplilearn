using Microsoft.EntityFrameworkCore;

namespace Contact.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        public DbSet<Contacts>Contacts { get; set; }
    }
}
