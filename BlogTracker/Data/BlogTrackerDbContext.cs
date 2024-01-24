using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlogTrackerApi.Data
{
    public class BlogTrackerDbContext : DbContext
    {

        public BlogTrackerDbContext(DbContextOptions<BlogTrackerDbContext> options)
            : base(options)
        {
        }

        public DbSet<BlogTrackerApi.Models.BlogInfo> BlogInfo { get; set; } = default!;

        public DbSet<BlogTrackerApi.Models.EmpInfo>? EmpInfo { get; set; }
        public DbSet<BlogTrackerApi.Models.AdminInfo> AdminInfo { get; set; }
    }
}