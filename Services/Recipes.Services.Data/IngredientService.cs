using System.Threading.Tasks;
using Recipes.Data.Common.Repositories;
using Recipes.Data.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Recipes.Services.Data
{
    public class IngredientService : IIngredientService
    {

        private readonly IRepository<Ingredient> ingredientRepository;

        public IngredientService(
            IRepository<Ingredient> ingredientRepository
        )
        {
            this.ingredientRepository = ingredientRepository;
        }

        public async Task Create(Ingredient ingredient)
        {
            await this.ingredientRepository.AddAsync(ingredient);
            await this.ingredientRepository.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return this.ingredientRepository.All().Any((x) => x.Id == id);
        }

        public IEnumerable<Ingredient> GetAll()
        {
            var ingredients = this.ingredientRepository.All();
            return ingredients;
        }

        public Ingredient GetById(int id)
        {
            return this.GetAll().FirstOrDefault((x) => x.Id == id);
        }

        public async Task Delete(int id)
        {
            var ingredient = this.GetById(id);
            this.ingredientRepository.Delete(ingredient);
            await this.ingredientRepository.SaveChangesAsync();
        }

        public async Task Update(Ingredient ingredient)
        {
            this.ingredientRepository.Update(ingredient);
            await this.ingredientRepository.SaveChangesAsync();
        }
    }
}