using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPL.Domain.Entities;

namespace WPL.Data.EntityConfig
{
    public class JogoTimeConfig : IEntityTypeConfiguration<JogoTime>
    {
        public void Configure(EntityTypeBuilder<JogoTime> builder)
        {
            builder.ToTable("JogoTime");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.GolsCasa).IsRequired();
            builder.Property(x => x.GolsFora).IsRequired();
            builder.Property(x => x.ImagemPlacar).HasColumnType("varchar(300)"); 
            builder.Property(x => x.ImagemAssistencias).HasColumnType("varchar(300)"); 
            builder.Property(x => x.ImagemGols).HasColumnType("varchar(300)"); 
            builder.Property(x => x.ImagemNotas).HasColumnType("varchar(300)");
            builder.Property(x => x.Confirmado).IsRequired();
            builder.Property(x => x.JogoId).IsRequired();
            builder.Property(x => x.TimeId).IsRequired();

            builder.HasOne(x => x.Jogo).WithMany(p => p.JogoTimes).HasForeignKey(x => x.JogoId);
            builder.HasOne(x => x.Time).WithMany(p => p.JogosTime).HasForeignKey(x => x.TimeId);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime");
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime");
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao);
            builder.Property(x => x.IdJogadorCadastro);
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
