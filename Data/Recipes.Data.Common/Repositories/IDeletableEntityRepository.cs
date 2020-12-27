namespace Recipes.Data.Common.Repositories
{
    using System.Linq;
    using System.Threading.Tasks;
    using Recipes.Data.Common.Models;

    // soft delete
    public interface IDeletableEntityRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IDeletableEntity
    {
        IQueryable<TEntity> AllWithDeleted();

        IQueryable<TEntity> AllAsNoTrackingWithDeleted();

        void HardDelete(TEntity entity);

        void Undelete(TEntity entity);
    }
}