using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace WebApiEntityFramework.Entities.ContextConfig
{
    public class Context : DbContext
    {
        public DbSet<tblUsuario> tblUsuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBSignalr;Data Source=NOTEBOOK-BRENNO");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblUsuario>(e => { e.HasKey(e => e.IdUsuario); });
        }
    }
}