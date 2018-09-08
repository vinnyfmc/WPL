﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPL.Domain.Entities;

namespace WPL.Data.EntityConfig
{
    public class JogoJogadorConfig : IEntityTypeConfiguration<JogoJogador>
    {
        public void Configure(EntityTypeBuilder<JogoJogador> builder)
        {
            builder.ToTable("JogoJogador");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Gols).IsRequired();
            builder.Property(x => x.Assistencias).IsRequired();
            builder.Property(x => x.Nota);
            builder.Property(x => x.CartaoAmarelo).HasColumnType("bit");
            builder.Property(x => x.CartaoVermelho).HasColumnType("bit");
            builder.Property(x => x.MelhorEmCampo).HasColumnType("bit");
            builder.Property(x => x.JogoId).IsRequired();
            builder.Property(x => x.JogadorId).IsRequired();
            builder.Property(x => x.PosicaoId).IsRequired();

            builder.HasOne(x => x.Jogo).WithMany(p => p.JogoJogadores).HasForeignKey(x => x.JogoId);
            builder.HasOne(x => x.Jogador).WithMany(p => p.JogosJogador).HasForeignKey(x => x.JogadorId);
            builder.HasOne(x => x.Posicao).WithMany(p => p.JogoJogadores).HasForeignKey(x => x.PosicaoId);

            builder.Property(x => x.DataAlteracao).HasColumnType("DateTime");
            builder.Property(x => x.DataCadastro).HasColumnType("DateTime");
            builder.Property(x => x.DataExclusao).HasColumnType("DateTime");
            builder.Property(x => x.IdJogadorAlteracao);
            builder.Property(x => x.IdJogadorCadastro);
            builder.Property(x => x.IdJogadorExclusao);
        }
    }
}
