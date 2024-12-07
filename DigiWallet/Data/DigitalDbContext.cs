using DigiWallet.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace DigiWallet.Data
{
    public class DigitalDbContext:DbContext
    {
        public DigitalDbContext(DbContextOptions<DigitalDbContext> options) :base(options)
        {
            
        }


        
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
       
   




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);

        }
    }
}
