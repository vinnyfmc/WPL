using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPL.Domain.Entities;

namespace WPL.Data.EntityConfig
{
    public class JogadorStatusHistoricoConfig : IEntityTypeConfiguration<JogadorStatusHistorico>
    {
        public void Configure(EntityTypeBuilder<JogadorStatusHistorico> builder)
        {
            builder.ToTable("JogadorStatusHistorico");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Status).IsRequired();

            builder.HasOne(x => x.Jogador);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao).IsRequired();
            builder.Property(x => x.IdJogadorCadastro).IsRequired();
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
