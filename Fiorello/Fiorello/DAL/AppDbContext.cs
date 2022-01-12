using Fiorello.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<SliderImage> SliderImages { get; set; }

        public DbSet<SliderContext> SliderContext { get; set; }

        public DbSet<Experts> Experts { get; set; }
    }
}
