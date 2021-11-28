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
            CreateMap<Customer, CustomerUpdateDto>();

            CreateMap<Contract, ContractReadDto>();
            CreateMap<ContractCreateDto, Contract>();
            CreateMap<ContractUpdateDto, Contract>();
            CreateMap<Contract, ContractUpdateDto>();

            CreateMap<Unit, UnitReadDto>();
            CreateMap<UnitCreateDto, Unit>();
            CreateMap<UnitUpdateDto, Unit>();
            CreateMap<Unit, UnitUpdateDto>();

            CreateMap<OtherWarranty, WarrantyReadDto>();
            CreateMap<WarrantyCreateDto, OtherWarranty>();
            CreateMap<WarrantyUpdateDto, OtherWarranty>();
            CreateMap<OtherWarranty, WarrantyUpdateDto>();

            CreateMap<MediaFilter, MediaFilterReadDto>();
            CreateMap<MediaFilterCreateDto, MediaFilter>();
            CreateMap<MediaFilterUpdateDto, MediaFilter>();
            CreateMap<MediaFilter, MediaFilterUpdateDto>();

            CreateMap<ServiceVisit, ServiceVisitReadDto>();
            CreateMap<ServiceVisitCreateDto, ServiceVisit>();
            CreateMap<ServiceVisitUpdateDto, ServiceVisit>();
            CreateMap<ServiceVisit, ServiceVisitUpdateDto>();
        }
    }
}