using Microsoft.EntityFrameworkCore;
using WebService.Models;

namespace WebService.Data
{
    public class DBManager : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source= PeerToPeer.db; foreign keys = true;");
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<JobResult> JobResults { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            List<Client> clients = new List<Client>();
            List<JobResult> jobResults = new List<JobResult>();

            modelBuilder.Entity<Client>().HasData(clients);
            modelBuilder.Entity<JobResult>().HasData(jobResults);
        }
        public DbSet<WebService.Models.JobResult>? JobResult { get; set; }
    }
}
