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

            builder.Property(x => x.Nome).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.TagName).HasColumnType("varchar(20)").IsRequired();
            builder.Property(x => x.DataNascimento).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.CPF).HasColumnType("varchar(11)").IsRequired();
            builder.Property(x => x.Email).HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.CEP).HasColumnType("varchar(8)");
            builder.Property(x => x.JogadorSenhaId);
            builder.Property(x => x.PlataformaId).IsRequired();
            builder.Property(x => x.PosicaoId).IsRequired();

            builder.HasOne(x => x.JogadorSenha).WithMany(p => p.Jogadores).HasForeignKey(x => x.JogadorSenhaId);
            builder.HasOne(x => x.Plataforma).WithMany(p => p.Jogadores).HasForeignKey(x => x.PlataformaId);
            builder.HasOne(x => x.PosicaoPreferida).WithMany(p => p.Jogadores).HasForeignKey(x => x.PosicaoId);

            builder.HasMany(x => x.HistoricosStatus);
            builder.HasMany(x => x.JogosJogador);
            builder.HasMany(x => x.TimesJogador);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime");
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime");
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao);
            builder.Property(x => x.IdJogadorCadastro);
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
