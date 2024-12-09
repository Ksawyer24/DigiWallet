namespace DigiWallet.Models
{
    public class PaystackConfig
    {
        public string PublicKey { get; set; } = string.Empty;
        public string SecretKey { get; set; } = string.Empty;
        public string BaseUrl { get; set; } = "https://api.paystack.co";
    }
}
