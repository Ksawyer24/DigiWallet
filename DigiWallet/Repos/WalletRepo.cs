using DigiWallet.Data;
using DigiWallet.Dto;
using DigiWallet.Models;
using DigiWallet.Repos.Interface;
using Microsoft.EntityFrameworkCore;

namespace DigiWallet.Repos
{
    public class WalletRepo : IWalletRepo
    {
        private readonly DigitalDbContext digitalDbContext;

        public WalletRepo(DigitalDbContext digitalDbContext)
        {
            this.digitalDbContext = digitalDbContext;
        }

        public async Task AddFundsAsync(Guid userId, decimal amount)
        {
            
            using var transaction = await digitalDbContext.Database.BeginTransactionAsync();

            try
            {
               
                var wallet = await digitalDbContext.Wallets
                 .FirstOrDefaultAsync(w => w.UserId == userId);

                if (wallet == null)
                {
                    throw new Exception("Wallet not found for this user.");
                }

                
                wallet.Balance += amount;

                
                await digitalDbContext.SaveChangesAsync();

                
                await transaction.CommitAsync();
            }

            catch (Exception)
            {
              
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task<Wallet> CreateWalletForUserAsync(Guid userId)
        {
            
            var existingWallet = await digitalDbContext.Wallets.FirstOrDefaultAsync(w => w.UserId == userId);

            if (existingWallet != null)
            {
                throw new Exception("User already has a wallet.");
            }

           
            var wallet = new Wallet
            {
                UserId = userId,               
                Transactions = new List<Transaction>() 
            };

            // 3. Add the wallet to the database
            await digitalDbContext.Wallets.AddAsync(wallet);

            // 4. Save the changes to the database
            await digitalDbContext.SaveChangesAsync();

            // 5. Return the created wallet
            return wallet;
        }

        public Task DeductFundsAsync(Guid walletId, decimal amount)
        {
            throw new NotImplementedException();
        }

        public Task<List<TransactionDto>> GetTransactionsByWalletIdAsync(Guid walletId)
        {
            throw new NotImplementedException();
        }
    }
}
