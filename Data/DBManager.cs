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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            List<Client> clients = new List<Client>();
        }
    }
}
