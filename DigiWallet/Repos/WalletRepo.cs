using DigiWallet.Data;
using DigiWallet.Dto;
using DigiWallet.Models;
using DigiWallet.Repos.Interface;

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
            throw new NotImplementedException();
        }

        public Task<Wallet> CreateWalletAsync(Wallet wallet)
        {
            throw new NotImplementedException();
        }

        public async Task DeductFundsAsync(Guid walletId, decimal amount)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TransactionDto>> GetTransactionsByWalletIdAsync(Guid walletId)
        {
            throw new NotImplementedException();
        }

        public async Task<WalletDto> GetWalletByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
