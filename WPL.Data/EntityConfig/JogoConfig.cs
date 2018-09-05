using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPL.Domain.Entities;


namespace WPL.Data.EntityConfig
{
    public class JogoConfig : IEntityTypeConfiguration<Jogo>
    {
        public void Configure(EntityTypeBuilder<Jogo> builder)
        {
            builder.ToTable("Jogo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Data).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.GolsCasa);
            builder.Property(x => x.GolsCasa);
            builder.Property(x => x.Concluido).IsRequired();

            builder.HasOne(x => x.Fase);
            builder.HasOne(x => x.TimeCasa);
            builder.HasOne(x => x.TimeFora);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime");
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime");
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao);
            builder.Property(x => x.IdJogadorCadastro);
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
