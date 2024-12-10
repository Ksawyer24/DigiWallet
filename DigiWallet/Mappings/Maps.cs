using AutoMapper;
using DigiWallet.Dto;
using DigiWallet.Models;

namespace DigiWallet.Mappings
{
    public class Maps:Profile
    {
        public Maps()
        {
            CreateMap<Transaction, TransactionDto>().ReverseMap();
            CreateMap<AddTransactionDto, Transaction>().ReverseMap();
            CreateMap<UpdateTransactionDto, Transaction>().ReverseMap();

            CreateMap<Wallet, WalletDto>().ReverseMap();
            CreateMap<AddWalletDto, Wallet>().ReverseMap();
            CreateMap<UpdateWalletDto, UpdateWalletDto>().ReverseMap();
        }
    }
}
