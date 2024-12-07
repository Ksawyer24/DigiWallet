using DigiWallet.Enums;
using Microsoft.AspNetCore.Identity;

namespace DigiWallet.Models
{
    public class User : IdentityUser<Guid>
    {
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public bool IsVerified { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? LastLogin { get; set; }
        public UserStatus Status { get; set; }

        public Wallet Wallet { get; set; }

    }
}