using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPL.Domain.Entities;

namespace WPL.Data.EntityConfig
{
    public class CampeonatoEdicaoFaseConfig : IEntityTypeConfiguration<CampeonatoEdicaoFase>
    {
        public void Configure(EntityTypeBuilder<CampeonatoEdicaoFase> builder)
        {
            builder.ToTable("CampeonatoEdicaoFase");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.Status).IsRequired();

            builder.HasOne(x => x.Edicao);

            builder.HasMany(x => x.Jogos);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime");
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime");
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao);
            builder.Property(x => x.IdJogadorCadastro);
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
