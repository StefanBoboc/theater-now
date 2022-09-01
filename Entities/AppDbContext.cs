using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterNow.Entities
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasOne(b => b.Client)
                .WithMany(ba => ba.Reservations)
                .HasForeignKey(bi => bi.ClientId);

            modelBuilder.Entity<Reservation>()
                .HasOne(b => b.Show)
                .WithMany(ba => ba.Reservations)
                .HasForeignKey(bi => bi.ShowId);
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Director> Directors { get; internal set; }
    }
}
