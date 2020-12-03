using System.Threading.Tasks;
using Recipes.Data.Common.Repositories;
using Recipes.Data.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Recipes.Services.Data
{
    public class FavouriteRecipeService : IFavouriteRecipeService
    {
        private readonly IRepository<FavouriteRecipe> favouriteRecipe;

        public FavouriteRecipeService(
            IRepository<FavouriteRecipe> favouriteRecipeRepository
        )
        {
            this.favouriteRecipeRepository = favouriteRecipeRepository;
        }

        public async Task Create(FavouriteRecipe favouriteRecipe)
        {
            await this.favouriteRecipeRepository.AddAsync(favouriteRecipe);
            await this.favouriteRecipeRepository.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return this.favouriteRecipeRepository.All().Any((x) => x.Id == id);
        }

        public IEnumerable<FavouriteRecipe> GetAll()
        {
            var favouriteRecipe = this.favouriteRecipeRepository.All();
            return favouriteRecipe;
        }

        public Category GetById(int id)
        {
            return this.GetAll().FirstOrDefault((x) => x.Id == id);
        }

        public async Task Delete(int id)
        {
            var user = this.GetById(id);
            this.userRepository.Delete(user);
            await this.userRepository.SaveChangesAsync();
        }

        public async Task Update(User user)
        {
            this.userRepository.Update(user);
            await this.userRepository.SaveChangesAsync();
        }
    }
}