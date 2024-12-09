using DigiWallet.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

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
        }
    }
}
