using Jo2me.Interface.Infrastructure;
using Jo2me.Interface.Repository;
using Jo2me.Model;

namespace Jo2me.Infrastructure.Repository
{
    public class LocationRepository : RepositoryBase<Location>, ILocationRepository
    {
        public LocationRepository(IDatabaseFactory dbFactory): base(dbFactory)
        {

        }
    }
}
