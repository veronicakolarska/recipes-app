using System.Threading.Tasks;
using Recipes.Data.Common.Repositories;
using Recipes.Data.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Recipes.Services.Data
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> categoryRepository;

        public CategoryService(
            IRepository<Category> categoryRepository
        )
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task Create(Category category)
        {
            await this.categoryRepository.AddAsync(category);
            await this.categoryRepository.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return this.categoryRepository.All().Any((x) => x.Id == id);
        }

        public IEnumerable<Category> GetAll()
        {
            var category = this.categoryRepository.All();
            return category;
        }

        public Category GetById(int id)
        {
            return this.GetAll().FirstOrDefault((x) => x.Id == id);
        }

        public async Task Delete(int id)
        {
            var exists = this.Exists(id);
            if (exists)
            {
                var category = this.GetById(id);
                this.categoryRepository.Delete(category);
                await this.categoryRepository.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"Category doesn't exist! ");
            }
        }

        public async Task Update(Category category)
        {
            this.categoryRepository.Update(category);
            await this.categoryRepository.SaveChangesAsync();
        }
    }
}