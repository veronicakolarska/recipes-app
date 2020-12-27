namespace Recipes.Data.Repositories
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Recipes.Data.Common.Repositories;

    using Microsoft.EntityFrameworkCore;

    // repository pattern - for abstraction 
    // defines methods for accessing and modifying the data
    // but we don't care that the data is exactly
    // allows us to be decoupled from the data

    // implements IRepository interface
    public class EfRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        public EfRepository(RecipeContext context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));
            this.DbSet = this.Context.Set<TEntity>();
        }

        // DbSet - from EF
        // one DbSet is a collection of all the rows of the table
        protected DbSet<TEntity> DbSet { get; set; }

        // a way to communicate with the database
        protected RecipeContext Context { get; set; }

        public virtual IQueryable<TEntity> All() => this.DbSet;

        // TODO: can remove
        public virtual IQueryable<TEntity> AllAsNoTracking() => this.DbSet.AsNoTracking();

        public virtual Task AddAsync(TEntity entity) => this.DbSet.AddAsync(entity).AsTask();

        public virtual void Update(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity) => this.DbSet.Remove(entity);

        public Task<int> SaveChangesAsync() => this.Context.SaveChangesAsync();

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Context?.Dispose();
            }
        }
    }
}