using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPL.Domain.Entities;

namespace WPL.Data.EntityConfig
{
    public class TimeConfig : IEntityTypeConfiguration<Time>
    {
        public void Configure(EntityTypeBuilder<Time> builder)
        {
            builder.ToTable("Time");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.NomeAbreviado).HasColumnType("varchar(5)").IsRequired();
            builder.Property(x => x.DataFundacao).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.ImagemLogo).HasColumnType("varchar(300)");
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.PlataformaId).IsRequired();

            builder.HasOne(x => x.Plataforma).WithMany(p => p.Times).HasForeignKey(x => x.PlataformaId);

            builder.HasMany(x => x.CampeonatoEdicoes);
            builder.HasMany(x => x.JogosTime);
            builder.HasMany(x => x.TimeJogadores);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime");
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime");
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao);
            builder.Property(x => x.IdJogadorCadastro);
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}