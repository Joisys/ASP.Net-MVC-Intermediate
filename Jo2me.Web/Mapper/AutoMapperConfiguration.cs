namespace Jo2me.Web.Mapper
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            AutoMapper.Mapper.Initialize(mapper =>
            { 
                mapper.AddProfile<ViewModelToDomainMappingProfile>() ;
                mapper.AddProfile<DomainToViewModelMappingProfile>();
            });
            
        }
    }
}