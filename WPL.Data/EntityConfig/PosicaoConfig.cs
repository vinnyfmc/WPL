using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPL.Domain.Entities;

namespace WPL.Data.EntityConfig
{
    public class PosicaoConfig : IEntityTypeConfiguration<Posicao>
    {
        public void Configure(EntityTypeBuilder<Posicao> builder)
        {
            builder.ToTable("Posicao");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Logo).HasColumnType("varchar(300)");
            builder.Property(x => x.Nome).HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.NomeAbrevado).HasColumnType("varchar(5)").IsRequired();
            builder.Property(x => x.Status).IsRequired();

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao).IsRequired();
            builder.Property(x => x.IdJogadorCadastro).IsRequired();
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
