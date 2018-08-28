using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPL.Domain.Entities;

namespace WPL.Data.EntityConfig
{
    public class JogadorConfig : IEntityTypeConfiguration<Jogador>
    {
        public void Configure(EntityTypeBuilder<Jogador> builder)
        {
            builder.ToTable("Jogador");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CEP).HasColumnType("varchar(8)");
            builder.Property(x => x.CPF).HasColumnType("varchar(11)").IsRequired();
            builder.Property(x => x.Email).HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Nome).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.TagName).HasColumnType("varchar(20)").IsRequired();
            builder.Property(x => x.DataNascimento).HasColumnType("DateTime").IsRequired();

            builder.HasOne(x => x.Plataforma);
            builder.HasOne(x => x.PosicaoPreferida);

            builder.HasMany(x => x.HistoricosStatus);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao).IsRequired();
            builder.Property(x => x.IdJogadorCadastro).IsRequired();
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
