using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPL.Domain.Entities;

namespace WPL.Data.EntityConfig
{
    public class CampeonatoPlataformaConfig : IEntityTypeConfiguration<CampeonatoPlataforma>
    {
        public void Configure(EntityTypeBuilder<CampeonatoPlataforma> builder)
        {
            builder.ToTable("CampeonatoPlataforma");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CampeonatoId).IsRequired();
            builder.Property(x => x.PlataformaId).IsRequired();

            builder.HasOne(x => x.Campeonato).WithMany(p => p.Plataformas).HasForeignKey(x => x.CampeonatoId);
            builder.HasOne(x => x.Plataforma).WithMany(p => p.Campeonatos).HasForeignKey(x => x.PlataformaId);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime");
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime");
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao);
            builder.Property(x => x.IdJogadorCadastro);
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
