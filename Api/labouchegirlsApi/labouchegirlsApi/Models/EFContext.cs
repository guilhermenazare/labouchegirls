using System.Data.Entity;

namespace labouchegirlsApi.Models
{
    public class EFContext : DbContext
    {
        public EFContext()
            : base("name=DefaultConnection")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Atendente> Atendentes { get; set; } 
    }
}