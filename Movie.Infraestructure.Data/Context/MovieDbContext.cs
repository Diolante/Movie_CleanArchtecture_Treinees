using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Movie.Domain.Models;

namespace Movie.Infraestructure.Data.Context
{
    public class MovieDbContext : DbContext
    {

        public DbSet<Movies> Movies { get; set; }

        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>().ToTable("FILMES");
            modelBuilder.Entity<Movies>().HasKey(e => e.Id);
            modelBuilder.Entity<Movies>().Property(e => e.Id).HasColumnType("int").HasColumnName("ID").IsRequired();
            modelBuilder.Entity<Movies>().Property(e => e.Rank).HasColumnType("int").HasColumnName("RANK").IsRequired();
            modelBuilder.Entity<Movies>().Property(e => e.Title).HasColumnType("varchar").HasColumnName("TITULO").HasMaxLength(250).IsRequired();
        }
    }
}
