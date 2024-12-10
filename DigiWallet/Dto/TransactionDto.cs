using DigiWallet.Models;

namespace DigiWallet.Dto
{
    public class TransactionDto
    {
        public Guid Id { get; set; }
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DateOfTransaction { get; set; }

        public Wallet Wallet { get; set; }
    }


    public class AddTransactionDto
    {
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DateOfTransaction { get; set; }

        public Wallet Wallet { get; set; }
    }


    public class UpdateTransactionDto
    {
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DateOfTransaction { get; set; }

       

    }
}
