﻿using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using P03_FootballBetting.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_FootballBetting.Data
{
    public class FootballBettingContext : DbContext
    {
        public FootballBettingContext(DbContextOptions options) : base(options)
        {
        }

        public FootballBettingContext()
        {
        }

        public DbSet<Bet> Bets { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerStatistic>().HasKey(x => new { x.PlayerId, x.GameId });

            modelBuilder.Entity<Team>().HasOne(x => x.PrimaryKitColor)
                                        .WithMany(x => x.PrimaryKitTeams)
                                        .HasForeignKey(x => x.PrimaryKitColorId)
                                        .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Team>().HasOne(x => x.SecondaryKitColor)
                                        .WithMany(x => x.SecondaryKitTeams)
                                        .HasForeignKey(x => x.SecondaryKitColorId)
                                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Game>().HasOne(x => x.AwayTeam)
                                        .WithMany(x => x.AwayGames)
                                        .HasForeignKey(x => x.AwayTeamId)
                                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Game>().HasOne(x => x.HomeTeam)
                                        .WithMany(x => x.HomeGames)
                                        .HasForeignKey(x => x.HomeTeamId)
                                        .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
