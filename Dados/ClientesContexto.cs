using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ClientesContexto : DbContext
    {
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>()
    .HasKey(t => t.ClienteId);

            modelBuilder.Entity<Cliente>().HasMany(c => c.Contatos).WithRequired(c => c.Cliente);
        }
    }
}
