using DigiWallet.Dto;
using DigiWallet.Models;

namespace DigiWallet.Repos.Interface
{
    public interface IWalletRepo
    {
        Task<Wallet> CreateWalletForUserAsync(Guid userId);
        Task AddFundsAsync(Guid userId, decimal amount);
        Task DeductFundsAsync(Guid walletId, decimal amount);
        Task<List<TransactionDto>> GetTransactionsByWalletIdAsync(Guid walletId);
    }
}
