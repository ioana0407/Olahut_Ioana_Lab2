using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Olahut_Ioana_Lab2.Models;

namespace Olahut_Ioana_Lab2.Data
{
    public class Olahut_Ioana_Lab2Context : DbContext
    {
        public Olahut_Ioana_Lab2Context (DbContextOptions<Olahut_Ioana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Olahut_Ioana_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Olahut_Ioana_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Olahut_Ioana_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
