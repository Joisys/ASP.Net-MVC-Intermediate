using Jo2me.Interface.Infrastructure;
using Jo2me.Interface.Repository;
using Jo2me.Model;

namespace Jo2me.Infrastructure.Repository
{
    public class UserRepository : RepositoryBase<ApplicationUser>, IUserRepository
    {

        public UserRepository(IDatabaseFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
