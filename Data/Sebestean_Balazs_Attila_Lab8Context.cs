using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sebestean_Balazs_Attila_Lab8.Models;

namespace Sebestean_Balazs_Attila_Lab8.Data
{
    public class Sebestean_Balazs_Attila_Lab8Context : DbContext
    {
        public Sebestean_Balazs_Attila_Lab8Context (DbContextOptions<Sebestean_Balazs_Attila_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Sebestean_Balazs_Attila_Lab8.Models.Book> Book { get; set; }

        public DbSet<Sebestean_Balazs_Attila_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Sebestean_Balazs_Attila_Lab8.Models.Category> Category { get; set; }
    }
}
