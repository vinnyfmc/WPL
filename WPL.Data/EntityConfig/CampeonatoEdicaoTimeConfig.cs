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
            builder.Property(x => x.CampeonatoEdicaoId).IsRequired();
            builder.Property(x => x.TimeId).IsRequired();

            builder.HasOne(x => x.CampeonatoEdicao).WithMany(p => p.Times).HasForeignKey(x => x.CampeonatoEdicaoId);
            builder.HasOne(x => x.Time).WithMany(p => p.CampeonatoEdicoes).HasForeignKey(x => x.TimeId);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime");
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime");
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao);
            builder.Property(x => x.IdJogadorCadastro);
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
