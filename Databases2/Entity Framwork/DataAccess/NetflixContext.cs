using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Entity_Framwork.Models;

namespace Entity_Framwork.DataAccess
{
    public class NetflixContext : DbContext
    {
        public NetflixContext(string connectionString) : base(new DbContextOptionsBuilder<NetflixContext>().UseSqlServer(connectionString).Options) 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbSet<Abbonementen> abbonementen { get; set; }
        public DbSet<Abbonementen_kwaliteiten> Abbonementen_kwaliteiten { get; set; }
        public DbSet<Afleveringen> Afleveringen { get; set; }
        public DbSet<Afleveringen_kwaliteiten> Afleveringen_kwaliteiten { get; set; }
        public DbSet<Afleveringen_ondertitelingen> Afleveringen_ondertitelingen { get; set; }
        public DbSet<Films> Films { get; set; }
        public DbSet<Films_genres> Films_genres { get; set; }
        public DbSet<Films_kijk_histories> Films_kijk_histories { get; set; }
        public DbSet<Films_kijklijst_items> Films_kijklijst_items { get; set; }
        public DbSet<Films_kijkwijzer_indicaties> Films_kijkwijzer_indicaties { get; set; }
        public DbSet<Films_kwaliteiten> Films_kwaliteiten { get; set; }
        public DbSet<Films_ondertitelingen> Films_ondertitelingen { get; set; }
        public DbSet<Gebruikers> Gebruikers { get; set; }
        public DbSet<Gebruikers_abbonementen> Gebruikers_abbonementen { get; set; }
        public DbSet<Genres_voorkeuren> Genres_voorkeuren { get; set; }
        public DbSet<Kijk_histories> Kijk_histories { get; set; }
        public DbSet<Kijklijst_items> Kijklijst_items { get; set; }
        public DbSet<Profielen> Profielen { get; set; }
        public DbSet<Seizoenen> Seizoenen { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Series_genres> Series_genres { get; set; }
        public DbSet<Series_kijk_histories> Series_kijk_histories { get; set; }
        public DbSet<Series_kijklijst_items> Series_kijklijst_items { get; set; }
        public DbSet<Series_kijkwijzer_indicaties> Series_kijkwijzer_indicaties { get; set; }
        public DbSet<Voorkeuren> Voorkeuren { get; set; }
        public DbSet<Voorkeuren_kijkwijzer_indicaties> Voorkeuren_kijkwijzer_indicaties { get; set; }

    }
}
