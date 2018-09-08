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
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CampeonatoEdicaoFaseId).IsRequired();
            builder.Property(x => x.TimeCasaId).IsRequired();
            builder.Property(x => x.TimeForaId).IsRequired();

            builder.HasOne(x => x.CampeonatoEdicaoFase).WithMany(p => p.Jogos).HasForeignKey(x => x.CampeonatoEdicaoFaseId);
            builder.HasOne(x => x.TimeCasa).WithMany(p => p.JogosTimeCasa).HasForeignKey(x => x.TimeCasaId);
            builder.HasOne(x => x.TimeFora).WithMany(p => p.JogosTimeFora).HasForeignKey(x => x.TimeForaId);

            builder.HasMany(x => x.JogoJogadores);
            builder.HasMany(x => x.JogoTimes);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime");
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime");
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao);
            builder.Property(x => x.IdJogadorCadastro);
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
