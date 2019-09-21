using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestZone.Entities.BaseEntites;

namespace TestZone
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("AppDBContext")
        {
            
        }
        public DbSet<Recipient> Recipients { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<BatchRecipient> BatchRecipients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
