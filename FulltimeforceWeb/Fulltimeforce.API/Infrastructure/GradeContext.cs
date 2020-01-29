using Microsoft.EntityFrameworkCore;
using System;

namespace Fulltimeforce.API.Infrastructure
{
    public class GradeContext : DbContext
    {
        public GradeContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Grade> Grades { get; set; }
    }
}
