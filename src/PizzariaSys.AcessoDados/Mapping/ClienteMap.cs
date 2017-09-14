using PizzariaSys.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace PizzariaSys.AcessoDados.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");

            HasKey(x => x.Id);

            Property(x => x.Nome)
              .HasColumnName("Nome")
              .HasColumnType("varchar")
              .HasMaxLength(100)
              .IsRequired();

            Property(x => x.Logradouro)
              .HasColumnName("Logradouro")
              .HasColumnType("varchar")
              .HasMaxLength(200)
              .IsRequired();

            Property(x => x.Numero)
              .HasColumnName("Numero")
              .HasColumnType("int")
              .IsRequired();

            Property(x => x.Bairro)
              .HasColumnName("Bairro")
              .HasColumnType("varchar")
              .HasMaxLength(100)
              .IsRequired();

            Property(x => x.TelefoneFixo)
              .HasColumnName("TelefoneFixo")
              .HasColumnType("varchar")
              .HasMaxLength(10);

            Property(x => x.TelefoneCelular)
              .HasColumnName("TelefoneCelular")
              .HasColumnType("varchar")
              .HasMaxLength(11);
        }
    }
}
