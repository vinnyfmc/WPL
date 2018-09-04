using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPL.Domain.Entities;

namespace WPL.Data.EntityConfig
{
    public class CampeonatoEdicaoTimeConfig : IEntityTypeConfiguration<CampeonatoEdicaoTime>
    {
        public void Configure(EntityTypeBuilder<CampeonatoEdicaoTime> builder)
        {
            builder.ToTable("CampeonatoEdicaoTime");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Status).IsRequired();

            builder.HasOne(x => x.Edicao);
            builder.HasOne(x => x.Time);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao).IsRequired();
            builder.Property(x => x.IdJogadorCadastro).IsRequired();
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
