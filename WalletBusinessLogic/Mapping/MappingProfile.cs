using AutoMapper;
using EFCoreRepository.Models;
using WalletBusinessLogic.Extentions;
using WalletBusinessLogic.Models;

namespace WalletBusinessLogic.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EfTransactionModel, TransactionModel>().ForMember(x => x.TransactionDate, 
                opt => opt.MapFrom(y => y.TransactionDate.IsDateInCurrentWeek() == true ? 
                    y.TransactionDate.Date.DayOfWeek.ToString() : y.TransactionDate.ToString()));
        }
    }
}
