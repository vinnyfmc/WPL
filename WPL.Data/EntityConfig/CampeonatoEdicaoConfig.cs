using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPL.Domain.Entities;

namespace WPL.Data.EntityConfig
{
    public class CampeonatoEdicaoConfig : IEntityTypeConfiguration<CampeonatoEdicao>
    {
        public void Configure(EntityTypeBuilder<CampeonatoEdicao> builder)
        {
            builder.ToTable("CampeonatoEdicao");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.DataInicio).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.DataFim).HasColumnType("DateTime");
            builder.Property(x => x.ImagemLogo).HasColumnType("varchar(300)");
            builder.Property(x => x.ImagemPremiacao).HasColumnType("varchar(300)");
            builder.Property(x => x.ImagemRegulamento).HasColumnType("varchar(300)");
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Tipo).IsRequired();

            builder.HasMany(x => x.Fases);
            builder.HasMany(x => x.Times);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao).IsRequired();
            builder.Property(x => x.IdJogadorCadastro).IsRequired();
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
