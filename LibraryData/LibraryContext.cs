using System;

using Microsoft.EntityFrameworkCore;

using LibraryData.Models;

namespace LibraryData
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options) { }

        public DbSet<Patron> Patrons { get; set; }
    }
}
