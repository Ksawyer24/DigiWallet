﻿using DigiWallet.Dto;

namespace DigiWallet.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DateOfTransaction { get; set; }

      
    }
}