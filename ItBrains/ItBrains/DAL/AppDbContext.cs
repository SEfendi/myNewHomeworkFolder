using ItBrains.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<FeedBack> FeedBacks { get; set; }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Blog> Blogs { get; set; }
    }
}
