using Jo2me.Data;
using Jo2me.Interface.Infrastructure;

namespace Jo2me.Infrastructure
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private StageDbContext _dataContext;

        public void Dispose()
        {
            _dataContext?.Dispose();
        }

        public StageDbContext Get()
        {
            return _dataContext ?? (_dataContext = new StageDbContext());
        }
    }

}
