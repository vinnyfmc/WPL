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

            builder.HasOne(x => x.Jogo);
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
