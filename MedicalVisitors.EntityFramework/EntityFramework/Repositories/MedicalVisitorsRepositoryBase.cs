using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MedicalVisitors.EntityFramework.Repositories
{
    public abstract class MedicalVisitorsRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MedicalVisitorsDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MedicalVisitorsRepositoryBase(IDbContextProvider<MedicalVisitorsDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MedicalVisitorsRepositoryBase<TEntity> : MedicalVisitorsRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MedicalVisitorsRepositoryBase(IDbContextProvider<MedicalVisitorsDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
