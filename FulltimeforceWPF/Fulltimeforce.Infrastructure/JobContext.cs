using Fulltimeforce.Core;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Fulltimeforce.Infrastructure
{
    public class JobContext : DbContext
    {
        public JobContext() : base("JobContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
