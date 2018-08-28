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

        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<JogadorStatusHistorico> JogadorHistoricosStatus { get; set; }
        public DbSet<Posicao> Posicoes { get; set; }
        public DbSet<Plataforma> Plataformas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JogadorConfig());
            modelBuilder.ApplyConfiguration(new PlataformaConfig());
            modelBuilder.ApplyConfiguration(new PosicaoConfig());
            modelBuilder.ApplyConfiguration(new JogadorStatusHistoricoConfig());
        }

        
    }
}
