using DigiWallet.Models;

namespace DigiWallet.Dto
{
    public class WalletDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "Default Wallet";
        public decimal Balance { get; set; }
        public string Currency { get; set; } = "GHC";
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public Guid UserId { get; set; }
    }

    public class AddWalletDto
    {
        public string Name { get; set; } = "Default Wallet";
        public decimal Balance { get; set; } = 0;
        public string Currency { get; set; } = "GHC";
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public Guid UserId { get; set; }

    }


    public class UpdateWalletDto
    {
      
        public string Name { get; set; } = "Default Wallet";
        public decimal Balance { get; set; }
        public string Currency { get; set; } = "GHC";
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
     
    }
}
