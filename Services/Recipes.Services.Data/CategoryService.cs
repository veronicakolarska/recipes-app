using System.Threading.Tasks;
using Recipes.Data.Common.Repositories;
using Recipes.Data.Models;
using System.Linq;
using System.Collections.Generic;
using Recipes.Services.Data.Contracts;
using Microsoft.EntityFrameworkCore;

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

        public IEnumerable<Category> GetAllWithRelatedData()
        {
            var category = this.categoryRepository.All().Include(x => x.Creator);
            return category;
        }

        public Category GetById(int id)
        {
            return this.GetAll().FirstOrDefault((x) => x.Id == id);
        }

        public async Task Delete(int id)
        {
            var category = this.GetById(id);
            this.categoryRepository.Delete(category);
            await this.categoryRepository.SaveChangesAsync();
        }

        public async Task Update(Category category)
        {
            this.categoryRepository.Update(category);
            await this.categoryRepository.SaveChangesAsync();
        }
    }
}