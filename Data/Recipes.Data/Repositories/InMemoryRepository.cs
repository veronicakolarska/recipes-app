namespace Recipes.Data.Repositories
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Recipes.Data.Common.Repositories;

    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    public class InMemoryRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        public IList<TEntity> InMemoryStore { get; set; }

        public InMemoryRepository()
        {
            this.InMemoryStore = new List<TEntity>();
        }

        public InMemoryRepository(IList<TEntity> data)
        {
            this.InMemoryStore = data;
        }

        public Task AddAsync(TEntity entity)
        {
            this.InMemoryStore.Add(entity);
            return Task.CompletedTask;
        }

        public IQueryable<TEntity> All()
        {
            return this.InMemoryStore.AsQueryable();
        }

        public IQueryable<TEntity> AllAsNoTracking()
        {
            return this.InMemoryStore.AsQueryable();
        }

        public void Delete(TEntity entity)
        {
            this.InMemoryStore.Remove(entity);
        }

        public void Dispose()
        {

        }

        public Task<int> SaveChangesAsync()
        {
            return Task.FromResult(0);
        }

        public void Update(TEntity entity)
        {
            var index = this.InMemoryStore.IndexOf(entity);
            if (index != -1)
            {
                this.InMemoryStore[index] = entity;
            }
        }
    }
}
