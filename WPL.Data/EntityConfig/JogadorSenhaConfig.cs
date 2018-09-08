using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPL.Domain.Entities;

namespace WPL.Data.EntityConfig
{
    public class JogadorSenhaConfig : IEntityTypeConfiguration<JogadorSenha>
    {
        public void Configure(EntityTypeBuilder<JogadorSenha> builder)
        {
            builder.ToTable("JogadorSenha");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Senha).HasColumnType("varchar(20)").IsRequired();

            builder.HasMany(x => x.Jogadores);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime");
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime");
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao);
            builder.Property(x => x.IdJogadorCadastro);
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
