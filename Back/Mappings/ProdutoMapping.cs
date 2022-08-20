using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.HasData(
                new Produto
                {
                    Id = 1,
                    Descricao = "Produto 01",
                    DataCadastro = DateTime.Now
                },
                new Produto
                {
                    Id = 2,
                    Descricao = "Produto 02",
                    DataCadastro = DateTime.Now
                }
            );

            /* ENTITY */
            builder.Property(x => x.DataCadastro)
                .HasColumnType("datetime");

            builder.Property(x => x.DataAlteracao)
                .HasColumnType("datetime");

            builder.ToTable("Produto");
        }
    }
}
