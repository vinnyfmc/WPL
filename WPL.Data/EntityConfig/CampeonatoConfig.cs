using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPL.Domain.Entities;

namespace WPL.Data.EntityConfig
{
    public class CampeonatoConfig : IEntityTypeConfiguration<Campeonato>
    {
        public void Configure(EntityTypeBuilder<Campeonato> builder)
        {
            builder.ToTable("Campeonato");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasColumnType("varchar(200)").IsRequired(); 
            builder.Property(x => x.NomeAbreviado).HasColumnType("varchar(10)").IsRequired();
            builder.Property(x => x.ImagemLogo).HasColumnType("varchar(300)");
            builder.Property(x => x.ImagemRegulamentoSugestao).HasColumnType("varchar(300)");
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.TipoSugestao);

            builder.HasMany(x => x.Plataformas);
            builder.HasMany(x => x.Edicoes);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime");
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime");
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao);
            builder.Property(x => x.IdJogadorCadastro);
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
