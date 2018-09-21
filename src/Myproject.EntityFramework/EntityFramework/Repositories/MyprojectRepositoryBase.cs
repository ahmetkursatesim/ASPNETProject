using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Myproject.EntityFramework.Repositories
{
    public abstract class MyprojectRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MyprojectDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MyprojectRepositoryBase(IDbContextProvider<MyprojectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MyprojectRepositoryBase<TEntity> : MyprojectRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MyprojectRepositoryBase(IDbContextProvider<MyprojectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
