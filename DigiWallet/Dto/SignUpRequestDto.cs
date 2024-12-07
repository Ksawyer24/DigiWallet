using DigiWallet.Models;
using System.ComponentModel.DataAnnotations;

namespace DigiWallet.Dto
{
    public class SignUpRequestDto
    {
        public long Id { get; set; } 

        [Required]
        public string FirstName { get; set; } = string.Empty; 

        [Required]
        public string LastName { get; set; } = string.Empty; 

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty; 

        [Phone]
        public string PhoneNumber { get; set; } = string.Empty; 

        [Range(0, double.MaxValue, ErrorMessage = "Wallet balance cannot be negative")]
        public decimal WalletBalance { get; set; } 

        public DateTime DateCreated { get; set; } 

        public DateTime? LastLogin { get; set; } 

        [Required]
        public string Status { get; set; } = string.Empty;

        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
