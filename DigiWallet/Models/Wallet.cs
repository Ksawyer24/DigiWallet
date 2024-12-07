namespace DigiWallet.Models
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "Default Wallet";
        public decimal Balance { get; set; }
        public string Currency { get; set; } = "GHC";
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public Guid UserId { get; set; }


    }
}