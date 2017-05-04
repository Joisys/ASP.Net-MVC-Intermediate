using System;
using Jo2me.Data;

namespace Jo2me.Interface.Infrastructure 
{
    public interface IDatabaseFactory : IDisposable
    {
        StageDbContext Get();
    }
}
