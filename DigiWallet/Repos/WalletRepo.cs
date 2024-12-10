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
            // Begin a transaction
            using var transaction = await digitalDbContext.Database.BeginTransactionAsync();

            try
            {
                // Retrieve the wallet
                var wallet = await digitalDbContext.Wallets
                 .FirstOrDefaultAsync(w => w.UserId == userId);

                if (wallet == null)
                {
                    throw new Exception("Wallet not found for the given user.");
                }

                // Update the wallet balance
                wallet.Balance += amount;

                // Save changes to the wallet
                await digitalDbContext.SaveChangesAsync();

                // Commit the transaction
                await transaction.CommitAsync();
            }

            catch (Exception)
            {
                // Rollback transaction in case of failure
                await transaction.RollbackAsync();
                throw;
            }
        }

        public Task<Wallet> CreateWalletForUserAsync(Guid userId)
        {
            throw new NotImplementedException();
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
