using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WPL.Data.EntityConfig;
using WPL.Domain.Entities;

namespace WPL.Data.Context
{
    public class WPLContext : DbContext
    {
        public IConfigurationRoot configuration { get; set; }

        public WPLContext(DbContextOptions<WPLContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Campeonato> Campeonato { get; set; }
        public DbSet<CampeonatoEdicao> CampeonatoEdicao { get; set; }
        public DbSet<CampeonatoEdicaoFase> CampeonatoEdicaoFase { get; set; }
        public DbSet<CampeonatoEdicaoTime> CampeonatoEdicaoTime { get; set; }
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<JogadorStatusHistorico> JogadorHistoricoStatus { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<JogoJogador> JogoJogador { get; set; }
        public DbSet<JogoTime> JogoTime { get; set; }
        public DbSet<Plataforma> Plataforma { get; set; }
        public DbSet<Posicao> Posicao { get; set; }
        public DbSet<Time> Time { get; set; }
        public DbSet<TimeJogador> TimeJogador { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CampeonatoConfig());
            modelBuilder.ApplyConfiguration(new CampeonatoEdicaoConfig());
            modelBuilder.ApplyConfiguration(new CampeonatoEdicaoFaseConfig());
            modelBuilder.ApplyConfiguration(new CampeonatoEdicaoTimeConfig());
            modelBuilder.ApplyConfiguration(new JogadorConfig());
            modelBuilder.ApplyConfiguration(new JogadorStatusHistoricoConfig());
            modelBuilder.ApplyConfiguration(new JogoConfig());
            modelBuilder.ApplyConfiguration(new JogoJogadorConfig());
            modelBuilder.ApplyConfiguration(new JogoTimeConfig());
            modelBuilder.ApplyConfiguration(new PlataformaConfig());
            modelBuilder.ApplyConfiguration(new PosicaoConfig());
            modelBuilder.ApplyConfiguration(new TimeConfig());
            modelBuilder.ApplyConfiguration(new TimeJogadorConfig());
        }

        
    }
}
