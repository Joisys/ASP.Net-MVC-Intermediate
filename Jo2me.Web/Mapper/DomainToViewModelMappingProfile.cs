using AutoMapper;
using Jo2me.Model;
using Jo2me.Web.Models;

namespace Jo2me.Web.Mapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Location, LocationViewModel>();
        }
    }
}