using Microsoft.EntityFrameworkCore;
using WebAPIFaseA.Entities;

namespace WebAPIFaseA.DataSource
{
    public class AmazonContext
    {
        public AmazonContext() { }

        public AmazonContext(DbContextOptions<AmazonContext> options)
        : base(options) { }


        public DbSet<Prodotto> Prodotti { get; set; }
        public DbSet<Cliente> Clienti { get; set; }
        public DbSet<Carrello> Carrello { get; set; }

    }
}
