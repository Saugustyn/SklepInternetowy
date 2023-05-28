using Microsoft.EntityFrameworkCore;
using SklepInternetowy.Models;

namespace SklepInternetowy.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Dostojewski- Biesy", Description= "Wielowątkowa, diaboliczna opowieść o tym jak szlachetne idee indywidualnej wolności w umysłach ludzi na wolność niegotowych, kształtowanych w uściskach carskiego samodzierżawia, przeradzają się w idee nihilizmu, bezwładne rewolucyjne ruchy i terroryzm.", Price = 30 },
                new Product { Id = 2, Name = "Gombrowicz- Kosmos", Description = "Późne, dojrzałe dzieło wielkiego pisarza stanowi kwintesencję jego poglądów na życie i sztukę. Dowodem na uniwersalność i doniosłość przesłania powieści jest uhonorowanie jej międzynarodową nagrodą Prix Formentor, najwyższym europejskim wyróżnieniem po Literackiej Nagrodzie Nobla", Price = 35 },
                new Product { Id = 3, Name = "Szostak- Cudze Słowa", Description = "Cudze słowa uwodzą wizją śródziemnomorskiej wyspy szczęśliwej i krakowskich mglistych Plant, pachną świeżo pieczonym chlebem i pilawem z jagnięciną. Powoli odkrywają przed czytelnikiem tajemnicę notesów, pełnych cudzych słów.", Price = 40 }
                );
        }
    }
}
