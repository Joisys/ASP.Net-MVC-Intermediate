using Jo2me.Data;
using Jo2me.Interface.Infrastructure;

namespace Jo2me.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
 
        private readonly IDatabaseFactory _dbFactory;
        private StageDbContext _dbContext;

        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public StageDbContext DbContext => _dbContext ?? (_dbContext = _dbFactory.Get());

        public void SaveChanges()
        {
            DbContext.SaveChanges();
        }
    }
}
