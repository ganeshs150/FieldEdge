using AutoMapper;
using Data.Entities;
using Model.DTOs;

namespace Business
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<CustomerMaster, CustomerViewModel>();
        }
    }
}
