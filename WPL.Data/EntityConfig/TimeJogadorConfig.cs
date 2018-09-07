using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPL.Domain.Entities;
namespace WPL.Data.EntityConfig
{
    public class TimeJogadorConfig : IEntityTypeConfiguration<TimeJogador>
    {
        public void Configure(EntityTypeBuilder<TimeJogador> builder)
        {
            builder.ToTable("TimeJogador");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.EhManager).HasColumnType("bit").IsRequired();
            builder.Property(x => x.EhSubManager).HasColumnType("bit").IsRequired();
            builder.Property(x => x.Status).IsRequired();

            builder.HasOne(x => x.PosicaoDefault);
            builder.HasOne(x => x.Jogador);
            builder.HasOne(x => x.Time);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime");
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime");
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao);
            builder.Property(x => x.IdJogadorCadastro);
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}