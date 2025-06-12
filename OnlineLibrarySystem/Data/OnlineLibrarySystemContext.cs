using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineLibrarySystem.Models;

namespace OnlineLibrarySystem.Data
{
    public class OnlineLibrarySystemContext : DbContext
    {
        public OnlineLibrarySystemContext (DbContextOptions<OnlineLibrarySystemContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineLibrarySystem.Models.Book> Book { get; set; } = default!;
    }
}
