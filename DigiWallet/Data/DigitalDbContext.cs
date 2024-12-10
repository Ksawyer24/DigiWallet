using DigiWallet.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Reflection.Emit;

namespace DigiWallet.Data
{
    public class DigitalDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public DigitalDbContext(DbContextOptions<DigitalDbContext> options) : base(options)
        {
        }


        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);




            // Wallet Configuration
            builder.Entity<Wallet>()
          .HasOne<User>()
          .WithOne() // assuming that every wallet has one user
          .HasForeignKey<Wallet>(w => w.UserId)
          .OnDelete(DeleteBehavior.Cascade);

            // Transaction Configuration
            builder.Entity<Transaction>()
                .HasOne(t => t.Wallet)
                .WithMany(w => w.Transactions)
                .HasForeignKey(t => t.WalletId);
        }
    }
}
