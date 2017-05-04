using AutoMapper;
using Jo2me.Model;
using Jo2me.Web.Models;

namespace Jo2me.Web.Mapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<LocationViewModel, Location>();
            CreateMap<CreateLocationViewModel, Location>();
            CreateMap<EditLocationViewModel, Location>();

        }
    }
}