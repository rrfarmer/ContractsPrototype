using AutoMapper;
using Prototype.Dtos;
using Prototype.Models;

namespace Prototype.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            // TODO: Break this out into sep mapping profiles
            CreateMap<Customer, CustomerReadDto>();
            CreateMap<CustomerCreateDto, Customer>();
            CreateMap<CustomerUpdateDto, Customer>();

            CreateMap<Contract, ContractReadDto>();
            CreateMap<ContractCreateDto, Contract>();

            CreateMap<Unit, UnitReadDto>();
            CreateMap<UnitCreateDto, Unit>();

            CreateMap<OtherWarranty, WarrantyReadDto>();
            CreateMap<WarrantyCreateDto, OtherWarranty>();

            CreateMap<MediaFilter, MediaFilterReadDto>();
            CreateMap<MediaFilterCreateDto, MediaFilter>();
        }
    }
}