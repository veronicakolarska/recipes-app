using System.Threading.Tasks;
using Recipes.Data.Common.Repositories;
using Recipes.Data.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Recipes.Services.Data.Contracts;

namespace Recipes.Services.Data
{
    public class RecipeService : IRecipeService
    {
        private readonly IRepository<Recipe> recipeRepository;

        public RecipeService(
            IRepository<Recipe> recipeRepository
        )
        {
            this.recipeRepository = recipeRepository;
        }

        public async Task Create(Recipe recipe)
        {
            await this.recipeRepository.AddAsync(recipe);
            await this.recipeRepository.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return this.recipeRepository.All().Any((x) => x.Id == id);
        }

        public IEnumerable<Recipe> GetAll()
        {
            var recipe = this.recipeRepository.All();
            return recipe;
        }

        public Recipe GetById(int id)
        {
            return this.GetAll().FirstOrDefault((x) => x.Id == id);
        }

        public Recipe GetByIdWithIngredients(int id)
        {
            return this.recipeRepository
                .All()
                .Include(x => x.Ingredients)
                .FirstOrDefault((x) => x.Id == id);
        }

        public async Task Delete(int id)
        {
            var recipe = this.GetById(id);
            this.recipeRepository.Delete(recipe);
            await this.recipeRepository.SaveChangesAsync();
        }

        public async Task Update(Recipe recipe)
        {
            this.recipeRepository.Update(recipe);
            await this.recipeRepository.SaveChangesAsync();
        }
    }
}