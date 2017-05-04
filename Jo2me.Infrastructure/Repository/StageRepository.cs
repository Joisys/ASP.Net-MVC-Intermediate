using Jo2me.Interface.Infrastructure;
using Jo2me.Interface.Repository;
using Jo2me.Model;

namespace Jo2me.Infrastructure.Repository
{
    public class StageRepository : RepositoryBase<Stage>, IStageRepository
    {
        public StageRepository(IDatabaseFactory dbFactory): base(dbFactory)
        {

        }
    }
}
