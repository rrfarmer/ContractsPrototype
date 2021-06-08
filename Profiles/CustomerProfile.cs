using AutoMapper;
using Prototype.Dtos;
using Prototype.Models;

namespace Prototype.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerReadDto>();
            CreateMap<CustomerCreateDto, Customer>();
        }
    }
}