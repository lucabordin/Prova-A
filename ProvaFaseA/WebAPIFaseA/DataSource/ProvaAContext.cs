using Microsoft.EntityFrameworkCore;
using WebAPIFaseA.Entities;

namespace WebAPIFaseA.DataSource
{
    public class ProvaAContext: DbContext
    {
        public ProvaAContext()
        {

        }
        public ProvaAContext(DbContextOptions<ProvaAContext> options)
        : base(options)
        {

        }
        public DbSet<Prodotto> Prodotti { get; set; }
        public DbSet<Carrello> Carrelli { get; set; }
        public DbSet<Cliente> Clienti { get; set; }
    }
}
