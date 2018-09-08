using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPL.Domain.Entities;

namespace WPL.Data.EntityConfig
{
    public class PlataformaConfig : IEntityTypeConfiguration<Plataforma>
    {
        public void Configure(EntityTypeBuilder<Plataforma> builder)
        {
            builder.ToTable("Plataforma");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ImagemLogo).HasColumnType("varchar(300)");
            builder.Property(x => x.Nome).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.NomeAbreviado).HasColumnType("varchar(5)").IsRequired();
            builder.Property(x => x.PlataformaDefault).IsRequired();
            builder.Property(x => x.Status).IsRequired();

            builder.HasMany(x => x.Campeonatos);
            builder.HasMany(x => x.Jogadores);
            builder.HasMany(x => x.Times);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime");
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime");
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao);
            builder.Property(x => x.IdJogadorCadastro);
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
