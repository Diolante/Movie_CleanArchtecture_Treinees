using Microsoft.EntityFrameworkCore;
using Movie.Domain.Models;
using System.Diagnostics.CodeAnalysis;

namespace Movie.Infraestructure.Data.Context
{
    [ExcludeFromCodeCoverage]
    public class MovieDbContext : DbContext
    {

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Directors> Directors { get; set; }

        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TABELA FILMES
            modelBuilder.Entity<Movies>().ToTable("FILMES");
            modelBuilder.Entity<Movies>().HasKey(e => e.Id);
            modelBuilder.Entity<Movies>().Property(e => e.Id).HasColumnType("int").HasColumnName("ID").IsRequired();
            modelBuilder.Entity<Movies>().Property(e => e.Rank).HasColumnType("int").HasColumnName("RANK").IsRequired();
            modelBuilder.Entity<Movies>().Property(e => e.Title).HasColumnType("varchar").HasColumnName("TITULO").HasMaxLength(250).IsRequired();

            // TABELA DIRETORES
            modelBuilder.Entity<Directors>().ToTable("DIRETORES");
            modelBuilder.Entity<Directors>().HasKey(e => e.Id);
            modelBuilder.Entity<Directors>().Property(e => e.Id).HasColumnType("int").HasColumnName("ID").IsRequired();
            modelBuilder.Entity<Directors>().Property(e => e.Name).HasColumnType("varchar").HasColumnName("NOME").IsRequired();
            modelBuilder.Entity<Directors>().Property(e => e.CountMovies).HasColumnType("int").HasColumnName("QUANTIDADE_FILMES").IsRequired();
        }
    }
}
