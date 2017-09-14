using PizzariaSys.AcessoDados.Mapping;
using PizzariaSys.Dominio.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PizzariaSys.AcessoDados.Contexto
{
    public class EfContexto : DbContext
    {
        public EfContexto()
            :base("strConexao")
        {

        }

        //representa as tabelas do banco
        public DbSet<Cliente> Clientes { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //remove  os plural das tabelas e cascade
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(x => x.HasMaxLength(100));

            //configuração dos mapping
            modelBuilder.Configurations.Add(new ClienteMap());
        }
    }
}
